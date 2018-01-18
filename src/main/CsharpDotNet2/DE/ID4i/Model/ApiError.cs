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
  public class ApiError {
    /// <summary>
    /// Gets or Sets Code
    /// </summary>
    [DataMember(Name="code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "code")]
    public string Code { get; set; }

    /// <summary>
    /// Gets or Sets ErrorId
    /// </summary>
    [DataMember(Name="errorId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "errorId")]
    public string ErrorId { get; set; }

    /// <summary>
    /// Gets or Sets ErrorList
    /// </summary>
    [DataMember(Name="errorList", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "errorList")]
    public List<ApiError> ErrorList { get; set; }

    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ApiError {\n");
      sb.Append("  Code: ").Append(Code).Append("\n");
      sb.Append("  ErrorId: ").Append(ErrorId).Append("\n");
      sb.Append("  ErrorList: ").Append(ErrorList).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
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
