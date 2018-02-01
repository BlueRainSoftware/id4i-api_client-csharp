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
  public class URL {
    /// <summary>
    /// Gets or Sets Authority
    /// </summary>
    [DataMember(Name="authority", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authority")]
    public string Authority { get; set; }

    /// <summary>
    /// Gets or Sets Content
    /// </summary>
    [DataMember(Name="content", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "content")]
    public Object Content { get; set; }

    /// <summary>
    /// Gets or Sets DefaultPort
    /// </summary>
    [DataMember(Name="defaultPort", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultPort")]
    public int? DefaultPort { get; set; }

    /// <summary>
    /// Gets or Sets File
    /// </summary>
    [DataMember(Name="file", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "file")]
    public string File { get; set; }

    /// <summary>
    /// Gets or Sets Host
    /// </summary>
    [DataMember(Name="host", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "host")]
    public string Host { get; set; }

    /// <summary>
    /// Gets or Sets Path
    /// </summary>
    [DataMember(Name="path", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "path")]
    public string Path { get; set; }

    /// <summary>
    /// Gets or Sets Port
    /// </summary>
    [DataMember(Name="port", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "port")]
    public int? Port { get; set; }

    /// <summary>
    /// Gets or Sets Protocol
    /// </summary>
    [DataMember(Name="protocol", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "protocol")]
    public string Protocol { get; set; }

    /// <summary>
    /// Gets or Sets Query
    /// </summary>
    [DataMember(Name="query", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "query")]
    public string Query { get; set; }

    /// <summary>
    /// Gets or Sets _Ref
    /// </summary>
    [DataMember(Name="ref", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ref")]
    public string _Ref { get; set; }

    /// <summary>
    /// Gets or Sets UserInfo
    /// </summary>
    [DataMember(Name="userInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userInfo")]
    public string UserInfo { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class URL {\n");
      sb.Append("  Authority: ").Append(Authority).Append("\n");
      sb.Append("  Content: ").Append(Content).Append("\n");
      sb.Append("  DefaultPort: ").Append(DefaultPort).Append("\n");
      sb.Append("  File: ").Append(File).Append("\n");
      sb.Append("  Host: ").Append(Host).Append("\n");
      sb.Append("  Path: ").Append(Path).Append("\n");
      sb.Append("  Port: ").Append(Port).Append("\n");
      sb.Append("  Protocol: ").Append(Protocol).Append("\n");
      sb.Append("  Query: ").Append(Query).Append("\n");
      sb.Append("  _Ref: ").Append(_Ref).Append("\n");
      sb.Append("  UserInfo: ").Append(UserInfo).Append("\n");
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
