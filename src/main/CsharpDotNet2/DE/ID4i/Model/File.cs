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
  public class File {
    /// <summary>
    /// Gets or Sets Absolute
    /// </summary>
    [DataMember(Name="absolute", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "absolute")]
    public bool? Absolute { get; set; }

    /// <summary>
    /// Gets or Sets AbsoluteFile
    /// </summary>
    [DataMember(Name="absoluteFile", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "absoluteFile")]
    public System.IO.Stream AbsoluteFile { get; set; }

    /// <summary>
    /// Gets or Sets AbsolutePath
    /// </summary>
    [DataMember(Name="absolutePath", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "absolutePath")]
    public string AbsolutePath { get; set; }

    /// <summary>
    /// Gets or Sets CanonicalFile
    /// </summary>
    [DataMember(Name="canonicalFile", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "canonicalFile")]
    public System.IO.Stream CanonicalFile { get; set; }

    /// <summary>
    /// Gets or Sets CanonicalPath
    /// </summary>
    [DataMember(Name="canonicalPath", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "canonicalPath")]
    public string CanonicalPath { get; set; }

    /// <summary>
    /// Gets or Sets Directory
    /// </summary>
    [DataMember(Name="directory", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "directory")]
    public bool? Directory { get; set; }

    /// <summary>
    /// Gets or Sets _File
    /// </summary>
    [DataMember(Name="file", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "file")]
    public bool? _File { get; set; }

    /// <summary>
    /// Gets or Sets FreeSpace
    /// </summary>
    [DataMember(Name="freeSpace", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "freeSpace")]
    public long? FreeSpace { get; set; }

    /// <summary>
    /// Gets or Sets Hidden
    /// </summary>
    [DataMember(Name="hidden", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hidden")]
    public bool? Hidden { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Parent
    /// </summary>
    [DataMember(Name="parent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parent")]
    public string Parent { get; set; }

    /// <summary>
    /// Gets or Sets ParentFile
    /// </summary>
    [DataMember(Name="parentFile", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parentFile")]
    public System.IO.Stream ParentFile { get; set; }

    /// <summary>
    /// Gets or Sets Path
    /// </summary>
    [DataMember(Name="path", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "path")]
    public string Path { get; set; }

    /// <summary>
    /// Gets or Sets TotalSpace
    /// </summary>
    [DataMember(Name="totalSpace", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalSpace")]
    public long? TotalSpace { get; set; }

    /// <summary>
    /// Gets or Sets UsableSpace
    /// </summary>
    [DataMember(Name="usableSpace", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "usableSpace")]
    public long? UsableSpace { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class File {\n");
      sb.Append("  Absolute: ").Append(Absolute).Append("\n");
      sb.Append("  AbsoluteFile: ").Append(AbsoluteFile).Append("\n");
      sb.Append("  AbsolutePath: ").Append(AbsolutePath).Append("\n");
      sb.Append("  CanonicalFile: ").Append(CanonicalFile).Append("\n");
      sb.Append("  CanonicalPath: ").Append(CanonicalPath).Append("\n");
      sb.Append("  Directory: ").Append(Directory).Append("\n");
      sb.Append("  _File: ").Append(_File).Append("\n");
      sb.Append("  FreeSpace: ").Append(FreeSpace).Append("\n");
      sb.Append("  Hidden: ").Append(Hidden).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Parent: ").Append(Parent).Append("\n");
      sb.Append("  ParentFile: ").Append(ParentFile).Append("\n");
      sb.Append("  Path: ").Append(Path).Append("\n");
      sb.Append("  TotalSpace: ").Append(TotalSpace).Append("\n");
      sb.Append("  UsableSpace: ").Append(UsableSpace).Append("\n");
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
