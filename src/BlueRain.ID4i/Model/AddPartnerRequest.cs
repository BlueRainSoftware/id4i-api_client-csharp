/* 
 * ID4i API
 *
 * ID4i HTTP API
 *
 * OpenAPI spec version: 0.8.6-SNAPSHOT
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
    /// AddPartnerRequest
    /// </summary>
    [DataContract]
    public partial class AddPartnerRequest :  IEquatable<AddPartnerRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddPartnerRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddPartnerRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddPartnerRequest" /> class.
        /// </summary>
        /// <param name="OrganizationId">The namespace of the partner organization to add (required).</param>
        public AddPartnerRequest(string OrganizationId = default(string))
        {
            // to ensure "OrganizationId" is required (not null)
            if (OrganizationId == null)
            {
                throw new InvalidDataException("OrganizationId is a required property for AddPartnerRequest and cannot be null");
            }
            else
            {
                this.OrganizationId = OrganizationId;
            }
        }
        
        /// <summary>
        /// The namespace of the partner organization to add
        /// </summary>
        /// <value>The namespace of the partner organization to add</value>
        [DataMember(Name="organizationId", EmitDefaultValue=false)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddPartnerRequest {\n");
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
            return this.Equals(input as AddPartnerRequest);
        }

        /// <summary>
        /// Returns true if AddPartnerRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AddPartnerRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddPartnerRequest input)
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
