/* 
 * ID4i API
 *
 * ID4i HTTP API
 *
 * OpenAPI spec version: 0.3.0
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
    /// GuidAlias
    /// </summary>
    [DataContract]
    public partial class GuidAlias :  IEquatable<GuidAlias>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GuidAlias" /> class.
        /// </summary>
        /// <param name="Alias">Alias.</param>
        public GuidAlias(string Alias = default(string))
        {
            this.Alias = Alias;
        }
        
        /// <summary>
        /// Gets or Sets Alias
        /// </summary>
        [DataMember(Name="alias", EmitDefaultValue=false)]
        public string Alias { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GuidAlias {\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
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
            return this.Equals(input as GuidAlias);
        }

        /// <summary>
        /// Returns true if GuidAlias instances are equal
        /// </summary>
        /// <param name="input">Instance of GuidAlias to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GuidAlias input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Alias == input.Alias ||
                    (this.Alias != null &&
                    this.Alias.Equals(input.Alias))
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
                if (this.Alias != null)
                    hashCode = hashCode * 59 + this.Alias.GetHashCode();
                return hashCode;
            }
        }
    }

}
