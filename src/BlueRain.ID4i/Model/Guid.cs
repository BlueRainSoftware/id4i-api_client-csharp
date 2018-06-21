/* 
 * ID4i API
 *
 * ID4i HTTP API
 *
 * OpenAPI spec version: 0.8.0
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
    /// Guid
    /// </summary>
    [DataContract]
    public partial class Guid :  IEquatable<Guid>
    {
        /// <summary>
        /// Physical attachment state of the GUID
        /// </summary>
        /// <value>Physical attachment state of the GUID</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PhysicalStateEnum
        {
            
            /// <summary>
            /// Enum UNATTACHED for value: UNATTACHED
            /// </summary>
            [EnumMember(Value = "UNATTACHED")]
            UNATTACHED = 1,
            
            /// <summary>
            /// Enum ATTACHED for value: ATTACHED
            /// </summary>
            [EnumMember(Value = "ATTACHED")]
            ATTACHED = 2,
            
            /// <summary>
            /// Enum DETACHED for value: DETACHED
            /// </summary>
            [EnumMember(Value = "DETACHED")]
            DETACHED = 3
        }

        /// <summary>
        /// Physical attachment state of the GUID
        /// </summary>
        /// <value>Physical attachment state of the GUID</value>
        [DataMember(Name="physicalState", EmitDefaultValue=false)]
        public PhysicalStateEnum? PhysicalState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Guid" /> class.
        /// </summary>
        /// <param name="PhysicalState">Physical attachment state of the GUID.</param>
        public Guid(PhysicalStateEnum? PhysicalState = default(PhysicalStateEnum?))
        {
            this.PhysicalState = PhysicalState;
        }
        
        /// <summary>
        /// The UTC unix timestamp of when this GUID has been created
        /// </summary>
        /// <value>The UTC unix timestamp of when this GUID has been created</value>
        [DataMember(Name="createdTimestamp", EmitDefaultValue=false)]
        public long? CreatedTimestamp { get; private set; }

        /// <summary>
        /// Organization namespace of the GUID holder
        /// </summary>
        /// <value>Organization namespace of the GUID holder</value>
        [DataMember(Name="holderOrganizationId", EmitDefaultValue=false)]
        public string HolderOrganizationId { get; private set; }

        /// <summary>
        /// The ID
        /// </summary>
        /// <value>The ID</value>
        [DataMember(Name="id4n", EmitDefaultValue=false)]
        public string Id4n { get; private set; }

        /// <summary>
        /// Organization namespace of the GUID owner
        /// </summary>
        /// <value>Organization namespace of the GUID owner</value>
        [DataMember(Name="ownerOrganizationId", EmitDefaultValue=false)]
        public string OwnerOrganizationId { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Guid {\n");
            sb.Append("  CreatedTimestamp: ").Append(CreatedTimestamp).Append("\n");
            sb.Append("  HolderOrganizationId: ").Append(HolderOrganizationId).Append("\n");
            sb.Append("  Id4n: ").Append(Id4n).Append("\n");
            sb.Append("  OwnerOrganizationId: ").Append(OwnerOrganizationId).Append("\n");
            sb.Append("  PhysicalState: ").Append(PhysicalState).Append("\n");
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
            return this.Equals(input as Guid);
        }

        /// <summary>
        /// Returns true if Guid instances are equal
        /// </summary>
        /// <param name="input">Instance of Guid to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Guid input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreatedTimestamp == input.CreatedTimestamp ||
                    (this.CreatedTimestamp != null &&
                    this.CreatedTimestamp.Equals(input.CreatedTimestamp))
                ) && 
                (
                    this.HolderOrganizationId == input.HolderOrganizationId ||
                    (this.HolderOrganizationId != null &&
                    this.HolderOrganizationId.Equals(input.HolderOrganizationId))
                ) && 
                (
                    this.Id4n == input.Id4n ||
                    (this.Id4n != null &&
                    this.Id4n.Equals(input.Id4n))
                ) && 
                (
                    this.OwnerOrganizationId == input.OwnerOrganizationId ||
                    (this.OwnerOrganizationId != null &&
                    this.OwnerOrganizationId.Equals(input.OwnerOrganizationId))
                ) && 
                (
                    this.PhysicalState == input.PhysicalState ||
                    (this.PhysicalState != null &&
                    this.PhysicalState.Equals(input.PhysicalState))
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
                if (this.CreatedTimestamp != null)
                    hashCode = hashCode * 59 + this.CreatedTimestamp.GetHashCode();
                if (this.HolderOrganizationId != null)
                    hashCode = hashCode * 59 + this.HolderOrganizationId.GetHashCode();
                if (this.Id4n != null)
                    hashCode = hashCode * 59 + this.Id4n.GetHashCode();
                if (this.OwnerOrganizationId != null)
                    hashCode = hashCode * 59 + this.OwnerOrganizationId.GetHashCode();
                if (this.PhysicalState != null)
                    hashCode = hashCode * 59 + this.PhysicalState.GetHashCode();
                return hashCode;
            }
        }
    }

}
