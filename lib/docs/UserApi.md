# IO.Swagger.Api.UserApi

All URIs are relative to *https://api.thelightbug.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UserLogin**](UserApi.md#userlogin) | **POST** /users/login | Login a user with username/email and password.
[**UserPrototypeCreateGeofences**](UserApi.md#userprototypecreategeofences) | **POST** /users/{id}/geofences | Creates a new instance in geofences of this model.
[**UserPrototypeDeleteGeofences**](UserApi.md#userprototypedeletegeofences) | **DELETE** /users/{id}/geofences | Deletes all geofences of this model.
[**UserPrototypeDestroyByIdGeofences**](UserApi.md#userprototypedestroybyidgeofences) | **DELETE** /users/{id}/geofences/{fk} | Delete a related item by id for geofences.
[**UserPrototypeFindByIdGeofences**](UserApi.md#userprototypefindbyidgeofences) | **GET** /users/{id}/geofences/{fk} | Find a related item by id for geofences.
[**UserPrototypeGetDevices**](UserApi.md#userprototypegetdevices) | **GET** /users/{id}/devices | Queries devices of user.
[**UserPrototypeGetGeofences**](UserApi.md#userprototypegetgeofences) | **GET** /users/{id}/geofences | Queries geofences of user.
[**UserPrototypeGetMqttCredentials**](UserApi.md#userprototypegetmqttcredentials) | **GET** /users/{id}/getMqttCredentials | 
[**UserPrototypeUpdateByIdGeofences**](UserApi.md#userprototypeupdatebyidgeofences) | **PUT** /users/{id}/geofences/{fk} | Update a related item by id for geofences.


<a name="userlogin"></a>
# **UserLogin**
> AccessToken UserLogin (Credentials credentials, string include = null)

Login a user with username/email and password.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UserLoginExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var credentials = new Credentials(); // Credentials | Body (JSON)
            var include = include_example;  // string | Related objects to include in the response. See the description of return value for more details. (optional) 

            try
            {
                // Login a user with username/email and password.
                AccessToken result = apiInstance.UserLogin(credentials, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.UserLogin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **credentials** | [**Credentials**](Credentials.md)| Body (JSON) | 
 **include** | **string**| Related objects to include in the response. See the description of return value for more details. | [optional] 

### Return type

[**AccessToken**](AccessToken.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userprototypecreategeofences"></a>
# **UserPrototypeCreateGeofences**
> Geofence UserPrototypeCreateGeofences (string id, Geofence data = null)

Creates a new instance in geofences of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UserPrototypeCreateGeofencesExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var id = id_example;  // string | user id
            var data = new Geofence(); // Geofence | Body (JSON) (optional) 

            try
            {
                // Creates a new instance in geofences of this model.
                Geofence result = apiInstance.UserPrototypeCreateGeofences(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.UserPrototypeCreateGeofences: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| user id | 
 **data** | [**Geofence**](Geofence.md)| Body (JSON) | [optional] 

### Return type

[**Geofence**](Geofence.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userprototypedeletegeofences"></a>
# **UserPrototypeDeleteGeofences**
> void UserPrototypeDeleteGeofences (string id)

Deletes all geofences of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UserPrototypeDeleteGeofencesExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var id = id_example;  // string | user id

            try
            {
                // Deletes all geofences of this model.
                apiInstance.UserPrototypeDeleteGeofences(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.UserPrototypeDeleteGeofences: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| user id | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userprototypedestroybyidgeofences"></a>
# **UserPrototypeDestroyByIdGeofences**
> void UserPrototypeDestroyByIdGeofences (string id, decimal? fk)

Delete a related item by id for geofences.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UserPrototypeDestroyByIdGeofencesExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var id = id_example;  // string | user id
            var fk = 8.14;  // decimal? | Foreign key for geofences

            try
            {
                // Delete a related item by id for geofences.
                apiInstance.UserPrototypeDestroyByIdGeofences(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.UserPrototypeDestroyByIdGeofences: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| user id | 
 **fk** | **decimal?**| Foreign key for geofences | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userprototypefindbyidgeofences"></a>
# **UserPrototypeFindByIdGeofences**
> Geofence UserPrototypeFindByIdGeofences (string id, decimal? fk)

Find a related item by id for geofences.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UserPrototypeFindByIdGeofencesExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var id = id_example;  // string | user id
            var fk = 8.14;  // decimal? | Foreign key for geofences

            try
            {
                // Find a related item by id for geofences.
                Geofence result = apiInstance.UserPrototypeFindByIdGeofences(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.UserPrototypeFindByIdGeofences: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| user id | 
 **fk** | **decimal?**| Foreign key for geofences | 

### Return type

[**Geofence**](Geofence.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userprototypegetdevices"></a>
# **UserPrototypeGetDevices**
> List<Device> UserPrototypeGetDevices (string id, string filter = null)

Queries devices of user.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UserPrototypeGetDevicesExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var id = id_example;  // string | user id
            var filter = filter_example;  // string | JSON Filter object (optional) 

            try
            {
                // Queries devices of user.
                List&lt;Device&gt; result = apiInstance.UserPrototypeGetDevices(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.UserPrototypeGetDevices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| user id | 
 **filter** | **string**| JSON Filter object | [optional] 

### Return type

[**List<Device>**](Device.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userprototypegetgeofences"></a>
# **UserPrototypeGetGeofences**
> List<Geofence> UserPrototypeGetGeofences (string id, string filter = null)

Queries geofences of user.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UserPrototypeGetGeofencesExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var id = id_example;  // string | user id
            var filter = filter_example;  // string | JSON Filter object (optional) 

            try
            {
                // Queries geofences of user.
                List&lt;Geofence&gt; result = apiInstance.UserPrototypeGetGeofences(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.UserPrototypeGetGeofences: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| user id | 
 **filter** | **string**| JSON Filter object | [optional] 

### Return type

[**List<Geofence>**](Geofence.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userprototypegetmqttcredentials"></a>
# **UserPrototypeGetMqttCredentials**
> InlineResponse200 UserPrototypeGetMqttCredentials (string id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UserPrototypeGetMqttCredentialsExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var id = id_example;  // string | user id

            try
            {
                InlineResponse200 result = apiInstance.UserPrototypeGetMqttCredentials(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.UserPrototypeGetMqttCredentials: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| user id | 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userprototypeupdatebyidgeofences"></a>
# **UserPrototypeUpdateByIdGeofences**
> Geofence UserPrototypeUpdateByIdGeofences (string id, decimal? fk, Geofence data = null)

Update a related item by id for geofences.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UserPrototypeUpdateByIdGeofencesExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var id = id_example;  // string | user id
            var fk = 8.14;  // decimal? | Foreign key for geofences
            var data = new Geofence(); // Geofence | Body (JSON) (optional) 

            try
            {
                // Update a related item by id for geofences.
                Geofence result = apiInstance.UserPrototypeUpdateByIdGeofences(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.UserPrototypeUpdateByIdGeofences: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| user id | 
 **fk** | **decimal?**| Foreign key for geofences | 
 **data** | [**Geofence**](Geofence.md)| Body (JSON) | [optional] 

### Return type

[**Geofence**](Geofence.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

