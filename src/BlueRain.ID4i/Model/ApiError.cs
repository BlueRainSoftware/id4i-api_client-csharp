/* 
 * ID4i API
 *
 * ID4i HTTP API
 *
 * OpenAPI spec version: 0.9.7-SNAPSHOT
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
            /// Enum AUTHORIZATIONREQUIREUSER for value: ERR_AUTHORIZATION_REQUIRE_USER
            /// </summary>
            [EnumMember(Value = "ERR_AUTHORIZATION_REQUIRE_USER")]
            AUTHORIZATIONREQUIREUSER = 10,
            
            /// <summary>
            /// Enum INPUTVALIDATIONFAILED for value: ERR_INPUT_VALIDATION_FAILED
            /// </summary>
            [EnumMember(Value = "ERR_INPUT_VALIDATION_FAILED")]
            INPUTVALIDATIONFAILED = 11,
            
            /// <summary>
            /// Enum FIELDINPUTVALIDATIONFAILED for value: ERR_FIELD_INPUT_VALIDATION_FAILED
            /// </summary>
            [EnumMember(Value = "ERR_FIELD_INPUT_VALIDATION_FAILED")]
            FIELDINPUTVALIDATIONFAILED = 12,
            
            /// <summary>
            /// Enum VALIDATIONCONSTRAINTFAILED for value: ERR_VALIDATION_CONSTRAINT_FAILED
            /// </summary>
            [EnumMember(Value = "ERR_VALIDATION_CONSTRAINT_FAILED")]
            VALIDATIONCONSTRAINTFAILED = 13,
            
            /// <summary>
            /// Enum INPUTNOTREADABLE for value: ERR_INPUT_NOT_READABLE
            /// </summary>
            [EnumMember(Value = "ERR_INPUT_NOT_READABLE")]
            INPUTNOTREADABLE = 14,
            
            /// <summary>
            /// Enum INVALIDINPUTPARAMETER for value: ERR_INVALID_INPUT_PARAMETER
            /// </summary>
            [EnumMember(Value = "ERR_INVALID_INPUT_PARAMETER")]
            INVALIDINPUTPARAMETER = 15,
            
            /// <summary>
            /// Enum GUIDCREATION for value: ERR_GUID_CREATION
            /// </summary>
            [EnumMember(Value = "ERR_GUID_CREATION")]
            GUIDCREATION = 16,
            
            /// <summary>
            /// Enum INVALIDID4NOBJECTTYPE for value: ERR_INVALID_ID4N_OBJECT_TYPE
            /// </summary>
            [EnumMember(Value = "ERR_INVALID_ID4N_OBJECT_TYPE")]
            INVALIDID4NOBJECTTYPE = 17,
            
            /// <summary>
            /// Enum MISSINGBILLINGINFORMATION for value: ERR_MISSING_BILLING_INFORMATION
            /// </summary>
            [EnumMember(Value = "ERR_MISSING_BILLING_INFORMATION")]
            MISSINGBILLINGINFORMATION = 18,
            
            /// <summary>
            /// Enum COLLECTIONUPDATEDENIED for value: ERR_COLLECTION_UPDATE_DENIED
            /// </summary>
            [EnumMember(Value = "ERR_COLLECTION_UPDATE_DENIED")]
            COLLECTIONUPDATEDENIED = 19,
            
            /// <summary>
            /// Enum ENTITYNOTFOUND for value: ERR_ENTITY_NOT_FOUND
            /// </summary>
            [EnumMember(Value = "ERR_ENTITY_NOT_FOUND")]
            ENTITYNOTFOUND = 20,
            
            /// <summary>
            /// Enum ENTITYTOOBIG for value: ERR_ENTITY_TOO_BIG
            /// </summary>
            [EnumMember(Value = "ERR_ENTITY_TOO_BIG")]
            ENTITYTOOBIG = 21,
            
            /// <summary>
            /// Enum DUPLICATE for value: ERR_DUPLICATE
            /// </summary>
            [EnumMember(Value = "ERR_DUPLICATE")]
            DUPLICATE = 22,
            
            /// <summary>
            /// Enum INTERNAL for value: ERR_INTERNAL
            /// </summary>
            [EnumMember(Value = "ERR_INTERNAL")]
            INTERNAL = 23,
            
            /// <summary>
            /// Enum UNKNOWN for value: ERR_UNKNOWN
            /// </summary>
            [EnumMember(Value = "ERR_UNKNOWN")]
            UNKNOWN = 24,
            
            /// <summary>
            /// Enum INVALIDORGANIZATIONUSERROLE for value: ERR_INVALID_ORGANIZATION_USERROLE
            /// </summary>
            [EnumMember(Value = "ERR_INVALID_ORGANIZATION_USERROLE")]
            INVALIDORGANIZATIONUSERROLE = 25,
            
            /// <summary>
            /// Enum ORGANIZATIONROLEINCONSISTENCY for value: ERR_ORGANIZATION_ROLE_INCONSISTENCY
            /// </summary>
            [EnumMember(Value = "ERR_ORGANIZATION_ROLE_INCONSISTENCY")]
            ORGANIZATIONROLEINCONSISTENCY = 26,
            
            /// <summary>
            /// Enum ORGANIZATIONNOTDELETABLE for value: ERR_ORGANIZATION_NOT_DELETABLE
            /// </summary>
            [EnumMember(Value = "ERR_ORGANIZATION_NOT_DELETABLE")]
            ORGANIZATIONNOTDELETABLE = 27,
            
            /// <summary>
            /// Enum USERALREADYINORGANIZATION for value: ERR_USER_ALREADY_IN_ORGANIZATION
            /// </summary>
            [EnumMember(Value = "ERR_USER_ALREADY_IN_ORGANIZATION")]
            USERALREADYINORGANIZATION = 28,
            
            /// <summary>
            /// Enum USERINVITATIONNEEDSMINIMUMONEROLE for value: ERR_USER_INVITATION_NEEDS_MINIMUM_ONE_ROLE
            /// </summary>
            [EnumMember(Value = "ERR_USER_INVITATION_NEEDS_MINIMUM_ONE_ROLE")]
            USERINVITATIONNEEDSMINIMUMONEROLE = 29,
            
            /// <summary>
            /// Enum USERINVITATIONSPECIFYEMAILORUSERNAME for value: ERR_USER_INVITATION_SPECIFY_EMAIL_OR_USERNAME
            /// </summary>
            [EnumMember(Value = "ERR_USER_INVITATION_SPECIFY_EMAIL_OR_USERNAME")]
            USERINVITATIONSPECIFYEMAILORUSERNAME = 30,
            
            /// <summary>
            /// Enum USERDEACTIVATED for value: ERR_USER_DEACTIVATED
            /// </summary>
            [EnumMember(Value = "ERR_USER_DEACTIVATED")]
            USERDEACTIVATED = 31,
            
            /// <summary>
            /// Enum LANGUAGENOTSUPPORTED for value: ERR_LANGUAGE_NOT_SUPPORTED
            /// </summary>
            [EnumMember(Value = "ERR_LANGUAGE_NOT_SUPPORTED")]
            LANGUAGENOTSUPPORTED = 32,
            
            /// <summary>
            /// Enum EMAILMISSINGTEMPLATEPARAM for value: ERR_EMAIL_MISSING_TEMPLATE_PARAM
            /// </summary>
            [EnumMember(Value = "ERR_EMAIL_MISSING_TEMPLATE_PARAM")]
            EMAILMISSINGTEMPLATEPARAM = 33,
            
            /// <summary>
            /// Enum EMAILTEMPLATENOTAVAILABLE for value: ERR_EMAIL_TEMPLATE_NOT_AVAILABLE
            /// </summary>
            [EnumMember(Value = "ERR_EMAIL_TEMPLATE_NOT_AVAILABLE")]
            EMAILTEMPLATENOTAVAILABLE = 34,
            
            /// <summary>
            /// Enum EMAILPREPARATIONFAILED for value: ERR_EMAIL_PREPARATION_FAILED
            /// </summary>
            [EnumMember(Value = "ERR_EMAIL_PREPARATION_FAILED")]
            EMAILPREPARATIONFAILED = 35,
            
            /// <summary>
            /// Enum IMAGECONVERSION for value: ERR_IMAGE_CONVERSION
            /// </summary>
            [EnumMember(Value = "ERR_IMAGE_CONVERSION")]
            IMAGECONVERSION = 36,
            
            /// <summary>
            /// Enum UPLOADTOOLARGE for value: ERR_UPLOAD_TOO_LARGE
            /// </summary>
            [EnumMember(Value = "ERR_UPLOAD_TOO_LARGE")]
            UPLOADTOOLARGE = 37,
            
            /// <summary>
            /// Enum INVALIDALIASTYPE for value: ERR_INVALID_ALIAS_TYPE
            /// </summary>
            [EnumMember(Value = "ERR_INVALID_ALIAS_TYPE")]
            INVALIDALIASTYPE = 38,
            
            /// <summary>
            /// Enum INVALIDURITEMPLATE for value: ERR_INVALID_URI_TEMPLATE
            /// </summary>
            [EnumMember(Value = "ERR_INVALID_URI_TEMPLATE")]
            INVALIDURITEMPLATE = 39,
            
            /// <summary>
            /// Enum INVALIDURITEMPLATEVARIABLE for value: ERR_INVALID_URI_TEMPLATE_VARIABLE
            /// </summary>
            [EnumMember(Value = "ERR_INVALID_URI_TEMPLATE_VARIABLE")]
            INVALIDURITEMPLATEVARIABLE = 40,
            
            /// <summary>
            /// Enum INVALIDNAMESPACE for value: ERR_INVALID_NAMESPACE
            /// </summary>
            [EnumMember(Value = "ERR_INVALID_NAMESPACE")]
            INVALIDNAMESPACE = 41,
            
            /// <summary>
            /// Enum NAMESPACEALREADYEXISTS for value: ERR_NAMESPACE_ALREADY_EXISTS
            /// </summary>
            [EnumMember(Value = "ERR_NAMESPACE_ALREADY_EXISTS")]
            NAMESPACEALREADYEXISTS = 42,
            
            /// <summary>
            /// Enum INSECUREPASSWORD for value: ERR_INSECURE_PASSWORD
            /// </summary>
            [EnumMember(Value = "ERR_INSECURE_PASSWORD")]
            INSECUREPASSWORD = 43,
            
            /// <summary>
            /// Enum TRANSFERDENIED for value: ERR_TRANSFER_DENIED
            /// </summary>
            [EnumMember(Value = "ERR_TRANSFER_DENIED")]
            TRANSFERDENIED = 44,
            
            /// <summary>
            /// Enum INVALIDPHYSICALSTATE for value: ERR_INVALID_PHYSICAL_STATE
            /// </summary>
            [EnumMember(Value = "ERR_INVALID_PHYSICAL_STATE")]
            INVALIDPHYSICALSTATE = 45,
            
            /// <summary>
            /// Enum INVALIDHISTORYPROPERTYNAMESPACE for value: ERR_INVALID_HISTORY_PROPERTY_NAMESPACE
            /// </summary>
            [EnumMember(Value = "ERR_INVALID_HISTORY_PROPERTY_NAMESPACE")]
            INVALIDHISTORYPROPERTYNAMESPACE = 46,
            
            /// <summary>
            /// Enum INVALIDHISTORYPROPERTYVALUE for value: ERR_INVALID_HISTORY_PROPERTY_VALUE
            /// </summary>
            [EnumMember(Value = "ERR_INVALID_HISTORY_PROPERTY_VALUE")]
            INVALIDHISTORYPROPERTYVALUE = 47,
            
            /// <summary>
            /// Enum ORGACANNOTBEOWNPARTNER for value: ERR_ORGA_CANNOT_BE_OWN_PARTNER
            /// </summary>
            [EnumMember(Value = "ERR_ORGA_CANNOT_BE_OWN_PARTNER")]
            ORGACANNOTBEOWNPARTNER = 48,
            
            /// <summary>
            /// Enum INVALIDGS1CODE for value: ERR_INVALID_GS1_CODE
            /// </summary>
            [EnumMember(Value = "ERR_INVALID_GS1_CODE")]
            INVALIDGS1CODE = 49,
            
            /// <summary>
            /// Enum INVALIDGS1CHARINCODE for value: ERR_INVALID_GS1_CHAR_IN_CODE
            /// </summary>
            [EnumMember(Value = "ERR_INVALID_GS1_CHAR_IN_CODE")]
            INVALIDGS1CHARINCODE = 50,
            
            /// <summary>
            /// Enum INVALIDGS1CODENOTUNIQUE for value: ERR_INVALID_GS1_CODE_NOT_UNIQUE
            /// </summary>
            [EnumMember(Value = "ERR_INVALID_GS1_CODE_NOT_UNIQUE")]
            INVALIDGS1CODENOTUNIQUE = 51,
            
            /// <summary>
            /// Enum INVALIDGS1GTIN for value: ERR_INVALID_GS1_GTIN
            /// </summary>
            [EnumMember(Value = "ERR_INVALID_GS1_GTIN")]
            INVALIDGS1GTIN = 52,
            
            /// <summary>
            /// Enum GS1CODECURRENTLYUNSUPPORTED for value: ERR_GS1_CODE_CURRENTLY_UNSUPPORTED
            /// </summary>
            [EnumMember(Value = "ERR_GS1_CODE_CURRENTLY_UNSUPPORTED")]
            GS1CODECURRENTLYUNSUPPORTED = 53
        }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiError" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApiError() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiError" /> class.
        /// </summary>
        /// <param name="Code">Code (required).</param>
        /// <param name="ErrorList">ErrorList (required).</param>
        /// <param name="Message">Message (required).</param>
        /// <param name="ErrorId">ErrorId (required).</param>
        public ApiError(CodeEnum Code = default(CodeEnum), List<ApiError> ErrorList = default(List<ApiError>), string Message = default(string), string ErrorId = default(string))
        {
            // to ensure "Code" is required (not null)
            if (Code == null)
            {
                throw new InvalidDataException("Code is a required property for ApiError and cannot be null");
            }
            else
            {
                this.Code = Code;
            }
            // to ensure "ErrorList" is required (not null)
            if (ErrorList == null)
            {
                throw new InvalidDataException("ErrorList is a required property for ApiError and cannot be null");
            }
            else
            {
                this.ErrorList = ErrorList;
            }
            // to ensure "Message" is required (not null)
            if (Message == null)
            {
                throw new InvalidDataException("Message is a required property for ApiError and cannot be null");
            }
            else
            {
                this.Message = Message;
            }
            // to ensure "ErrorId" is required (not null)
            if (ErrorId == null)
            {
                throw new InvalidDataException("ErrorId is a required property for ApiError and cannot be null");
            }
            else
            {
                this.ErrorId = ErrorId;
            }
        }
        

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
        /// Gets or Sets ErrorId
        /// </summary>
        [DataMember(Name="errorId", EmitDefaultValue=false)]
        public string ErrorId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiError {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  ErrorList: ").Append(ErrorList).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  ErrorId: ").Append(ErrorId).Append("\n");
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
                    this.ErrorList == input.ErrorList ||
                    this.ErrorList != null &&
                    this.ErrorList.SequenceEqual(input.ErrorList)
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.ErrorId == input.ErrorId ||
                    (this.ErrorId != null &&
                    this.ErrorId.Equals(input.ErrorId))
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
                if (this.ErrorList != null)
                    hashCode = hashCode * 59 + this.ErrorList.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.ErrorId != null)
                    hashCode = hashCode * 59 + this.ErrorId.GetHashCode();
                return hashCode;
            }
        }
    }

}
