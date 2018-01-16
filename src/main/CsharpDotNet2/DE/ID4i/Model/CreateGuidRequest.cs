using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace DE.ID4i.Model {

  /// <summary>
  /// GUID creation information
  /// </summary>
  [DataContract]
  public class CreateGuidRequest {
    /// <summary>
    /// The total number of GUIDs to create
    /// </summary>
    /// <value>The total number of GUIDs to create</value>
    [DataMember(Name="count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "count")]
    public int? Count { get; set; }

    /// <summary>
    /// The charactersequence length of the GUID
    /// </summary>
    /// <value>The charactersequence length of the GUID</value>
    [DataMember(Name="length", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "length")]
    public int? Length { get; set; }

    /// <summary>
    /// The id of the organization where the generated GUIDs should be assigned.
    /// </summary>
    /// <value>The id of the organization where the generated GUIDs should be assigned.</value>
    [DataMember(Name="organizationId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "organizationId")]
    public long? OrganizationId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CreateGuidRequest {\n");
      sb.Append("  Count: ").Append(Count).Append("\n");
      sb.Append("  Length: ").Append(Length).Append("\n");
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
