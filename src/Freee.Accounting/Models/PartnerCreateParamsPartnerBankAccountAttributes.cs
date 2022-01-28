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
    /// PartnerCreateParamsPartnerBankAccountAttributes
    /// </summary>
    [DataContract(Name = "partnerCreateParams_partner_bank_account_attributes")]
    public partial class PartnerCreateParamsPartnerBankAccountAttributes : IEquatable<PartnerCreateParamsPartnerBankAccountAttributes>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PartnerCreateParamsPartnerBankAccountAttributes" /> class.
        /// </summary>
        /// <param name="accountName">受取人名（カナ）.</param>
        /// <param name="accountNumber">口座番号.</param>
        /// <param name="accountType">口座種別(ordinary:普通、checking：当座、earmarked：納税準備預金、savings：貯蓄、other:その他).</param>
        /// <param name="bankCode">銀行コード.</param>
        /// <param name="bankName">銀行名.</param>
        /// <param name="bankNameKana">銀行名（カナ）.</param>
        /// <param name="branchCode">支店番号.</param>
        /// <param name="branchKana">支店名（カナ）.</param>
        /// <param name="branchName">支店名.</param>
        /// <param name="longAccountName">受取人名.</param>
        public PartnerCreateParamsPartnerBankAccountAttributes(string accountName = default(string), string accountNumber = default(string), string accountType = default(string), string bankCode = default(string), string bankName = default(string), string bankNameKana = default(string), string branchCode = default(string), string branchKana = default(string), string branchName = default(string), string longAccountName = default(string))
        {
            this.AccountName = accountName;
            this.AccountNumber = accountNumber;
            this.AccountType = accountType;
            this.BankCode = bankCode;
            this.BankName = bankName;
            this.BankNameKana = bankNameKana;
            this.BranchCode = branchCode;
            this.BranchKana = branchKana;
            this.BranchName = branchName;
            this.LongAccountName = longAccountName;
        }

        /// <summary>
        /// 受取人名（カナ）
        /// </summary>
        /// <value>受取人名（カナ）</value>
        [DataMember(Name = "account_name", EmitDefaultValue = false)]
        public string AccountName { get; set; }

        /// <summary>
        /// 口座番号
        /// </summary>
        /// <value>口座番号</value>
        [DataMember(Name = "account_number", EmitDefaultValue = false)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// 口座種別(ordinary:普通、checking：当座、earmarked：納税準備預金、savings：貯蓄、other:その他)
        /// </summary>
        /// <value>口座種別(ordinary:普通、checking：当座、earmarked：納税準備預金、savings：貯蓄、other:その他)</value>
        [DataMember(Name = "account_type", EmitDefaultValue = false)]
        public string AccountType { get; set; }

        /// <summary>
        /// 銀行コード
        /// </summary>
        /// <value>銀行コード</value>
        [DataMember(Name = "bank_code", EmitDefaultValue = false)]
        public string BankCode { get; set; }

        /// <summary>
        /// 銀行名
        /// </summary>
        /// <value>銀行名</value>
        [DataMember(Name = "bank_name", EmitDefaultValue = false)]
        public string BankName { get; set; }

        /// <summary>
        /// 銀行名（カナ）
        /// </summary>
        /// <value>銀行名（カナ）</value>
        [DataMember(Name = "bank_name_kana", EmitDefaultValue = false)]
        public string BankNameKana { get; set; }

        /// <summary>
        /// 支店番号
        /// </summary>
        /// <value>支店番号</value>
        [DataMember(Name = "branch_code", EmitDefaultValue = false)]
        public string BranchCode { get; set; }

        /// <summary>
        /// 支店名（カナ）
        /// </summary>
        /// <value>支店名（カナ）</value>
        [DataMember(Name = "branch_kana", EmitDefaultValue = false)]
        public string BranchKana { get; set; }

        /// <summary>
        /// 支店名
        /// </summary>
        /// <value>支店名</value>
        [DataMember(Name = "branch_name", EmitDefaultValue = false)]
        public string BranchName { get; set; }

        /// <summary>
        /// 受取人名
        /// </summary>
        /// <value>受取人名</value>
        [DataMember(Name = "long_account_name", EmitDefaultValue = false)]
        public string LongAccountName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PartnerCreateParamsPartnerBankAccountAttributes {\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  AccountType: ").Append(AccountType).Append("\n");
            sb.Append("  BankCode: ").Append(BankCode).Append("\n");
            sb.Append("  BankName: ").Append(BankName).Append("\n");
            sb.Append("  BankNameKana: ").Append(BankNameKana).Append("\n");
            sb.Append("  BranchCode: ").Append(BranchCode).Append("\n");
            sb.Append("  BranchKana: ").Append(BranchKana).Append("\n");
            sb.Append("  BranchName: ").Append(BranchName).Append("\n");
            sb.Append("  LongAccountName: ").Append(LongAccountName).Append("\n");
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
            return this.Equals(input as PartnerCreateParamsPartnerBankAccountAttributes);
        }

        /// <summary>
        /// Returns true if PartnerCreateParamsPartnerBankAccountAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of PartnerCreateParamsPartnerBankAccountAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PartnerCreateParamsPartnerBankAccountAttributes input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountName == input.AccountName ||
                    (this.AccountName != null &&
                    this.AccountName.Equals(input.AccountName))
                ) && 
                (
                    this.AccountNumber == input.AccountNumber ||
                    (this.AccountNumber != null &&
                    this.AccountNumber.Equals(input.AccountNumber))
                ) && 
                (
                    this.AccountType == input.AccountType ||
                    (this.AccountType != null &&
                    this.AccountType.Equals(input.AccountType))
                ) && 
                (
                    this.BankCode == input.BankCode ||
                    (this.BankCode != null &&
                    this.BankCode.Equals(input.BankCode))
                ) && 
                (
                    this.BankName == input.BankName ||
                    (this.BankName != null &&
                    this.BankName.Equals(input.BankName))
                ) && 
                (
                    this.BankNameKana == input.BankNameKana ||
                    (this.BankNameKana != null &&
                    this.BankNameKana.Equals(input.BankNameKana))
                ) && 
                (
                    this.BranchCode == input.BranchCode ||
                    (this.BranchCode != null &&
                    this.BranchCode.Equals(input.BranchCode))
                ) && 
                (
                    this.BranchKana == input.BranchKana ||
                    (this.BranchKana != null &&
                    this.BranchKana.Equals(input.BranchKana))
                ) && 
                (
                    this.BranchName == input.BranchName ||
                    (this.BranchName != null &&
                    this.BranchName.Equals(input.BranchName))
                ) && 
                (
                    this.LongAccountName == input.LongAccountName ||
                    (this.LongAccountName != null &&
                    this.LongAccountName.Equals(input.LongAccountName))
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
                if (this.AccountName != null)
                {
                    hashCode = (hashCode * 59) + this.AccountName.GetHashCode();
                }
                if (this.AccountNumber != null)
                {
                    hashCode = (hashCode * 59) + this.AccountNumber.GetHashCode();
                }
                if (this.AccountType != null)
                {
                    hashCode = (hashCode * 59) + this.AccountType.GetHashCode();
                }
                if (this.BankCode != null)
                {
                    hashCode = (hashCode * 59) + this.BankCode.GetHashCode();
                }
                if (this.BankName != null)
                {
                    hashCode = (hashCode * 59) + this.BankName.GetHashCode();
                }
                if (this.BankNameKana != null)
                {
                    hashCode = (hashCode * 59) + this.BankNameKana.GetHashCode();
                }
                if (this.BranchCode != null)
                {
                    hashCode = (hashCode * 59) + this.BranchCode.GetHashCode();
                }
                if (this.BranchKana != null)
                {
                    hashCode = (hashCode * 59) + this.BranchKana.GetHashCode();
                }
                if (this.BranchName != null)
                {
                    hashCode = (hashCode * 59) + this.BranchName.GetHashCode();
                }
                if (this.LongAccountName != null)
                {
                    hashCode = (hashCode * 59) + this.LongAccountName.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
