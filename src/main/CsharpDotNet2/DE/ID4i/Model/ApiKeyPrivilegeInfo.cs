using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace DE.ID4i.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ApiKeyPrivilegeInfo {
    /// <summary>
    /// Gets or Sets HelpText
    /// </summary>
    [DataMember(Name="helpText", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "helpText")]
    public string HelpText { get; set; }

    /// <summary>
    /// Gets or Sets Id4nAssociated
    /// </summary>
    [DataMember(Name="id4nAssociated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id4nAssociated")]
    public bool? Id4nAssociated { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ApiKeyPrivilegeInfo {\n");
      sb.Append("  HelpText: ").Append(HelpText).Append("\n");
      sb.Append("  Id4nAssociated: ").Append(Id4nAssociated).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
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
