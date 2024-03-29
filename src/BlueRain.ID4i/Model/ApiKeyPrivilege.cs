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
    /// ApiKeyPrivilege
    /// </summary>
    [DataContract]
    public partial class ApiKeyPrivilege :  IEquatable<ApiKeyPrivilege>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyPrivilege" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApiKeyPrivilege() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyPrivilege" /> class.
        /// </summary>
        /// <param name="Id4nAssociated">Id4nAssociated (required).</param>
        /// <param name="Privilege">Privilege (required).</param>
        public ApiKeyPrivilege(bool? Id4nAssociated = default(bool?), string Privilege = default(string))
        {
            // to ensure "Id4nAssociated" is required (not null)
            if (Id4nAssociated == null)
            {
                throw new InvalidDataException("Id4nAssociated is a required property for ApiKeyPrivilege and cannot be null");
            }
            else
            {
                this.Id4nAssociated = Id4nAssociated;
            }
            // to ensure "Privilege" is required (not null)
            if (Privilege == null)
            {
                throw new InvalidDataException("Privilege is a required property for ApiKeyPrivilege and cannot be null");
            }
            else
            {
                this.Privilege = Privilege;
            }
        }
        
        /// <summary>
        /// Gets or Sets Id4nAssociated
        /// </summary>
        [DataMember(Name="id4nAssociated", EmitDefaultValue=false)]
        public bool? Id4nAssociated { get; set; }

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
            sb.Append("class ApiKeyPrivilege {\n");
            sb.Append("  Id4nAssociated: ").Append(Id4nAssociated).Append("\n");
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
            return this.Equals(input as ApiKeyPrivilege);
        }

        /// <summary>
        /// Returns true if ApiKeyPrivilege instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiKeyPrivilege to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiKeyPrivilege input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id4nAssociated == input.Id4nAssociated ||
                    (this.Id4nAssociated != null &&
                    this.Id4nAssociated.Equals(input.Id4nAssociated))
                ) && 
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
                if (this.Id4nAssociated != null)
                    hashCode = hashCode * 59 + this.Id4nAssociated.GetHashCode();
                if (this.Privilege != null)
                    hashCode = hashCode * 59 + this.Privilege.GetHashCode();
                return hashCode;
            }
        }
    }

}
