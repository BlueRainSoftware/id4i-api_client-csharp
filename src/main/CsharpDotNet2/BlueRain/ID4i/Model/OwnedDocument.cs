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
  public class OwnedDocument {
    /// <summary>
    /// Gets or Sets Filename
    /// </summary>
    [DataMember(Name="filename", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filename")]
    public string Filename { get; set; }

    /// <summary>
    /// The organization's id which owns the document
    /// </summary>
    /// <value>The organization's id which owns the document</value>
    [DataMember(Name="ownerOrganizationId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ownerOrganizationId")]
    public long? OwnerOrganizationId { get; set; }

    /// <summary>
    /// Visibility configuration
    /// </summary>
    /// <value>Visibility configuration</value>
    [DataMember(Name="visibility", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "visibility")]
    public Visibility Visibility { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OwnedDocument {\n");
      sb.Append("  Filename: ").Append(Filename).Append("\n");
      sb.Append("  OwnerOrganizationId: ").Append(OwnerOrganizationId).Append("\n");
      sb.Append("  Visibility: ").Append(Visibility).Append("\n");
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
