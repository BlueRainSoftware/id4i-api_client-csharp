/* 
 * ID4i API
 *
 * ID4i HTTP API
 *
 * OpenAPI spec version: 0.2.5-SNAPSHOT
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
    /// RoutingFileRequest
    /// </summary>
    [DataContract]
    public partial class RoutingFileRequest :  IEquatable<RoutingFileRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoutingFileRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RoutingFileRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RoutingFileRequest" /> class.
        /// </summary>
        /// <param name="OrganizationId">OrganizationId.</param>
        /// <param name="Routing">Routing (required).</param>
        public RoutingFileRequest(long? OrganizationId = default(long?), RoutingFile Routing = default(RoutingFile))
        {
            // to ensure "Routing" is required (not null)
            if (Routing == null)
            {
                throw new InvalidDataException("Routing is a required property for RoutingFileRequest and cannot be null");
            }
            else
            {
                this.Routing = Routing;
            }
            this.OrganizationId = OrganizationId;
        }
        
        /// <summary>
        /// Gets or Sets OrganizationId
        /// </summary>
        [DataMember(Name="organizationId", EmitDefaultValue=false)]
        public long? OrganizationId { get; set; }

        /// <summary>
        /// Gets or Sets Routing
        /// </summary>
        [DataMember(Name="routing", EmitDefaultValue=false)]
        public RoutingFile Routing { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoutingFileRequest {\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  Routing: ").Append(Routing).Append("\n");
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
            return this.Equals(input as RoutingFileRequest);
        }

        /// <summary>
        /// Returns true if RoutingFileRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RoutingFileRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoutingFileRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OrganizationId == input.OrganizationId ||
                    (this.OrganizationId != null &&
                    this.OrganizationId.Equals(input.OrganizationId))
                ) && 
                (
                    this.Routing == input.Routing ||
                    (this.Routing != null &&
                    this.Routing.Equals(input.Routing))
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
                if (this.OrganizationId != null)
                    hashCode = hashCode * 59 + this.OrganizationId.GetHashCode();
                if (this.Routing != null)
                    hashCode = hashCode * 59 + this.Routing.GetHashCode();
                return hashCode;
            }
        }
    }

}