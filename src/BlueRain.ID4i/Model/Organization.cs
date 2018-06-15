/* 
 * ID4i API
 *
 * ID4i HTTP API
 *
 * OpenAPI spec version: 0.8.0-SNAPSHOT
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
    /// An organization
    /// </summary>
    [DataContract]
    public partial class Organization :  IEquatable<Organization>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Organization" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Organization() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Organization" /> class.
        /// </summary>
        /// <param name="Name">The name of the organization (required).</param>
        /// <param name="_Namespace">The namespace of the organization (required).</param>
        public Organization(string Name = default(string), string _Namespace = default(string))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for Organization and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "_Namespace" is required (not null)
            if (_Namespace == null)
            {
                throw new InvalidDataException("_Namespace is a required property for Organization and cannot be null");
            }
            else
            {
                this._Namespace = _Namespace;
            }
        }
        
        /// <summary>
        /// The id of the organization ( Deprecated: Use namespace instead. )
        /// </summary>
        /// <value>The id of the organization ( Deprecated: Use namespace instead. )</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// URL to a logo of the organization
        /// </summary>
        /// <value>URL to a logo of the organization</value>
        [DataMember(Name="logoURL", EmitDefaultValue=false)]
        public string LogoURL { get; private set; }

        /// <summary>
        /// The name of the organization
        /// </summary>
        /// <value>The name of the organization</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The namespace of the organization
        /// </summary>
        /// <value>The namespace of the organization</value>
        [DataMember(Name="namespace", EmitDefaultValue=false)]
        public string _Namespace { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Organization {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LogoURL: ").Append(LogoURL).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  _Namespace: ").Append(_Namespace).Append("\n");
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
            return this.Equals(input as Organization);
        }

        /// <summary>
        /// Returns true if Organization instances are equal
        /// </summary>
        /// <param name="input">Instance of Organization to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Organization input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LogoURL == input.LogoURL ||
                    (this.LogoURL != null &&
                    this.LogoURL.Equals(input.LogoURL))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this._Namespace == input._Namespace ||
                    (this._Namespace != null &&
                    this._Namespace.Equals(input._Namespace))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LogoURL != null)
                    hashCode = hashCode * 59 + this.LogoURL.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this._Namespace != null)
                    hashCode = hashCode * 59 + this._Namespace.GetHashCode();
                return hashCode;
            }
        }
    }

}
