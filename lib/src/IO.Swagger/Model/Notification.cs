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
    /// Notification
    /// </summary>
    [DataContract]
    public partial class Notification :  IEquatable<Notification>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Notification" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Notification() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Notification" /> class.
        /// </summary>
        /// <param name="created">created (required).</param>
        /// <param name="_params">_params.</param>
        /// <param name="message">message.</param>
        /// <param name="dismissedOn">dismissedOn.</param>
        /// <param name="dismissedBy">dismissedBy.</param>
        /// <param name="id">id.</param>
        /// <param name="deviceId">deviceId.</param>
        /// <param name="pointId">pointId.</param>
        /// <param name="userId">userId.</param>
        /// <param name="triggerId">triggerId.</param>
        public Notification(DateTime? created = default(DateTime?), Object _params = default(Object), string message = default(string), DateTime? dismissedOn = default(DateTime?), Object dismissedBy = default(Object), decimal? id = default(decimal?), decimal? deviceId = default(decimal?), decimal? pointId = default(decimal?), decimal? userId = default(decimal?), decimal? triggerId = default(decimal?))
        {
            // to ensure "created" is required (not null)
            if (created == null)
            {
                throw new InvalidDataException("created is a required property for Notification and cannot be null");
            }
            else
            {
                this.Created = created;
            }
            this.Params = _params;
            this.Message = message;
            this.DismissedOn = dismissedOn;
            this.DismissedBy = dismissedBy;
            this.Id = id;
            this.DeviceId = deviceId;
            this.PointId = pointId;
            this.UserId = userId;
            this.TriggerId = triggerId;
        }
        
        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Gets or Sets Params
        /// </summary>
        [DataMember(Name="params", EmitDefaultValue=false)]
        public Object Params { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets DismissedOn
        /// </summary>
        [DataMember(Name="dismissedOn", EmitDefaultValue=false)]
        public DateTime? DismissedOn { get; set; }

        /// <summary>
        /// Gets or Sets DismissedBy
        /// </summary>
        [DataMember(Name="dismissedBy", EmitDefaultValue=false)]
        public Object DismissedBy { get; set; }

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
        /// Gets or Sets PointId
        /// </summary>
        [DataMember(Name="pointId", EmitDefaultValue=false)]
        public decimal? PointId { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public decimal? UserId { get; set; }

        /// <summary>
        /// Gets or Sets TriggerId
        /// </summary>
        [DataMember(Name="triggerId", EmitDefaultValue=false)]
        public decimal? TriggerId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Notification {\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Params: ").Append(Params).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  DismissedOn: ").Append(DismissedOn).Append("\n");
            sb.Append("  DismissedBy: ").Append(DismissedBy).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DeviceId: ").Append(DeviceId).Append("\n");
            sb.Append("  PointId: ").Append(PointId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  TriggerId: ").Append(TriggerId).Append("\n");
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
            return this.Equals(input as Notification);
        }

        /// <summary>
        /// Returns true if Notification instances are equal
        /// </summary>
        /// <param name="input">Instance of Notification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Notification input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Params == input.Params ||
                    (this.Params != null &&
                    this.Params.Equals(input.Params))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.DismissedOn == input.DismissedOn ||
                    (this.DismissedOn != null &&
                    this.DismissedOn.Equals(input.DismissedOn))
                ) && 
                (
                    this.DismissedBy == input.DismissedBy ||
                    (this.DismissedBy != null &&
                    this.DismissedBy.Equals(input.DismissedBy))
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
                ) && 
                (
                    this.PointId == input.PointId ||
                    (this.PointId != null &&
                    this.PointId.Equals(input.PointId))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.TriggerId == input.TriggerId ||
                    (this.TriggerId != null &&
                    this.TriggerId.Equals(input.TriggerId))
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
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Params != null)
                    hashCode = hashCode * 59 + this.Params.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.DismissedOn != null)
                    hashCode = hashCode * 59 + this.DismissedOn.GetHashCode();
                if (this.DismissedBy != null)
                    hashCode = hashCode * 59 + this.DismissedBy.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.DeviceId != null)
                    hashCode = hashCode * 59 + this.DeviceId.GetHashCode();
                if (this.PointId != null)
                    hashCode = hashCode * 59 + this.PointId.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.TriggerId != null)
                    hashCode = hashCode * 59 + this.TriggerId.GetHashCode();
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
