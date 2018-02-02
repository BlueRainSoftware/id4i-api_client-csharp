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
  public class GuidCollection {
    /// <summary>
    /// The UTC unix timestamp of when this collection has been created
    /// </summary>
    /// <value>The UTC unix timestamp of when this collection has been created</value>
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
    /// Gets or Sets NextScanOwnership
    /// </summary>
    [DataMember(Name="nextScanOwnership", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nextScanOwnership")]
    public bool? NextScanOwnership { get; set; }

    /// <summary>
    /// Gets or Sets OwnerOrganizationId
    /// </summary>
    [DataMember(Name="ownerOrganizationId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ownerOrganizationId")]
    public long? OwnerOrganizationId { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GuidCollection {\n");
      sb.Append("  CreatedTimestamp: ").Append(CreatedTimestamp).Append("\n");
      sb.Append("  Id4n: ").Append(Id4n).Append("\n");
      sb.Append("  Label: ").Append(Label).Append("\n");
      sb.Append("  NextScanOwnership: ").Append(NextScanOwnership).Append("\n");
      sb.Append("  OwnerOrganizationId: ").Append(OwnerOrganizationId).Append("\n");
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
