﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using System.Web.Script.Serialization;
using IO.Swagger.Model;
using IO.Swagger.Api;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace tracking_example
{
    class Messaging
    {
        MqttClient client = new MqttClient("mqtt.remotethings.co.uk", 8883, true, null, null, MqttSslProtocols.TLSv1_2);
        private UserApi userApi;
        private string userId;
        private bool connected = false;
        private JsonSerializerSettings serializerSettings = new JsonSerializerSettings
        {
            ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor
        };

        public Messaging(UserApi userApi, string userId)
        {
            this.userApi = userApi;
            this.userId = userId;
        }

        public async Task start()
        {
            if (!userApi.Configuration.DefaultHeader.Any((v) => v.Key == "Authorization"))
            {
                throw new Exception("Please authenticate userApi before opening a messaging connection");
            }

            var mqttCred = userApi.UserPrototypeGetMqttCredentials(userId);

            byte code = client.Connect(mqttCred.ClientId, mqttCred.Username, mqttCred.Password, false, 60);
            if (code != MqttMsgConnack.CONN_ACCEPTED)
            {
                throw new Exception("Failed to connect to Messaging Server");
            }
            var topics = new string[]
            {
                "users/" + userId + "/devices/+/datapoints",
                "users/" + userId + "/devices/+/readings",
                "users/" + userId + "/devices/+/notifications"
            };
            client.Subscribe(topics, new byte[] { 2, 2, 2 });
            client.MqttMsgSubscribed += Client_MqttMsgSubscribed;
            client.MqttMsgPublishReceived += ProcessNewMessage;

            client.ConnectionClosed += handleDisconnect;

            connected = true;
            
            while (connected) await Task.Delay(1000);            
        }

        private void handleDisconnect(object sender, EventArgs e)
        {
            Debug.Print("Messaging Disconnected");
            connected = false;
        }

        private void ProcessNewMessage(object sender, MqttMsgPublishEventArgs e)
        {
            var msg = Encoding.UTF8.GetString(e.Message);
            var topic = e.Topic;

            var parts = topic.Split('/');
            var deviceId = parts[3];
            var messageType = parts[4];

            if (messageType.Equals("datapoints"))
            {
                this.processNewDatapoint(deviceId, msg);
            }
            else if (messageType.Equals("readings"))
            {
                this.processNewSensorReading(deviceId, msg);
            }
            else if (messageType.Equals("notifications"))
            {
                this.processNewNotification(deviceId, msg);
            }
        }

        private void Client_MqttMsgSubscribed(object sender, MqttMsgSubscribedEventArgs e)
        {
            Debug.Print("Subscribed to new messages successfully");
        }


        private void processNewSensorReading(string deviceId, string message)
        {
            try {
                var reading = (SensorReading)JsonConvert.DeserializeObject(message, typeof(SensorReading), serializerSettings);
                Debug.Print("Received new reading from device {0}! {1}={2}", deviceId, reading.Type, reading.Value);                
                
                //Type can be a number of things, for example:
                /*
                if (reading.Type.Equals("temp"))
                {
                    // for temp, value is a float:
                    var temperature = (float)reading.Value;
                    processTemperature(deviceId, temperature);
                }
                */
                
            }
            catch (Exception e)
            {
                Debug.Print("Invalid sensor message received: {0}", e.Message);
            }
        }

        private void processNewNotification(string deviceId, string message)
        {
            try
            {
                // Object incoming
                /*
                {
                    timestamp: timestamp (notification creation time),
                    params: Object (notificationTrigger params) ,
                    trigger: {
                        name: string (notificationTrigger name),
                        id: int (notificationTrigger id),
                        type: string (notificationTrigger type)
                    },
                    point: DataPoint,
                    device: {
                        id: int (device id),
                        name: string (device name),
                        serial: string (device serial number)
                    }
                }
                */
                Debug.Print("Incoming notification: {0}", message);
                dynamic notification = JObject.Parse(message);
                if ("geofence".Equals(notification.trigger.type))
                {
                    Debug.Print("Received new geofence notification ({0}) for device {1}", (string)notification.trigger.name, deviceId);

                }

            }
            catch (Exception e)
            {
                Debug.Print("Invalid notification message received: {0}", e.Message);
            }
        }

        private void processNewDatapoint(string deviceId, string message)
        {
            try
            {
                var newPoint = (Datapoint)JsonConvert.DeserializeObject(message, typeof(Datapoint), serializerSettings);
                Debug.Print("Received new point from device {0}! {1},{2} alt:{3}m, speed:{4}km/h", deviceId, newPoint.Location.Lat, newPoint.Location.Lng, newPoint.Altitude, newPoint.Speed);

                /* 
                 * If we're expecting bluetooth data from this device, we can query the database for 
                 * data that was transmitted with this point, using the correlationId as a reference
                 *
                if(bleDataExpected && newPoint.CorrelationId != null)
                {
                    PrintNearbyBluetoothDataForPoint(deviceId, newPoint.CorrelationId); // example given in program.CS
                }
                */
            }
            catch (Exception e)
            {
                Debug.Print("Invalid datapoint message received: {0}", e.Message);
            }
        }
        
    }
}
