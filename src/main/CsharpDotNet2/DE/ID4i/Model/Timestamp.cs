using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace  {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class Timestamp {
    /// <summary>
    /// Gets or Sets Date
    /// </summary>
    [DataMember(Name="date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date")]
    public int? Date { get; set; }

    /// <summary>
    /// Gets or Sets Day
    /// </summary>
    [DataMember(Name="day", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "day")]
    public int? Day { get; set; }

    /// <summary>
    /// Gets or Sets Hours
    /// </summary>
    [DataMember(Name="hours", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hours")]
    public int? Hours { get; set; }

    /// <summary>
    /// Gets or Sets Minutes
    /// </summary>
    [DataMember(Name="minutes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minutes")]
    public int? Minutes { get; set; }

    /// <summary>
    /// Gets or Sets Month
    /// </summary>
    [DataMember(Name="month", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "month")]
    public int? Month { get; set; }

    /// <summary>
    /// Gets or Sets Nanos
    /// </summary>
    [DataMember(Name="nanos", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nanos")]
    public int? Nanos { get; set; }

    /// <summary>
    /// Gets or Sets Seconds
    /// </summary>
    [DataMember(Name="seconds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "seconds")]
    public int? Seconds { get; set; }

    /// <summary>
    /// Gets or Sets Time
    /// </summary>
    [DataMember(Name="time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "time")]
    public long? Time { get; set; }

    /// <summary>
    /// Gets or Sets TimezoneOffset
    /// </summary>
    [DataMember(Name="timezoneOffset", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timezoneOffset")]
    public int? TimezoneOffset { get; set; }

    /// <summary>
    /// Gets or Sets Year
    /// </summary>
    [DataMember(Name="year", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "year")]
    public int? Year { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
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
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
