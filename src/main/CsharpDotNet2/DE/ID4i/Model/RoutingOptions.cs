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
  public class RoutingOptions {
    /// <summary>
    /// Gets or Sets DeleteOutdatedRoutes
    /// </summary>
    [DataMember(Name="deleteOutdatedRoutes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deleteOutdatedRoutes")]
    public bool? DeleteOutdatedRoutes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RoutingOptions {\n");
      sb.Append("  DeleteOutdatedRoutes: ").Append(DeleteOutdatedRoutes).Append("\n");
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
