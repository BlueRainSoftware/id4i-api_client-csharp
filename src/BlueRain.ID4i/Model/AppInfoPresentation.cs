/* 
 * ID4i API
 *
 * ID4i HTTP API
 *
 * OpenAPI spec version: 0.7.4-SNAPSHOT
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
    /// AppInfoPresentation
    /// </summary>
    [DataContract]
    public partial class AppInfoPresentation :  IEquatable<AppInfoPresentation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppInfoPresentation" /> class.
        /// </summary>
        /// <param name="Branch">Branch.</param>
        /// <param name="CommitTime">CommitTime.</param>
        /// <param name="Name">Name.</param>
        /// <param name="ProductionMode">ProductionMode.</param>
        /// <param name="Revision">Revision.</param>
        /// <param name="Version">Version.</param>
        public AppInfoPresentation(string Branch = default(string), string CommitTime = default(string), string Name = default(string), bool? ProductionMode = default(bool?), string Revision = default(string), string Version = default(string))
        {
            this.Branch = Branch;
            this.CommitTime = CommitTime;
            this.Name = Name;
            this.ProductionMode = ProductionMode;
            this.Revision = Revision;
            this.Version = Version;
        }
        
        /// <summary>
        /// Gets or Sets Branch
        /// </summary>
        [DataMember(Name="branch", EmitDefaultValue=false)]
        public string Branch { get; set; }

        /// <summary>
        /// Gets or Sets CommitTime
        /// </summary>
        [DataMember(Name="commitTime", EmitDefaultValue=false)]
        public string CommitTime { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ProductionMode
        /// </summary>
        [DataMember(Name="productionMode", EmitDefaultValue=false)]
        public bool? ProductionMode { get; set; }

        /// <summary>
        /// Gets or Sets Revision
        /// </summary>
        [DataMember(Name="revision", EmitDefaultValue=false)]
        public string Revision { get; set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppInfoPresentation {\n");
            sb.Append("  Branch: ").Append(Branch).Append("\n");
            sb.Append("  CommitTime: ").Append(CommitTime).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ProductionMode: ").Append(ProductionMode).Append("\n");
            sb.Append("  Revision: ").Append(Revision).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(input as AppInfoPresentation);
        }

        /// <summary>
        /// Returns true if AppInfoPresentation instances are equal
        /// </summary>
        /// <param name="input">Instance of AppInfoPresentation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppInfoPresentation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Branch == input.Branch ||
                    (this.Branch != null &&
                    this.Branch.Equals(input.Branch))
                ) && 
                (
                    this.CommitTime == input.CommitTime ||
                    (this.CommitTime != null &&
                    this.CommitTime.Equals(input.CommitTime))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ProductionMode == input.ProductionMode ||
                    (this.ProductionMode != null &&
                    this.ProductionMode.Equals(input.ProductionMode))
                ) && 
                (
                    this.Revision == input.Revision ||
                    (this.Revision != null &&
                    this.Revision.Equals(input.Revision))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.Branch != null)
                    hashCode = hashCode * 59 + this.Branch.GetHashCode();
                if (this.CommitTime != null)
                    hashCode = hashCode * 59 + this.CommitTime.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ProductionMode != null)
                    hashCode = hashCode * 59 + this.ProductionMode.GetHashCode();
                if (this.Revision != null)
                    hashCode = hashCode * 59 + this.Revision.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }
    }

}
