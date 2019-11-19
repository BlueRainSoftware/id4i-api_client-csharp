/* 
 * ID4i API
 *
 * ID4i HTTP API
 *
 * OpenAPI spec version: 0.9.7
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
    /// QueueUpdateRequest
    /// </summary>
    [DataContract]
    public partial class QueueUpdateRequest :  IEquatable<QueueUpdateRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueUpdateRequest" /> class.
        /// </summary>
        /// <param name="Active">If this value is set to false the queue will be deleted..</param>
        /// <param name="Id">Id.</param>
        /// <param name="PurgeQueue">Set this value to true if you want to purge the queue..</param>
        public QueueUpdateRequest(bool? Active = default(bool?), string Id = default(string), bool? PurgeQueue = default(bool?))
        {
            this.Active = Active;
            this.Id = Id;
            this.PurgeQueue = PurgeQueue;
        }
        
        /// <summary>
        /// If this value is set to false the queue will be deleted.
        /// </summary>
        /// <value>If this value is set to false the queue will be deleted.</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Set this value to true if you want to purge the queue.
        /// </summary>
        /// <value>Set this value to true if you want to purge the queue.</value>
        [DataMember(Name="purgeQueue", EmitDefaultValue=false)]
        public bool? PurgeQueue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueueUpdateRequest {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PurgeQueue: ").Append(PurgeQueue).Append("\n");
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
            return this.Equals(input as QueueUpdateRequest);
        }

        /// <summary>
        /// Returns true if QueueUpdateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of QueueUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueueUpdateRequest input)
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
                    this.PurgeQueue == input.PurgeQueue ||
                    (this.PurgeQueue != null &&
                    this.PurgeQueue.Equals(input.PurgeQueue))
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
                if (this.PurgeQueue != null)
                    hashCode = hashCode * 59 + this.PurgeQueue.GetHashCode();
                return hashCode;
            }
        }
    }

}
