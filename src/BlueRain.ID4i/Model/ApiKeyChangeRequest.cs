/* 
 * ID4i API
 *
 * ID4i HTTP API
 *
 * OpenAPI spec version: 0.7.0-SNAPSHOT
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
    /// ApiKeyChangeRequest
    /// </summary>
    [DataContract]
    public partial class ApiKeyChangeRequest :  IEquatable<ApiKeyChangeRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyChangeRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApiKeyChangeRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyChangeRequest" /> class.
        /// </summary>
        /// <param name="Active">Active.</param>
        /// <param name="NewLabel">NewLabel (required).</param>
        public ApiKeyChangeRequest(bool? Active = default(bool?), string NewLabel = default(string))
        {
            // to ensure "NewLabel" is required (not null)
            if (NewLabel == null)
            {
                throw new InvalidDataException("NewLabel is a required property for ApiKeyChangeRequest and cannot be null");
            }
            else
            {
                this.NewLabel = NewLabel;
            }
            this.Active = Active;
        }
        
        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }

        /// <summary>
        /// Gets or Sets NewLabel
        /// </summary>
        [DataMember(Name="newLabel", EmitDefaultValue=false)]
        public string NewLabel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiKeyChangeRequest {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  NewLabel: ").Append(NewLabel).Append("\n");
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
            return this.Equals(input as ApiKeyChangeRequest);
        }

        /// <summary>
        /// Returns true if ApiKeyChangeRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiKeyChangeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiKeyChangeRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
                ) && 
                (
                    this.NewLabel == input.NewLabel ||
                    (this.NewLabel != null &&
                    this.NewLabel.Equals(input.NewLabel))
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
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.NewLabel != null)
                    hashCode = hashCode * 59 + this.NewLabel.GetHashCode();
                return hashCode;
            }
        }
    }

}
