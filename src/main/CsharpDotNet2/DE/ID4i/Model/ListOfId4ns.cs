using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace DE.ID4i.Model {

  /// <summary>
  /// A list of id4ns
  /// </summary>
  [DataContract]
  public class ListOfId4ns {
    /// <summary>
    /// A list of id4ns.
    /// </summary>
    /// <value>A list of id4ns.</value>
    [DataMember(Name="id4ns", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id4ns")]
    public List<string> Id4ns { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ListOfId4ns {\n");
      sb.Append("  Id4ns: ").Append(Id4ns).Append("\n");
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
