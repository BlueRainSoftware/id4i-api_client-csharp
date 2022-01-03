/* 
 * ID4i API
 *
 * ID4i HTTP API
 *
 * OpenAPI spec version: 1.0.0
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
    /// A list of GS1/MAPP codes
    /// </summary>
    [DataContract]
    public partial class ListOfGS1s :  IEquatable<ListOfGS1s>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListOfGS1s" /> class.
        /// </summary>
        /// <param name="Codes">A list of GS1/MAPP codes..</param>
        public ListOfGS1s(List<string> Codes = default(List<string>))
        {
            this.Codes = Codes;
        }
        
        /// <summary>
        /// A list of GS1/MAPP codes.
        /// </summary>
        /// <value>A list of GS1/MAPP codes.</value>
        [DataMember(Name="codes", EmitDefaultValue=false)]
        public List<string> Codes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListOfGS1s {\n");
            sb.Append("  Codes: ").Append(Codes).Append("\n");
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
            return this.Equals(input as ListOfGS1s);
        }

        /// <summary>
        /// Returns true if ListOfGS1s instances are equal
        /// </summary>
        /// <param name="input">Instance of ListOfGS1s to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListOfGS1s input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Codes == input.Codes ||
                    this.Codes != null &&
                    this.Codes.SequenceEqual(input.Codes)
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
                if (this.Codes != null)
                    hashCode = hashCode * 59 + this.Codes.GetHashCode();
                return hashCode;
            }
        }
    }

}
