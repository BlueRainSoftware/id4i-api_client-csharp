/* 
 * ID4i API
 *
 * ID4i HTTP API
 *
 * OpenAPI spec version: 0.8.3
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
    /// A changelog entry
    /// </summary>
    [DataContract]
    public partial class ChangeLogEntry :  IEquatable<ChangeLogEntry>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeLogEntry" /> class.
        /// </summary>
        /// <param name="MessageProperties">The values of the properties in the message. May be nested as object with a value field .</param>
        public ChangeLogEntry(Dictionary<string, Object> MessageProperties = default(Dictionary<string, Object>))
        {
            this.MessageProperties = MessageProperties;
        }
        
        /// <summary>
        /// The unique id of the changelog entry
        /// </summary>
        /// <value>The unique id of the changelog entry</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }

        /// <summary>
        /// The message as template or rendered as plain text
        /// </summary>
        /// <value>The message as template or rendered as plain text</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; private set; }

        /// <summary>
        /// The values of the properties in the message. May be nested as object with a value field 
        /// </summary>
        /// <value>The values of the properties in the message. May be nested as object with a value field </value>
        [DataMember(Name="messageProperties", EmitDefaultValue=false)]
        public Dictionary<string, Object> MessageProperties { get; set; }

        /// <summary>
        /// The UTC unix timestamp when this change occurred
        /// </summary>
        /// <value>The UTC unix timestamp when this change occurred</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public long? Timestamp { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangeLogEntry {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  MessageProperties: ").Append(MessageProperties).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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
            return this.Equals(input as ChangeLogEntry);
        }

        /// <summary>
        /// Returns true if ChangeLogEntry instances are equal
        /// </summary>
        /// <param name="input">Instance of ChangeLogEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChangeLogEntry input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.MessageProperties == input.MessageProperties ||
                    this.MessageProperties != null &&
                    this.MessageProperties.SequenceEqual(input.MessageProperties)
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.MessageProperties != null)
                    hashCode = hashCode * 59 + this.MessageProperties.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                return hashCode;
            }
        }
    }

}
