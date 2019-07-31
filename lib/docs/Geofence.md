# IO.Swagger.Model.Geofence
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Outline** | **List&lt;Object&gt;** | Array of {lat:x,lng:y} objects representing the vertices of the polygon. Do not use with center and radius. | [optional] 
**Center** | [**GeoPoint**](GeoPoint.md) | For circular geofences, the center. Property is ignored if outline !&#x3D; null. | [optional] 
**Radius** | **decimal?** | For circular geofences, the radius of the circle in meters. Property is ignored if outline !&#x3D; null. | [optional] 
**Type** | **string** | &#39;inside&#39;, &#39;outside&#39; or &#39;cross&#39;. For device safe-zone the value is ignored (always &#39;outside&#39;) | [optional] 
**Name** | **string** |  | [optional] 
**WasInside** | **bool?** | If the last point received was inside the geofence. Only updated for notifications (not the safe-zone as that is evaluated on the device) | [optional] [default to false]
**LastChecked** | **DateTime?** | When the geofence was last evaluated. Only updated for notifications (not the safe-zone as that is evaluated on the device) | [optional] 
**Modified** | **bool?** |  | [optional] [default to false]
**Id** | **decimal?** |  | [optional] 
**DeviceId** | **decimal?** |  | [optional] 
**ConfigId** | **decimal?** |  | [optional] 
**UserId** | **decimal?** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

