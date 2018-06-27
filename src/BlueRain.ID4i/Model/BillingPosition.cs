/* 
 * ID4i API
 *
 * ID4i HTTP API
 *
 * OpenAPI spec version: 0.8.1
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
    /// BillingPosition
    /// </summary>
    [DataContract]
    public partial class BillingPosition :  IEquatable<BillingPosition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingPosition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BillingPosition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingPosition" /> class.
        /// </summary>
        /// <param name="Count">Count (required).</param>
        /// <param name="Description">Description (required).</param>
        /// <param name="Service">Service (required).</param>
        /// <param name="Sum">Sum (required).</param>
        public BillingPosition(long? Count = default(long?), string Description = default(string), string Service = default(string), float? Sum = default(float?))
        {
            // to ensure "Count" is required (not null)
            if (Count == null)
            {
                throw new InvalidDataException("Count is a required property for BillingPosition and cannot be null");
            }
            else
            {
                this.Count = Count;
            }
            // to ensure "Description" is required (not null)
            if (Description == null)
            {
                throw new InvalidDataException("Description is a required property for BillingPosition and cannot be null");
            }
            else
            {
                this.Description = Description;
            }
            // to ensure "Service" is required (not null)
            if (Service == null)
            {
                throw new InvalidDataException("Service is a required property for BillingPosition and cannot be null");
            }
            else
            {
                this.Service = Service;
            }
            // to ensure "Sum" is required (not null)
            if (Sum == null)
            {
                throw new InvalidDataException("Sum is a required property for BillingPosition and cannot be null");
            }
            else
            {
                this.Sum = Sum;
            }
        }
        
        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public long? Count { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Service
        /// </summary>
        [DataMember(Name="service", EmitDefaultValue=false)]
        public string Service { get; set; }

        /// <summary>
        /// Gets or Sets Sum
        /// </summary>
        [DataMember(Name="sum", EmitDefaultValue=false)]
        public float? Sum { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillingPosition {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Service: ").Append(Service).Append("\n");
            sb.Append("  Sum: ").Append(Sum).Append("\n");
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
            return this.Equals(input as BillingPosition);
        }

        /// <summary>
        /// Returns true if BillingPosition instances are equal
        /// </summary>
        /// <param name="input">Instance of BillingPosition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingPosition input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Service == input.Service ||
                    (this.Service != null &&
                    this.Service.Equals(input.Service))
                ) && 
                (
                    this.Sum == input.Sum ||
                    (this.Sum != null &&
                    this.Sum.Equals(input.Sum))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Service != null)
                    hashCode = hashCode * 59 + this.Service.GetHashCode();
                if (this.Sum != null)
                    hashCode = hashCode * 59 + this.Sum.GetHashCode();
                return hashCode;
            }
        }
    }

}
