/* 
 * ID4i API
 *
 * ID4i HTTP API
 *
 * OpenAPI spec version: 0.2.5-SNAPSHOT
 * Contact: info@bluerain.de
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = BlueRain.ID4i.Client.SwaggerDateConverter;

namespace BlueRain.ID4i.Model
{
    /// <summary>
    /// ApiError
    /// </summary>
    [DataContract]
    public partial class ApiError :  IEquatable<ApiError>
    {
        /// <summary>
        /// Defines Code
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            
            /// <summary>
            /// Enum REGISTRATIONVERIFICATIONNOTOKEN for value: ERR_REGISTRATION_VERIFICATION_NO_TOKEN
            /// </summary>
            [EnumMember(Value = "ERR_REGISTRATION_VERIFICATION_NO_TOKEN")]
            REGISTRATIONVERIFICATIONNOTOKEN = 1,
            
            /// <summary>
            /// Enum REGISTRATIONVERIFICATIONINVALIDTOKEN for value: ERR_REGISTRATION_VERIFICATION_INVALID_TOKEN
            /// </summary>
            [EnumMember(Value = "ERR_REGISTRATION_VERIFICATION_INVALID_TOKEN")]
            REGISTRATIONVERIFICATIONINVALIDTOKEN = 2,
            
            /// <summary>
            /// Enum REGISTRATIONVERIFICATIONEXPIREDTOKEN for value: ERR_REGISTRATION_VERIFICATION_EXPIRED_TOKEN
            /// </summary>
            [EnumMember(Value = "ERR_REGISTRATION_VERIFICATION_EXPIRED_TOKEN")]
            REGISTRATIONVERIFICATIONEXPIREDTOKEN = 3,
            
            /// <summary>
            /// Enum AUTHENTICATIONNOTOKEN for value: ERR_AUTHENTICATION_NO_TOKEN
            /// </summary>
            [EnumMember(Value = "ERR_AUTHENTICATION_NO_TOKEN")]
            AUTHENTICATIONNOTOKEN = 4,
            
            /// <summary>
            /// Enum AUTHENTICATIONINVALIDTOKEN for value: ERR_AUTHENTICATION_INVALID_TOKEN
            /// </summary>
            [EnumMember(Value = "ERR_AUTHENTICATION_INVALID_TOKEN")]
            AUTHENTICATIONINVALIDTOKEN = 5,
            
            /// <summary>
            /// Enum AUTHENTICATIONEXPIREDTOKEN for value: ERR_AUTHENTICATION_EXPIRED_TOKEN
            /// </summary>
            [EnumMember(Value = "ERR_AUTHENTICATION_EXPIRED_TOKEN")]
            AUTHENTICATIONEXPIREDTOKEN = 6,
            
            /// <summary>
            /// Enum AUTHENTICATIONFAILED for value: ERR_AUTHENTICATION_FAILED
            /// </summary>
            [EnumMember(Value = "ERR_AUTHENTICATION_FAILED")]
            AUTHENTICATIONFAILED = 7,
            
            /// <summary>
            /// Enum AUTHORIZATIONMISSINGPRIVILEGES for value: ERR_AUTHORIZATION_MISSING_PRIVILEGES
            /// </summary>
            [EnumMember(Value = "ERR_AUTHORIZATION_MISSING_PRIVILEGES")]
            AUTHORIZATIONMISSINGPRIVILEGES = 8,
            
            /// <summary>
            /// Enum AUTHORIZATIONFORBIDDEN for value: ERR_AUTHORIZATION_FORBIDDEN
            /// </summary>
            [EnumMember(Value = "ERR_AUTHORIZATION_FORBIDDEN")]
            AUTHORIZATIONFORBIDDEN = 9,
            
            /// <summary>
            /// Enum INPUTVALIDATIONFAILED for value: ERR_INPUT_VALIDATION_FAILED
            /// </summary>
            [EnumMember(Value = "ERR_INPUT_VALIDATION_FAILED")]
            INPUTVALIDATIONFAILED = 10,
            
            /// <summary>
            /// Enum FIELDINPUTVALIDATIONFAILED for value: ERR_FIELD_INPUT_VALIDATION_FAILED
            /// </summary>
            [EnumMember(Value = "ERR_FIELD_INPUT_VALIDATION_FAILED")]
            FIELDINPUTVALIDATIONFAILED = 11,
            
            /// <summary>
            /// Enum VALIDATIONCONSTRAINTFAILED for value: ERR_VALIDATION_CONSTRAINT_FAILED
            /// </summary>
            [EnumMember(Value = "ERR_VALIDATION_CONSTRAINT_FAILED")]
            VALIDATIONCONSTRAINTFAILED = 12,
            
            /// <summary>
            /// Enum INPUTNOTREADABLE for value: ERR_INPUT_NOT_READABLE
            /// </summary>
            [EnumMember(Value = "ERR_INPUT_NOT_READABLE")]
            INPUTNOTREADABLE = 13,
            
            /// <summary>
            /// Enum INVALIDINPUTPARAMETER for value: ERR_INVALID_INPUT_PARAMETER
            /// </summary>
            [EnumMember(Value = "ERR_INVALID_INPUT_PARAMETER")]
            INVALIDINPUTPARAMETER = 14,
            
            /// <summary>
            /// Enum GUIDCREATION for value: ERR_GUID_CREATION
            /// </summary>
            [EnumMember(Value = "ERR_GUID_CREATION")]
            GUIDCREATION = 15,
            
            /// <summary>
            /// Enum INVALIDID4NOBJECTTYPE for value: ERR_INVALID_ID4N_OBJECT_TYPE
            /// </summary>
            [EnumMember(Value = "ERR_INVALID_ID4N_OBJECT_TYPE")]
            INVALIDID4NOBJECTTYPE = 16,
            
            /// <summary>
            /// Enum COLLECTIONUPDATEDENIED for value: ERR_COLLECTION_UPDATE_DENIED
            /// </summary>
            [EnumMember(Value = "ERR_COLLECTION_UPDATE_DENIED")]
            COLLECTIONUPDATEDENIED = 17,
            
            /// <summary>
            /// Enum ENTITYNOTFOUND for value: ERR_ENTITY_NOT_FOUND
            /// </summary>
            [EnumMember(Value = "ERR_ENTITY_NOT_FOUND")]
            ENTITYNOTFOUND = 18,
            
            /// <summary>
            /// Enum ENTITYTOOBIG for value: ERR_ENTITY_TOO_BIG
            /// </summary>
            [EnumMember(Value = "ERR_ENTITY_TOO_BIG")]
            ENTITYTOOBIG = 19,
            
            /// <summary>
            /// Enum DUPLICATE for value: ERR_DUPLICATE
            /// </summary>
            [EnumMember(Value = "ERR_DUPLICATE")]
            DUPLICATE = 20,
            
            /// <summary>
            /// Enum INTERNAL for value: ERR_INTERNAL
            /// </summary>
            [EnumMember(Value = "ERR_INTERNAL")]
            INTERNAL = 21,
            
            /// <summary>
            /// Enum UNKNOWN for value: ERR_UNKNOWN
            /// </summary>
            [EnumMember(Value = "ERR_UNKNOWN")]
            UNKNOWN = 22,
            
            /// <summary>
            /// Enum INVALIDORGANIZATIONUSERROLE for value: ERR_INVALID_ORGANIZATION_USERROLE
            /// </summary>
            [EnumMember(Value = "ERR_INVALID_ORGANIZATION_USERROLE")]
            INVALIDORGANIZATIONUSERROLE = 23,
            
            /// <summary>
            /// Enum ORGANIZATIONROLEINCONSISTENCY for value: ERR_ORGANIZATION_ROLE_INCONSISTENCY
            /// </summary>
            [EnumMember(Value = "ERR_ORGANIZATION_ROLE_INCONSISTENCY")]
            ORGANIZATIONROLEINCONSISTENCY = 24,
            
            /// <summary>
            /// Enum ORGANIZATIONNOTDELETABLE for value: ERR_ORGANIZATION_NOT_DELETABLE
            /// </summary>
            [EnumMember(Value = "ERR_ORGANIZATION_NOT_DELETABLE")]
            ORGANIZATIONNOTDELETABLE = 25,
            
            /// <summary>
            /// Enum USERALREADYINORGANIZATION for value: ERR_USER_ALREADY_IN_ORGANIZATION
            /// </summary>
            [EnumMember(Value = "ERR_USER_ALREADY_IN_ORGANIZATION")]
            USERALREADYINORGANIZATION = 26,
            
            /// <summary>
            /// Enum USERINVITATIONNEEDSMINIMUMONEROLE for value: ERR_USER_INVITATION_NEEDS_MINIMUM_ONE_ROLE
            /// </summary>
            [EnumMember(Value = "ERR_USER_INVITATION_NEEDS_MINIMUM_ONE_ROLE")]
            USERINVITATIONNEEDSMINIMUMONEROLE = 27,
            
            /// <summary>
            /// Enum USERINVITATIONSPECIFYEMAILORUSERNAME for value: ERR_USER_INVITATION_SPECIFY_EMAIL_OR_USERNAME
            /// </summary>
            [EnumMember(Value = "ERR_USER_INVITATION_SPECIFY_EMAIL_OR_USERNAME")]
            USERINVITATIONSPECIFYEMAILORUSERNAME = 28,
            
            /// <summary>
            /// Enum LANGUAGENOTSUPPORTED for value: ERR_LANGUAGE_NOT_SUPPORTED
            /// </summary>
            [EnumMember(Value = "ERR_LANGUAGE_NOT_SUPPORTED")]
            LANGUAGENOTSUPPORTED = 29,
            
            /// <summary>
            /// Enum EMAILMISSINGTEMPLATEPARAM for value: ERR_EMAIL_MISSING_TEMPLATE_PARAM
            /// </summary>
            [EnumMember(Value = "ERR_EMAIL_MISSING_TEMPLATE_PARAM")]
            EMAILMISSINGTEMPLATEPARAM = 30,
            
            /// <summary>
            /// Enum EMAILTEMPLATENOTAVAILABLE for value: ERR_EMAIL_TEMPLATE_NOT_AVAILABLE
            /// </summary>
            [EnumMember(Value = "ERR_EMAIL_TEMPLATE_NOT_AVAILABLE")]
            EMAILTEMPLATENOTAVAILABLE = 31,
            
            /// <summary>
            /// Enum EMAILPREPARATIONFAILED for value: ERR_EMAIL_PREPARATION_FAILED
            /// </summary>
            [EnumMember(Value = "ERR_EMAIL_PREPARATION_FAILED")]
            EMAILPREPARATIONFAILED = 32,
            
            /// <summary>
            /// Enum IMAGECONVERSION for value: ERR_IMAGE_CONVERSION
            /// </summary>
            [EnumMember(Value = "ERR_IMAGE_CONVERSION")]
            IMAGECONVERSION = 33,
            
            /// <summary>
            /// Enum UPLOADTOOLARGE for value: ERR_UPLOAD_TOO_LARGE
            /// </summary>
            [EnumMember(Value = "ERR_UPLOAD_TOO_LARGE")]
            UPLOADTOOLARGE = 34,
            
            /// <summary>
            /// Enum INVALIDALIASTYPE for value: ERR_INVALID_ALIAS_TYPE
            /// </summary>
            [EnumMember(Value = "ERR_INVALID_ALIAS_TYPE")]
            INVALIDALIASTYPE = 35,
            
            /// <summary>
            /// Enum INVALIDURITEMPLATE for value: ERR_INVALID_URI_TEMPLATE
            /// </summary>
            [EnumMember(Value = "ERR_INVALID_URI_TEMPLATE")]
            INVALIDURITEMPLATE = 36,
            
            /// <summary>
            /// Enum INVALIDURITEMPLATEVARIABLE for value: ERR_INVALID_URI_TEMPLATE_VARIABLE
            /// </summary>
            [EnumMember(Value = "ERR_INVALID_URI_TEMPLATE_VARIABLE")]
            INVALIDURITEMPLATEVARIABLE = 37,
            
            /// <summary>
            /// Enum MODULENOTACTIVE for value: ERR_MODULE_NOT_ACTIVE
            /// </summary>
            [EnumMember(Value = "ERR_MODULE_NOT_ACTIVE")]
            MODULENOTACTIVE = 38,
            
            /// <summary>
            /// Enum INSECUREPASSWORD for value: ERR_INSECURE_PASSWORD
            /// </summary>
            [EnumMember(Value = "ERR_INSECURE_PASSWORD")]
            INSECUREPASSWORD = 39
        }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public CodeEnum? Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiError" /> class.
        /// </summary>
        /// <param name="Code">Code.</param>
        /// <param name="ErrorId">ErrorId.</param>
        /// <param name="ErrorList">ErrorList.</param>
        /// <param name="Message">Message.</param>
        public ApiError(CodeEnum? Code = default(CodeEnum?), string ErrorId = default(string), List<ApiError> ErrorList = default(List<ApiError>), string Message = default(string))
        {
            this.Code = Code;
            this.ErrorId = ErrorId;
            this.ErrorList = ErrorList;
            this.Message = Message;
        }
        

        /// <summary>
        /// Gets or Sets ErrorId
        /// </summary>
        [DataMember(Name="errorId", EmitDefaultValue=false)]
        public string ErrorId { get; set; }

        /// <summary>
        /// Gets or Sets ErrorList
        /// </summary>
        [DataMember(Name="errorList", EmitDefaultValue=false)]
        public List<ApiError> ErrorList { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
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
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ApiError);
        }

        /// <summary>
        /// Returns true if ApiError instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiError input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.ErrorId == input.ErrorId ||
                    (this.ErrorId != null &&
                    this.ErrorId.Equals(input.ErrorId))
                ) && 
                (
                    this.ErrorList == input.ErrorList ||
                    this.ErrorList != null &&
                    this.ErrorList.SequenceEqual(input.ErrorList)
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.ErrorId != null)
                    hashCode = hashCode * 59 + this.ErrorId.GetHashCode();
                if (this.ErrorList != null)
                    hashCode = hashCode * 59 + this.ErrorList.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                return hashCode;
            }
        }
    }

}
