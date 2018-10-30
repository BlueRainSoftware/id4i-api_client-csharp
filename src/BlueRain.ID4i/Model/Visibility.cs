/* 
 * ID4i API
 *
 * ID4i HTTP API
 *
 * OpenAPI spec version: 0.9.3-SNAPSHOT
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
    /// Visibility
    /// </summary>
    [DataContract]
    public partial class Visibility :  IEquatable<Visibility>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Visibility" /> class.
        /// </summary>
        /// <param name="_Public">Document is publicly readable (if ID4N is owned by the same organization).</param>
        /// <param name="SharedOrganizationIds">Document is readable by these organizations (independend of ID4N ownership).</param>
        public Visibility(bool? _Public = default(bool?), List<string> SharedOrganizationIds = default(List<string>))
        {
            this._Public = _Public;
            this.SharedOrganizationIds = SharedOrganizationIds;
        }
        
        /// <summary>
        /// Document is publicly readable (if ID4N is owned by the same organization)
        /// </summary>
        /// <value>Document is publicly readable (if ID4N is owned by the same organization)</value>
        [DataMember(Name="public", EmitDefaultValue=false)]
        public bool? _Public { get; set; }

        /// <summary>
        /// Document is readable by these organizations (independend of ID4N ownership)
        /// </summary>
        /// <value>Document is readable by these organizations (independend of ID4N ownership)</value>
        [DataMember(Name="sharedOrganizationIds", EmitDefaultValue=false)]
        public List<string> SharedOrganizationIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Visibility {\n");
            sb.Append("  _Public: ").Append(_Public).Append("\n");
            sb.Append("  SharedOrganizationIds: ").Append(SharedOrganizationIds).Append("\n");
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
            return this.Equals(input as Visibility);
        }

        /// <summary>
        /// Returns true if Visibility instances are equal
        /// </summary>
        /// <param name="input">Instance of Visibility to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Visibility input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._Public == input._Public ||
                    (this._Public != null &&
                    this._Public.Equals(input._Public))
                ) && 
                (
                    this.SharedOrganizationIds == input.SharedOrganizationIds ||
                    this.SharedOrganizationIds != null &&
                    this.SharedOrganizationIds.SequenceEqual(input.SharedOrganizationIds)
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
                if (this._Public != null)
                    hashCode = hashCode * 59 + this._Public.GetHashCode();
                if (this.SharedOrganizationIds != null)
                    hashCode = hashCode * 59 + this.SharedOrganizationIds.GetHashCode();
                return hashCode;
            }
        }
    }

}
