/* 
 * ID4i API
 *
 * ID4i HTTP API
 *
 * OpenAPI spec version: 0.9.7-SNAPSHOT
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
    /// ServiceCosts
    /// </summary>
    [DataContract]
    public partial class ServiceCosts :  IEquatable<ServiceCosts>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceCosts" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ServiceCosts() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceCosts" /> class.
        /// </summary>
        /// <param name="Listing">Listing (required).</param>
        public ServiceCosts(Dictionary<string, decimal?> Listing = default(Dictionary<string, decimal?>))
        {
            // to ensure "Listing" is required (not null)
            if (Listing == null)
            {
                throw new InvalidDataException("Listing is a required property for ServiceCosts and cannot be null");
            }
            else
            {
                this.Listing = Listing;
            }
        }
        
        /// <summary>
        /// Gets or Sets Listing
        /// </summary>
        [DataMember(Name="listing", EmitDefaultValue=false)]
        public Dictionary<string, decimal?> Listing { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceCosts {\n");
            sb.Append("  Listing: ").Append(Listing).Append("\n");
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
            return this.Equals(input as ServiceCosts);
        }

        /// <summary>
        /// Returns true if ServiceCosts instances are equal
        /// </summary>
        /// <param name="input">Instance of ServiceCosts to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServiceCosts input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Listing == input.Listing ||
                    this.Listing != null &&
                    this.Listing.SequenceEqual(input.Listing)
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
                if (this.Listing != null)
                    hashCode = hashCode * 59 + this.Listing.GetHashCode();
                return hashCode;
            }
        }
    }

}
