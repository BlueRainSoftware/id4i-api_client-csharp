/* 
 * ID4i API
 *
 * ID4i HTTP API
 *
 * OpenAPI spec version: 0.8.6-SNAPSHOT
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
    /// DocumentUpdate
    /// </summary>
    [DataContract]
    public partial class DocumentUpdate :  IEquatable<DocumentUpdate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentUpdate" /> class.
        /// </summary>
        /// <param name="Filename">File Name.</param>
        /// <param name="MimeType">Mime Type.</param>
        /// <param name="Visibility">Visibility configuration.</param>
        public DocumentUpdate(string Filename = default(string), string MimeType = default(string), VisibilityUpdate Visibility = default(VisibilityUpdate))
        {
            this.Filename = Filename;
            this.MimeType = MimeType;
            this.Visibility = Visibility;
        }
        
        /// <summary>
        /// File Name
        /// </summary>
        /// <value>File Name</value>
        [DataMember(Name="filename", EmitDefaultValue=false)]
        public string Filename { get; set; }

        /// <summary>
        /// Mime Type
        /// </summary>
        /// <value>Mime Type</value>
        [DataMember(Name="mimeType", EmitDefaultValue=false)]
        public string MimeType { get; set; }

        /// <summary>
        /// Visibility configuration
        /// </summary>
        /// <value>Visibility configuration</value>
        [DataMember(Name="visibility", EmitDefaultValue=false)]
        public VisibilityUpdate Visibility { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentUpdate {\n");
            sb.Append("  Filename: ").Append(Filename).Append("\n");
            sb.Append("  MimeType: ").Append(MimeType).Append("\n");
            sb.Append("  Visibility: ").Append(Visibility).Append("\n");
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
            return this.Equals(input as DocumentUpdate);
        }

        /// <summary>
        /// Returns true if DocumentUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of DocumentUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentUpdate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Filename == input.Filename ||
                    (this.Filename != null &&
                    this.Filename.Equals(input.Filename))
                ) && 
                (
                    this.MimeType == input.MimeType ||
                    (this.MimeType != null &&
                    this.MimeType.Equals(input.MimeType))
                ) && 
                (
                    this.Visibility == input.Visibility ||
                    (this.Visibility != null &&
                    this.Visibility.Equals(input.Visibility))
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
                if (this.Filename != null)
                    hashCode = hashCode * 59 + this.Filename.GetHashCode();
                if (this.MimeType != null)
                    hashCode = hashCode * 59 + this.MimeType.GetHashCode();
                if (this.Visibility != null)
                    hashCode = hashCode * 59 + this.Visibility.GetHashCode();
                return hashCode;
            }
        }
    }

}
