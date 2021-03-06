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
    /// DeviceTransient
    /// </summary>
    [DataContract]
    public partial class DeviceTransient :  IEquatable<DeviceTransient>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceTransient" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeviceTransient() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceTransient" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="duration">duration (required).</param>
        /// <param name="triggeredAt">triggeredAt (required).</param>
        /// <param name="end">end.</param>
        /// <param name="sent">sent.</param>
        /// <param name="sms">sms (default to false).</param>
        /// <param name="id">id.</param>
        /// <param name="deviceId">deviceId.</param>
        public DeviceTransient(decimal? type = default(decimal?), decimal? duration = default(decimal?), DateTime? triggeredAt = default(DateTime?), DateTime? end = default(DateTime?), DateTime? sent = default(DateTime?), bool? sms = false, decimal? id = default(decimal?), decimal? deviceId = default(decimal?))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for DeviceTransient and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // to ensure "duration" is required (not null)
            if (duration == null)
            {
                throw new InvalidDataException("duration is a required property for DeviceTransient and cannot be null");
            }
            else
            {
                this.Duration = duration;
            }
            // to ensure "triggeredAt" is required (not null)
            if (triggeredAt == null)
            {
                throw new InvalidDataException("triggeredAt is a required property for DeviceTransient and cannot be null");
            }
            else
            {
                this.TriggeredAt = triggeredAt;
            }
            this.End = end;
            this.Sent = sent;
            // use default value if no "sms" provided
            if (sms == null)
            {
                this.Sms = false;
            }
            else
            {
                this.Sms = sms;
            }
            this.Id = id;
            this.DeviceId = deviceId;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public decimal? Type { get; set; }

        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public decimal? Duration { get; set; }

        /// <summary>
        /// Gets or Sets TriggeredAt
        /// </summary>
        [DataMember(Name="triggeredAt", EmitDefaultValue=false)]
        public DateTime? TriggeredAt { get; set; }

        /// <summary>
        /// Gets or Sets End
        /// </summary>
        [DataMember(Name="end", EmitDefaultValue=false)]
        public DateTime? End { get; set; }

        /// <summary>
        /// Gets or Sets Sent
        /// </summary>
        [DataMember(Name="sent", EmitDefaultValue=false)]
        public DateTime? Sent { get; set; }

        /// <summary>
        /// Gets or Sets Sms
        /// </summary>
        [DataMember(Name="sms", EmitDefaultValue=false)]
        public bool? Sms { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public decimal? Id { get; set; }

        /// <summary>
        /// Gets or Sets DeviceId
        /// </summary>
        [DataMember(Name="deviceId", EmitDefaultValue=false)]
        public decimal? DeviceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeviceTransient {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  TriggeredAt: ").Append(TriggeredAt).Append("\n");
            sb.Append("  End: ").Append(End).Append("\n");
            sb.Append("  Sent: ").Append(Sent).Append("\n");
            sb.Append("  Sms: ").Append(Sms).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DeviceId: ").Append(DeviceId).Append("\n");
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
            return this.Equals(input as DeviceTransient);
        }

        /// <summary>
        /// Returns true if DeviceTransient instances are equal
        /// </summary>
        /// <param name="input">Instance of DeviceTransient to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceTransient input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
                ) && 
                (
                    this.TriggeredAt == input.TriggeredAt ||
                    (this.TriggeredAt != null &&
                    this.TriggeredAt.Equals(input.TriggeredAt))
                ) && 
                (
                    this.End == input.End ||
                    (this.End != null &&
                    this.End.Equals(input.End))
                ) && 
                (
                    this.Sent == input.Sent ||
                    (this.Sent != null &&
                    this.Sent.Equals(input.Sent))
                ) && 
                (
                    this.Sms == input.Sms ||
                    (this.Sms != null &&
                    this.Sms.Equals(input.Sms))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.DeviceId == input.DeviceId ||
                    (this.DeviceId != null &&
                    this.DeviceId.Equals(input.DeviceId))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.TriggeredAt != null)
                    hashCode = hashCode * 59 + this.TriggeredAt.GetHashCode();
                if (this.End != null)
                    hashCode = hashCode * 59 + this.End.GetHashCode();
                if (this.Sent != null)
                    hashCode = hashCode * 59 + this.Sent.GetHashCode();
                if (this.Sms != null)
                    hashCode = hashCode * 59 + this.Sms.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.DeviceId != null)
                    hashCode = hashCode * 59 + this.DeviceId.GetHashCode();
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
