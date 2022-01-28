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
    /// InlineResponse20010
    /// </summary>
    [DataContract(Name = "inline_response_200_10")]
    public partial class InlineResponse20010 : IEquatable<InlineResponse20010>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20010" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineResponse20010() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20010" /> class.
        /// </summary>
        /// <param name="taxes">taxes (required).</param>
        public InlineResponse20010(List<InlineResponse20010Taxes> taxes = default(List<InlineResponse20010Taxes>))
        {
            // to ensure "taxes" is required (not null)
            if (taxes == null) {
                throw new ArgumentNullException("taxes is a required property for InlineResponse20010 and cannot be null");
            }
            this.Taxes = taxes;
        }

        /// <summary>
        /// Gets or Sets Taxes
        /// </summary>
        [DataMember(Name = "taxes", IsRequired = true, EmitDefaultValue = false)]
        public List<InlineResponse20010Taxes> Taxes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InlineResponse20010 {\n");
            sb.Append("  Taxes: ").Append(Taxes).Append("\n");
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
            return this.Equals(input as InlineResponse20010);
        }

        /// <summary>
        /// Returns true if InlineResponse20010 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse20010 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20010 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Taxes == input.Taxes ||
                    this.Taxes != null &&
                    input.Taxes != null &&
                    this.Taxes.SequenceEqual(input.Taxes)
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
                if (this.Taxes != null)
                {
                    hashCode = (hashCode * 59) + this.Taxes.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
