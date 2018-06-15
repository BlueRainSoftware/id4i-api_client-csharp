/* 
 * ID4i API
 *
 * ID4i HTTP API
 *
 * OpenAPI spec version: 0.8.0-SNAPSHOT
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
    /// Route
    /// </summary>
    [DataContract]
    public partial class Route :  IEquatable<Route>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Route" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Route() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Route" /> class.
        /// </summary>
        /// <param name="_Params">_Params (required).</param>
        /// <param name="Priority">Priority.</param>
        /// <param name="_Public">_Public (required).</param>
        /// <param name="Type">Type (required).</param>
        /// <param name="ValidUntil">ValidUntil.</param>
        public Route(Dictionary<string, string> _Params = default(Dictionary<string, string>), int? Priority = default(int?), bool? _Public = default(bool?), string Type = default(string), long? ValidUntil = default(long?))
        {
            // to ensure "_Params" is required (not null)
            if (_Params == null)
            {
                throw new InvalidDataException("_Params is a required property for Route and cannot be null");
            }
            else
            {
                this._Params = _Params;
            }
            // to ensure "_Public" is required (not null)
            if (_Public == null)
            {
                throw new InvalidDataException("_Public is a required property for Route and cannot be null");
            }
            else
            {
                this._Public = _Public;
            }
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for Route and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            this.Priority = Priority;
            this.ValidUntil = ValidUntil;
        }
        
        /// <summary>
        /// Gets or Sets _Params
        /// </summary>
        [DataMember(Name="params", EmitDefaultValue=false)]
        public Dictionary<string, string> _Params { get; set; }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// Gets or Sets _Public
        /// </summary>
        [DataMember(Name="public", EmitDefaultValue=false)]
        public bool? _Public { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets ValidUntil
        /// </summary>
        [DataMember(Name="validUntil", EmitDefaultValue=false)]
        public long? ValidUntil { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Route {\n");
            sb.Append("  _Params: ").Append(_Params).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  _Public: ").Append(_Public).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ValidUntil: ").Append(ValidUntil).Append("\n");
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
            return this.Equals(input as Route);
        }

        /// <summary>
        /// Returns true if Route instances are equal
        /// </summary>
        /// <param name="input">Instance of Route to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Route input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._Params == input._Params ||
                    this._Params != null &&
                    this._Params.SequenceEqual(input._Params)
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) && 
                (
                    this._Public == input._Public ||
                    (this._Public != null &&
                    this._Public.Equals(input._Public))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.ValidUntil == input.ValidUntil ||
                    (this.ValidUntil != null &&
                    this.ValidUntil.Equals(input.ValidUntil))
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
                if (this._Params != null)
                    hashCode = hashCode * 59 + this._Params.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this._Public != null)
                    hashCode = hashCode * 59 + this._Public.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ValidUntil != null)
                    hashCode = hashCode * 59 + this.ValidUntil.GetHashCode();
                return hashCode;
            }
        }
    }

}
