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
  public class GuidAlias {
    /// <summary>
    /// Gets or Sets Alias
    /// </summary>
    [DataMember(Name="alias", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "alias")]
    public string Alias { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GuidAlias {\n");
      sb.Append("  Alias: ").Append(Alias).Append("\n");
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
