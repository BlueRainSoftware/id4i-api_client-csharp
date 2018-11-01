/* 
 * ID4i API
 *
 * ID4i HTTP API
 *
 * OpenAPI spec version: 0.9.3
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
    /// VisibilityUpdate
    /// </summary>
    [DataContract]
    public partial class VisibilityUpdate :  IEquatable<VisibilityUpdate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VisibilityUpdate" /> class.
        /// </summary>
        /// <param name="_Public">Document is publicly readable (if ID4N is owned by the same organization).</param>
        /// <param name="SharedWithOrganizationIds">Document is readable by these organizations (independend of ID4N ownership).</param>
        public VisibilityUpdate(bool? _Public = default(bool?), List<string> SharedWithOrganizationIds = default(List<string>))
        {
            this._Public = _Public;
            this.SharedWithOrganizationIds = SharedWithOrganizationIds;
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
        [DataMember(Name="sharedWithOrganizationIds", EmitDefaultValue=false)]
        public List<string> SharedWithOrganizationIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VisibilityUpdate {\n");
            sb.Append("  _Public: ").Append(_Public).Append("\n");
            sb.Append("  SharedWithOrganizationIds: ").Append(SharedWithOrganizationIds).Append("\n");
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
            return this.Equals(input as VisibilityUpdate);
        }

        /// <summary>
        /// Returns true if VisibilityUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of VisibilityUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VisibilityUpdate input)
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
                    this.SharedWithOrganizationIds == input.SharedWithOrganizationIds ||
                    this.SharedWithOrganizationIds != null &&
                    this.SharedWithOrganizationIds.SequenceEqual(input.SharedWithOrganizationIds)
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
                if (this.SharedWithOrganizationIds != null)
                    hashCode = hashCode * 59 + this.SharedWithOrganizationIds.GetHashCode();
                return hashCode;
            }
        }
    }

}
