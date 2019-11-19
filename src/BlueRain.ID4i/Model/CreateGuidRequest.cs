/* 
 * ID4i API
 *
 * ID4i HTTP API
 *
 * OpenAPI spec version: 0.9.7
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
    /// GUID creation information
    /// </summary>
    [DataContract]
    public partial class CreateGuidRequest :  IEquatable<CreateGuidRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGuidRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateGuidRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGuidRequest" /> class.
        /// </summary>
        /// <param name="Count">The total number of GUIDs to create (required).</param>
        /// <param name="Length">The charactersequence length of the GUID (required).</param>
        /// <param name="OrganizationId">The namespace of the organization where the generated GUIDs should be assigned. (required).</param>
        public CreateGuidRequest(int? Count = default(int?), int? Length = default(int?), string OrganizationId = default(string))
        {
            // to ensure "Count" is required (not null)
            if (Count == null)
            {
                throw new InvalidDataException("Count is a required property for CreateGuidRequest and cannot be null");
            }
            else
            {
                this.Count = Count;
            }
            // to ensure "Length" is required (not null)
            if (Length == null)
            {
                throw new InvalidDataException("Length is a required property for CreateGuidRequest and cannot be null");
            }
            else
            {
                this.Length = Length;
            }
            // to ensure "OrganizationId" is required (not null)
            if (OrganizationId == null)
            {
                throw new InvalidDataException("OrganizationId is a required property for CreateGuidRequest and cannot be null");
            }
            else
            {
                this.OrganizationId = OrganizationId;
            }
        }
        
        /// <summary>
        /// The total number of GUIDs to create
        /// </summary>
        /// <value>The total number of GUIDs to create</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }

        /// <summary>
        /// The charactersequence length of the GUID
        /// </summary>
        /// <value>The charactersequence length of the GUID</value>
        [DataMember(Name="length", EmitDefaultValue=false)]
        public int? Length { get; set; }

        /// <summary>
        /// The namespace of the organization where the generated GUIDs should be assigned.
        /// </summary>
        /// <value>The namespace of the organization where the generated GUIDs should be assigned.</value>
        [DataMember(Name="organizationId", EmitDefaultValue=false)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateGuidRequest {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
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
            return this.Equals(input as CreateGuidRequest);
        }

        /// <summary>
        /// Returns true if CreateGuidRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateGuidRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateGuidRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
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
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.Length != null)
                    hashCode = hashCode * 59 + this.Length.GetHashCode();
                if (this.OrganizationId != null)
                    hashCode = hashCode * 59 + this.OrganizationId.GetHashCode();
                return hashCode;
            }
        }
    }

}
