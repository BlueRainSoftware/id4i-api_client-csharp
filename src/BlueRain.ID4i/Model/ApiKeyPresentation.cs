/* 
 * ID4i API
 *
 * ID4i HTTP API
 *
 * OpenAPI spec version: 0.9.3
 * Contact: info@bluerain.de
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = BlueRain.ID4i.Client.SwaggerDateConverter;

namespace BlueRain.ID4i.Model
{
    /// <summary>
    /// ApiKeyPresentation
    /// </summary>
    [DataContract]
    public partial class ApiKeyPresentation :  IEquatable<ApiKeyPresentation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyPresentation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApiKeyPresentation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyPresentation" /> class.
        /// </summary>
        /// <param name="Active">Whether this API key is active (required).</param>
        /// <param name="CreatedAt">The UTC unix timestamp of when this api key has been created (required).</param>
        /// <param name="CreatedBy">CreatedBy (required).</param>
        /// <param name="Key">The api key identifier (required).</param>
        /// <param name="Label">The label / name of the api key (required).</param>
        /// <param name="OrganizationId">The organization namespace this api key belongs to (required).</param>
        public ApiKeyPresentation(bool? Active = default(bool?), long? CreatedAt = default(long?), string CreatedBy = default(string), string Key = default(string), string Label = default(string), string OrganizationId = default(string))
        {
            // to ensure "Active" is required (not null)
            if (Active == null)
            {
                throw new InvalidDataException("Active is a required property for ApiKeyPresentation and cannot be null");
            }
            else
            {
                this.Active = Active;
            }
            // to ensure "CreatedAt" is required (not null)
            if (CreatedAt == null)
            {
                throw new InvalidDataException("CreatedAt is a required property for ApiKeyPresentation and cannot be null");
            }
            else
            {
                this.CreatedAt = CreatedAt;
            }
            // to ensure "CreatedBy" is required (not null)
            if (CreatedBy == null)
            {
                throw new InvalidDataException("CreatedBy is a required property for ApiKeyPresentation and cannot be null");
            }
            else
            {
                this.CreatedBy = CreatedBy;
            }
            // to ensure "Key" is required (not null)
            if (Key == null)
            {
                throw new InvalidDataException("Key is a required property for ApiKeyPresentation and cannot be null");
            }
            else
            {
                this.Key = Key;
            }
            // to ensure "Label" is required (not null)
            if (Label == null)
            {
                throw new InvalidDataException("Label is a required property for ApiKeyPresentation and cannot be null");
            }
            else
            {
                this.Label = Label;
            }
            // to ensure "OrganizationId" is required (not null)
            if (OrganizationId == null)
            {
                throw new InvalidDataException("OrganizationId is a required property for ApiKeyPresentation and cannot be null");
            }
            else
            {
                this.OrganizationId = OrganizationId;
            }
        }
        
        /// <summary>
        /// Whether this API key is active
        /// </summary>
        /// <value>Whether this API key is active</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }

        /// <summary>
        /// The UTC unix timestamp of when this api key has been created
        /// </summary>
        /// <value>The UTC unix timestamp of when this api key has been created</value>
        [DataMember(Name="createdAt", EmitDefaultValue=false)]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// The api key identifier
        /// </summary>
        /// <value>The api key identifier</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }

        /// <summary>
        /// The label / name of the api key
        /// </summary>
        /// <value>The label / name of the api key</value>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// The organization namespace this api key belongs to
        /// </summary>
        /// <value>The organization namespace this api key belongs to</value>
        [DataMember(Name="organizationId", EmitDefaultValue=false)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiKeyPresentation {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as ApiKeyPresentation);
        }

        /// <summary>
        /// Returns true if ApiKeyPresentation instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiKeyPresentation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiKeyPresentation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.OrganizationId == input.OrganizationId ||
                    (this.OrganizationId != null &&
                    this.OrganizationId.Equals(input.OrganizationId))
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
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.OrganizationId != null)
                    hashCode = hashCode * 59 + this.OrganizationId.GetHashCode();
                return hashCode;
            }
        }
    }

}
