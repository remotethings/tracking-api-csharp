# IO.Swagger.Api.DeviceApi

All URIs are relative to *https://api.thelightbug.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeviceFindById**](DeviceApi.md#devicefindbyid) | **GET** /devices/{id} | Find a model instance by {{id}} from the data source.
[**DevicePrototypeCreateGatewayReadings**](DeviceApi.md#deviceprototypecreategatewayreadings) | **POST** /devices/{id}/gatewayReadings | Creates a new instance in gatewayReadings of this model.
[**DevicePrototypeCreateMessages**](DeviceApi.md#deviceprototypecreatemessages) | **POST** /devices/{id}/messages | Creates a new instance in messages of this model.
[**DevicePrototypeCreateNotificationTriggers**](DeviceApi.md#deviceprototypecreatenotificationtriggers) | **POST** /devices/{id}/notificationTriggers | Create alert/notification trigger for device
[**DevicePrototypeDeleteGatewayReadings**](DeviceApi.md#deviceprototypedeletegatewayreadings) | **DELETE** /devices/{id}/gatewayReadings | Deletes all gatewayReadings of this model.
[**DevicePrototypeDeleteMessages**](DeviceApi.md#deviceprototypedeletemessages) | **DELETE** /devices/{id}/messages | Deletes all messages of this model.
[**DevicePrototypeDeleteNotificationTriggers**](DeviceApi.md#deviceprototypedeletenotificationtriggers) | **DELETE** /devices/{id}/notificationTriggers | Remove all alert/notification trigger for device
[**DevicePrototypeDestroyByIdGatewayReadings**](DeviceApi.md#deviceprototypedestroybyidgatewayreadings) | **DELETE** /devices/{id}/gatewayReadings/{fk} | Delete a related item by id for gatewayReadings.
[**DevicePrototypeDestroyByIdNotificationTriggers**](DeviceApi.md#deviceprototypedestroybyidnotificationtriggers) | **DELETE** /devices/{id}/notificationTriggers/{fk} | Remove alert/notification trigger by id {fk} for device
[**DevicePrototypeDestroyByIdPoints**](DeviceApi.md#deviceprototypedestroybyidpoints) | **DELETE** /devices/{id}/points/{fk} | Delete a specific point for a device
[**DevicePrototypeDestroyByIdTransients**](DeviceApi.md#deviceprototypedestroybyidtransients) | **DELETE** /devices/{id}/transients/{fk} | Delete a related item by id for transients.
[**DevicePrototypeFindByIdGatewayReadings**](DeviceApi.md#deviceprototypefindbyidgatewayreadings) | **GET** /devices/{id}/gatewayReadings/{fk} | Find a related item by id for gatewayReadings.
[**DevicePrototypeFindByIdNotificationTriggers**](DeviceApi.md#deviceprototypefindbyidnotificationtriggers) | **GET** /devices/{id}/notificationTriggers/{fk} | Find a related item by id for notificationTriggers.
[**DevicePrototypeFindByIdPoints**](DeviceApi.md#deviceprototypefindbyidpoints) | **GET** /devices/{id}/points/{fk} | Retrieve a specific point for a device
[**DevicePrototypeFindByIdReadings**](DeviceApi.md#deviceprototypefindbyidreadings) | **GET** /devices/{id}/readings/{fk} | Retrieve a specific reading for a device
[**DevicePrototypeFindByIdTransients**](DeviceApi.md#deviceprototypefindbyidtransients) | **GET** /devices/{id}/transients/{fk} | Find a related item by id for transients.
[**DevicePrototypeFlightMode**](DeviceApi.md#deviceprototypeflightmode) | **GET** /devices/{id}/flightMode | 
[**DevicePrototypeGetConfig**](DeviceApi.md#deviceprototypegetconfig) | **GET** /devices/{id}/config | Retrieve configuration for a device
[**DevicePrototypeGetGatewayReadings**](DeviceApi.md#deviceprototypegetgatewayreadings) | **GET** /devices/{id}/gatewayReadings | Queries gatewayReadings of device.
[**DevicePrototypeGetMessages**](DeviceApi.md#deviceprototypegetmessages) | **GET** /devices/{id}/messages | Queries messages of device.
[**DevicePrototypeGetNotificationTriggers**](DeviceApi.md#deviceprototypegetnotificationtriggers) | **GET** /devices/{id}/notificationTriggers | Get alerts for device
[**DevicePrototypeGetPoints**](DeviceApi.md#deviceprototypegetpoints) | **GET** /devices/{id}/points | Retrieve points for a device
[**DevicePrototypeGetReadings**](DeviceApi.md#deviceprototypegetreadings) | **GET** /devices/{id}/readings | Retrieve readings for a device
[**DevicePrototypeGetSafeZone**](DeviceApi.md#deviceprototypegetsafezone) | **GET** /devices/{id}/getSafeZone | Get safe-zone for device
[**DevicePrototypeGetTransients**](DeviceApi.md#deviceprototypegettransients) | **GET** /devices/{id}/transients | Queries transients of device.
[**DevicePrototypeNearbyDeviceData**](DeviceApi.md#deviceprototypenearbydevicedata) | **GET** /devices/{id}/nearbyDeviceData | 
[**DevicePrototypeNearbyDevices**](DeviceApi.md#deviceprototypenearbydevices) | **GET** /devices/{id}/nearbyDevices | 
[**DevicePrototypeSetSafeZone**](DeviceApi.md#deviceprototypesetsafezone) | **POST** /devices/{id}/setSafeZone | Update safe-zone for device
[**DevicePrototypeUpdateByIdGatewayReadings**](DeviceApi.md#deviceprototypeupdatebyidgatewayreadings) | **PUT** /devices/{id}/gatewayReadings/{fk} | Update a related item by id for gatewayReadings.
[**DevicePrototypeUpdateByIdNotificationTriggers**](DeviceApi.md#deviceprototypeupdatebyidnotificationtriggers) | **PUT** /devices/{id}/notificationTriggers/{fk} | Update an alert/notification trigger by id {fk} for device
[**DevicePrototypeUpdateByIdTransients**](DeviceApi.md#deviceprototypeupdatebyidtransients) | **PUT** /devices/{id}/transients/{fk} | Update a related item by id for transients.
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

<a name="deviceprototypecreategatewayreadings"></a>
# **DevicePrototypeCreateGatewayReadings**
> SensorReading DevicePrototypeCreateGatewayReadings (decimal? id, SensorReading data = null)

Creates a new instance in gatewayReadings of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DevicePrototypeCreateGatewayReadingsExample
    {
        public void main()
        {
            var apiInstance = new DeviceApi();
            var id = 8.14;  // decimal? | device id
            var data = new SensorReading(); // SensorReading | Body (JSON) (optional) 

            try
            {
                // Creates a new instance in gatewayReadings of this model.
                SensorReading result = apiInstance.DevicePrototypeCreateGatewayReadings(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceApi.DevicePrototypeCreateGatewayReadings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **decimal?**| device id | 
 **data** | [**SensorReading**](SensorReading.md)| Body (JSON) | [optional] 

### Return type

[**SensorReading**](SensorReading.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deviceprototypecreatemessages"></a>
# **DevicePrototypeCreateMessages**
> DeviceMessage DevicePrototypeCreateMessages (decimal? id, DeviceMessage data = null)

Creates a new instance in messages of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DevicePrototypeCreateMessagesExample
    {
        public void main()
        {
            var apiInstance = new DeviceApi();
            var id = 8.14;  // decimal? | device id
            var data = new DeviceMessage(); // DeviceMessage | Body (JSON) (optional) 

            try
            {
                // Creates a new instance in messages of this model.
                DeviceMessage result = apiInstance.DevicePrototypeCreateMessages(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceApi.DevicePrototypeCreateMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **decimal?**| device id | 
 **data** | [**DeviceMessage**](DeviceMessage.md)| Body (JSON) | [optional] 

### Return type

[**DeviceMessage**](DeviceMessage.md)

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

<a name="deviceprototypedeletegatewayreadings"></a>
# **DevicePrototypeDeleteGatewayReadings**
> void DevicePrototypeDeleteGatewayReadings (decimal? id)

Deletes all gatewayReadings of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DevicePrototypeDeleteGatewayReadingsExample
    {
        public void main()
        {
            var apiInstance = new DeviceApi();
            var id = 8.14;  // decimal? | device id

            try
            {
                // Deletes all gatewayReadings of this model.
                apiInstance.DevicePrototypeDeleteGatewayReadings(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceApi.DevicePrototypeDeleteGatewayReadings: " + e.Message );
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

<a name="deviceprototypedeletemessages"></a>
# **DevicePrototypeDeleteMessages**
> void DevicePrototypeDeleteMessages (decimal? id)

Deletes all messages of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DevicePrototypeDeleteMessagesExample
    {
        public void main()
        {
            var apiInstance = new DeviceApi();
            var id = 8.14;  // decimal? | device id

            try
            {
                // Deletes all messages of this model.
                apiInstance.DevicePrototypeDeleteMessages(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceApi.DevicePrototypeDeleteMessages: " + e.Message );
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

<a name="deviceprototypedestroybyidgatewayreadings"></a>
# **DevicePrototypeDestroyByIdGatewayReadings**
> void DevicePrototypeDestroyByIdGatewayReadings (decimal? id, decimal? fk)

Delete a related item by id for gatewayReadings.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DevicePrototypeDestroyByIdGatewayReadingsExample
    {
        public void main()
        {
            var apiInstance = new DeviceApi();
            var id = 8.14;  // decimal? | device id
            var fk = 8.14;  // decimal? | Foreign key for gatewayReadings

            try
            {
                // Delete a related item by id for gatewayReadings.
                apiInstance.DevicePrototypeDestroyByIdGatewayReadings(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceApi.DevicePrototypeDestroyByIdGatewayReadings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **decimal?**| device id | 
 **fk** | **decimal?**| Foreign key for gatewayReadings | 

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

<a name="deviceprototypedestroybyidtransients"></a>
# **DevicePrototypeDestroyByIdTransients**
> void DevicePrototypeDestroyByIdTransients (decimal? id, decimal? fk)

Delete a related item by id for transients.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DevicePrototypeDestroyByIdTransientsExample
    {
        public void main()
        {
            var apiInstance = new DeviceApi();
            var id = 8.14;  // decimal? | device id
            var fk = 8.14;  // decimal? | Foreign key for transients

            try
            {
                // Delete a related item by id for transients.
                apiInstance.DevicePrototypeDestroyByIdTransients(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceApi.DevicePrototypeDestroyByIdTransients: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **decimal?**| device id | 
 **fk** | **decimal?**| Foreign key for transients | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deviceprototypefindbyidgatewayreadings"></a>
# **DevicePrototypeFindByIdGatewayReadings**
> SensorReading DevicePrototypeFindByIdGatewayReadings (decimal? id, decimal? fk)

Find a related item by id for gatewayReadings.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DevicePrototypeFindByIdGatewayReadingsExample
    {
        public void main()
        {
            var apiInstance = new DeviceApi();
            var id = 8.14;  // decimal? | device id
            var fk = 8.14;  // decimal? | Foreign key for gatewayReadings

            try
            {
                // Find a related item by id for gatewayReadings.
                SensorReading result = apiInstance.DevicePrototypeFindByIdGatewayReadings(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceApi.DevicePrototypeFindByIdGatewayReadings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **decimal?**| device id | 
 **fk** | **decimal?**| Foreign key for gatewayReadings | 

### Return type

[**SensorReading**](SensorReading.md)

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

<a name="deviceprototypefindbyidtransients"></a>
# **DevicePrototypeFindByIdTransients**
> DeviceTransient DevicePrototypeFindByIdTransients (decimal? id, decimal? fk)

Find a related item by id for transients.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DevicePrototypeFindByIdTransientsExample
    {
        public void main()
        {
            var apiInstance = new DeviceApi();
            var id = 8.14;  // decimal? | device id
            var fk = 8.14;  // decimal? | Foreign key for transients

            try
            {
                // Find a related item by id for transients.
                DeviceTransient result = apiInstance.DevicePrototypeFindByIdTransients(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceApi.DevicePrototypeFindByIdTransients: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **decimal?**| device id | 
 **fk** | **decimal?**| Foreign key for transients | 

### Return type

[**DeviceTransient**](DeviceTransient.md)

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

<a name="deviceprototypegetgatewayreadings"></a>
# **DevicePrototypeGetGatewayReadings**
> List<SensorReading> DevicePrototypeGetGatewayReadings (decimal? id, string filter = null)

Queries gatewayReadings of device.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DevicePrototypeGetGatewayReadingsExample
    {
        public void main()
        {
            var apiInstance = new DeviceApi();
            var id = 8.14;  // decimal? | device id
            var filter = filter_example;  // string | JSON Filter object (optional) 

            try
            {
                // Queries gatewayReadings of device.
                List&lt;SensorReading&gt; result = apiInstance.DevicePrototypeGetGatewayReadings(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceApi.DevicePrototypeGetGatewayReadings: " + e.Message );
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

<a name="deviceprototypegetmessages"></a>
# **DevicePrototypeGetMessages**
> List<DeviceMessage> DevicePrototypeGetMessages (decimal? id, string filter = null)

Queries messages of device.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DevicePrototypeGetMessagesExample
    {
        public void main()
        {
            var apiInstance = new DeviceApi();
            var id = 8.14;  // decimal? | device id
            var filter = filter_example;  // string | JSON Filter object (optional) 

            try
            {
                // Queries messages of device.
                List&lt;DeviceMessage&gt; result = apiInstance.DevicePrototypeGetMessages(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceApi.DevicePrototypeGetMessages: " + e.Message );
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

[**List<DeviceMessage>**](DeviceMessage.md)

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

<a name="deviceprototypegettransients"></a>
# **DevicePrototypeGetTransients**
> List<DeviceTransient> DevicePrototypeGetTransients (decimal? id, string filter = null)

Queries transients of device.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DevicePrototypeGetTransientsExample
    {
        public void main()
        {
            var apiInstance = new DeviceApi();
            var id = 8.14;  // decimal? | device id
            var filter = filter_example;  // string | JSON Filter object (optional) 

            try
            {
                // Queries transients of device.
                List&lt;DeviceTransient&gt; result = apiInstance.DevicePrototypeGetTransients(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceApi.DevicePrototypeGetTransients: " + e.Message );
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

[**List<DeviceTransient>**](DeviceTransient.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deviceprototypenearbydevicedata"></a>
# **DevicePrototypeNearbyDeviceData**
> Object DevicePrototypeNearbyDeviceData (decimal? id, string nearbyId, string dateRange)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DevicePrototypeNearbyDeviceDataExample
    {
        public void main()
        {
            var apiInstance = new DeviceApi();
            var id = 8.14;  // decimal? | device id
            var nearbyId = nearbyId_example;  // string | 
            var dateRange = dateRange_example;  // string | 

            try
            {
                Object result = apiInstance.DevicePrototypeNearbyDeviceData(id, nearbyId, dateRange);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceApi.DevicePrototypeNearbyDeviceData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **decimal?**| device id | 
 **nearbyId** | **string**|  | 
 **dateRange** | **string**|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deviceprototypenearbydevices"></a>
# **DevicePrototypeNearbyDevices**
> Object DevicePrototypeNearbyDevices (decimal? id, string dateRange = null, string correlationId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DevicePrototypeNearbyDevicesExample
    {
        public void main()
        {
            var apiInstance = new DeviceApi();
            var id = 8.14;  // decimal? | device id
            var dateRange = dateRange_example;  // string |  (optional) 
            var correlationId = correlationId_example;  // string |  (optional) 

            try
            {
                Object result = apiInstance.DevicePrototypeNearbyDevices(id, dateRange, correlationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceApi.DevicePrototypeNearbyDevices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **decimal?**| device id | 
 **dateRange** | **string**|  | [optional] 
 **correlationId** | **string**|  | [optional] 

### Return type

**Object**

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

<a name="deviceprototypeupdatebyidgatewayreadings"></a>
# **DevicePrototypeUpdateByIdGatewayReadings**
> SensorReading DevicePrototypeUpdateByIdGatewayReadings (decimal? id, decimal? fk, SensorReading data = null)

Update a related item by id for gatewayReadings.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DevicePrototypeUpdateByIdGatewayReadingsExample
    {
        public void main()
        {
            var apiInstance = new DeviceApi();
            var id = 8.14;  // decimal? | device id
            var fk = 8.14;  // decimal? | Foreign key for gatewayReadings
            var data = new SensorReading(); // SensorReading | Body (JSON) (optional) 

            try
            {
                // Update a related item by id for gatewayReadings.
                SensorReading result = apiInstance.DevicePrototypeUpdateByIdGatewayReadings(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceApi.DevicePrototypeUpdateByIdGatewayReadings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **decimal?**| device id | 
 **fk** | **decimal?**| Foreign key for gatewayReadings | 
 **data** | [**SensorReading**](SensorReading.md)| Body (JSON) | [optional] 

### Return type

[**SensorReading**](SensorReading.md)

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

<a name="deviceprototypeupdatebyidtransients"></a>
# **DevicePrototypeUpdateByIdTransients**
> DeviceTransient DevicePrototypeUpdateByIdTransients (decimal? id, decimal? fk, DeviceTransient data = null)

Update a related item by id for transients.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DevicePrototypeUpdateByIdTransientsExample
    {
        public void main()
        {
            var apiInstance = new DeviceApi();
            var id = 8.14;  // decimal? | device id
            var fk = 8.14;  // decimal? | Foreign key for transients
            var data = new DeviceTransient(); // DeviceTransient | Body (JSON) (optional) 

            try
            {
                // Update a related item by id for transients.
                DeviceTransient result = apiInstance.DevicePrototypeUpdateByIdTransients(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceApi.DevicePrototypeUpdateByIdTransients: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **decimal?**| device id | 
 **fk** | **decimal?**| Foreign key for transients | 
 **data** | [**DeviceTransient**](DeviceTransient.md)| Body (JSON) | [optional] 

### Return type

[**DeviceTransient**](DeviceTransient.md)

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

