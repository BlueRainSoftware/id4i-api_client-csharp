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
  public class RoutingFileRequest {
    /// <summary>
    /// Gets or Sets Routing
    /// </summary>
    [DataMember(Name="routing", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "routing")]
    public RoutingFile Routing { get; set; }

    /// <summary>
    /// Gets or Sets OrganizationId
    /// </summary>
    [DataMember(Name="organizationId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "organizationId")]
    public long? OrganizationId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RoutingFileRequest {\n");
      sb.Append("  Routing: ").Append(Routing).Append("\n");
      sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
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
