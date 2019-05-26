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
    /// QueuePresentation
    /// </summary>
    [DataContract]
    public partial class QueuePresentation :  IEquatable<QueuePresentation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueuePresentation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QueuePresentation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QueuePresentation" /> class.
        /// </summary>
        /// <param name="Active">Active (required).</param>
        /// <param name="Id">Id (required).</param>
        /// <param name="WaitingMessages">The count of queued messages.</param>
        public QueuePresentation(bool? Active = default(bool?), string Id = default(string), long? WaitingMessages = default(long?))
        {
            // to ensure "Active" is required (not null)
            if (Active == null)
            {
                throw new InvalidDataException("Active is a required property for QueuePresentation and cannot be null");
            }
            else
            {
                this.Active = Active;
            }
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for QueuePresentation and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            this.WaitingMessages = WaitingMessages;
        }
        
        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The count of queued messages
        /// </summary>
        /// <value>The count of queued messages</value>
        [DataMember(Name="waitingMessages", EmitDefaultValue=false)]
        public long? WaitingMessages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueuePresentation {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  WaitingMessages: ").Append(WaitingMessages).Append("\n");
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
            return this.Equals(input as QueuePresentation);
        }

        /// <summary>
        /// Returns true if QueuePresentation instances are equal
        /// </summary>
        /// <param name="input">Instance of QueuePresentation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueuePresentation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.WaitingMessages == input.WaitingMessages ||
                    (this.WaitingMessages != null &&
                    this.WaitingMessages.Equals(input.WaitingMessages))
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
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.WaitingMessages != null)
                    hashCode = hashCode * 59 + this.WaitingMessages.GetHashCode();
                return hashCode;
            }
        }
    }

}
