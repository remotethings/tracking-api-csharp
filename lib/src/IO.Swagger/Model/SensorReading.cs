/* 
 * TrackingAPI
 *
 * API for retrieving tracking data and changing settings on LightBug & RemoteThings tracking devices
 *
 * OpenAPI spec version: 1.1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// SensorReading
    /// </summary>
    [DataContract]
    public partial class SensorReading :  IEquatable<SensorReading>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SensorReading" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SensorReading() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SensorReading" /> class.
        /// </summary>
        /// <param name="timestamp">Timestamp for the reading (required).</param>
        /// <param name="created">Timestamp for the writing to db (required).</param>
        /// <param name="type">Sensor type: &#39;ultra&#39; (fill level), &#39;temp&#39; (temperature), ... (required).</param>
        /// <param name="value">JSON value (required).</param>
        /// <param name="rssi">RSSI if from secondary wireless device.</param>
        /// <param name="meta">JSON metadata.</param>
        /// <param name="relatedId">LoraId of another (ie for signal strength).</param>
        /// <param name="correlationId">Internal use - correlation identifier.</param>
        /// <param name="id">id.</param>
        /// <param name="gatewayId">gatewayId.</param>
        /// <param name="deviceId">deviceId.</param>
        /// <param name="sensorDeviceId">sensorDeviceId.</param>
        /// <param name="datapointId">datapointId.</param>
        public SensorReading(DateTime? timestamp = default(DateTime?), DateTime? created = default(DateTime?), string type = default(string), Object value = default(Object), decimal? rssi = default(decimal?), Object meta = default(Object), decimal? relatedId = default(decimal?), string correlationId = default(string), decimal? id = default(decimal?), decimal? gatewayId = default(decimal?), decimal? deviceId = default(decimal?), string sensorDeviceId = default(string), decimal? datapointId = default(decimal?))
        {
            // to ensure "timestamp" is required (not null)
            if (timestamp == null)
            {
                throw new InvalidDataException("timestamp is a required property for SensorReading and cannot be null");
            }
            else
            {
                this.Timestamp = timestamp;
            }
            // to ensure "created" is required (not null)
            if (created == null)
            {
                throw new InvalidDataException("created is a required property for SensorReading and cannot be null");
            }
            else
            {
                this.Created = created;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for SensorReading and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new InvalidDataException("value is a required property for SensorReading and cannot be null");
            }
            else
            {
                this.Value = value;
            }
            this.Rssi = rssi;
            this.Meta = meta;
            this.RelatedId = relatedId;
            this.CorrelationId = correlationId;
            this.Id = id;
            this.GatewayId = gatewayId;
            this.DeviceId = deviceId;
            this.SensorDeviceId = sensorDeviceId;
            this.DatapointId = datapointId;
        }
        
        /// <summary>
        /// Timestamp for the reading
        /// </summary>
        /// <value>Timestamp for the reading</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Timestamp for the writing to db
        /// </summary>
        /// <value>Timestamp for the writing to db</value>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Sensor type: &#39;ultra&#39; (fill level), &#39;temp&#39; (temperature), ...
        /// </summary>
        /// <value>Sensor type: &#39;ultra&#39; (fill level), &#39;temp&#39; (temperature), ...</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// JSON value
        /// </summary>
        /// <value>JSON value</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public Object Value { get; set; }

        /// <summary>
        /// RSSI if from secondary wireless device
        /// </summary>
        /// <value>RSSI if from secondary wireless device</value>
        [DataMember(Name="rssi", EmitDefaultValue=false)]
        public decimal? Rssi { get; set; }

        /// <summary>
        /// JSON metadata
        /// </summary>
        /// <value>JSON metadata</value>
        [DataMember(Name="meta", EmitDefaultValue=false)]
        public Object Meta { get; set; }

        /// <summary>
        /// LoraId of another (ie for signal strength)
        /// </summary>
        /// <value>LoraId of another (ie for signal strength)</value>
        [DataMember(Name="relatedId", EmitDefaultValue=false)]
        public decimal? RelatedId { get; set; }

        /// <summary>
        /// Internal use - correlation identifier
        /// </summary>
        /// <value>Internal use - correlation identifier</value>
        [DataMember(Name="correlationId", EmitDefaultValue=false)]
        public string CorrelationId { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public decimal? Id { get; set; }

        /// <summary>
        /// Gets or Sets GatewayId
        /// </summary>
        [DataMember(Name="gatewayId", EmitDefaultValue=false)]
        public decimal? GatewayId { get; set; }

        /// <summary>
        /// Gets or Sets DeviceId
        /// </summary>
        [DataMember(Name="deviceId", EmitDefaultValue=false)]
        public decimal? DeviceId { get; set; }

        /// <summary>
        /// Gets or Sets SensorDeviceId
        /// </summary>
        [DataMember(Name="sensorDeviceId", EmitDefaultValue=false)]
        public string SensorDeviceId { get; set; }

        /// <summary>
        /// Gets or Sets DatapointId
        /// </summary>
        [DataMember(Name="datapointId", EmitDefaultValue=false)]
        public decimal? DatapointId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SensorReading {\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Rssi: ").Append(Rssi).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
            sb.Append("  RelatedId: ").Append(RelatedId).Append("\n");
            sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  GatewayId: ").Append(GatewayId).Append("\n");
            sb.Append("  DeviceId: ").Append(DeviceId).Append("\n");
            sb.Append("  SensorDeviceId: ").Append(SensorDeviceId).Append("\n");
            sb.Append("  DatapointId: ").Append(DatapointId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SensorReading);
        }

        /// <summary>
        /// Returns true if SensorReading instances are equal
        /// </summary>
        /// <param name="input">Instance of SensorReading to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SensorReading input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Rssi == input.Rssi ||
                    (this.Rssi != null &&
                    this.Rssi.Equals(input.Rssi))
                ) && 
                (
                    this.Meta == input.Meta ||
                    (this.Meta != null &&
                    this.Meta.Equals(input.Meta))
                ) && 
                (
                    this.RelatedId == input.RelatedId ||
                    (this.RelatedId != null &&
                    this.RelatedId.Equals(input.RelatedId))
                ) && 
                (
                    this.CorrelationId == input.CorrelationId ||
                    (this.CorrelationId != null &&
                    this.CorrelationId.Equals(input.CorrelationId))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.GatewayId == input.GatewayId ||
                    (this.GatewayId != null &&
                    this.GatewayId.Equals(input.GatewayId))
                ) && 
                (
                    this.DeviceId == input.DeviceId ||
                    (this.DeviceId != null &&
                    this.DeviceId.Equals(input.DeviceId))
                ) && 
                (
                    this.SensorDeviceId == input.SensorDeviceId ||
                    (this.SensorDeviceId != null &&
                    this.SensorDeviceId.Equals(input.SensorDeviceId))
                ) && 
                (
                    this.DatapointId == input.DatapointId ||
                    (this.DatapointId != null &&
                    this.DatapointId.Equals(input.DatapointId))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Rssi != null)
                    hashCode = hashCode * 59 + this.Rssi.GetHashCode();
                if (this.Meta != null)
                    hashCode = hashCode * 59 + this.Meta.GetHashCode();
                if (this.RelatedId != null)
                    hashCode = hashCode * 59 + this.RelatedId.GetHashCode();
                if (this.CorrelationId != null)
                    hashCode = hashCode * 59 + this.CorrelationId.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.GatewayId != null)
                    hashCode = hashCode * 59 + this.GatewayId.GetHashCode();
                if (this.DeviceId != null)
                    hashCode = hashCode * 59 + this.DeviceId.GetHashCode();
                if (this.SensorDeviceId != null)
                    hashCode = hashCode * 59 + this.SensorDeviceId.GetHashCode();
                if (this.DatapointId != null)
                    hashCode = hashCode * 59 + this.DatapointId.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
