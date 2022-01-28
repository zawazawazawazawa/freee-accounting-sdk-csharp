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
    /// Tax
    /// </summary>
    [DataContract(Name = "tax")]
    public partial class Tax : IEquatable<Tax>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tax" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Tax() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Tax" /> class.
        /// </summary>
        /// <param name="code">税区分コード (required).</param>
        /// <param name="name">税区分名 (required).</param>
        /// <param name="nameJa">税区分名（日本語表示用） (required).</param>
        public Tax(int code = default(int), string name = default(string), string nameJa = default(string))
        {
            this.Code = code;
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for Tax and cannot be null");
            }
            this.Name = name;
            // to ensure "nameJa" is required (not null)
            if (nameJa == null) {
                throw new ArgumentNullException("nameJa is a required property for Tax and cannot be null");
            }
            this.NameJa = nameJa;
        }

        /// <summary>
        /// 税区分コード
        /// </summary>
        /// <value>税区分コード</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = false)]
        public int Code { get; set; }

        /// <summary>
        /// 税区分名
        /// </summary>
        /// <value>税区分名</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// 税区分名（日本語表示用）
        /// </summary>
        /// <value>税区分名（日本語表示用）</value>
        [DataMember(Name = "name_ja", IsRequired = true, EmitDefaultValue = false)]
        public string NameJa { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Tax {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NameJa: ").Append(NameJa).Append("\n");
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
            return this.Equals(input as Tax);
        }

        /// <summary>
        /// Returns true if Tax instances are equal
        /// </summary>
        /// <param name="input">Instance of Tax to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Tax input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Code == input.Code ||
                    this.Code.Equals(input.Code)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NameJa == input.NameJa ||
                    (this.NameJa != null &&
                    this.NameJa.Equals(input.NameJa))
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
                hashCode = (hashCode * 59) + this.Code.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.NameJa != null)
                {
                    hashCode = (hashCode * 59) + this.NameJa.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
