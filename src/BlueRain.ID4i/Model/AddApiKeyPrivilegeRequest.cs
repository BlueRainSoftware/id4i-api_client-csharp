/* 
 * ID4i API
 *
 * ID4i HTTP API
 *
 * OpenAPI spec version: 0.9.6
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
    /// AddApiKeyPrivilegeRequest
    /// </summary>
    [DataContract]
    public partial class AddApiKeyPrivilegeRequest :  IEquatable<AddApiKeyPrivilegeRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddApiKeyPrivilegeRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddApiKeyPrivilegeRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddApiKeyPrivilegeRequest" /> class.
        /// </summary>
        /// <param name="Privilege">Privilege (required).</param>
        public AddApiKeyPrivilegeRequest(string Privilege = default(string))
        {
            // to ensure "Privilege" is required (not null)
            if (Privilege == null)
            {
                throw new InvalidDataException("Privilege is a required property for AddApiKeyPrivilegeRequest and cannot be null");
            }
            else
            {
                this.Privilege = Privilege;
            }
        }
        
        /// <summary>
        /// Gets or Sets Privilege
        /// </summary>
        [DataMember(Name="privilege", EmitDefaultValue=false)]
        public string Privilege { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddApiKeyPrivilegeRequest {\n");
            sb.Append("  Privilege: ").Append(Privilege).Append("\n");
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
            return this.Equals(input as AddApiKeyPrivilegeRequest);
        }

        /// <summary>
        /// Returns true if AddApiKeyPrivilegeRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AddApiKeyPrivilegeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddApiKeyPrivilegeRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Privilege == input.Privilege ||
                    (this.Privilege != null &&
                    this.Privilege.Equals(input.Privilege))
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
                if (this.Privilege != null)
                    hashCode = hashCode * 59 + this.Privilege.GetHashCode();
                return hashCode;
            }
        }
    }

}
