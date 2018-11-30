/* 
 * ID4i API
 *
 * ID4i HTTP API
 *
 * OpenAPI spec version: 0.9.5
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
    /// PaginatedResponseOfGuidCollection
    /// </summary>
    [DataContract]
    public partial class PaginatedResponseOfGuidCollection :  IEquatable<PaginatedResponseOfGuidCollection>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedResponseOfGuidCollection" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaginatedResponseOfGuidCollection() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedResponseOfGuidCollection" /> class.
        /// </summary>
        /// <param name="Elements">Elements (required).</param>
        /// <param name="Limit">The number of returned elements (required).</param>
        /// <param name="Offset">Starting with the n-th element (required).</param>
        /// <param name="Total">The total number of elements.</param>
        public PaginatedResponseOfGuidCollection(List<GuidCollection> Elements = default(List<GuidCollection>), int? Limit = default(int?), int? Offset = default(int?), int? Total = default(int?))
        {
            // to ensure "Elements" is required (not null)
            if (Elements == null)
            {
                throw new InvalidDataException("Elements is a required property for PaginatedResponseOfGuidCollection and cannot be null");
            }
            else
            {
                this.Elements = Elements;
            }
            // to ensure "Limit" is required (not null)
            if (Limit == null)
            {
                throw new InvalidDataException("Limit is a required property for PaginatedResponseOfGuidCollection and cannot be null");
            }
            else
            {
                this.Limit = Limit;
            }
            // to ensure "Offset" is required (not null)
            if (Offset == null)
            {
                throw new InvalidDataException("Offset is a required property for PaginatedResponseOfGuidCollection and cannot be null");
            }
            else
            {
                this.Offset = Offset;
            }
            this.Total = Total;
        }
        
        /// <summary>
        /// Gets or Sets Elements
        /// </summary>
        [DataMember(Name="elements", EmitDefaultValue=false)]
        public List<GuidCollection> Elements { get; set; }

        /// <summary>
        /// The number of returned elements
        /// </summary>
        /// <value>The number of returned elements</value>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// Starting with the n-th element
        /// </summary>
        /// <value>Starting with the n-th element</value>
        [DataMember(Name="offset", EmitDefaultValue=false)]
        public int? Offset { get; set; }

        /// <summary>
        /// The total number of elements
        /// </summary>
        /// <value>The total number of elements</value>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public int? Total { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaginatedResponseOfGuidCollection {\n");
            sb.Append("  Elements: ").Append(Elements).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
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
            return this.Equals(input as PaginatedResponseOfGuidCollection);
        }

        /// <summary>
        /// Returns true if PaginatedResponseOfGuidCollection instances are equal
        /// </summary>
        /// <param name="input">Instance of PaginatedResponseOfGuidCollection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaginatedResponseOfGuidCollection input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Elements == input.Elements ||
                    this.Elements != null &&
                    this.Elements.SequenceEqual(input.Elements)
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
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
                if (this.Elements != null)
                    hashCode = hashCode * 59 + this.Elements.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }

}
