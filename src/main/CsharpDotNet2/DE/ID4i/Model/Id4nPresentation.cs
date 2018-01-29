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
  public class Id4nPresentation {
    /// <summary>
    /// A unix timestamp of when this ID has been created
    /// </summary>
    /// <value>A unix timestamp of when this ID has been created</value>
    [DataMember(Name="createdTimestamp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdTimestamp")]
    public long? CreatedTimestamp { get; set; }

    /// <summary>
    /// The ID
    /// </summary>
    /// <value>The ID</value>
    [DataMember(Name="id4n", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id4n")]
    public string Id4n { get; set; }

    /// <summary>
    /// Gets or Sets Label
    /// </summary>
    [DataMember(Name="label", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "label")]
    public string Label { get; set; }

    /// <summary>
    /// Indicates if next scan ownership is active or not. If privileges are missing or the type of object doesn't support NSO this value is null.
    /// </summary>
    /// <value>Indicates if next scan ownership is active or not. If privileges are missing or the type of object doesn't support NSO this value is null.</value>
    [DataMember(Name="nextScanOwnership", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nextScanOwnership")]
    public bool? NextScanOwnership { get; set; }

    /// <summary>
    /// The type of ID
    /// </summary>
    /// <value>The type of ID</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Id4nPresentation {\n");
      sb.Append("  CreatedTimestamp: ").Append(CreatedTimestamp).Append("\n");
      sb.Append("  Id4n: ").Append(Id4n).Append("\n");
      sb.Append("  Label: ").Append(Label).Append("\n");
      sb.Append("  NextScanOwnership: ").Append(NextScanOwnership).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
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
