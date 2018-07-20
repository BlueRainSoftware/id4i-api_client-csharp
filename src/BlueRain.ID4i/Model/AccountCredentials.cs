/* 
 * ID4i API
 *
 * ID4i HTTP API
 *
 * OpenAPI spec version: 0.8.5-SNAPSHOT
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
    /// AccountCredentials
    /// </summary>
    [DataContract]
    public partial class AccountCredentials :  IEquatable<AccountCredentials>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountCredentials" /> class.
        /// </summary>
        /// <param name="Login">Login.</param>
        /// <param name="Password">Password.</param>
        public AccountCredentials(string Login = default(string), string Password = default(string))
        {
            this.Login = Login;
            this.Password = Password;
        }
        
        /// <summary>
        /// Gets or Sets Login
        /// </summary>
        [DataMember(Name="login", EmitDefaultValue=false)]
        public string Login { get; set; }

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
            sb.Append("class AccountCredentials {\n");
            sb.Append("  Login: ").Append(Login).Append("\n");
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
            return this.Equals(input as AccountCredentials);
        }

        /// <summary>
        /// Returns true if AccountCredentials instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountCredentials to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountCredentials input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Login == input.Login ||
                    (this.Login != null &&
                    this.Login.Equals(input.Login))
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
                if (this.Login != null)
                    hashCode = hashCode * 59 + this.Login.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                return hashCode;
            }
        }
    }

}
