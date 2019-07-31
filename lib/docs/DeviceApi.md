# IO.Swagger.Api.DeviceApi

All URIs are relative to *https://api.thelightbug.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeviceFindById**](DeviceApi.md#devicefindbyid) | **GET** /devices/{id} | Find a model instance by {{id}} from the data source.
[**DevicePrototypeCreateNotificationTriggers**](DeviceApi.md#deviceprototypecreatenotificationtriggers) | **POST** /devices/{id}/notificationTriggers | Create alert/notification trigger for device
[**DevicePrototypeDeleteNotificationTriggers**](DeviceApi.md#deviceprototypedeletenotificationtriggers) | **DELETE** /devices/{id}/notificationTriggers | Remove all alert/notification trigger for device
[**DevicePrototypeDestroyByIdNotificationTriggers**](DeviceApi.md#deviceprototypedestroybyidnotificationtriggers) | **DELETE** /devices/{id}/notificationTriggers/{fk} | Remove alert/notification trigger by id {fk} for device
[**DevicePrototypeDestroyByIdPoints**](DeviceApi.md#deviceprototypedestroybyidpoints) | **DELETE** /devices/{id}/points/{fk} | Delete a specific point for a device
[**DevicePrototypeFindByIdNotificationTriggers**](DeviceApi.md#deviceprototypefindbyidnotificationtriggers) | **GET** /devices/{id}/notificationTriggers/{fk} | Find a related item by id for notificationTriggers.
[**DevicePrototypeFindByIdPoints**](DeviceApi.md#deviceprototypefindbyidpoints) | **GET** /devices/{id}/points/{fk} | Retrieve a specific point for a device
[**DevicePrototypeFindByIdReadings**](DeviceApi.md#deviceprototypefindbyidreadings) | **GET** /devices/{id}/readings/{fk} | Retrieve a specific reading for a device
[**DevicePrototypeFlightMode**](DeviceApi.md#deviceprototypeflightmode) | **GET** /devices/{id}/flightMode | 
[**DevicePrototypeGetConfig**](DeviceApi.md#deviceprototypegetconfig) | **GET** /devices/{id}/config | Retrieve configuration for a device
[**DevicePrototypeGetNotificationTriggers**](DeviceApi.md#deviceprototypegetnotificationtriggers) | **GET** /devices/{id}/notificationTriggers | Get alerts for device
[**DevicePrototypeGetPoints**](DeviceApi.md#deviceprototypegetpoints) | **GET** /devices/{id}/points | Retrieve points for a device
[**DevicePrototypeGetReadings**](DeviceApi.md#deviceprototypegetreadings) | **GET** /devices/{id}/readings | Retrieve readings for a device
[**DevicePrototypeGetSafeZone**](DeviceApi.md#deviceprototypegetsafezone) | **GET** /devices/{id}/getSafeZone | Get safe-zone for device
[**DevicePrototypeSetSafeZone**](DeviceApi.md#deviceprototypesetsafezone) | **POST** /devices/{id}/setSafeZone | Update safe-zone for device
[**DevicePrototypeUpdateByIdNotificationTriggers**](DeviceApi.md#deviceprototypeupdatebyidnotificationtriggers) | **PUT** /devices/{id}/notificationTriggers/{fk} | Update an alert/notification trigger by id {fk} for device
[**DevicePrototypeUpdateConfig**](DeviceApi.md#deviceprototypeupdateconfig) | **PUT** /devices/{id}/config | Update configuration for a device


<a name="devicefindbyid"></a>
# **DeviceFindById**
> Device DeviceFindById (string id, string filter = null)

Find a model instance by {{id}} from the data source.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeviceFindByIdExample
    {
        public void main()
        {
            var apiInstance = new DeviceApi();
            var id = id_example;  // string | Model id
            var filter = filter_example;  // string | Filter defining fields and include - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find a model instance by {{id}} from the data source.
                Device result = apiInstance.DeviceFindById(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceApi.DeviceFindById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **filter** | **string**| Filter defining fields and include - must be a JSON-encoded string ({\&quot;something\&quot;:\&quot;value\&quot;}) | [optional] 

### Return type

[**Device**](Device.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deviceprototypecreatenotificationtriggers"></a>
# **DevicePrototypeCreateNotificationTriggers**
> NotificationTrigger DevicePrototypeCreateNotificationTriggers (decimal? id, NotificationTrigger data = null)

Create alert/notification trigger for device

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DevicePrototypeCreateNotificationTriggersExample
    {
        public void main()
        {
            var apiInstance = new DeviceApi();
            var id = 8.14;  // decimal? | device id
            var data = new NotificationTrigger(); // NotificationTrigger | Body (JSON) (optional) 

            try
            {
                // Create alert/notification trigger for device
                NotificationTrigger result = apiInstance.DevicePrototypeCreateNotificationTriggers(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceApi.DevicePrototypeCreateNotificationTriggers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **decimal?**| device id | 
 **data** | [**NotificationTrigger**](NotificationTrigger.md)| Body (JSON) | [optional] 

### Return type

[**NotificationTrigger**](NotificationTrigger.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deviceprototypedeletenotificationtriggers"></a>
# **DevicePrototypeDeleteNotificationTriggers**
> void DevicePrototypeDeleteNotificationTriggers (decimal? id)

Remove all alert/notification trigger for device

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DevicePrototypeDeleteNotificationTriggersExample
    {
        public void main()
        {
            var apiInstance = new DeviceApi();
            var id = 8.14;  // decimal? | device id

            try
            {
                // Remove all alert/notification trigger for device
                apiInstance.DevicePrototypeDeleteNotificationTriggers(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceApi.DevicePrototypeDeleteNotificationTriggers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **decimal?**| device id | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deviceprototypedestroybyidnotificationtriggers"></a>
# **DevicePrototypeDestroyByIdNotificationTriggers**
> void DevicePrototypeDestroyByIdNotificationTriggers (decimal? id, decimal? fk)

Remove alert/notification trigger by id {fk} for device

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DevicePrototypeDestroyByIdNotificationTriggersExample
    {
        public void main()
        {
            var apiInstance = new DeviceApi();
            var id = 8.14;  // decimal? | device id
            var fk = 8.14;  // decimal? | Foreign key for notificationTriggers

            try
            {
                // Remove alert/notification trigger by id {fk} for device
                apiInstance.DevicePrototypeDestroyByIdNotificationTriggers(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceApi.DevicePrototypeDestroyByIdNotificationTriggers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **decimal?**| device id | 
 **fk** | **decimal?**| Foreign key for notificationTriggers | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deviceprototypedestroybyidpoints"></a>
# **DevicePrototypeDestroyByIdPoints**
> void DevicePrototypeDestroyByIdPoints (decimal? id, decimal? fk)

Delete a specific point for a device

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DevicePrototypeDestroyByIdPointsExample
    {
        public void main()
        {
            var apiInstance = new DeviceApi();
            var id = 8.14;  // decimal? | device id
            var fk = 8.14;  // decimal? | Foreign key for points

            try
            {
                // Delete a specific point for a device
                apiInstance.DevicePrototypeDestroyByIdPoints(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceApi.DevicePrototypeDestroyByIdPoints: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **decimal?**| device id | 
 **fk** | **decimal?**| Foreign key for points | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deviceprototypefindbyidnotificationtriggers"></a>
# **DevicePrototypeFindByIdNotificationTriggers**
> NotificationTrigger DevicePrototypeFindByIdNotificationTriggers (decimal? id, decimal? fk)

Find a related item by id for notificationTriggers.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DevicePrototypeFindByIdNotificationTriggersExample
    {
        public void main()
        {
            var apiInstance = new DeviceApi();
            var id = 8.14;  // decimal? | device id
            var fk = 8.14;  // decimal? | Foreign key for notificationTriggers

            try
            {
                // Find a related item by id for notificationTriggers.
                NotificationTrigger result = apiInstance.DevicePrototypeFindByIdNotificationTriggers(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceApi.DevicePrototypeFindByIdNotificationTriggers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **decimal?**| device id | 
 **fk** | **decimal?**| Foreign key for notificationTriggers | 

### Return type

[**NotificationTrigger**](NotificationTrigger.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deviceprototypefindbyidpoints"></a>
# **DevicePrototypeFindByIdPoints**
> Datapoint DevicePrototypeFindByIdPoints (decimal? id, decimal? fk)

Retrieve a specific point for a device

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DevicePrototypeFindByIdPointsExample
    {
        public void main()
        {
            var apiInstance = new DeviceApi();
            var id = 8.14;  // decimal? | device id
            var fk = 8.14;  // decimal? | Foreign key for points

            try
            {
                // Retrieve a specific point for a device
                Datapoint result = apiInstance.DevicePrototypeFindByIdPoints(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceApi.DevicePrototypeFindByIdPoints: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **decimal?**| device id | 
 **fk** | **decimal?**| Foreign key for points | 

### Return type

[**Datapoint**](Datapoint.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deviceprototypefindbyidreadings"></a>
# **DevicePrototypeFindByIdReadings**
> SensorReading DevicePrototypeFindByIdReadings (decimal? id, decimal? fk)

Retrieve a specific reading for a device

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DevicePrototypeFindByIdReadingsExample
    {
        public void main()
        {
            var apiInstance = new DeviceApi();
            var id = 8.14;  // decimal? | device id
            var fk = 8.14;  // decimal? | Foreign key for readings

            try
            {
                // Retrieve a specific reading for a device
                SensorReading result = apiInstance.DevicePrototypeFindByIdReadings(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceApi.DevicePrototypeFindByIdReadings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **decimal?**| device id | 
 **fk** | **decimal?**| Foreign key for readings | 

### Return type

[**SensorReading**](SensorReading.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deviceprototypeflightmode"></a>
# **DevicePrototypeFlightMode**
> Object DevicePrototypeFlightMode (decimal? id, decimal? duration)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DevicePrototypeFlightModeExample
    {
        public void main()
        {
            var apiInstance = new DeviceApi();
            var id = 8.14;  // decimal? | device id
            var duration = 8.14;  // decimal? | How long to go into flightMode, in minutes

            try
            {
                Object result = apiInstance.DevicePrototypeFlightMode(id, duration);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceApi.DevicePrototypeFlightMode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **decimal?**| device id | 
 **duration** | **decimal?**| How long to go into flightMode, in minutes | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deviceprototypegetconfig"></a>
# **DevicePrototypeGetConfig**
> DeviceConfig DevicePrototypeGetConfig (decimal? id, bool? refresh = null)

Retrieve configuration for a device

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DevicePrototypeGetConfigExample
    {
        public void main()
        {
            var apiInstance = new DeviceApi();
            var id = 8.14;  // decimal? | device id
            var refresh = true;  // bool? | unused (optional) 

            try
            {
                // Retrieve configuration for a device
                DeviceConfig result = apiInstance.DevicePrototypeGetConfig(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceApi.DevicePrototypeGetConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **decimal?**| device id | 
 **refresh** | **bool?**| unused | [optional] 

### Return type

[**DeviceConfig**](DeviceConfig.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deviceprototypegetnotificationtriggers"></a>
# **DevicePrototypeGetNotificationTriggers**
> List<NotificationTrigger> DevicePrototypeGetNotificationTriggers (decimal? id, string filter = null)

Get alerts for device

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DevicePrototypeGetNotificationTriggersExample
    {
        public void main()
        {
            var apiInstance = new DeviceApi();
            var id = 8.14;  // decimal? | device id
            var filter = filter_example;  // string | JSON Filter object (optional) 

            try
            {
                // Get alerts for device
                List&lt;NotificationTrigger&gt; result = apiInstance.DevicePrototypeGetNotificationTriggers(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceApi.DevicePrototypeGetNotificationTriggers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **decimal?**| device id | 
 **filter** | **string**| JSON Filter object | [optional] 

### Return type

[**List<NotificationTrigger>**](NotificationTrigger.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deviceprototypegetpoints"></a>
# **DevicePrototypeGetPoints**
> List<Datapoint> DevicePrototypeGetPoints (decimal? id, string filter = null)

Retrieve points for a device

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DevicePrototypeGetPointsExample
    {
        public void main()
        {
            var apiInstance = new DeviceApi();
            var id = 8.14;  // decimal? | device id
            var filter = filter_example;  // string | JSON Filter object (optional) 

            try
            {
                // Retrieve points for a device
                List&lt;Datapoint&gt; result = apiInstance.DevicePrototypeGetPoints(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceApi.DevicePrototypeGetPoints: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **decimal?**| device id | 
 **filter** | **string**| JSON Filter object | [optional] 

### Return type

[**List<Datapoint>**](Datapoint.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deviceprototypegetreadings"></a>
# **DevicePrototypeGetReadings**
> List<SensorReading> DevicePrototypeGetReadings (decimal? id, string filter = null)

Retrieve readings for a device

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DevicePrototypeGetReadingsExample
    {
        public void main()
        {
            var apiInstance = new DeviceApi();
            var id = 8.14;  // decimal? | device id
            var filter = filter_example;  // string | JSON Filter object (optional) 

            try
            {
                // Retrieve readings for a device
                List&lt;SensorReading&gt; result = apiInstance.DevicePrototypeGetReadings(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceApi.DevicePrototypeGetReadings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **decimal?**| device id | 
 **filter** | **string**| JSON Filter object | [optional] 

### Return type

[**List<SensorReading>**](SensorReading.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deviceprototypegetsafezone"></a>
# **DevicePrototypeGetSafeZone**
> Geofence DevicePrototypeGetSafeZone (decimal? id)

Get safe-zone for device

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DevicePrototypeGetSafeZoneExample
    {
        public void main()
        {
            var apiInstance = new DeviceApi();
            var id = 8.14;  // decimal? | device id

            try
            {
                // Get safe-zone for device
                Geofence result = apiInstance.DevicePrototypeGetSafeZone(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceApi.DevicePrototypeGetSafeZone: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **decimal?**| device id | 

### Return type

[**Geofence**](Geofence.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deviceprototypesetsafezone"></a>
# **DevicePrototypeSetSafeZone**
> Geofence DevicePrototypeSetSafeZone (decimal? id, List<GeoPoint> data)

Update safe-zone for device

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DevicePrototypeSetSafeZoneExample
    {
        public void main()
        {
            var apiInstance = new DeviceApi();
            var id = 8.14;  // decimal? | device id
            var data = new List<GeoPoint>(); // List<GeoPoint> | Array of {lat:x,lng:y} points denoting the vertices of the safe-zone

            try
            {
                // Update safe-zone for device
                Geofence result = apiInstance.DevicePrototypeSetSafeZone(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceApi.DevicePrototypeSetSafeZone: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **decimal?**| device id | 
 **data** | [**List&lt;GeoPoint&gt;**](GeoPoint.md)| Array of {lat:x,lng:y} points denoting the vertices of the safe-zone | 

### Return type

[**Geofence**](Geofence.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deviceprototypeupdatebyidnotificationtriggers"></a>
# **DevicePrototypeUpdateByIdNotificationTriggers**
> NotificationTrigger DevicePrototypeUpdateByIdNotificationTriggers (decimal? id, decimal? fk, NotificationTrigger data = null)

Update an alert/notification trigger by id {fk} for device

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DevicePrototypeUpdateByIdNotificationTriggersExample
    {
        public void main()
        {
            var apiInstance = new DeviceApi();
            var id = 8.14;  // decimal? | device id
            var fk = 8.14;  // decimal? | Foreign key for notificationTriggers
            var data = new NotificationTrigger(); // NotificationTrigger | Body (JSON) (optional) 

            try
            {
                // Update an alert/notification trigger by id {fk} for device
                NotificationTrigger result = apiInstance.DevicePrototypeUpdateByIdNotificationTriggers(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceApi.DevicePrototypeUpdateByIdNotificationTriggers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **decimal?**| device id | 
 **fk** | **decimal?**| Foreign key for notificationTriggers | 
 **data** | [**NotificationTrigger**](NotificationTrigger.md)| Body (JSON) | [optional] 

### Return type

[**NotificationTrigger**](NotificationTrigger.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deviceprototypeupdateconfig"></a>
# **DevicePrototypeUpdateConfig**
> DeviceConfig DevicePrototypeUpdateConfig (decimal? id, DeviceConfig data = null)

Update configuration for a device

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DevicePrototypeUpdateConfigExample
    {
        public void main()
        {
            var apiInstance = new DeviceApi();
            var id = 8.14;  // decimal? | device id
            var data = new DeviceConfig(); // DeviceConfig | Body (JSON) (optional) 

            try
            {
                // Update configuration for a device
                DeviceConfig result = apiInstance.DevicePrototypeUpdateConfig(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceApi.DevicePrototypeUpdateConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **decimal?**| device id | 
 **data** | [**DeviceConfig**](DeviceConfig.md)| Body (JSON) | [optional] 

### Return type

[**DeviceConfig**](DeviceConfig.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

