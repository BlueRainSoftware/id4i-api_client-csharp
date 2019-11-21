/* 
 * ID4i API
 *
 * ID4i HTTP API
 *
 * OpenAPI spec version: 0.9.8-SNAPSHOT
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
    /// OrganizationUserInvitation
    /// </summary>
    [DataContract]
    public partial class OrganizationUserInvitation :  IEquatable<OrganizationUserInvitation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationUserInvitation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrganizationUserInvitation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationUserInvitation" /> class.
        /// </summary>
        /// <param name="Email">Email.</param>
        /// <param name="UserName">UserName.</param>
        /// <param name="Roles">Roles (required).</param>
        public OrganizationUserInvitation(string Email = default(string), string UserName = default(string), List<string> Roles = default(List<string>))
        {
            // to ensure "Roles" is required (not null)
            if (Roles == null)
            {
                throw new InvalidDataException("Roles is a required property for OrganizationUserInvitation and cannot be null");
            }
            else
            {
                this.Roles = Roles;
            }
            this.Email = Email;
            this.UserName = UserName;
        }
        
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets UserName
        /// </summary>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or Sets Roles
        /// </summary>
        [DataMember(Name="roles", EmitDefaultValue=false)]
        public List<string> Roles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrganizationUserInvitation {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
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
            return this.Equals(input as OrganizationUserInvitation);
        }

        /// <summary>
        /// Returns true if OrganizationUserInvitation instances are equal
        /// </summary>
        /// <param name="input">Instance of OrganizationUserInvitation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrganizationUserInvitation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.Roles == input.Roles ||
                    this.Roles != null &&
                    this.Roles.SequenceEqual(input.Roles)
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
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.Roles != null)
                    hashCode = hashCode * 59 + this.Roles.GetHashCode();
                return hashCode;
            }
        }
    }

}
