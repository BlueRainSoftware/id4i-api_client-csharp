/* 
 * ID4i API
 *
 * ID4i HTTP API
 *
 * OpenAPI spec version: 0.9.7-SNAPSHOT
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
    /// GS1/MAPP codes import information
    /// </summary>
    [DataContract]
    public partial class ImportGS1CodesRequest :  IEquatable<ImportGS1CodesRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImportGS1CodesRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImportGS1CodesRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImportGS1CodesRequest" /> class.
        /// </summary>
        /// <param name="ListOfGS1s">The list of GS1/Mapp codes to be imported (required).</param>
        /// <param name="OrganizationId">The organization where the GS1/Mapp code is imported. (required).</param>
        public ImportGS1CodesRequest(ListOfGS1s ListOfGS1s = default(ListOfGS1s), string OrganizationId = default(string))
        {
            // to ensure "ListOfGS1s" is required (not null)
            if (ListOfGS1s == null)
            {
                throw new InvalidDataException("ListOfGS1s is a required property for ImportGS1CodesRequest and cannot be null");
            }
            else
            {
                this.ListOfGS1s = ListOfGS1s;
            }
            // to ensure "OrganizationId" is required (not null)
            if (OrganizationId == null)
            {
                throw new InvalidDataException("OrganizationId is a required property for ImportGS1CodesRequest and cannot be null");
            }
            else
            {
                this.OrganizationId = OrganizationId;
            }
        }
        
        /// <summary>
        /// The list of GS1/Mapp codes to be imported
        /// </summary>
        /// <value>The list of GS1/Mapp codes to be imported</value>
        [DataMember(Name="listOfGS1s", EmitDefaultValue=false)]
        public ListOfGS1s ListOfGS1s { get; set; }

        /// <summary>
        /// The organization where the GS1/Mapp code is imported.
        /// </summary>
        /// <value>The organization where the GS1/Mapp code is imported.</value>
        [DataMember(Name="organizationId", EmitDefaultValue=false)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportGS1CodesRequest {\n");
            sb.Append("  ListOfGS1s: ").Append(ListOfGS1s).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
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
            return this.Equals(input as ImportGS1CodesRequest);
        }

        /// <summary>
        /// Returns true if ImportGS1CodesRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ImportGS1CodesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImportGS1CodesRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ListOfGS1s == input.ListOfGS1s ||
                    (this.ListOfGS1s != null &&
                    this.ListOfGS1s.Equals(input.ListOfGS1s))
                ) && 
                (
                    this.OrganizationId == input.OrganizationId ||
                    (this.OrganizationId != null &&
                    this.OrganizationId.Equals(input.OrganizationId))
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
                if (this.ListOfGS1s != null)
                    hashCode = hashCode * 59 + this.ListOfGS1s.GetHashCode();
                if (this.OrganizationId != null)
                    hashCode = hashCode * 59 + this.OrganizationId.GetHashCode();
                return hashCode;
            }
        }
    }

}
