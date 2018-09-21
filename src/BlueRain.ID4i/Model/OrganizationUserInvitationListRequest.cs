/* 
 * ID4i API
 *
 * ID4i HTTP API
 *
 * OpenAPI spec version: 0.9.1
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
    /// OrganizationUserInvitationListRequest
    /// </summary>
    [DataContract]
    public partial class OrganizationUserInvitationListRequest :  IEquatable<OrganizationUserInvitationListRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationUserInvitationListRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrganizationUserInvitationListRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationUserInvitationListRequest" /> class.
        /// </summary>
        /// <param name="Invitations">Invitations (required).</param>
        public OrganizationUserInvitationListRequest(List<OrganizationUserInvitation> Invitations = default(List<OrganizationUserInvitation>))
        {
            // to ensure "Invitations" is required (not null)
            if (Invitations == null)
            {
                throw new InvalidDataException("Invitations is a required property for OrganizationUserInvitationListRequest and cannot be null");
            }
            else
            {
                this.Invitations = Invitations;
            }
        }
        
        /// <summary>
        /// Gets or Sets Invitations
        /// </summary>
        [DataMember(Name="invitations", EmitDefaultValue=false)]
        public List<OrganizationUserInvitation> Invitations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrganizationUserInvitationListRequest {\n");
            sb.Append("  Invitations: ").Append(Invitations).Append("\n");
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
            return this.Equals(input as OrganizationUserInvitationListRequest);
        }

        /// <summary>
        /// Returns true if OrganizationUserInvitationListRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of OrganizationUserInvitationListRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrganizationUserInvitationListRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Invitations == input.Invitations ||
                    this.Invitations != null &&
                    this.Invitations.SequenceEqual(input.Invitations)
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
                if (this.Invitations != null)
                    hashCode = hashCode * 59 + this.Invitations.GetHashCode();
                return hashCode;
            }
        }
    }

}
