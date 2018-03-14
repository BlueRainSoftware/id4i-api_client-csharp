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
    /// RoutingFile
    /// </summary>
    [DataContract]
    public partial class RoutingFile :  IEquatable<RoutingFile>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoutingFile" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RoutingFile() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RoutingFile" /> class.
        /// </summary>
        /// <param name="Options">Options.</param>
        /// <param name="Routes">Routes (required).</param>
        public RoutingFile(RoutingOptions Options = default(RoutingOptions), List<Route> Routes = default(List<Route>))
        {
            // to ensure "Routes" is required (not null)
            if (Routes == null)
            {
                throw new InvalidDataException("Routes is a required property for RoutingFile and cannot be null");
            }
            else
            {
                this.Routes = Routes;
            }
            this.Options = Options;
        }
        
        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name="options", EmitDefaultValue=false)]
        public RoutingOptions Options { get; set; }

        /// <summary>
        /// Gets or Sets Routes
        /// </summary>
        [DataMember(Name="routes", EmitDefaultValue=false)]
        public List<Route> Routes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoutingFile {\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  Routes: ").Append(Routes).Append("\n");
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
            return this.Equals(input as RoutingFile);
        }

        /// <summary>
        /// Returns true if RoutingFile instances are equal
        /// </summary>
        /// <param name="input">Instance of RoutingFile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoutingFile input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Options == input.Options ||
                    (this.Options != null &&
                    this.Options.Equals(input.Options))
                ) && 
                (
                    this.Routes == input.Routes ||
                    this.Routes != null &&
                    this.Routes.SequenceEqual(input.Routes)
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
                if (this.Options != null)
                    hashCode = hashCode * 59 + this.Options.GetHashCode();
                if (this.Routes != null)
                    hashCode = hashCode * 59 + this.Routes.GetHashCode();
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
            yield break;
        }
    }

}
