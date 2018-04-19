/* 
 * ID4i API
 *
 * ID4i HTTP API
 *
 * OpenAPI spec version: 0.5.0
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
    /// PasswordResetVerificationRequest
    /// </summary>
    [DataContract]
    public partial class PasswordResetVerificationRequest :  IEquatable<PasswordResetVerificationRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PasswordResetVerificationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PasswordResetVerificationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PasswordResetVerificationRequest" /> class.
        /// </summary>
        /// <param name="Password">Password (required).</param>
        /// <param name="Token">Token (required).</param>
        public PasswordResetVerificationRequest(string Password = default(string), string Token = default(string))
        {
            // to ensure "Password" is required (not null)
            if (Password == null)
            {
                throw new InvalidDataException("Password is a required property for PasswordResetVerificationRequest and cannot be null");
            }
            else
            {
                this.Password = Password;
            }
            // to ensure "Token" is required (not null)
            if (Token == null)
            {
                throw new InvalidDataException("Token is a required property for PasswordResetVerificationRequest and cannot be null");
            }
            else
            {
                this.Token = Token;
            }
        }
        
        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string Token { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PasswordResetVerificationRequest {\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
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
            return this.Equals(input as PasswordResetVerificationRequest);
        }

        /// <summary>
        /// Returns true if PasswordResetVerificationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PasswordResetVerificationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PasswordResetVerificationRequest input)
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
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
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
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
                return hashCode;
            }
        }
    }

}
