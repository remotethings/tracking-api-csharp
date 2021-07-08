using IO.Swagger.Model;
using System;
using System.Runtime.Serialization;

public class NotificationModel {
    [DataMember(Name = "notification", EmitDefaultValue = false)]
    public Notification Notification;
    
    [DataMember(Name = "reading", EmitDefaultValue = false)]
    public SensorReading Reading;
    
    [DataMember(Name = "datapoint", EmitDefaultValue = false)]
    public Datapoint Datapoint;

}
