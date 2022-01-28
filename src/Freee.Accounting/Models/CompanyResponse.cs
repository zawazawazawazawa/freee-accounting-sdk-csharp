/*
 * freee API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using OpenAPIDateConverter = Freee.Accounting.Client.OpenAPIDateConverter;

namespace Freee.Accounting.Models
{
    /// <summary>
    /// CompanyResponse
    /// </summary>
    [DataContract(Name = "companyResponse")]
    public partial class CompanyResponse : IEquatable<CompanyResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CompanyResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyResponse" /> class.
        /// </summary>
        /// <param name="company">company (required).</param>
        public CompanyResponse(CompanyResponseCompany company = default(CompanyResponseCompany))
        {
            // to ensure "company" is required (not null)
            if (company == null) {
                throw new ArgumentNullException("company is a required property for CompanyResponse and cannot be null");
            }
            this.Company = company;
        }

        /// <summary>
        /// Gets or Sets Company
        /// </summary>
        [DataMember(Name = "company", IsRequired = true, EmitDefaultValue = false)]
        public CompanyResponseCompany Company { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CompanyResponse {\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CompanyResponse);
        }

        /// <summary>
        /// Returns true if CompanyResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CompanyResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanyResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
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
                if (this.Company != null)
                {
                    hashCode = (hashCode * 59) + this.Company.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
