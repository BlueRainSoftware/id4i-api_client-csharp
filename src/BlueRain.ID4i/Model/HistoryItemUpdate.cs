/* 
 * ID4i API
 *
 * ID4i HTTP API
 *
 * OpenAPI spec version: 0.5.1
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
    /// GUID history item update (diff patch)
    /// </summary>
    [DataContract]
    public partial class HistoryItemUpdate :  IEquatable<HistoryItemUpdate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryItemUpdate" /> class.
        /// </summary>
        /// <param name="OrganizationId">New organization id displayed for this item. If given, must match the holder of GUID and the organization the history item is found under..</param>
        /// <param name="Visibility">History item visibility restrictions.</param>
        public HistoryItemUpdate(long? OrganizationId = default(long?), Visibility Visibility = default(Visibility))
        {
            this.OrganizationId = OrganizationId;
            this.Visibility = Visibility;
        }
        
        /// <summary>
        /// New organization id displayed for this item. If given, must match the holder of GUID and the organization the history item is found under.
        /// </summary>
        /// <value>New organization id displayed for this item. If given, must match the holder of GUID and the organization the history item is found under.</value>
        [DataMember(Name="organizationId", EmitDefaultValue=false)]
        public long? OrganizationId { get; set; }

        /// <summary>
        /// History item visibility restrictions
        /// </summary>
        /// <value>History item visibility restrictions</value>
        [DataMember(Name="visibility", EmitDefaultValue=false)]
        public Visibility Visibility { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistoryItemUpdate {\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  Visibility: ").Append(Visibility).Append("\n");
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
            return this.Equals(input as HistoryItemUpdate);
        }

        /// <summary>
        /// Returns true if HistoryItemUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of HistoryItemUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistoryItemUpdate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OrganizationId == input.OrganizationId ||
                    (this.OrganizationId != null &&
                    this.OrganizationId.Equals(input.OrganizationId))
                ) && 
                (
                    this.Visibility == input.Visibility ||
                    (this.Visibility != null &&
                    this.Visibility.Equals(input.Visibility))
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
                if (this.OrganizationId != null)
                    hashCode = hashCode * 59 + this.OrganizationId.GetHashCode();
                if (this.Visibility != null)
                    hashCode = hashCode * 59 + this.Visibility.GetHashCode();
                return hashCode;
            }
        }
    }

}