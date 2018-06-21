# IO.Swagger.Model.Datapoint
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Location** | [**GeoPoint**](GeoPoint.md) |  | [optional] 
**Timestamp** | **DateTime?** | Timestamp for the datapoint. NB this is not necessarily the same as &#39;created&#39; | 
**Speed** | **decimal?** | Ground velocity in kmh, as determined by the GPS | [optional] 
**Altitude** | **decimal?** | Altitude in m, as determined by the GPS | [optional] 
**Course** | **decimal?** | Course in degrees, as determined by the GPS | [optional] 
**NumValue** | **string** | Internal use only | [optional] 
**StringValue** | **string** | Internal use only | [optional] 
**SendReason** | **decimal?** | Bitfield indicating reason for datapoint transmission and status of the device at the time.   Bit1(1): Wake mode active,    Bit2(2): Sleep mode active,    Bit3(4): Bluetooth disconnected,    Bit4(8): Outside of Safe-zone,    Bit5(16): Motion detected,    Bit6(32): Device started moving,    Bit7(64): Device stopped moving,    Bit8(128): Position is stale: last known location was used   Special case 255/0xFF: device was checking in with server. Ignore all data | [optional] 
**Sats** | **decimal?** | Number of visible satellites, as determined by the GPS | [optional] 
**Hdop** | **decimal?** | Deprecated | [optional] 
**Accuracy** | **decimal?** | Accuracy of the location in meters | [optional] 
**LocationType** | **string** | Type of position. Can be &#39;gps&#39;, &#39;wifi&#39;, &#39;gsm&#39; or &#39;invalid&#39; | [default to "gps"]
**BatteryVoltage** | **decimal?** | Battery charge level in volts. | [optional] 
**AverageCharge** | **decimal?** | Internal Use. 255 indicates plugged in and charging. | [optional] 
**Created** | **DateTime?** | Timestamp for when the datapoint was received and processed by the server | 
**Address** | **string** | A reverse geocode result for the point | [optional] 
**AlertType** | **decimal?** | Bitfield indicating what alerts where active at transmission time   Bit1(1): Freefall / Drop detected,    Bit2(2): Rotation detected,    Bit3(4): GSM jamming detected,    Bit4(8): Button was pressed,    Bit5(16): Generic Alert  | [optional] 
**Id** | **decimal?** |  | [optional] 
**DeviceId** | **decimal?** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

