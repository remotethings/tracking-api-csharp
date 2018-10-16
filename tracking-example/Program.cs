using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
using System.Web.Script.Serialization;
using System.Dynamic;

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
            catch(Exception e)
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
                Name: "geofence alert test",
                Type: "geofence",
                MuteFor: 0, // disable rate limit
                Delivery: new Dictionary<string, bool>() { { "mqtt", true } },
                UserId: Decimal.Parse(this.userId),
                Parameters: parameters
            );            

            return this.deviceApi.DevicePrototypeCreateNotificationTriggers(deviceId, notif);
        }
        
        void getDevices()
        {
            this.devices = this.userApi.UserPrototypeGetDevices(this.userId);
            Debug.Print("Got {0} devices for this account", this.devices.Count);
        }

        static long dateToUnixMillis(DateTime date)
        {
            var timeSpan = (date - new DateTime(1970, 1, 1, 0, 0, 0));
            return (long)timeSpan.TotalSeconds*1000;
        }

        void printLastLocations()
        {
            var startDate = DateTime.UtcNow.AddDays(-1);
            var endDate = DateTime.UtcNow;
            var filter = new {
                where = new {
                    timestamp = new { between = new long[] { dateToUnixMillis(startDate), dateToUnixMillis(endDate) } }
                },
                order = "timestamp DESC",
                //limit = 5
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
                }
            }
            
        }

        async Task listenForNewData()
        {
            //Subscribe to receive new data
            var messaging = new Messaging(userApi, userId);
            await messaging.start();
        }

        static void Main(string[] args)
        {
            var example = new Program();
            example.login();

            if (example.authToken == null) return;

            var notif = example.createGeofenceAlert(123); // todo: change device id
            if (notif != null && notif.Id != null) Debug.Print("Created alert {0} with id {1}", notif.Name, notif.Id);
            else Debug.Print("Failed to created alert");

            example.getDevices();
            example.printLastLocations();

            var wait = example.listenForNewData();
            while (!wait.IsCompleted) ;
            
        }
    }
}
