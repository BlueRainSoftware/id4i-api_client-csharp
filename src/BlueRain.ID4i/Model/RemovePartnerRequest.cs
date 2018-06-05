/* 
 * ID4i API
 *
 * ID4i HTTP API
 *
 * OpenAPI spec version: 0.7.4-SNAPSHOT
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
    /// RemovePartnerRequest
    /// </summary>
    [DataContract]
    public partial class RemovePartnerRequest :  IEquatable<RemovePartnerRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemovePartnerRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RemovePartnerRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RemovePartnerRequest" /> class.
        /// </summary>
        /// <param name="OrganizationId">The namespace of the partner organization to remove (required).</param>
        public RemovePartnerRequest(string OrganizationId = default(string))
        {
            // to ensure "OrganizationId" is required (not null)
            if (OrganizationId == null)
            {
                throw new InvalidDataException("OrganizationId is a required property for RemovePartnerRequest and cannot be null");
            }
            else
            {
                this.OrganizationId = OrganizationId;
            }
        }
        
        /// <summary>
        /// The namespace of the partner organization to remove
        /// </summary>
        /// <value>The namespace of the partner organization to remove</value>
        [DataMember(Name="organizationId", EmitDefaultValue=false)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RemovePartnerRequest {\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
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
            return this.Equals(input as RemovePartnerRequest);
        }

        /// <summary>
        /// Returns true if RemovePartnerRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RemovePartnerRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RemovePartnerRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OrganizationId == input.OrganizationId ||
                    (this.OrganizationId != null &&
                    this.OrganizationId.Equals(input.OrganizationId))
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
                return hashCode;
            }
        }
    }

}