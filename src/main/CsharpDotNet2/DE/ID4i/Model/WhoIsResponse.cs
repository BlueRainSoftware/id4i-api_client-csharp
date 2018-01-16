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
  public class WhoIsResponse {
    /// <summary>
    /// Gets or Sets Aliases
    /// </summary>
    [DataMember(Name="aliases", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "aliases")]
    public Dictionary<string, string> Aliases { get; set; }

    /// <summary>
    /// Gets or Sets Organization
    /// </summary>
    [DataMember(Name="organization", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "organization")]
    public Organization Organization { get; set; }

    /// <summary>
    /// Gets or Sets OrganizationAddress
    /// </summary>
    [DataMember(Name="organizationAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "organizationAddress")]
    public OrganizationAddress OrganizationAddress { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WhoIsResponse {\n");
      sb.Append("  Aliases: ").Append(Aliases).Append("\n");
      sb.Append("  Organization: ").Append(Organization).Append("\n");
      sb.Append("  OrganizationAddress: ").Append(OrganizationAddress).Append("\n");
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
