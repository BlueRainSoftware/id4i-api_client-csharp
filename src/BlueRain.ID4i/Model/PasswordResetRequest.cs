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
    /// PasswordResetRequest
    /// </summary>
    [DataContract]
    public partial class PasswordResetRequest :  IEquatable<PasswordResetRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PasswordResetRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PasswordResetRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PasswordResetRequest" /> class.
        /// </summary>
        /// <param name="Username">Username (required).</param>
        public PasswordResetRequest(string Username = default(string))
        {
            // to ensure "Username" is required (not null)
            if (Username == null)
            {
                throw new InvalidDataException("Username is a required property for PasswordResetRequest and cannot be null");
            }
            else
            {
                this.Username = Username;
            }
        }
        
        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PasswordResetRequest {\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
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
            return this.Equals(input as PasswordResetRequest);
        }

        /// <summary>
        /// Returns true if PasswordResetRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PasswordResetRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PasswordResetRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
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
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                return hashCode;
            }
        }
    }

}
