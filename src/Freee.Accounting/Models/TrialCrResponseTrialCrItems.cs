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
    /// TrialCrResponseTrialCrItems
    /// </summary>
    [DataContract(Name = "trialCrResponse_trial_cr_items")]
    public partial class TrialCrResponseTrialCrItems : IEquatable<TrialCrResponseTrialCrItems>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrialCrResponseTrialCrItems" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TrialCrResponseTrialCrItems() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrialCrResponseTrialCrItems" /> class.
        /// </summary>
        /// <param name="closingBalance">期末残高.</param>
        /// <param name="compositionRatio">構成比.</param>
        /// <param name="creditAmount">貸方金額.</param>
        /// <param name="debitAmount">借方金額.</param>
        /// <param name="id">品目ID (required).</param>
        /// <param name="name">品目.</param>
        /// <param name="openingBalance">期首残高.</param>
        public TrialCrResponseTrialCrItems(int closingBalance = default(int), decimal compositionRatio = default(decimal), int creditAmount = default(int), int debitAmount = default(int), int id = default(int), string name = default(string), int openingBalance = default(int))
        {
            this.Id = id;
            this.ClosingBalance = closingBalance;
            this.CompositionRatio = compositionRatio;
            this.CreditAmount = creditAmount;
            this.DebitAmount = debitAmount;
            this.Name = name;
            this.OpeningBalance = openingBalance;
        }

        /// <summary>
        /// 期末残高
        /// </summary>
        /// <value>期末残高</value>
        [DataMember(Name = "closing_balance", EmitDefaultValue = false)]
        public int ClosingBalance { get; set; }

        /// <summary>
        /// 構成比
        /// </summary>
        /// <value>構成比</value>
        [DataMember(Name = "composition_ratio", EmitDefaultValue = false)]
        public decimal CompositionRatio { get; set; }

        /// <summary>
        /// 貸方金額
        /// </summary>
        /// <value>貸方金額</value>
        [DataMember(Name = "credit_amount", EmitDefaultValue = false)]
        public int CreditAmount { get; set; }

        /// <summary>
        /// 借方金額
        /// </summary>
        /// <value>借方金額</value>
        [DataMember(Name = "debit_amount", EmitDefaultValue = false)]
        public int DebitAmount { get; set; }

        /// <summary>
        /// 品目ID
        /// </summary>
        /// <value>品目ID</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// 品目
        /// </summary>
        /// <value>品目</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// 期首残高
        /// </summary>
        /// <value>期首残高</value>
        [DataMember(Name = "opening_balance", EmitDefaultValue = false)]
        public int OpeningBalance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TrialCrResponseTrialCrItems {\n");
            sb.Append("  ClosingBalance: ").Append(ClosingBalance).Append("\n");
            sb.Append("  CompositionRatio: ").Append(CompositionRatio).Append("\n");
            sb.Append("  CreditAmount: ").Append(CreditAmount).Append("\n");
            sb.Append("  DebitAmount: ").Append(DebitAmount).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OpeningBalance: ").Append(OpeningBalance).Append("\n");
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
            return this.Equals(input as TrialCrResponseTrialCrItems);
        }

        /// <summary>
        /// Returns true if TrialCrResponseTrialCrItems instances are equal
        /// </summary>
        /// <param name="input">Instance of TrialCrResponseTrialCrItems to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrialCrResponseTrialCrItems input)
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
                    this.CompositionRatio == input.CompositionRatio ||
                    this.CompositionRatio.Equals(input.CompositionRatio)
                ) && 
                (
                    this.CreditAmount == input.CreditAmount ||
                    this.CreditAmount.Equals(input.CreditAmount)
                ) && 
                (
                    this.DebitAmount == input.DebitAmount ||
                    this.DebitAmount.Equals(input.DebitAmount)
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OpeningBalance == input.OpeningBalance ||
                    this.OpeningBalance.Equals(input.OpeningBalance)
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
                hashCode = (hashCode * 59) + this.CompositionRatio.GetHashCode();
                hashCode = (hashCode * 59) + this.CreditAmount.GetHashCode();
                hashCode = (hashCode * 59) + this.DebitAmount.GetHashCode();
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.OpeningBalance.GetHashCode();
                return hashCode;
            }
        }

    }

}
