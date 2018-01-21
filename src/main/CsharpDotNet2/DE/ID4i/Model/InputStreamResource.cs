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
  public class InputStreamResource {
    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets File
    /// </summary>
    [DataMember(Name="file", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "file")]
    public System.IO.Stream File { get; set; }

    /// <summary>
    /// Gets or Sets Filename
    /// </summary>
    [DataMember(Name="filename", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filename")]
    public string Filename { get; set; }

    /// <summary>
    /// Gets or Sets InputStream
    /// </summary>
    [DataMember(Name="inputStream", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inputStream")]
    public InputStream InputStream { get; set; }

    /// <summary>
    /// Gets or Sets Open
    /// </summary>
    [DataMember(Name="open", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "open")]
    public bool? Open { get; set; }

    /// <summary>
    /// Gets or Sets Readable
    /// </summary>
    [DataMember(Name="readable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "readable")]
    public bool? Readable { get; set; }

    /// <summary>
    /// Gets or Sets Uri
    /// </summary>
    [DataMember(Name="uri", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uri")]
    public URI Uri { get; set; }

    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public URL Url { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InputStreamResource {\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  File: ").Append(File).Append("\n");
      sb.Append("  Filename: ").Append(Filename).Append("\n");
      sb.Append("  InputStream: ").Append(InputStream).Append("\n");
      sb.Append("  Open: ").Append(Open).Append("\n");
      sb.Append("  Readable: ").Append(Readable).Append("\n");
      sb.Append("  Uri: ").Append(Uri).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
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
