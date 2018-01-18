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
  public class URI {
    /// <summary>
    /// Gets or Sets Absolute
    /// </summary>
    [DataMember(Name="absolute", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "absolute")]
    public bool? Absolute { get; set; }

    /// <summary>
    /// Gets or Sets Authority
    /// </summary>
    [DataMember(Name="authority", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authority")]
    public string Authority { get; set; }

    /// <summary>
    /// Gets or Sets Fragment
    /// </summary>
    [DataMember(Name="fragment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fragment")]
    public string Fragment { get; set; }

    /// <summary>
    /// Gets or Sets Host
    /// </summary>
    [DataMember(Name="host", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "host")]
    public string Host { get; set; }

    /// <summary>
    /// Gets or Sets Opaque
    /// </summary>
    [DataMember(Name="opaque", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "opaque")]
    public bool? Opaque { get; set; }

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
    /// Gets or Sets Query
    /// </summary>
    [DataMember(Name="query", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "query")]
    public string Query { get; set; }

    /// <summary>
    /// Gets or Sets RawAuthority
    /// </summary>
    [DataMember(Name="rawAuthority", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rawAuthority")]
    public string RawAuthority { get; set; }

    /// <summary>
    /// Gets or Sets RawFragment
    /// </summary>
    [DataMember(Name="rawFragment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rawFragment")]
    public string RawFragment { get; set; }

    /// <summary>
    /// Gets or Sets RawPath
    /// </summary>
    [DataMember(Name="rawPath", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rawPath")]
    public string RawPath { get; set; }

    /// <summary>
    /// Gets or Sets RawQuery
    /// </summary>
    [DataMember(Name="rawQuery", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rawQuery")]
    public string RawQuery { get; set; }

    /// <summary>
    /// Gets or Sets RawSchemeSpecificPart
    /// </summary>
    [DataMember(Name="rawSchemeSpecificPart", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rawSchemeSpecificPart")]
    public string RawSchemeSpecificPart { get; set; }

    /// <summary>
    /// Gets or Sets RawUserInfo
    /// </summary>
    [DataMember(Name="rawUserInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rawUserInfo")]
    public string RawUserInfo { get; set; }

    /// <summary>
    /// Gets or Sets Scheme
    /// </summary>
    [DataMember(Name="scheme", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scheme")]
    public string Scheme { get; set; }

    /// <summary>
    /// Gets or Sets SchemeSpecificPart
    /// </summary>
    [DataMember(Name="schemeSpecificPart", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "schemeSpecificPart")]
    public string SchemeSpecificPart { get; set; }

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
      sb.Append("class URI {\n");
      sb.Append("  Absolute: ").Append(Absolute).Append("\n");
      sb.Append("  Authority: ").Append(Authority).Append("\n");
      sb.Append("  Fragment: ").Append(Fragment).Append("\n");
      sb.Append("  Host: ").Append(Host).Append("\n");
      sb.Append("  Opaque: ").Append(Opaque).Append("\n");
      sb.Append("  Path: ").Append(Path).Append("\n");
      sb.Append("  Port: ").Append(Port).Append("\n");
      sb.Append("  Query: ").Append(Query).Append("\n");
      sb.Append("  RawAuthority: ").Append(RawAuthority).Append("\n");
      sb.Append("  RawFragment: ").Append(RawFragment).Append("\n");
      sb.Append("  RawPath: ").Append(RawPath).Append("\n");
      sb.Append("  RawQuery: ").Append(RawQuery).Append("\n");
      sb.Append("  RawSchemeSpecificPart: ").Append(RawSchemeSpecificPart).Append("\n");
      sb.Append("  RawUserInfo: ").Append(RawUserInfo).Append("\n");
      sb.Append("  Scheme: ").Append(Scheme).Append("\n");
      sb.Append("  SchemeSpecificPart: ").Append(SchemeSpecificPart).Append("\n");
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
