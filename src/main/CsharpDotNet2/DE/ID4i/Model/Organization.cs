using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace  {

  /// <summary>
  /// An organization
  /// </summary>
  [DataContract]
  public class Organization {
    /// <summary>
    /// The id of the organization
    /// </summary>
    /// <value>The id of the organization</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// URL to a logo of the organization
    /// </summary>
    /// <value>URL to a logo of the organization</value>
    [DataMember(Name="logoURL", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "logoURL")]
    public string LogoURL { get; set; }

    /// <summary>
    /// The name of the organization
    /// </summary>
    /// <value>The name of the organization</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Organization {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  LogoURL: ").Append(LogoURL).Append("\n");
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
