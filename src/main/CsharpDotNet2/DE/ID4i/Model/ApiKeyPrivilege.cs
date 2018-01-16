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
  public class ApiKeyPrivilege {
    /// <summary>
    /// Gets or Sets Id4nAssociated
    /// </summary>
    [DataMember(Name="id4nAssociated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id4nAssociated")]
    public bool? Id4nAssociated { get; set; }

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
      sb.Append("class ApiKeyPrivilege {\n");
      sb.Append("  Id4nAssociated: ").Append(Id4nAssociated).Append("\n");
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
