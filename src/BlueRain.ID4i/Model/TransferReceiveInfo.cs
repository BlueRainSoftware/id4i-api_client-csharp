/* 
 * ID4i API
 *
 * ID4i HTTP API
 *
 * OpenAPI spec version: 0.9.3
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
    /// TransferReceiveInfo
    /// </summary>
    [DataContract]
    public partial class TransferReceiveInfo :  IEquatable<TransferReceiveInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferReceiveInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransferReceiveInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferReceiveInfo" /> class.
        /// </summary>
        /// <param name="HolderOrganizationId">The current holder of the object (required).</param>
        /// <param name="RecipientOrganizationIds">Allow only these organizations to obtain this object.</param>
        public TransferReceiveInfo(string HolderOrganizationId = default(string), List<string> RecipientOrganizationIds = default(List<string>))
        {
            // to ensure "HolderOrganizationId" is required (not null)
            if (HolderOrganizationId == null)
            {
                throw new InvalidDataException("HolderOrganizationId is a required property for TransferReceiveInfo and cannot be null");
            }
            else
            {
                this.HolderOrganizationId = HolderOrganizationId;
            }
            this.RecipientOrganizationIds = RecipientOrganizationIds;
        }
        
        /// <summary>
        /// The current holder of the object
        /// </summary>
        /// <value>The current holder of the object</value>
        [DataMember(Name="holderOrganizationId", EmitDefaultValue=false)]
        public string HolderOrganizationId { get; set; }

        /// <summary>
        /// Keep the public ownership while transferring the object
        /// </summary>
        /// <value>Keep the public ownership while transferring the object</value>
        [DataMember(Name="keepOwnership", EmitDefaultValue=false)]
        public bool? KeepOwnership { get; private set; }

        /// <summary>
        /// Anyone who knows (or can scan) the ID4N can claim ownership of this object
        /// </summary>
        /// <value>Anyone who knows (or can scan) the ID4N can claim ownership of this object</value>
        [DataMember(Name="openForClaims", EmitDefaultValue=false)]
        public bool? OpenForClaims { get; private set; }

        /// <summary>
        /// The current publicly visible owner of the object
        /// </summary>
        /// <value>The current publicly visible owner of the object</value>
        [DataMember(Name="ownerOrganizationId", EmitDefaultValue=false)]
        public string OwnerOrganizationId { get; private set; }

        /// <summary>
        /// Allow only these organizations to obtain this object
        /// </summary>
        /// <value>Allow only these organizations to obtain this object</value>
        [DataMember(Name="recipientOrganizationIds", EmitDefaultValue=false)]
        public List<string> RecipientOrganizationIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransferReceiveInfo {\n");
            sb.Append("  HolderOrganizationId: ").Append(HolderOrganizationId).Append("\n");
            sb.Append("  KeepOwnership: ").Append(KeepOwnership).Append("\n");
            sb.Append("  OpenForClaims: ").Append(OpenForClaims).Append("\n");
            sb.Append("  OwnerOrganizationId: ").Append(OwnerOrganizationId).Append("\n");
            sb.Append("  RecipientOrganizationIds: ").Append(RecipientOrganizationIds).Append("\n");
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
            return this.Equals(input as TransferReceiveInfo);
        }

        /// <summary>
        /// Returns true if TransferReceiveInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of TransferReceiveInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferReceiveInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HolderOrganizationId == input.HolderOrganizationId ||
                    (this.HolderOrganizationId != null &&
                    this.HolderOrganizationId.Equals(input.HolderOrganizationId))
                ) && 
                (
                    this.KeepOwnership == input.KeepOwnership ||
                    (this.KeepOwnership != null &&
                    this.KeepOwnership.Equals(input.KeepOwnership))
                ) && 
                (
                    this.OpenForClaims == input.OpenForClaims ||
                    (this.OpenForClaims != null &&
                    this.OpenForClaims.Equals(input.OpenForClaims))
                ) && 
                (
                    this.OwnerOrganizationId == input.OwnerOrganizationId ||
                    (this.OwnerOrganizationId != null &&
                    this.OwnerOrganizationId.Equals(input.OwnerOrganizationId))
                ) && 
                (
                    this.RecipientOrganizationIds == input.RecipientOrganizationIds ||
                    this.RecipientOrganizationIds != null &&
                    this.RecipientOrganizationIds.SequenceEqual(input.RecipientOrganizationIds)
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
                if (this.HolderOrganizationId != null)
                    hashCode = hashCode * 59 + this.HolderOrganizationId.GetHashCode();
                if (this.KeepOwnership != null)
                    hashCode = hashCode * 59 + this.KeepOwnership.GetHashCode();
                if (this.OpenForClaims != null)
                    hashCode = hashCode * 59 + this.OpenForClaims.GetHashCode();
                if (this.OwnerOrganizationId != null)
                    hashCode = hashCode * 59 + this.OwnerOrganizationId.GetHashCode();
                if (this.RecipientOrganizationIds != null)
                    hashCode = hashCode * 59 + this.RecipientOrganizationIds.GetHashCode();
                return hashCode;
            }
        }
    }

}
