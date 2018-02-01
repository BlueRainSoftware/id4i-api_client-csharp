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
  public class AppInfoPresentation {
    /// <summary>
    /// Gets or Sets Branch
    /// </summary>
    [DataMember(Name="branch", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "branch")]
    public string Branch { get; set; }

    /// <summary>
    /// Gets or Sets CommitTime
    /// </summary>
    [DataMember(Name="commitTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commitTime")]
    public string CommitTime { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Revision
    /// </summary>
    [DataMember(Name="revision", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "revision")]
    public string Revision { get; set; }

    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    [DataMember(Name="version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "version")]
    public string Version { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AppInfoPresentation {\n");
      sb.Append("  Branch: ").Append(Branch).Append("\n");
      sb.Append("  CommitTime: ").Append(CommitTime).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Revision: ").Append(Revision).Append("\n");
      sb.Append("  Version: ").Append(Version).Append("\n");
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
