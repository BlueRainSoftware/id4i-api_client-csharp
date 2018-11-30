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
    /// A list of id4ns
    /// </summary>
    [DataContract]
    public partial class ListOfId4ns :  IEquatable<ListOfId4ns>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListOfId4ns" /> class.
        /// </summary>
        /// <param name="Id4ns">A list of id4ns..</param>
        public ListOfId4ns(List<string> Id4ns = default(List<string>))
        {
            this.Id4ns = Id4ns;
        }
        
        /// <summary>
        /// A list of id4ns.
        /// </summary>
        /// <value>A list of id4ns.</value>
        [DataMember(Name="id4ns", EmitDefaultValue=false)]
        public List<string> Id4ns { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListOfId4ns {\n");
            sb.Append("  Id4ns: ").Append(Id4ns).Append("\n");
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
            return this.Equals(input as ListOfId4ns);
        }

        /// <summary>
        /// Returns true if ListOfId4ns instances are equal
        /// </summary>
        /// <param name="input">Instance of ListOfId4ns to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListOfId4ns input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id4ns == input.Id4ns ||
                    this.Id4ns != null &&
                    this.Id4ns.SequenceEqual(input.Id4ns)
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
                if (this.Id4ns != null)
                    hashCode = hashCode * 59 + this.Id4ns.GetHashCode();
                return hashCode;
            }
        }
    }

}
