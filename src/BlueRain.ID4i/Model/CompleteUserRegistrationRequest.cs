/* 
 * ID4i API
 *
 * ID4i HTTP API
 *
 * OpenAPI spec version: 0.9.0
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
    /// CompleteUserRegistrationRequest
    /// </summary>
    [DataContract]
    public partial class CompleteUserRegistrationRequest :  IEquatable<CompleteUserRegistrationRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompleteUserRegistrationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CompleteUserRegistrationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CompleteUserRegistrationRequest" /> class.
        /// </summary>
        /// <param name="VerificationToken">VerificationToken (required).</param>
        /// <param name="Username">Username (required).</param>
        /// <param name="Password">Password (required).</param>
        public CompleteUserRegistrationRequest(string VerificationToken = default(string), string Username = default(string), string Password = default(string))
        {
            // to ensure "VerificationToken" is required (not null)
            if (VerificationToken == null)
            {
                throw new InvalidDataException("VerificationToken is a required property for CompleteUserRegistrationRequest and cannot be null");
            }
            else
            {
                this.VerificationToken = VerificationToken;
            }
            // to ensure "Username" is required (not null)
            if (Username == null)
            {
                throw new InvalidDataException("Username is a required property for CompleteUserRegistrationRequest and cannot be null");
            }
            else
            {
                this.Username = Username;
            }
            // to ensure "Password" is required (not null)
            if (Password == null)
            {
                throw new InvalidDataException("Password is a required property for CompleteUserRegistrationRequest and cannot be null");
            }
            else
            {
                this.Password = Password;
            }
        }
        
        /// <summary>
        /// Gets or Sets VerificationToken
        /// </summary>
        [DataMember(Name="verificationToken", EmitDefaultValue=false)]
        public string VerificationToken { get; set; }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompleteUserRegistrationRequest {\n");
            sb.Append("  VerificationToken: ").Append(VerificationToken).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
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
            return this.Equals(input as CompleteUserRegistrationRequest);
        }

        /// <summary>
        /// Returns true if CompleteUserRegistrationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CompleteUserRegistrationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompleteUserRegistrationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VerificationToken == input.VerificationToken ||
                    (this.VerificationToken != null &&
                    this.VerificationToken.Equals(input.VerificationToken))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
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
                if (this.VerificationToken != null)
                    hashCode = hashCode * 59 + this.VerificationToken.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                return hashCode;
            }
        }
    }

}
