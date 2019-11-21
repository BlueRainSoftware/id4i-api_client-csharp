/* 
 * ID4i API
 *
 * ID4i HTTP API
 *
 * OpenAPI spec version: 0.9.8-SNAPSHOT
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
    /// OrganizationAddress
    /// </summary>
    [DataContract]
    public partial class OrganizationAddress :  IEquatable<OrganizationAddress>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationAddress" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrganizationAddress() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationAddress" /> class.
        /// </summary>
        /// <param name="CompanyName">CompanyName.</param>
        /// <param name="Firstname">Firstname (required).</param>
        /// <param name="Lastname">Lastname (required).</param>
        /// <param name="Street">Street (required).</param>
        /// <param name="PostCode">PostCode (required).</param>
        /// <param name="City">City (required).</param>
        /// <param name="CountryCode">The ISO 3166 two-letter country code (required).</param>
        /// <param name="Telephone">The telephone number e.g..</param>
        public OrganizationAddress(string CompanyName = default(string), string Firstname = default(string), string Lastname = default(string), string Street = default(string), string PostCode = default(string), string City = default(string), string CountryCode = default(string), string Telephone = default(string))
        {
            // to ensure "Firstname" is required (not null)
            if (Firstname == null)
            {
                throw new InvalidDataException("Firstname is a required property for OrganizationAddress and cannot be null");
            }
            else
            {
                this.Firstname = Firstname;
            }
            // to ensure "Lastname" is required (not null)
            if (Lastname == null)
            {
                throw new InvalidDataException("Lastname is a required property for OrganizationAddress and cannot be null");
            }
            else
            {
                this.Lastname = Lastname;
            }
            // to ensure "Street" is required (not null)
            if (Street == null)
            {
                throw new InvalidDataException("Street is a required property for OrganizationAddress and cannot be null");
            }
            else
            {
                this.Street = Street;
            }
            // to ensure "PostCode" is required (not null)
            if (PostCode == null)
            {
                throw new InvalidDataException("PostCode is a required property for OrganizationAddress and cannot be null");
            }
            else
            {
                this.PostCode = PostCode;
            }
            // to ensure "City" is required (not null)
            if (City == null)
            {
                throw new InvalidDataException("City is a required property for OrganizationAddress and cannot be null");
            }
            else
            {
                this.City = City;
            }
            // to ensure "CountryCode" is required (not null)
            if (CountryCode == null)
            {
                throw new InvalidDataException("CountryCode is a required property for OrganizationAddress and cannot be null");
            }
            else
            {
                this.CountryCode = CountryCode;
            }
            this.CompanyName = CompanyName;
            this.Telephone = Telephone;
        }
        
        /// <summary>
        /// Gets or Sets CompanyName
        /// </summary>
        [DataMember(Name="companyName", EmitDefaultValue=false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or Sets Firstname
        /// </summary>
        [DataMember(Name="firstname", EmitDefaultValue=false)]
        public string Firstname { get; set; }

        /// <summary>
        /// Gets or Sets Lastname
        /// </summary>
        [DataMember(Name="lastname", EmitDefaultValue=false)]
        public string Lastname { get; set; }

        /// <summary>
        /// Gets or Sets Street
        /// </summary>
        [DataMember(Name="street", EmitDefaultValue=false)]
        public string Street { get; set; }

        /// <summary>
        /// Gets or Sets PostCode
        /// </summary>
        [DataMember(Name="postCode", EmitDefaultValue=false)]
        public string PostCode { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// The ISO 3166 two-letter country code
        /// </summary>
        /// <value>The ISO 3166 two-letter country code</value>
        [DataMember(Name="countryCode", EmitDefaultValue=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// The country name
        /// </summary>
        /// <value>The country name</value>
        [DataMember(Name="countryName", EmitDefaultValue=false)]
        public string CountryName { get; private set; }

        /// <summary>
        /// The telephone number e.g.
        /// </summary>
        /// <value>The telephone number e.g.</value>
        [DataMember(Name="telephone", EmitDefaultValue=false)]
        public string Telephone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrganizationAddress {\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  Firstname: ").Append(Firstname).Append("\n");
            sb.Append("  Lastname: ").Append(Lastname).Append("\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
            sb.Append("  PostCode: ").Append(PostCode).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  CountryName: ").Append(CountryName).Append("\n");
            sb.Append("  Telephone: ").Append(Telephone).Append("\n");
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
            return this.Equals(input as OrganizationAddress);
        }

        /// <summary>
        /// Returns true if OrganizationAddress instances are equal
        /// </summary>
        /// <param name="input">Instance of OrganizationAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrganizationAddress input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CompanyName == input.CompanyName ||
                    (this.CompanyName != null &&
                    this.CompanyName.Equals(input.CompanyName))
                ) && 
                (
                    this.Firstname == input.Firstname ||
                    (this.Firstname != null &&
                    this.Firstname.Equals(input.Firstname))
                ) && 
                (
                    this.Lastname == input.Lastname ||
                    (this.Lastname != null &&
                    this.Lastname.Equals(input.Lastname))
                ) && 
                (
                    this.Street == input.Street ||
                    (this.Street != null &&
                    this.Street.Equals(input.Street))
                ) && 
                (
                    this.PostCode == input.PostCode ||
                    (this.PostCode != null &&
                    this.PostCode.Equals(input.PostCode))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) && 
                (
                    this.CountryName == input.CountryName ||
                    (this.CountryName != null &&
                    this.CountryName.Equals(input.CountryName))
                ) && 
                (
                    this.Telephone == input.Telephone ||
                    (this.Telephone != null &&
                    this.Telephone.Equals(input.Telephone))
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
                if (this.CompanyName != null)
                    hashCode = hashCode * 59 + this.CompanyName.GetHashCode();
                if (this.Firstname != null)
                    hashCode = hashCode * 59 + this.Firstname.GetHashCode();
                if (this.Lastname != null)
                    hashCode = hashCode * 59 + this.Lastname.GetHashCode();
                if (this.Street != null)
                    hashCode = hashCode * 59 + this.Street.GetHashCode();
                if (this.PostCode != null)
                    hashCode = hashCode * 59 + this.PostCode.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.CountryName != null)
                    hashCode = hashCode * 59 + this.CountryName.GetHashCode();
                if (this.Telephone != null)
                    hashCode = hashCode * 59 + this.Telephone.GetHashCode();
                return hashCode;
            }
        }
    }

}
