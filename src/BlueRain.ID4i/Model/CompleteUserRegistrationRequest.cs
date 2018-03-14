/* 
 * ID4i API
 *
 * ID4i HTTP API
 *
 * OpenAPI spec version: 0.2.4
 * Contact: info@bluerain.de
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = BlueRain.ID4i.Client.SwaggerDateConverter;

namespace BlueRain.ID4i.Model
{
    /// <summary>
    /// CompleteUserRegistrationRequest
    /// </summary>
    [DataContract]
    public partial class CompleteUserRegistrationRequest :  IEquatable<CompleteUserRegistrationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompleteUserRegistrationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CompleteUserRegistrationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CompleteUserRegistrationRequest" /> class.
        /// </summary>
        /// <param name="Password">Password (required).</param>
        /// <param name="Username">Username (required).</param>
        /// <param name="VerificationToken">VerificationToken (required).</param>
        public CompleteUserRegistrationRequest(string Password = default(string), string Username = default(string), string VerificationToken = default(string))
        {
            // to ensure "Password" is required (not null)
            if (Password == null)
            {
                throw new InvalidDataException("Password is a required property for CompleteUserRegistrationRequest and cannot be null");
            }
            else
            {
                this.Password = Password;
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
            // to ensure "VerificationToken" is required (not null)
            if (VerificationToken == null)
            {
                throw new InvalidDataException("VerificationToken is a required property for CompleteUserRegistrationRequest and cannot be null");
            }
            else
            {
                this.VerificationToken = VerificationToken;
            }
        }
        
        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Gets or Sets VerificationToken
        /// </summary>
        [DataMember(Name="verificationToken", EmitDefaultValue=false)]
        public string VerificationToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompleteUserRegistrationRequest {\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  VerificationToken: ").Append(VerificationToken).Append("\n");
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
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.VerificationToken == input.VerificationToken ||
                    (this.VerificationToken != null &&
                    this.VerificationToken.Equals(input.VerificationToken))
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
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.VerificationToken != null)
                    hashCode = hashCode * 59 + this.VerificationToken.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Password (string) maxLength
            if(this.Password != null && this.Password.Length > 99)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Password, length must be less than 99.", new [] { "Password" });
            }

            // Password (string) minLength
            if(this.Password != null && this.Password.Length < 8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Password, length must be greater than 8.", new [] { "Password" });
            }

            // Username (string) pattern
            Regex regexUsername = new Regex(@"[a-zA-Z0-9_.-]{6,50}", RegexOptions.CultureInvariant);
            if (false == regexUsername.Match(this.Username).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Username, must match a pattern of " + regexUsername, new [] { "Username" });
            }

            yield break;
        }
    }

}
