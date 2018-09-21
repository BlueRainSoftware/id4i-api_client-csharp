/* 
 * ID4i API
 *
 * ID4i HTTP API
 *
 * OpenAPI spec version: 0.9.2-SNAPSHOT
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
    /// GUID history item
    /// </summary>
    [DataContract]
    public partial class HistoryItem :  IEquatable<HistoryItem>
    {
        /// <summary>
        /// Type of the history item
        /// </summary>
        /// <value>Type of the history item</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum CREATED for value: CREATED
            /// </summary>
            [EnumMember(Value = "CREATED")]
            CREATED = 1,
            
            /// <summary>
            /// Enum DESTROYED for value: DESTROYED
            /// </summary>
            [EnumMember(Value = "DESTROYED")]
            DESTROYED = 2,
            
            /// <summary>
            /// Enum RECYCLED for value: RECYCLED
            /// </summary>
            [EnumMember(Value = "RECYCLED")]
            RECYCLED = 3,
            
            /// <summary>
            /// Enum SHIPMENTPREPARED for value: SHIPMENT_PREPARED
            /// </summary>
            [EnumMember(Value = "SHIPMENT_PREPARED")]
            SHIPMENTPREPARED = 4,
            
            /// <summary>
            /// Enum STORED for value: STORED
            /// </summary>
            [EnumMember(Value = "STORED")]
            STORED = 5,
            
            /// <summary>
            /// Enum RETRIEVEDFROMSTORAGE for value: RETRIEVED_FROM_STORAGE
            /// </summary>
            [EnumMember(Value = "RETRIEVED_FROM_STORAGE")]
            RETRIEVEDFROMSTORAGE = 6,
            
            /// <summary>
            /// Enum PACKAGED for value: PACKAGED
            /// </summary>
            [EnumMember(Value = "PACKAGED")]
            PACKAGED = 7,
            
            /// <summary>
            /// Enum DISPATCHED for value: DISPATCHED
            /// </summary>
            [EnumMember(Value = "DISPATCHED")]
            DISPATCHED = 8,
            
            /// <summary>
            /// Enum RECEIVED for value: RECEIVED
            /// </summary>
            [EnumMember(Value = "RECEIVED")]
            RECEIVED = 9,
            
            /// <summary>
            /// Enum REPROCESSINGSTARTED for value: REPROCESSING_STARTED
            /// </summary>
            [EnumMember(Value = "REPROCESSING_STARTED")]
            REPROCESSINGSTARTED = 10,
            
            /// <summary>
            /// Enum REPROCESSINGCANCELLED for value: REPROCESSING_CANCELLED
            /// </summary>
            [EnumMember(Value = "REPROCESSING_CANCELLED")]
            REPROCESSINGCANCELLED = 11,
            
            /// <summary>
            /// Enum REPROCESSINGFINISHED for value: REPROCESSING_FINISHED
            /// </summary>
            [EnumMember(Value = "REPROCESSING_FINISHED")]
            REPROCESSINGFINISHED = 12,
            
            /// <summary>
            /// Enum DISASSEMBLED for value: DISASSEMBLED
            /// </summary>
            [EnumMember(Value = "DISASSEMBLED")]
            DISASSEMBLED = 13,
            
            /// <summary>
            /// Enum MAINTENANCESTARTED for value: MAINTENANCE_STARTED
            /// </summary>
            [EnumMember(Value = "MAINTENANCE_STARTED")]
            MAINTENANCESTARTED = 14,
            
            /// <summary>
            /// Enum MAINTENANCECANCELLED for value: MAINTENANCE_CANCELLED
            /// </summary>
            [EnumMember(Value = "MAINTENANCE_CANCELLED")]
            MAINTENANCECANCELLED = 15,
            
            /// <summary>
            /// Enum MAINTENANCEFINISHED for value: MAINTENANCE_FINISHED
            /// </summary>
            [EnumMember(Value = "MAINTENANCE_FINISHED")]
            MAINTENANCEFINISHED = 16,
            
            /// <summary>
            /// Enum PRODUCTIONSTEPSTARTED for value: PRODUCTION_STEP_STARTED
            /// </summary>
            [EnumMember(Value = "PRODUCTION_STEP_STARTED")]
            PRODUCTIONSTEPSTARTED = 17,
            
            /// <summary>
            /// Enum PRODUCTIONSTEPCANCELLED for value: PRODUCTION_STEP_CANCELLED
            /// </summary>
            [EnumMember(Value = "PRODUCTION_STEP_CANCELLED")]
            PRODUCTIONSTEPCANCELLED = 18,
            
            /// <summary>
            /// Enum PRODUCTIONSTEPFINISHED for value: PRODUCTION_STEP_FINISHED
            /// </summary>
            [EnumMember(Value = "PRODUCTION_STEP_FINISHED")]
            PRODUCTIONSTEPFINISHED = 19
        }

        /// <summary>
        /// Type of the history item
        /// </summary>
        /// <value>Type of the history item</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HistoryItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryItem" /> class.
        /// </summary>
        /// <param name="AdditionalProperties">History items custom additional properties.</param>
        /// <param name="OrganizationId">Originator of the history item (required).</param>
        /// <param name="Type">Type of the history item (required).</param>
        /// <param name="Visibility">History item visibility restrictions.</param>
        public HistoryItem(Dictionary<string, string> AdditionalProperties = default(Dictionary<string, string>), string OrganizationId = default(string), TypeEnum Type = default(TypeEnum), Visibility Visibility = default(Visibility))
        {
            // to ensure "OrganizationId" is required (not null)
            if (OrganizationId == null)
            {
                throw new InvalidDataException("OrganizationId is a required property for HistoryItem and cannot be null");
            }
            else
            {
                this.OrganizationId = OrganizationId;
            }
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for HistoryItem and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            this.AdditionalProperties = AdditionalProperties;
            this.Visibility = Visibility;
        }
        
        /// <summary>
        /// History items custom additional properties
        /// </summary>
        /// <value>History items custom additional properties</value>
        [DataMember(Name="additionalProperties", EmitDefaultValue=false)]
        public Dictionary<string, string> AdditionalProperties { get; set; }

        /// <summary>
        /// Originator of the history item
        /// </summary>
        /// <value>Originator of the history item</value>
        [DataMember(Name="organizationId", EmitDefaultValue=false)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Forms the primary key of the history item together with the GUID and the organizationId
        /// </summary>
        /// <value>Forms the primary key of the history item together with the GUID and the organizationId</value>
        [DataMember(Name="sequenceId", EmitDefaultValue=false)]
        public int? SequenceId { get; private set; }

        /// <summary>
        /// History item timestamp
        /// </summary>
        /// <value>History item timestamp</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public long? Timestamp { get; private set; }


        /// <summary>
        /// History item visibility restrictions
        /// </summary>
        /// <value>History item visibility restrictions</value>
        [DataMember(Name="visibility", EmitDefaultValue=false)]
        public Visibility Visibility { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistoryItem {\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  SequenceId: ").Append(SequenceId).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Visibility: ").Append(Visibility).Append("\n");
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
            return this.Equals(input as HistoryItem);
        }

        /// <summary>
        /// Returns true if HistoryItem instances are equal
        /// </summary>
        /// <param name="input">Instance of HistoryItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistoryItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdditionalProperties == input.AdditionalProperties ||
                    this.AdditionalProperties != null &&
                    this.AdditionalProperties.SequenceEqual(input.AdditionalProperties)
                ) && 
                (
                    this.OrganizationId == input.OrganizationId ||
                    (this.OrganizationId != null &&
                    this.OrganizationId.Equals(input.OrganizationId))
                ) && 
                (
                    this.SequenceId == input.SequenceId ||
                    (this.SequenceId != null &&
                    this.SequenceId.Equals(input.SequenceId))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Visibility == input.Visibility ||
                    (this.Visibility != null &&
                    this.Visibility.Equals(input.Visibility))
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
                if (this.AdditionalProperties != null)
                    hashCode = hashCode * 59 + this.AdditionalProperties.GetHashCode();
                if (this.OrganizationId != null)
                    hashCode = hashCode * 59 + this.OrganizationId.GetHashCode();
                if (this.SequenceId != null)
                    hashCode = hashCode * 59 + this.SequenceId.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Visibility != null)
                    hashCode = hashCode * 59 + this.Visibility.GetHashCode();
                return hashCode;
            }
        }
    }

}
