/* 
 * ID4i API
 *
 * ID4i HTTP API
 *
 * OpenAPI spec version: 0.2.4
 * Contact: info@bluerain.de
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = BlueRain.ID4i.Client.SwaggerDateConverter;

namespace BlueRain.ID4i.Model
{
    /// <summary>
    /// Id4n
    /// </summary>
    [DataContract]
    public partial class Id4n :  IEquatable<Id4n>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Id4n" /> class.
        /// </summary>
        /// <param name="_Id4n">The ID.</param>
        public Id4n(string _Id4n = default(string))
        {
            this._Id4n = _Id4n;
        }
        
        /// <summary>
        /// The ID
        /// </summary>
        /// <value>The ID</value>
        [DataMember(Name="id4n", EmitDefaultValue=false)]
        public string _Id4n { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Id4n {\n");
            sb.Append("  _Id4n: ").Append(_Id4n).Append("\n");
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
            return this.Equals(input as Id4n);
        }

        /// <summary>
        /// Returns true if Id4n instances are equal
        /// </summary>
        /// <param name="input">Instance of Id4n to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Id4n input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._Id4n == input._Id4n ||
                    (this._Id4n != null &&
                    this._Id4n.Equals(input._Id4n))
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
                if (this._Id4n != null)
                    hashCode = hashCode * 59 + this._Id4n.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
