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
    /// RegistrationVerificationTokenPresentation
    /// </summary>
    [DataContract]
    public partial class RegistrationVerificationTokenPresentation :  IEquatable<RegistrationVerificationTokenPresentation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegistrationVerificationTokenPresentation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RegistrationVerificationTokenPresentation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RegistrationVerificationTokenPresentation" /> class.
        /// </summary>
        /// <param name="Token">Token (required).</param>
        public RegistrationVerificationTokenPresentation(string Token = default(string))
        {
            // to ensure "Token" is required (not null)
            if (Token == null)
            {
                throw new InvalidDataException("Token is a required property for RegistrationVerificationTokenPresentation and cannot be null");
            }
            else
            {
                this.Token = Token;
            }
        }
        
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
            sb.Append("class RegistrationVerificationTokenPresentation {\n");
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
            return this.Equals(input as RegistrationVerificationTokenPresentation);
        }

        /// <summary>
        /// Returns true if RegistrationVerificationTokenPresentation instances are equal
        /// </summary>
        /// <param name="input">Instance of RegistrationVerificationTokenPresentation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegistrationVerificationTokenPresentation input)
        {
            if (input == null)
                return false;

            return 
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
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
                return hashCode;
            }
        }
    }

}
