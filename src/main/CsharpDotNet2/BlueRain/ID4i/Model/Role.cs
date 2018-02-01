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
  public class Role {
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Privileges
    /// </summary>
    [DataMember(Name="privileges", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "privileges")]
    public List<string> Privileges { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Role {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Privileges: ").Append(Privileges).Append("\n");
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
