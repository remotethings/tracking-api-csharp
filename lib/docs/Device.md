# IO.Swagger.Model.Device
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Imei** | **string** |  | [optional] 
**Iccid** | **string** |  | [optional] 
**LoraId** | **decimal?** |  | [optional] 
**Imsi** | **string** |  | [optional] 
**BtMac** | **decimal?** | Bluetooth MAC Address as 48bit number | [optional] 
**BtMacAddress** | **string** | Bluetooth MAC Address in standard format | [optional] 
**UwbId** | **decimal?** | UWB Address as 32bit number | [optional] 
**Serial** | **string** |  | [optional] 
**Type** | **string** |  | [optional] 
**Expires** | **DateTime?** |  | [optional] 
**LastConnection** | **DateTime?** |  | [optional] 
**FirstSeen** | **DateTime?** |  | 
**Mode** | **string** |  | [optional] [default to "default"]
**Name** | **string** |  | [optional] 
**BatteryVoltage** | **decimal?** |  | [optional] 
**BatteryType** | **string** |  | [optional] [default to "LIO"]
**Tags** | **List&lt;string&gt;** |  | [optional] 
**CurrentMode** | **decimal?** | Indicates last known device state. 0 &#x3D; awake, 1 &#x3D; sleep, 6 &#x3D; flight mode | [optional] 
**Color** | **string** |  | [optional] [default to "fc7c3d"]
**SaveToWeb** | **bool?** |  | [optional] [default to false]
**Active** | **bool?** |  | [optional] [default to false]
**DeepSleep** | **bool?** |  | [optional] [default to false]
**Simstate** | **string** |  | [optional] [default to "active"]
**StripeSubscription** | **string** |  | [optional] 
**SubscriptionType** | **string** |  | [optional] 
**Meta** | **Object** |  | [optional] 
**ResellerId** | **decimal?** |  | [optional] 
**ResellerPlanId** | **decimal?** |  | [optional] 
**Id** | **decimal?** |  | [optional] 
**OwnerId** | **decimal?** |  | [optional] 
**SecurePhoneId** | **decimal?** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

