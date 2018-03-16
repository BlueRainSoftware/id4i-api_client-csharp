/* 
 * ID4i API
 *
 * ID4i HTTP API
 *
 * OpenAPI spec version: 0.2.5-SNAPSHOT
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
    /// ApiKeyCreationRequest
    /// </summary>
    [DataContract]
    public partial class ApiKeyCreationRequest :  IEquatable<ApiKeyCreationRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyCreationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApiKeyCreationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyCreationRequest" /> class.
        /// </summary>
        /// <param name="Label">Label (required).</param>
        /// <param name="OrganizationId">OrganizationId (required).</param>
        /// <param name="Secret">Secret (required).</param>
        public ApiKeyCreationRequest(string Label = default(string), long? OrganizationId = default(long?), string Secret = default(string))
        {
            // to ensure "Label" is required (not null)
            if (Label == null)
            {
                throw new InvalidDataException("Label is a required property for ApiKeyCreationRequest and cannot be null");
            }
            else
            {
                this.Label = Label;
            }
            // to ensure "OrganizationId" is required (not null)
            if (OrganizationId == null)
            {
                throw new InvalidDataException("OrganizationId is a required property for ApiKeyCreationRequest and cannot be null");
            }
            else
            {
                this.OrganizationId = OrganizationId;
            }
            // to ensure "Secret" is required (not null)
            if (Secret == null)
            {
                throw new InvalidDataException("Secret is a required property for ApiKeyCreationRequest and cannot be null");
            }
            else
            {
                this.Secret = Secret;
            }
        }
        
        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationId
        /// </summary>
        [DataMember(Name="organizationId", EmitDefaultValue=false)]
        public long? OrganizationId { get; set; }

        /// <summary>
        /// Gets or Sets Secret
        /// </summary>
        [DataMember(Name="secret", EmitDefaultValue=false)]
        public string Secret { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiKeyCreationRequest {\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  Secret: ").Append(Secret).Append("\n");
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
            return this.Equals(input as ApiKeyCreationRequest);
        }

        /// <summary>
        /// Returns true if ApiKeyCreationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiKeyCreationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiKeyCreationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.OrganizationId == input.OrganizationId ||
                    (this.OrganizationId != null &&
                    this.OrganizationId.Equals(input.OrganizationId))
                ) && 
                (
                    this.Secret == input.Secret ||
                    (this.Secret != null &&
                    this.Secret.Equals(input.Secret))
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
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.OrganizationId != null)
                    hashCode = hashCode * 59 + this.OrganizationId.GetHashCode();
                if (this.Secret != null)
                    hashCode = hashCode * 59 + this.Secret.GetHashCode();
                return hashCode;
            }
        }
    }

}