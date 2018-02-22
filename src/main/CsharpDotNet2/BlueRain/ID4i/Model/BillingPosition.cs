using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BlueRain.ID4i.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class BillingPosition {
    /// <summary>
    /// Gets or Sets Count
    /// </summary>
    [DataMember(Name="count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "count")]
    public long? Count { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Service
    /// </summary>
    [DataMember(Name="service", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "service")]
    public string Service { get; set; }

    /// <summary>
    /// Gets or Sets Sum
    /// </summary>
    [DataMember(Name="sum", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sum")]
    public float? Sum { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BillingPosition {\n");
      sb.Append("  Count: ").Append(Count).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Service: ").Append(Service).Append("\n");
      sb.Append("  Sum: ").Append(Sum).Append("\n");
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
