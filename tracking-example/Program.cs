using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Model;
using System.Web.Script.Serialization;
using System.Dynamic;
using Newtonsoft.Json.Linq;
using Amazon;

namespace tracking_example
{
    class Program
    {
        private DeviceApi deviceApi = new DeviceApi();
        private UserApi userApi = new UserApi();

        private string userId;
        private string authToken;

        private List<Device> devices;

        void login()
        {
            try
            {
                var token = this.userApi.UserLogin(new Credentials("username", "password"));
                this.userId = token.UserId.ToString();
                this.authToken = token.Id;
                this.userApi.Configuration.AddDefaultHeader("Authorization", token.Id);
                this.deviceApi.Configuration.AddDefaultHeader("Authorization", token.Id);
            } 
            catch
            {
                Debug.Print("Failed to login, please check credentials");
            }

        }

        Geofence createGeofence()
        {
            Geofence geofence = new Geofence();
            geofence.Name = "Zone Test 2";
            geofence.Type = "reporting"; // "reporting" = yellow, "safe" = green, "prohibited" = red when drawn on map
            geofence.Outline = new List<object>();
            GeoPoint geoPoint = new GeoPoint();
            geoPoint.Lat = Convert.ToDecimal(-18.0);
            geoPoint.Lng = Convert.ToDecimal(120.4);
            geofence.Outline.Add(geoPoint);
            geoPoint = new GeoPoint();
            geoPoint.Lat = Convert.ToDecimal(-20.3);
            geoPoint.Lng = Convert.ToDecimal(160.0);
            geofence.Outline.Add(geoPoint);
            geoPoint = new GeoPoint();
            geoPoint.Lat = Convert.ToDecimal(-32.5);
            geoPoint.Lng = Convert.ToDecimal(140.0);
            geofence.Outline.Add(geoPoint);

            return this.userApi.UserPrototypeCreateGeofences(this.userId, geofence);            
        }

        NotificationTrigger createGeofenceAlert(Decimal deviceId)
        {

            var fence = createGeofence();

            dynamic parameters = new ExpandoObject();
            parameters.zoneId = fence.Id;
            parameters.zoneType = "inside"; // can be "inside", "outside" or "cross"
            // Optional

            // If delivery.email = true, use the following to send email to address other than username
            // parameters.email = "example@gmail.com"

            // If delivery.http = true, use the following to define the endpoint
            // parameters.endpoint = "https://example.com/myalertreceiver"

            var notif = new NotificationTrigger(            
                name: "geofence alert test",
                type: "geofence",
                muteFor: 0, // disable rate limit
                delivery: new Dictionary<string, bool>() { { "mqtt", true } },
                userId: Decimal.Parse(this.userId),
                parameters: parameters
            );            

            return this.deviceApi.DevicePrototypeCreateNotificationTriggers(deviceId, notif);
        }

        void enterFlightMode(Decimal deviceId, UInt16 minutes)
        {
            this.deviceApi.DevicePrototypeFlightMode(deviceId, (decimal)minutes);
            // Query transients to check if it's been sent
           //this.deviceApi.DevicePrototypeGetTransients(deviceId, "{\"where\": {\"sent\":null},\"order\":\"triggeredAt DESC\", \"limit\": 1}");
        }

        void activateBuzzer(Decimal deviceId)
        {
            this.deviceApi.DevicePrototypeCreateMessages(deviceId, new DeviceMessage(message: "#hi0202"));
        }


        // Setup forwarding of datapoints to SQS for all devices on account
        // You will need to have setup an SQS queue on your account with the following Policy Document:
        // NOTE: replace  "arn:aws:sqs:us-east-2:829297355604:test_lb" with your queue ARN
        // {
        //     "Version": "2012-10-17",
        //     "Id": "AllowLightbugPush",
        //     "Statement": [
        //      {
        //         "Sid": "AllowLightbugPush001",
        //         "Effect": "Allow",
        //         "Principal": "*",
        //         "Action": "sqs:SendMessage",
        //         "Resource": "arn:aws:sqs:us-east-2:829297355604:test_lb",
        //         "Condition": {
        //             "ArnEquals": {
        //                 "aws:SourceArn": "arn:aws:sns:*:367158939173:*"
        //             }
        //         }
        //      }
        //     ]
        // }
        //
        // Based on information available https://docs.aws.amazon.com/sns/latest/dg/SendMessageToSQS.cross.account.html
        // Once you have run this script, you will need to wait for "SubscriptionConfirmation" message and
        // visit the SubscribeURL to confirm subscription, as detailed int the above link under *To confirm a subscription using the Amazon SQS console*
        NotificationTrigger setupSqsPush(Decimal deviceId, string eventType, string hookName, string sqsArn)
        {
            var filter = new {
                where = new {
                    name = hookName,
                    type = eventType                    
                },
            };
            var jsonFilter = new JavaScriptSerializer().Serialize(filter);
            var triggers = this.deviceApi.DevicePrototypeGetNotificationTriggers(deviceId, jsonFilter);
            if (triggers.Count > 0) return triggers[0]; // already exists

            //Not found, create
            var notif = new NotificationTrigger(
                name: hookName,
                type: eventType,
                muteFor: 0, // disable rate limit
                delivery: new { sqs = true , sqsArn= sqsArn},
                userId: Decimal.Parse(this.userId),
                parameters: new { }
            );

            Debug.Print("Setting up push for device {0}", deviceId);
            return this.deviceApi.DevicePrototypeCreateNotificationTriggers(deviceId, notif);
        }

        void getDevices()
        {
            this.devices = this.userApi.UserPrototypeGetDevices(this.userId);
            Debug.Print("Got {0} devices for this account", this.devices.Count);
        }

        static long dateToMillis(DateTime date)
        {
            var timeSpan = (date - new DateTime(1970, 1, 1, 0, 0, 0));
            return (long)timeSpan.TotalSeconds*1000;
        }

        public static DateTime millisToDate(long jsTimeStamp)
        {
            // Unix timestamp is milliseconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(jsTimeStamp / 1000).ToLocalTime();
            return dtDateTime;
        }

        void printLastLocations(bool showNearbyBluetoothData = false)
        {
            var startDate = DateTime.UtcNow.AddDays(-1);
            var endDate = DateTime.UtcNow;
            var filter = new {
                where = new {
                    timestamp = new { between = new long[] { dateToMillis(startDate), dateToMillis(endDate) } }
                },
                order = "timestamp DESC",
                limit = 5
            };
            var jsonFilter = new JavaScriptSerializer().Serialize(filter);
            foreach (var device in this.devices)
            {
                Debug.Print("Getting points in the last day for device {0}, id = {1}", device.Name, device.Id);
                var points = this.deviceApi.DevicePrototypeGetPoints(device.Id, jsonFilter);
                foreach(var point in points)
                {
                    if(point.Location == null) continue;
                    if (point.Address == null) point.Address = "";
                    Debug.Print("Point for device {0}: {1},{2} at {3}, {4}", device.Id, point.Location.Lat, point.Location.Lng, point.Timestamp.ToString(), point.Address);
                    if (showNearbyBluetoothData && point.CorrelationId != null)
                    {
                        PrintNearbyBluetoothDataForPoint((decimal)device.Id, point.CorrelationId);
                    }
                }
            }
            
        }
        
        void printNearbyData()
        {
            var startDate = DateTime.UtcNow.AddDays(-1);
            var endDate = DateTime.UtcNow;
            var filter = new {
                where = new {
                    //type= "ble_seen", // optional type filter - ble_seen, temp, humidity...
                    timestamp = new { between = new long[] { dateToMillis(startDate), dateToMillis(endDate) } }
                },
                order = "timestamp DESC",
                //limit = 5
            };
            var jsonFilter = new JavaScriptSerializer().Serialize(filter);
            foreach (var device in this.devices)
            {
                Debug.Print("Getting points in the last day for device {0}, id = {1}", device.Name, device.Id);
                var readings = this.deviceApi.DevicePrototypeGetGatewayReadings(device.Id, jsonFilter);
                foreach(var reading in readings)
                {
                    Debug.Print("Sensor Data collected by {0} for device {1}: {2},{3} at {4}", device.Id, reading.DeviceId, reading.Type, reading.Value, reading.Timestamp);
                }
            }
            
        }

        private void PrintNearbyBluetoothDataForPoint(decimal deviceId, string correlationId)
        {
            var nearbyData = this.deviceApi.DevicePrototypeNearbyDevices(deviceId, correlationId: correlationId);
            foreach (dynamic nearby in nearbyData)
            {
                Debug.Print("Device {0} was near BLE Device with MAC={1} [ID={2}] - sensor data collected: ", deviceId, (string)nearby.device.btMac, (int)nearby.device.id);
                foreach (var reading in (JObject)nearby.readings)
                {
                    var data = reading.Value.ToObject<JObject>();
                    Debug.Print("{4}[{0}] = {1} @ {2} with RSSI = {3}dBm", reading.Key, data["value"], millisToDate((long)data["timestamp"]), data["rssi"], (int)nearby.device.id);
                }
            }
        }

   

        void getNearbyDeviceData()
        {
            var startDate = DateTime.UtcNow.AddDays(-1);
            var endDate = DateTime.UtcNow;
            var filter = new
            {
                where = new
                {
                    timestamp = new { between = new long[] { dateToMillis(startDate), dateToMillis(endDate) } }
                },
                order = "timestamp DESC",
                //limit = 5
            };
            var jsonFilter = new JavaScriptSerializer().Serialize(filter);
            foreach (var device in this.devices)
            {
                Debug.Print("Getting points in the last day for device {0}, id = {1}", device.Name, device.Id);
                var points = this.deviceApi.DevicePrototypeGetPoints(device.Id, jsonFilter);
                foreach (var point in points)
                {
                    if (point.Location == null) continue;
                    if (point.Address == null) point.Address = "";
                    Debug.Print("Point for device {0}: {1},{2} at {3}, {4}", device.Id, point.Location.Lat, point.Location.Lng, point.Timestamp.ToString(), point.Address);
                }
            }

        }

        async Task listenForNewDataMqtt()
        {
            //Subscribe to receive new data
            var messaging = new Messaging(userApi, userId);
            await messaging.start();
        }
        
        async Task listenForNewDataSqs()
        {
            // Configuration
            // Remember your queue needs to have the specified policy document (see README)
            // and you will need to confirm subscription (read the Debug output for instructions / see SqsClient.cs Line 152)
            var REGION = RegionEndpoint.EUWest1;
            const string ACCESS_KEY = "IAM_ACCESSKEY"; // needs SQS access
            const string SECRET = "IAM_SECRET";
            const string QUEUE_ARN = "arn:aws:sqs:eu-west-1:123456789:test-push";
            const string QUEUE_URL = "https://sqs.eu-west-1.amazonaws.com/123456789/test-push";

            this.devices.ForEach(d => {
                this.setupSqsPush((decimal)d.Id, "newLoc", "AllNewPoints-SQS", QUEUE_ARN);
                this.setupSqsPush((decimal)d.Id, "newReading", "AllNewReadings-SQS", QUEUE_ARN);
            });
            
            //Subscribe to receive new data
            var sqsClient = new Sqs.SqsClient(REGION, ACCESS_KEY, SECRET);
            await sqsClient.Listen(QUEUE_URL);
        }

        static void Main(string[] args)
        {
            var example = new Program();
            example.login();

            if (example.authToken == null) return;

            //var notif = example.createGeofenceAlert(123); // todo: change device id
            //if (notif != null && notif.Id != null) Debug.Print("Created alert {0} with id {1}", notif.Name, notif.Id);
            //else Debug.Print("Failed to created alert");


            example.getDevices();


            // send Device into flightMode for 1 day
            //example.enterFlightMode(deviceId, 60 * 24);


            // Print last 5 locations today 
            example.printLastLocations();
            // we could also print the data and fetch nearby  ble devices for each point (bluetooth enabled trackers only)
            //example.printLastLocations(true);

            // For bluetooth enabled devices, we can also perform a date search
            // this is much faster than querying one point at a time using CorrelationId as in the above example (printLastLocations)
            //example.printNearbyData();


            // Listen for new points
            //  example.listenForNewDataMqtt().Wait();
            example.listenForNewDataSqs().Wait();

        }
    }
}
