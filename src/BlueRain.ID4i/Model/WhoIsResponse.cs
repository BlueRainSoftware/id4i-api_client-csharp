/* 
 * ID4i API
 *
 * ID4i HTTP API
 *
 * OpenAPI spec version: 0.9.5-SNAPSHOT
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
    /// WhoIsResponse
    /// </summary>
    [DataContract]
    public partial class WhoIsResponse :  IEquatable<WhoIsResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WhoIsResponse" /> class.
        /// </summary>
        /// <param name="Aliases">Aliases.</param>
        /// <param name="Organization">Organization.</param>
        /// <param name="OrganizationAddress">OrganizationAddress.</param>
        public WhoIsResponse(Dictionary<string, string> Aliases = default(Dictionary<string, string>), Organization Organization = default(Organization), OrganizationAddress OrganizationAddress = default(OrganizationAddress))
        {
            this.Aliases = Aliases;
            this.Organization = Organization;
            this.OrganizationAddress = OrganizationAddress;
        }
        
        /// <summary>
        /// Gets or Sets Aliases
        /// </summary>
        [DataMember(Name="aliases", EmitDefaultValue=false)]
        public Dictionary<string, string> Aliases { get; set; }

        /// <summary>
        /// Gets or Sets Organization
        /// </summary>
        [DataMember(Name="organization", EmitDefaultValue=false)]
        public Organization Organization { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationAddress
        /// </summary>
        [DataMember(Name="organizationAddress", EmitDefaultValue=false)]
        public OrganizationAddress OrganizationAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WhoIsResponse {\n");
            sb.Append("  Aliases: ").Append(Aliases).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
            sb.Append("  OrganizationAddress: ").Append(OrganizationAddress).Append("\n");
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
            return this.Equals(input as WhoIsResponse);
        }

        /// <summary>
        /// Returns true if WhoIsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of WhoIsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WhoIsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Aliases == input.Aliases ||
                    this.Aliases != null &&
                    this.Aliases.SequenceEqual(input.Aliases)
                ) && 
                (
                    this.Organization == input.Organization ||
                    (this.Organization != null &&
                    this.Organization.Equals(input.Organization))
                ) && 
                (
                    this.OrganizationAddress == input.OrganizationAddress ||
                    (this.OrganizationAddress != null &&
                    this.OrganizationAddress.Equals(input.OrganizationAddress))
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
                if (this.Aliases != null)
                    hashCode = hashCode * 59 + this.Aliases.GetHashCode();
                if (this.Organization != null)
                    hashCode = hashCode * 59 + this.Organization.GetHashCode();
                if (this.OrganizationAddress != null)
                    hashCode = hashCode * 59 + this.OrganizationAddress.GetHashCode();
                return hashCode;
            }
        }
    }

}
