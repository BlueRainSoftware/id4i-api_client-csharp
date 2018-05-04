/* 
 * ID4i API
 *
 * ID4i HTTP API
 *
 * OpenAPI spec version: 0.6.0
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
    /// URI
    /// </summary>
    [DataContract]
    public partial class URI :  IEquatable<URI>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="URI" /> class.
        /// </summary>
        /// <param name="Absolute">Absolute.</param>
        /// <param name="Authority">Authority.</param>
        /// <param name="Fragment">Fragment.</param>
        /// <param name="Host">Host.</param>
        /// <param name="Opaque">Opaque.</param>
        /// <param name="Path">Path.</param>
        /// <param name="Port">Port.</param>
        /// <param name="Query">Query.</param>
        /// <param name="RawAuthority">RawAuthority.</param>
        /// <param name="RawFragment">RawFragment.</param>
        /// <param name="RawPath">RawPath.</param>
        /// <param name="RawQuery">RawQuery.</param>
        /// <param name="RawSchemeSpecificPart">RawSchemeSpecificPart.</param>
        /// <param name="RawUserInfo">RawUserInfo.</param>
        /// <param name="Scheme">Scheme.</param>
        /// <param name="SchemeSpecificPart">SchemeSpecificPart.</param>
        /// <param name="UserInfo">UserInfo.</param>
        public URI(bool? Absolute = default(bool?), string Authority = default(string), string Fragment = default(string), string Host = default(string), bool? Opaque = default(bool?), string Path = default(string), int? Port = default(int?), string Query = default(string), string RawAuthority = default(string), string RawFragment = default(string), string RawPath = default(string), string RawQuery = default(string), string RawSchemeSpecificPart = default(string), string RawUserInfo = default(string), string Scheme = default(string), string SchemeSpecificPart = default(string), string UserInfo = default(string))
        {
            this.Absolute = Absolute;
            this.Authority = Authority;
            this.Fragment = Fragment;
            this.Host = Host;
            this.Opaque = Opaque;
            this.Path = Path;
            this.Port = Port;
            this.Query = Query;
            this.RawAuthority = RawAuthority;
            this.RawFragment = RawFragment;
            this.RawPath = RawPath;
            this.RawQuery = RawQuery;
            this.RawSchemeSpecificPart = RawSchemeSpecificPart;
            this.RawUserInfo = RawUserInfo;
            this.Scheme = Scheme;
            this.SchemeSpecificPart = SchemeSpecificPart;
            this.UserInfo = UserInfo;
        }
        
        /// <summary>
        /// Gets or Sets Absolute
        /// </summary>
        [DataMember(Name="absolute", EmitDefaultValue=false)]
        public bool? Absolute { get; set; }

        /// <summary>
        /// Gets or Sets Authority
        /// </summary>
        [DataMember(Name="authority", EmitDefaultValue=false)]
        public string Authority { get; set; }

        /// <summary>
        /// Gets or Sets Fragment
        /// </summary>
        [DataMember(Name="fragment", EmitDefaultValue=false)]
        public string Fragment { get; set; }

        /// <summary>
        /// Gets or Sets Host
        /// </summary>
        [DataMember(Name="host", EmitDefaultValue=false)]
        public string Host { get; set; }

        /// <summary>
        /// Gets or Sets Opaque
        /// </summary>
        [DataMember(Name="opaque", EmitDefaultValue=false)]
        public bool? Opaque { get; set; }

        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }

        /// <summary>
        /// Gets or Sets Port
        /// </summary>
        [DataMember(Name="port", EmitDefaultValue=false)]
        public int? Port { get; set; }

        /// <summary>
        /// Gets or Sets Query
        /// </summary>
        [DataMember(Name="query", EmitDefaultValue=false)]
        public string Query { get; set; }

        /// <summary>
        /// Gets or Sets RawAuthority
        /// </summary>
        [DataMember(Name="rawAuthority", EmitDefaultValue=false)]
        public string RawAuthority { get; set; }

        /// <summary>
        /// Gets or Sets RawFragment
        /// </summary>
        [DataMember(Name="rawFragment", EmitDefaultValue=false)]
        public string RawFragment { get; set; }

        /// <summary>
        /// Gets or Sets RawPath
        /// </summary>
        [DataMember(Name="rawPath", EmitDefaultValue=false)]
        public string RawPath { get; set; }

        /// <summary>
        /// Gets or Sets RawQuery
        /// </summary>
        [DataMember(Name="rawQuery", EmitDefaultValue=false)]
        public string RawQuery { get; set; }

        /// <summary>
        /// Gets or Sets RawSchemeSpecificPart
        /// </summary>
        [DataMember(Name="rawSchemeSpecificPart", EmitDefaultValue=false)]
        public string RawSchemeSpecificPart { get; set; }

        /// <summary>
        /// Gets or Sets RawUserInfo
        /// </summary>
        [DataMember(Name="rawUserInfo", EmitDefaultValue=false)]
        public string RawUserInfo { get; set; }

        /// <summary>
        /// Gets or Sets Scheme
        /// </summary>
        [DataMember(Name="scheme", EmitDefaultValue=false)]
        public string Scheme { get; set; }

        /// <summary>
        /// Gets or Sets SchemeSpecificPart
        /// </summary>
        [DataMember(Name="schemeSpecificPart", EmitDefaultValue=false)]
        public string SchemeSpecificPart { get; set; }

        /// <summary>
        /// Gets or Sets UserInfo
        /// </summary>
        [DataMember(Name="userInfo", EmitDefaultValue=false)]
        public string UserInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class URI {\n");
            sb.Append("  Absolute: ").Append(Absolute).Append("\n");
            sb.Append("  Authority: ").Append(Authority).Append("\n");
            sb.Append("  Fragment: ").Append(Fragment).Append("\n");
            sb.Append("  Host: ").Append(Host).Append("\n");
            sb.Append("  Opaque: ").Append(Opaque).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  RawAuthority: ").Append(RawAuthority).Append("\n");
            sb.Append("  RawFragment: ").Append(RawFragment).Append("\n");
            sb.Append("  RawPath: ").Append(RawPath).Append("\n");
            sb.Append("  RawQuery: ").Append(RawQuery).Append("\n");
            sb.Append("  RawSchemeSpecificPart: ").Append(RawSchemeSpecificPart).Append("\n");
            sb.Append("  RawUserInfo: ").Append(RawUserInfo).Append("\n");
            sb.Append("  Scheme: ").Append(Scheme).Append("\n");
            sb.Append("  SchemeSpecificPart: ").Append(SchemeSpecificPart).Append("\n");
            sb.Append("  UserInfo: ").Append(UserInfo).Append("\n");
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
            return this.Equals(input as URI);
        }

        /// <summary>
        /// Returns true if URI instances are equal
        /// </summary>
        /// <param name="input">Instance of URI to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(URI input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Absolute == input.Absolute ||
                    (this.Absolute != null &&
                    this.Absolute.Equals(input.Absolute))
                ) && 
                (
                    this.Authority == input.Authority ||
                    (this.Authority != null &&
                    this.Authority.Equals(input.Authority))
                ) && 
                (
                    this.Fragment == input.Fragment ||
                    (this.Fragment != null &&
                    this.Fragment.Equals(input.Fragment))
                ) && 
                (
                    this.Host == input.Host ||
                    (this.Host != null &&
                    this.Host.Equals(input.Host))
                ) && 
                (
                    this.Opaque == input.Opaque ||
                    (this.Opaque != null &&
                    this.Opaque.Equals(input.Opaque))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
                ) && 
                (
                    this.Query == input.Query ||
                    (this.Query != null &&
                    this.Query.Equals(input.Query))
                ) && 
                (
                    this.RawAuthority == input.RawAuthority ||
                    (this.RawAuthority != null &&
                    this.RawAuthority.Equals(input.RawAuthority))
                ) && 
                (
                    this.RawFragment == input.RawFragment ||
                    (this.RawFragment != null &&
                    this.RawFragment.Equals(input.RawFragment))
                ) && 
                (
                    this.RawPath == input.RawPath ||
                    (this.RawPath != null &&
                    this.RawPath.Equals(input.RawPath))
                ) && 
                (
                    this.RawQuery == input.RawQuery ||
                    (this.RawQuery != null &&
                    this.RawQuery.Equals(input.RawQuery))
                ) && 
                (
                    this.RawSchemeSpecificPart == input.RawSchemeSpecificPart ||
                    (this.RawSchemeSpecificPart != null &&
                    this.RawSchemeSpecificPart.Equals(input.RawSchemeSpecificPart))
                ) && 
                (
                    this.RawUserInfo == input.RawUserInfo ||
                    (this.RawUserInfo != null &&
                    this.RawUserInfo.Equals(input.RawUserInfo))
                ) && 
                (
                    this.Scheme == input.Scheme ||
                    (this.Scheme != null &&
                    this.Scheme.Equals(input.Scheme))
                ) && 
                (
                    this.SchemeSpecificPart == input.SchemeSpecificPart ||
                    (this.SchemeSpecificPart != null &&
                    this.SchemeSpecificPart.Equals(input.SchemeSpecificPart))
                ) && 
                (
                    this.UserInfo == input.UserInfo ||
                    (this.UserInfo != null &&
                    this.UserInfo.Equals(input.UserInfo))
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
                if (this.Absolute != null)
                    hashCode = hashCode * 59 + this.Absolute.GetHashCode();
                if (this.Authority != null)
                    hashCode = hashCode * 59 + this.Authority.GetHashCode();
                if (this.Fragment != null)
                    hashCode = hashCode * 59 + this.Fragment.GetHashCode();
                if (this.Host != null)
                    hashCode = hashCode * 59 + this.Host.GetHashCode();
                if (this.Opaque != null)
                    hashCode = hashCode * 59 + this.Opaque.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.Query != null)
                    hashCode = hashCode * 59 + this.Query.GetHashCode();
                if (this.RawAuthority != null)
                    hashCode = hashCode * 59 + this.RawAuthority.GetHashCode();
                if (this.RawFragment != null)
                    hashCode = hashCode * 59 + this.RawFragment.GetHashCode();
                if (this.RawPath != null)
                    hashCode = hashCode * 59 + this.RawPath.GetHashCode();
                if (this.RawQuery != null)
                    hashCode = hashCode * 59 + this.RawQuery.GetHashCode();
                if (this.RawSchemeSpecificPart != null)
                    hashCode = hashCode * 59 + this.RawSchemeSpecificPart.GetHashCode();
                if (this.RawUserInfo != null)
                    hashCode = hashCode * 59 + this.RawUserInfo.GetHashCode();
                if (this.Scheme != null)
                    hashCode = hashCode * 59 + this.Scheme.GetHashCode();
                if (this.SchemeSpecificPart != null)
                    hashCode = hashCode * 59 + this.SchemeSpecificPart.GetHashCode();
                if (this.UserInfo != null)
                    hashCode = hashCode * 59 + this.UserInfo.GetHashCode();
                return hashCode;
            }
        }
    }

}
