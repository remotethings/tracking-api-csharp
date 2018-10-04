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

                //var notif = new NotificationTrigger();
                //notif.Delivery = new Dictionary<string, bool>() { { "mqtt", true } };

            } 
            catch(Exception e)
            {
                Debug.Print("Failed to login, please check credentials");
            }

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

            example.getDevices();
            example.printLastLocations();

            var wait = example.listenForNewData();
            while (!wait.IsCompleted) ;
            
        }
    }
}
