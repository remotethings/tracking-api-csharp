# IO.Swagger.Model.SensorReading
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Timestamp** | **DateTime?** | Timestamp for the reading | 
**Created** | **DateTime?** | Timestamp for the writing to db | 
**Type** | **string** | Sensor type: &#39;ultra&#39; (fill level), &#39;temp&#39; (temperature), ... | 
**Value** | **Object** | JSON value | 
**Meta** | **Object** | JSON metadata | [optional] 
**RelatedId** | **decimal?** | LoraId of another (ie for signal strength) | [optional] 
**Id** | **decimal?** |  | [optional] 
**GatewayId** | **decimal?** |  | [optional] 
**DeviceId** | **decimal?** |  | [optional] 
**SensorDeviceId** | **string** |  | [optional] 
**DatapointId** | **decimal?** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

