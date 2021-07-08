using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Amazon;
using Amazon.Runtime;
using Amazon.SQS;
using Amazon.SQS.Model;
using IO.Swagger.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace Sqs
{

    public class SqsClient
    {
        private readonly IAmazonSQS _sqsClient;
        private JsonSerializerSettings serializerSettings = new JsonSerializerSettings
        {
            ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor
        };

        public SqsClient(RegionEndpoint region, string accessKey, string secret)
        {
            var sqsConfig = new AmazonSQSConfig
            {
                RegionEndpoint = region,
            };
            this._sqsClient = new AmazonSQSClient(accessKey, secret, sqsConfig);
        }

        private void ProcessNewSensorReading(Notification notification, SensorReading reading)
        {
            try
            {
                Debug.Print("Received new reading from device {0}! {1}={2}", reading.DeviceId, reading.Type, reading.Value);

                //Type can be a number of things, for example:
                /*
                if (reading.Type.Equals("temp"))
                {
                    // for temp, value is a float:
                    var temperature = (float)reading.Value;
                    processTemperature(deviceId, temperature);
                }
                 else if (reading.Type.Equals("geofence_sync"))
                {
                    //RTK devices only
    `               Debug.Print("Device {0} has synchronised geofence settings", reading.DeviceId);        
                }
                 else if (reading.Type.Equals("geofence_log"))
                {
                    //RTK devices only
                    dynamic data = JObject.Parse(reading.Value.ToString());                    
                    Debug.Print($"Device {reading.DeviceId} had geofence event @ {reading.Timestamp}. ZoneId = {data.zoneId}, type = {data.type}, action taken = {data.action}");        
                }
                */

            }
            catch (Exception e)
            {
                Debug.Print("Invalid sensor message received: {0}", e.Message);
            }
        }

        private void ProcessNewGeofenceNotification(Notification notification, Datapoint point, dynamic parameters)
        {
            try
            {
                Debug.Print($"Geofence notification {parameters.name} for device {point.DeviceId} of type {parameters.subtype}");
                switch (parameters.subtype)
                {
                    case "cross":

                        if(parameters.meta.crossType == "entry")
                        {
                            Debug.Print($"Device {point.DeviceId} entered zone {parameters.meta.zone.name}, foreignId {parameters.meta.zone.foreignId}");
                        }
                        else  if (parameters.meta.crossType == "exit")
                        {
                            Debug.Print($"Device {point.DeviceId} exited zone {parameters.meta.zone.name}, foreignId {parameters.meta.zone.foreignId}");
                        }

                        break;

                    // Other types of geofences...
                    case "entry":
                    case "exit":
                    case "inside":
                    case "outside":
                    default:
                        break;
                }
            }
            catch (Exception e)
            {
                Debug.Print("Invalid geofence notification message received: {0}", e.Message);
            }
        }

        private void ProcessNewDatapoint(Notification notification, Datapoint point)
        {
            try
            {
                Debug.Print("Received new point from device {0}! {1},{2} alt:{3}m, speed:{4}km/h", point.DeviceId, point.Location.Lat, point.Location.Lng, point.Altitude, point.Speed);
            }
            catch (Exception e)
            {
                Debug.Print("Invalid datapoint message received: {0}", e.Message);
            }
        }


        private bool ProcessMessage(Message message)
        {
            dynamic body = JsonConvert.DeserializeObject<ExpandoObject>(message.Body, new ExpandoObjectConverter());
            NotificationModel data = JsonConvert.DeserializeObject<NotificationModel>(body.Message, this.serializerSettings);

            // Ugly extraction from variable object
            dynamic parameters = JObject.Parse(data.Notification.Params.ToString());
            string type = parameters.type.Value;

            Debug.Print($"got message of type {type} = {body.Message}");

            switch (type)
            {
                case "newReading":
                    ProcessNewSensorReading(data.Notification, data.Reading);
                    break;
                case "newLoc":
                    ProcessNewDatapoint(data.Notification, data.Datapoint);
                    break;
                case "geofence":
                    ProcessNewGeofenceNotification(data.Notification, data.Datapoint, parameters);
                    break;
                default:
                    Debug.Fail("Unknown notification", type);
                    break;
            }


            return true;
        }


        public async Task Listen(string queueUrl, CancellationToken cancellationToken = default)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                var messages = await GetMessages(queueUrl, cancellationToken);

                messages.ForEach(async m =>
                {
                    if (m.Body.Contains("SubscribeURL"))
                    {
                        Debug.Print("QUEUE NEEDS CONFIRMING, open the SubscribeUrl in your browser");
                        Debug.Print(m.Body);
                        await DeleteMessage(queueUrl, m.ReceiptHandle);
                        return;
                    } 

                    try
                    {

                        if (ProcessMessage(m)) await DeleteMessage(queueUrl, m.ReceiptHandle); // only delete if successfully processed.
                    }
                    catch (Exception e)
                    {
                        Debug.Fail($"Failed to process message with error", e.Message);
                    }

                });

            }
        }

        private async Task<List<Message>> GetMessages(string queueUrl, CancellationToken cancellationToken = default)
        {
            try
            {
                var response = await _sqsClient.ReceiveMessageAsync(new ReceiveMessageRequest
                {
                    QueueUrl = queueUrl,
                    WaitTimeSeconds = 10,
                    MessageAttributeNames = new List<string> { "All" }
                }, cancellationToken);

                if (response.HttpStatusCode != HttpStatusCode.OK)
                {
                    throw new AmazonSQSException($"Failed to GetMessagesAsync for queue {queueUrl}. Response: {response.HttpStatusCode}");
                }

                return response.Messages;
            }
            catch (TaskCanceledException)
            {
                Debug.Print($"Failed to GetMessagesAsync for queue {queueUrl} because the task was canceled");
                return new List<Message>();
            }
            catch (Exception)
            {
                Debug.Fail($"Failed to GetMessagesAsync for queue {queueUrl}");
                throw;
            }
        }


        private async Task DeleteMessage(string queueUrl, string receiptHandle)
        {
            try
            {
                var response = await _sqsClient.DeleteMessageAsync(queueUrl, receiptHandle);

                if (response.HttpStatusCode != HttpStatusCode.OK)
                {
                    throw new AmazonSQSException($"Failed to DeleteMessageAsync with for [{receiptHandle}] from queue '{queueUrl}'. Response: {response.HttpStatusCode}");
                }
            }
            catch (Exception)
            {
                Debug.Fail($"Failed to DeleteMessageAsync from queue {queueUrl}");
                throw;
            }
        }

    }
}