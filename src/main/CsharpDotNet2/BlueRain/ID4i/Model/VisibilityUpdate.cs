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
  public class VisibilityUpdate {
    /// <summary>
    /// Document is publicly readable (if ID4N is owned by the same organization)
    /// </summary>
    /// <value>Document is publicly readable (if ID4N is owned by the same organization)</value>
    [DataMember(Name="public", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "public")]
    public bool? _Public { get; set; }

    /// <summary>
    /// Document is readable by these organizations (independend of ID4N ownership)
    /// </summary>
    /// <value>Document is readable by these organizations (independend of ID4N ownership)</value>
    [DataMember(Name="sharedWithOrganizationIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sharedWithOrganizationIds")]
    public List<long?> SharedWithOrganizationIds { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class VisibilityUpdate {\n");
      sb.Append("  _Public: ").Append(_Public).Append("\n");
      sb.Append("  SharedWithOrganizationIds: ").Append(SharedWithOrganizationIds).Append("\n");
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
