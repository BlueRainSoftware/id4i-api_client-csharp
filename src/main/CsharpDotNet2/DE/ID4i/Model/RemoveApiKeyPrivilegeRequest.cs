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
  public class RemoveApiKeyPrivilegeRequest {
    /// <summary>
    /// Gets or Sets Privilege
    /// </summary>
    [DataMember(Name="privilege", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "privilege")]
    public string Privilege { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RemoveApiKeyPrivilegeRequest {\n");
      sb.Append("  Privilege: ").Append(Privilege).Append("\n");
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
