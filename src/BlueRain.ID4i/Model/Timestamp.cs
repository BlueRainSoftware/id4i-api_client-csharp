/* 
 * ID4i API
 *
 * ID4i HTTP API
 *
 * OpenAPI spec version: 0.8.6
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
    /// Timestamp
    /// </summary>
    [DataContract]
    public partial class Timestamp :  IEquatable<Timestamp>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Timestamp" /> class.
        /// </summary>
        /// <param name="Date">Date.</param>
        /// <param name="Day">Day.</param>
        /// <param name="Hours">Hours.</param>
        /// <param name="Minutes">Minutes.</param>
        /// <param name="Month">Month.</param>
        /// <param name="Nanos">Nanos.</param>
        /// <param name="Seconds">Seconds.</param>
        /// <param name="Time">Time.</param>
        /// <param name="TimezoneOffset">TimezoneOffset.</param>
        /// <param name="Year">Year.</param>
        public Timestamp(int? Date = default(int?), int? Day = default(int?), int? Hours = default(int?), int? Minutes = default(int?), int? Month = default(int?), int? Nanos = default(int?), int? Seconds = default(int?), long? Time = default(long?), int? TimezoneOffset = default(int?), int? Year = default(int?))
        {
            this.Date = Date;
            this.Day = Day;
            this.Hours = Hours;
            this.Minutes = Minutes;
            this.Month = Month;
            this.Nanos = Nanos;
            this.Seconds = Seconds;
            this.Time = Time;
            this.TimezoneOffset = TimezoneOffset;
            this.Year = Year;
        }
        
        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public int? Date { get; set; }

        /// <summary>
        /// Gets or Sets Day
        /// </summary>
        [DataMember(Name="day", EmitDefaultValue=false)]
        public int? Day { get; set; }

        /// <summary>
        /// Gets or Sets Hours
        /// </summary>
        [DataMember(Name="hours", EmitDefaultValue=false)]
        public int? Hours { get; set; }

        /// <summary>
        /// Gets or Sets Minutes
        /// </summary>
        [DataMember(Name="minutes", EmitDefaultValue=false)]
        public int? Minutes { get; set; }

        /// <summary>
        /// Gets or Sets Month
        /// </summary>
        [DataMember(Name="month", EmitDefaultValue=false)]
        public int? Month { get; set; }

        /// <summary>
        /// Gets or Sets Nanos
        /// </summary>
        [DataMember(Name="nanos", EmitDefaultValue=false)]
        public int? Nanos { get; set; }

        /// <summary>
        /// Gets or Sets Seconds
        /// </summary>
        [DataMember(Name="seconds", EmitDefaultValue=false)]
        public int? Seconds { get; set; }

        /// <summary>
        /// Gets or Sets Time
        /// </summary>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public long? Time { get; set; }

        /// <summary>
        /// Gets or Sets TimezoneOffset
        /// </summary>
        [DataMember(Name="timezoneOffset", EmitDefaultValue=false)]
        public int? TimezoneOffset { get; set; }

        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [DataMember(Name="year", EmitDefaultValue=false)]
        public int? Year { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Timestamp {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Day: ").Append(Day).Append("\n");
            sb.Append("  Hours: ").Append(Hours).Append("\n");
            sb.Append("  Minutes: ").Append(Minutes).Append("\n");
            sb.Append("  Month: ").Append(Month).Append("\n");
            sb.Append("  Nanos: ").Append(Nanos).Append("\n");
            sb.Append("  Seconds: ").Append(Seconds).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  TimezoneOffset: ").Append(TimezoneOffset).Append("\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
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
            return this.Equals(input as Timestamp);
        }

        /// <summary>
        /// Returns true if Timestamp instances are equal
        /// </summary>
        /// <param name="input">Instance of Timestamp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Timestamp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.Day == input.Day ||
                    (this.Day != null &&
                    this.Day.Equals(input.Day))
                ) && 
                (
                    this.Hours == input.Hours ||
                    (this.Hours != null &&
                    this.Hours.Equals(input.Hours))
                ) && 
                (
                    this.Minutes == input.Minutes ||
                    (this.Minutes != null &&
                    this.Minutes.Equals(input.Minutes))
                ) && 
                (
                    this.Month == input.Month ||
                    (this.Month != null &&
                    this.Month.Equals(input.Month))
                ) && 
                (
                    this.Nanos == input.Nanos ||
                    (this.Nanos != null &&
                    this.Nanos.Equals(input.Nanos))
                ) && 
                (
                    this.Seconds == input.Seconds ||
                    (this.Seconds != null &&
                    this.Seconds.Equals(input.Seconds))
                ) && 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                ) && 
                (
                    this.TimezoneOffset == input.TimezoneOffset ||
                    (this.TimezoneOffset != null &&
                    this.TimezoneOffset.Equals(input.TimezoneOffset))
                ) && 
                (
                    this.Year == input.Year ||
                    (this.Year != null &&
                    this.Year.Equals(input.Year))
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
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.Day != null)
                    hashCode = hashCode * 59 + this.Day.GetHashCode();
                if (this.Hours != null)
                    hashCode = hashCode * 59 + this.Hours.GetHashCode();
                if (this.Minutes != null)
                    hashCode = hashCode * 59 + this.Minutes.GetHashCode();
                if (this.Month != null)
                    hashCode = hashCode * 59 + this.Month.GetHashCode();
                if (this.Nanos != null)
                    hashCode = hashCode * 59 + this.Nanos.GetHashCode();
                if (this.Seconds != null)
                    hashCode = hashCode * 59 + this.Seconds.GetHashCode();
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.TimezoneOffset != null)
                    hashCode = hashCode * 59 + this.TimezoneOffset.GetHashCode();
                if (this.Year != null)
                    hashCode = hashCode * 59 + this.Year.GetHashCode();
                return hashCode;
            }
        }
    }

}
