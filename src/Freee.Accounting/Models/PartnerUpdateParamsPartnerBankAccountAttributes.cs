// <auto-generated>
// Copyright (c) freee K.K. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license
// information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
//
// </auto-generated>

namespace Freee.Accounting.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class PartnerUpdateParamsPartnerBankAccountAttributes
    {
        /// <summary>
        /// Initializes a new instance of the
        /// PartnerUpdateParamsPartnerBankAccountAttributes class.
        /// </summary>
        public PartnerUpdateParamsPartnerBankAccountAttributes()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// PartnerUpdateParamsPartnerBankAccountAttributes class.
        /// </summary>
        /// <param name="bankName">銀行名</param>
        /// <param name="bankNameKana">銀行名（カナ）</param>
        /// <param name="bankCode">銀行番号</param>
        /// <param name="branchName">支店名</param>
        /// <param name="branchKana">支店名（カナ）</param>
        /// <param name="branchCode">支店番号</param>
        /// <param
        /// name="accountType">口座種別(ordinary:普通、checking：当座、earmarked：納税準備預金、savings：貯蓄、other:その他)</param>
        /// <param name="accountNumber">口座番号</param>
        /// <param name="longAccountName">受取人名</param>
        /// <param name="accountName">受取人名（カナ）</param>
        public PartnerUpdateParamsPartnerBankAccountAttributes(string bankName = default(string), string bankNameKana = default(string), string bankCode = default(string), string branchName = default(string), string branchKana = default(string), string branchCode = default(string), string accountType = default(string), string accountNumber = default(string), string longAccountName = default(string), string accountName = default(string))
        {
            BankName = bankName;
            BankNameKana = bankNameKana;
            BankCode = bankCode;
            BranchName = branchName;
            BranchKana = branchKana;
            BranchCode = branchCode;
            AccountType = accountType;
            AccountNumber = accountNumber;
            LongAccountName = longAccountName;
            AccountName = accountName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets 銀行名
        /// </summary>
        [JsonProperty(PropertyName = "bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// Gets or sets 銀行名（カナ）
        /// </summary>
        [JsonProperty(PropertyName = "bank_name_kana")]
        public string BankNameKana { get; set; }

        /// <summary>
        /// Gets or sets 銀行番号
        /// </summary>
        [JsonProperty(PropertyName = "bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// Gets or sets 支店名
        /// </summary>
        [JsonProperty(PropertyName = "branch_name")]
        public string BranchName { get; set; }

        /// <summary>
        /// Gets or sets 支店名（カナ）
        /// </summary>
        [JsonProperty(PropertyName = "branch_kana")]
        public string BranchKana { get; set; }

        /// <summary>
        /// Gets or sets 支店番号
        /// </summary>
        [JsonProperty(PropertyName = "branch_code")]
        public string BranchCode { get; set; }

        /// <summary>
        /// Gets or sets
        /// 口座種別(ordinary:普通、checking：当座、earmarked：納税準備預金、savings：貯蓄、other:その他)
        /// </summary>
        [JsonProperty(PropertyName = "account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// Gets or sets 口座番号
        /// </summary>
        [JsonProperty(PropertyName = "account_number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Gets or sets 受取人名
        /// </summary>
        [JsonProperty(PropertyName = "long_account_name")]
        public string LongAccountName { get; set; }

        /// <summary>
        /// Gets or sets 受取人名（カナ）
        /// </summary>
        [JsonProperty(PropertyName = "account_name")]
        public string AccountName { get; set; }

    }
}
