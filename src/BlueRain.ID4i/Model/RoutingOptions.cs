/* 
 * ID4i API
 *
 * ID4i HTTP API
 *
 * OpenAPI spec version: 0.8.5-SNAPSHOT
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
    /// RoutingOptions
    /// </summary>
    [DataContract]
    public partial class RoutingOptions :  IEquatable<RoutingOptions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoutingOptions" /> class.
        /// </summary>
        /// <param name="DeleteOutdatedRoutes">DeleteOutdatedRoutes.</param>
        public RoutingOptions(bool? DeleteOutdatedRoutes = default(bool?))
        {
            this.DeleteOutdatedRoutes = DeleteOutdatedRoutes;
        }
        
        /// <summary>
        /// Gets or Sets DeleteOutdatedRoutes
        /// </summary>
        [DataMember(Name="deleteOutdatedRoutes", EmitDefaultValue=false)]
        public bool? DeleteOutdatedRoutes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoutingOptions {\n");
            sb.Append("  DeleteOutdatedRoutes: ").Append(DeleteOutdatedRoutes).Append("\n");
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
            return this.Equals(input as RoutingOptions);
        }

        /// <summary>
        /// Returns true if RoutingOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of RoutingOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoutingOptions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeleteOutdatedRoutes == input.DeleteOutdatedRoutes ||
                    (this.DeleteOutdatedRoutes != null &&
                    this.DeleteOutdatedRoutes.Equals(input.DeleteOutdatedRoutes))
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
                if (this.DeleteOutdatedRoutes != null)
                    hashCode = hashCode * 59 + this.DeleteOutdatedRoutes.GetHashCode();
                return hashCode;
            }
        }
    }

}
