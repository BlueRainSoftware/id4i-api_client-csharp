/* 
 * ID4i API
 *
 * ID4i HTTP API
 *
 * OpenAPI spec version: 0.5.1
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
    /// CreateRoutingCollectionRequest
    /// </summary>
    [DataContract]
    public partial class CreateRoutingCollectionRequest :  IEquatable<CreateRoutingCollectionRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRoutingCollectionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateRoutingCollectionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRoutingCollectionRequest" /> class.
        /// </summary>
        /// <param name="Label">Label (required).</param>
        /// <param name="Length">Length (required).</param>
        /// <param name="OrganizationId">OrganizationId (required).</param>
        public CreateRoutingCollectionRequest(string Label = default(string), int? Length = default(int?), long? OrganizationId = default(long?))
        {
            // to ensure "Label" is required (not null)
            if (Label == null)
            {
                throw new InvalidDataException("Label is a required property for CreateRoutingCollectionRequest and cannot be null");
            }
            else
            {
                this.Label = Label;
            }
            // to ensure "Length" is required (not null)
            if (Length == null)
            {
                throw new InvalidDataException("Length is a required property for CreateRoutingCollectionRequest and cannot be null");
            }
            else
            {
                this.Length = Length;
            }
            // to ensure "OrganizationId" is required (not null)
            if (OrganizationId == null)
            {
                throw new InvalidDataException("OrganizationId is a required property for CreateRoutingCollectionRequest and cannot be null");
            }
            else
            {
                this.OrganizationId = OrganizationId;
            }
        }
        
        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// Gets or Sets Length
        /// </summary>
        [DataMember(Name="length", EmitDefaultValue=false)]
        public int? Length { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationId
        /// </summary>
        [DataMember(Name="organizationId", EmitDefaultValue=false)]
        public long? OrganizationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateRoutingCollectionRequest {\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Length: ").Append(Length).Append("\n");
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
            return this.Equals(input as CreateRoutingCollectionRequest);
        }

        /// <summary>
        /// Returns true if CreateRoutingCollectionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateRoutingCollectionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateRoutingCollectionRequest input)
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
                    this.Length == input.Length ||
                    (this.Length != null &&
                    this.Length.Equals(input.Length))
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
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.Length != null)
                    hashCode = hashCode * 59 + this.Length.GetHashCode();
                if (this.OrganizationId != null)
                    hashCode = hashCode * 59 + this.OrganizationId.GetHashCode();
                return hashCode;
            }
        }
    }

}
