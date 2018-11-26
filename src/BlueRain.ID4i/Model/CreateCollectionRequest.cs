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
    /// CreateCollectionRequest
    /// </summary>
    [DataContract]
    public partial class CreateCollectionRequest :  IEquatable<CreateCollectionRequest>
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum ROUTINGCOLLECTION for value: ROUTING_COLLECTION
            /// </summary>
            [EnumMember(Value = "ROUTING_COLLECTION")]
            ROUTINGCOLLECTION = 1,
            
            /// <summary>
            /// Enum LOGISTICCOLLECTION for value: LOGISTIC_COLLECTION
            /// </summary>
            [EnumMember(Value = "LOGISTIC_COLLECTION")]
            LOGISTICCOLLECTION = 2,
            
            /// <summary>
            /// Enum LABELLEDCOLLECTION for value: LABELLED_COLLECTION
            /// </summary>
            [EnumMember(Value = "LABELLED_COLLECTION")]
            LABELLEDCOLLECTION = 3
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollectionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateCollectionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollectionRequest" /> class.
        /// </summary>
        /// <param name="Label">Label.</param>
        /// <param name="OrganizationId">OrganizationId (required).</param>
        /// <param name="Length">Length (required).</param>
        /// <param name="Type">Type (required).</param>
        public CreateCollectionRequest(string Label = default(string), string OrganizationId = default(string), int? Length = default(int?), TypeEnum Type = default(TypeEnum))
        {
            // to ensure "OrganizationId" is required (not null)
            if (OrganizationId == null)
            {
                throw new InvalidDataException("OrganizationId is a required property for CreateCollectionRequest and cannot be null");
            }
            else
            {
                this.OrganizationId = OrganizationId;
            }
            // to ensure "Length" is required (not null)
            if (Length == null)
            {
                throw new InvalidDataException("Length is a required property for CreateCollectionRequest and cannot be null");
            }
            else
            {
                this.Length = Length;
            }
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for CreateCollectionRequest and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            this.Label = Label;
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
        public string OrganizationId { get; set; }

        /// <summary>
        /// Gets or Sets Length
        /// </summary>
        [DataMember(Name="length", EmitDefaultValue=false)]
        public int? Length { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCollectionRequest {\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  Length: ").Append(Length).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as CreateCollectionRequest);
        }

        /// <summary>
        /// Returns true if CreateCollectionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateCollectionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateCollectionRequest input)
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
                    this.Length == input.Length ||
                    (this.Length != null &&
                    this.Length.Equals(input.Length))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Length != null)
                    hashCode = hashCode * 59 + this.Length.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }

}
