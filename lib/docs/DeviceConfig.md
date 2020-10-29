# IO.Swagger.Model.DeviceConfig
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CurrentFW** | **string** | Current Firmware version | [optional] 
**OtaFW** | **string** | Pending Firmware version. If non null, the unit will be told to upgrade to this version when it next transmits in sleep mode. | [optional] 
**Interval** | **decimal?** | The wake mode interval in seconds. The unit will connect to the server this often when awake. | 
**SleepInterval** | **decimal?** | Sleep mode interval in seconds. The unit will try to connect this often to the server when asleep | 
**CheckInInterval** | **decimal?** | DEPRECATED A failsafe to ensure the unit connects to the server at least this often. | [optional] 
**Packing** | **decimal?** | The number of GPS points to send with each transmission. A packing setting of 3 with an &#39;interval&#39; of 60s will result in points recorded approximately every 20s, but they will only be sent together. This increases the time you have to wait for locations to come through to the server but improves battery life | 
**MovementSensitivity** | **decimal?** | Deprecated. See debounce. | [optional] 
**Debounce** | **decimal?** | Movement sensitivity on a scale of 1 to 10, with 1 being the most sensitive. It is correlated to the number of consecutive milliseconds the acceleration needs to exceed the movementSensitivity threshold | [optional] 
**MovementSensitivity2** | **decimal?** | A secondary debounce value. Typically this value is lower or equal to debounce, representing increased sensitivity to movement once the device is already moving. | [optional] 
**Behavior** | **decimal?** | Char Bitfield with various flags. Advanced use only.  DisableBluetooth:32 |  Encrypt:128 |  GsmOnWhenAwake:1 |  GsmOnWhenAsleep:2 |  GpsOnWhenAwake:4 |  DisableWifiAccuracyAssist:8 |  RepeatSleep:16 |  DisableWifi:64 | [optional] 
**ModeControl** | **decimal?** | Char Bitfield with various flags. Advanced use only.  StartStopOnly:1 |  LockAwakeOnAlert:2 |  SendSleepLocAfterBtDisconnect:4 |  | [optional] 
**ModeControl2** | **decimal?** | Char Bitfield with various flags. Advanced use only. FW &gt;&#x3D; 69.  SendStopImmediately:1 |  StopTimeoutIsInMinutes:2 |  HarshPowerBudget:4 |  Lock2G: 8 | [optional] 
**GpsTimeout** | **decimal?** | How long to let the GPS searches for a lock in seconds before giving up. Max 255s. | [optional] 
**TransmitTimeout** | **decimal?** | When the unit first wakes up from sleep, how long to wait before trying to transmit in multiples of 30 seconds. 0 &#x3D; instant, 1 &#x3D; 30s, 2 &#x3D; 60s...   Useful to avoid detection or draining battery inside shielded buildings. | [optional] 
**GpsStabilize** | **decimal?** | How long to let the GPS stabilise in seconds once a lock is achieved before sending the position. Higher values may increase accuracy. | [optional] 
**GpsCheckInterval** | **decimal?** | If a safe-zone is used, how often to check the wifi &amp; gps to see if its still inside it (only applies when motion is detected) | [optional] 
**StopTimeout** | **decimal?** | The total amount of time in seconds the unit has to be stationary for before deeming the journey over and switching to sleep mode | [optional] 
**TolerancePercentage** | **decimal?** | Power budget in mAh per location update. Default 10, do not set lower than 5. | [optional] 
**ReasonsToWake** | **List&lt;Object&gt;** |  | [optional] 
**Modified** | **DateTime?** | Set to any non null date to indicate the configuration should be pushed to the device when it next connects | [optional] 
**ForceFw** | **bool?** | Internal use.   Used with otaFW. Set to true to force the unit to upgrade on next connection (rather than waiting for a sleep connection | [optional] [default to false]
**ReceivedAt** | **DateTime?** | Indicates the last time the settings were sent to the device | [optional] 
**Reset** | **decimal?** | Non NULL values cause unit to restart on next connection   0 &#x3D; Normal reboot   1 &#x3D; Clear settings cache and restart   2 &#x3D; Clear cache and bluetooth connection data, then restart | [optional] 
**FlashTryCount** | **decimal?** | Internal use. Set to 0 when changing otaFW | [optional] 
**HomeWifiNetwork** | **string** | WiFi network name to use as a Safe-zone. When this network is visible, stay asleep | [optional] 
**HomeWifiPassword** | **string** | WiFi network paswword. If set enables transmission over WiFi. | [optional] 
**WakeAction** | **string** | Internal Use Only. What to do when the unit wakes up (ie is moved and not in a safe-zone). Options are &#39;available&#39; (lost and found), and &#39;normal&#39; (tracking) | [default to "normal"]
**OnDemandTime** | **decimal?** | Deprecated | 
**AlertAction** | **string** | What to do when the button is pressed or the unit is dropped. Options are &#39;available&#39; (stay registered on the mobile network), &#39;nothing&#39; (one transmission) and  &#39;lockOn&#39; (keep transmitting at &#39;interval&#39; until instructed otherwise | [default to "nothing"]
**Id** | **decimal?** |  | [optional] 
**DeviceId** | **decimal?** |  | [optional] 
**SafeZoneId** | **decimal?** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

