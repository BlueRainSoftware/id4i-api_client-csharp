/* 
 * ID4i API
 *
 * ID4i HTTP API
 *
 * OpenAPI spec version: 0.8.2-SNAPSHOT
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
    /// GuidCollection
    /// </summary>
    [DataContract]
    public partial class GuidCollection :  IEquatable<GuidCollection>
    {
        /// <summary>
        /// Physical attachment state of the collection
        /// </summary>
        /// <value>Physical attachment state of the collection</value>
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
        /// Physical attachment state of the collection
        /// </summary>
        /// <value>Physical attachment state of the collection</value>
        [DataMember(Name="physicalState", EmitDefaultValue=false)]
        public PhysicalStateEnum? PhysicalState { get; set; }
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum ROUTINGCOLLECTION for value: ROUTING_COLLECTION
            /// </summary>
            [EnumMember(Value = "ROUTING_COLLECTION")]
            ROUTINGCOLLECTION = 1,
            
            /// <summary>
            /// Enum LOGISTICCOLLECTION for value: LOGISTIC_COLLECTION
            /// </summary>
            [EnumMember(Value = "LOGISTIC_COLLECTION")]
            LOGISTICCOLLECTION = 2,
            
            /// <summary>
            /// Enum LABELLEDCOLLECTION for value: LABELLED_COLLECTION
            /// </summary>
            [EnumMember(Value = "LABELLED_COLLECTION")]
            LABELLEDCOLLECTION = 3
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GuidCollection" /> class.
        /// </summary>
        /// <param name="HolderOrganizationId">Organization namespace of the holder of the collection.</param>
        /// <param name="Label">Label.</param>
        /// <param name="PhysicalState">Physical attachment state of the collection.</param>
        public GuidCollection(string HolderOrganizationId = default(string), string Label = default(string), PhysicalStateEnum? PhysicalState = default(PhysicalStateEnum?))
        {
            this.HolderOrganizationId = HolderOrganizationId;
            this.Label = Label;
            this.PhysicalState = PhysicalState;
        }
        
        /// <summary>
        /// The UTC unix timestamp of when this collection has been created
        /// </summary>
        /// <value>The UTC unix timestamp of when this collection has been created</value>
        [DataMember(Name="createdTimestamp", EmitDefaultValue=false)]
        public long? CreatedTimestamp { get; private set; }

        /// <summary>
        /// Organization namespace of the holder of the collection
        /// </summary>
        /// <value>Organization namespace of the holder of the collection</value>
        [DataMember(Name="holderOrganizationId", EmitDefaultValue=false)]
        public string HolderOrganizationId { get; set; }

        /// <summary>
        /// The ID
        /// </summary>
        /// <value>The ID</value>
        [DataMember(Name="id4n", EmitDefaultValue=false)]
        public string Id4n { get; private set; }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// Organization namespace of the collection owner
        /// </summary>
        /// <value>Organization namespace of the collection owner</value>
        [DataMember(Name="ownerOrganizationId", EmitDefaultValue=false)]
        public string OwnerOrganizationId { get; private set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GuidCollection {\n");
            sb.Append("  CreatedTimestamp: ").Append(CreatedTimestamp).Append("\n");
            sb.Append("  HolderOrganizationId: ").Append(HolderOrganizationId).Append("\n");
            sb.Append("  Id4n: ").Append(Id4n).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  OwnerOrganizationId: ").Append(OwnerOrganizationId).Append("\n");
            sb.Append("  PhysicalState: ").Append(PhysicalState).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as GuidCollection);
        }

        /// <summary>
        /// Returns true if GuidCollection instances are equal
        /// </summary>
        /// <param name="input">Instance of GuidCollection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GuidCollection input)
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
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
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
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.OwnerOrganizationId != null)
                    hashCode = hashCode * 59 + this.OwnerOrganizationId.GetHashCode();
                if (this.PhysicalState != null)
                    hashCode = hashCode * 59 + this.PhysicalState.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }

}
