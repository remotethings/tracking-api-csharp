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
    /// DeviceMessage
    /// </summary>
    [DataContract]
    public partial class DeviceMessage :  IEquatable<DeviceMessage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceMessage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeviceMessage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceMessage" /> class.
        /// </summary>
        /// <param name="config">config.</param>
        /// <param name="message">message.</param>
        /// <param name="mobileTerminated">mobileTerminated (default to true).</param>
        /// <param name="created">created (required).</param>
        /// <param name="sent">sent.</param>
        /// <param name="id">id.</param>
        /// <param name="deviceId">deviceId.</param>
        /// <param name="userId">userId.</param>
        public DeviceMessage(byte[] config = default(byte[]), string message = default(string), bool? mobileTerminated = true, DateTime? created = default(DateTime?), DateTime? sent = default(DateTime?), decimal? id = default(decimal?), decimal? deviceId = default(decimal?), decimal? userId = default(decimal?))
        {
            // to ensure "created" is required (not null)
            if (created == null)
            {
                throw new InvalidDataException("created is a required property for DeviceMessage and cannot be null");
            }
            else
            {
                this.Created = created;
            }
            this.Config = config;
            this.Message = message;
            // use default value if no "mobileTerminated" provided
            if (mobileTerminated == null)
            {
                this.MobileTerminated = true;
            }
            else
            {
                this.MobileTerminated = mobileTerminated;
            }
            this.Sent = sent;
            this.Id = id;
            this.DeviceId = deviceId;
            this.UserId = userId;
        }
        
        /// <summary>
        /// Gets or Sets Config
        /// </summary>
        [DataMember(Name="config", EmitDefaultValue=false)]
        public byte[] Config { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets MobileTerminated
        /// </summary>
        [DataMember(Name="mobileTerminated", EmitDefaultValue=false)]
        public bool? MobileTerminated { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Gets or Sets Sent
        /// </summary>
        [DataMember(Name="sent", EmitDefaultValue=false)]
        public DateTime? Sent { get; set; }

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
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public decimal? UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeviceMessage {\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  MobileTerminated: ").Append(MobileTerminated).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Sent: ").Append(Sent).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DeviceId: ").Append(DeviceId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(input as DeviceMessage);
        }

        /// <summary>
        /// Returns true if DeviceMessage instances are equal
        /// </summary>
        /// <param name="input">Instance of DeviceMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceMessage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Config == input.Config ||
                    (this.Config != null &&
                    this.Config.Equals(input.Config))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.MobileTerminated == input.MobileTerminated ||
                    (this.MobileTerminated != null &&
                    this.MobileTerminated.Equals(input.MobileTerminated))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Sent == input.Sent ||
                    (this.Sent != null &&
                    this.Sent.Equals(input.Sent))
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
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                if (this.Config != null)
                    hashCode = hashCode * 59 + this.Config.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.MobileTerminated != null)
                    hashCode = hashCode * 59 + this.MobileTerminated.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Sent != null)
                    hashCode = hashCode * 59 + this.Sent.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.DeviceId != null)
                    hashCode = hashCode * 59 + this.DeviceId.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
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
