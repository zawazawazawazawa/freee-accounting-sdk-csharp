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
    /// TrialCrSectionsResponseTrialCrSectionsSegment1Tags
    /// </summary>
    [DataContract(Name = "trialCrSectionsResponse_trial_cr_sections_segment_1_tags")]
    public partial class TrialCrSectionsResponseTrialCrSectionsSegment1Tags : IEquatable<TrialCrSectionsResponseTrialCrSectionsSegment1Tags>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrialCrSectionsResponseTrialCrSectionsSegment1Tags" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TrialCrSectionsResponseTrialCrSectionsSegment1Tags() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrialCrSectionsResponseTrialCrSectionsSegment1Tags" /> class.
        /// </summary>
        /// <param name="closingBalance">期末残高.</param>
        /// <param name="id">セグメント1タグID (required).</param>
        /// <param name="name">セグメント1タグ名.</param>
        public TrialCrSectionsResponseTrialCrSectionsSegment1Tags(int closingBalance = default(int), int id = default(int), string name = default(string))
        {
            this.Id = id;
            this.ClosingBalance = closingBalance;
            this.Name = name;
        }

        /// <summary>
        /// 期末残高
        /// </summary>
        /// <value>期末残高</value>
        [DataMember(Name = "closing_balance", EmitDefaultValue = false)]
        public int ClosingBalance { get; set; }

        /// <summary>
        /// セグメント1タグID
        /// </summary>
        /// <value>セグメント1タグID</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// セグメント1タグ名
        /// </summary>
        /// <value>セグメント1タグ名</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TrialCrSectionsResponseTrialCrSectionsSegment1Tags {\n");
            sb.Append("  ClosingBalance: ").Append(ClosingBalance).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as TrialCrSectionsResponseTrialCrSectionsSegment1Tags);
        }

        /// <summary>
        /// Returns true if TrialCrSectionsResponseTrialCrSectionsSegment1Tags instances are equal
        /// </summary>
        /// <param name="input">Instance of TrialCrSectionsResponseTrialCrSectionsSegment1Tags to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrialCrSectionsResponseTrialCrSectionsSegment1Tags input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ClosingBalance == input.ClosingBalance ||
                    this.ClosingBalance.Equals(input.ClosingBalance)
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                hashCode = (hashCode * 59) + this.ClosingBalance.GetHashCode();
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
