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
    /// DealCreateParamsPayments
    /// </summary>
    [DataContract(Name = "dealCreateParams_payments")]
    public partial class DealCreateParamsPayments : IEquatable<DealCreateParamsPayments>
    {
        /// <summary>
        /// 口座区分 (銀行口座: bank_account, クレジットカード: credit_card, 現金: wallet, プライベート資金（法人の場合は役員借入金もしくは役員借入金、個人の場合は事業主貸もしくは事業主借）: private_account_item)：payments指定時は必須
        /// </summary>
        /// <value>口座区分 (銀行口座: bank_account, クレジットカード: credit_card, 現金: wallet, プライベート資金（法人の場合は役員借入金もしくは役員借入金、個人の場合は事業主貸もしくは事業主借）: private_account_item)：payments指定時は必須</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FromWalletableTypeEnum
        {
            /// <summary>
            /// Enum BankAccount for value: bank_account
            /// </summary>
            [EnumMember(Value = "bank_account")]
            BankAccount = 1,

            /// <summary>
            /// Enum CreditCard for value: credit_card
            /// </summary>
            [EnumMember(Value = "credit_card")]
            CreditCard = 2,

            /// <summary>
            /// Enum Wallet for value: wallet
            /// </summary>
            [EnumMember(Value = "wallet")]
            Wallet = 3,

            /// <summary>
            /// Enum PrivateAccountItem for value: private_account_item
            /// </summary>
            [EnumMember(Value = "private_account_item")]
            PrivateAccountItem = 4

        }


        /// <summary>
        /// 口座区分 (銀行口座: bank_account, クレジットカード: credit_card, 現金: wallet, プライベート資金（法人の場合は役員借入金もしくは役員借入金、個人の場合は事業主貸もしくは事業主借）: private_account_item)：payments指定時は必須
        /// </summary>
        /// <value>口座区分 (銀行口座: bank_account, クレジットカード: credit_card, 現金: wallet, プライベート資金（法人の場合は役員借入金もしくは役員借入金、個人の場合は事業主貸もしくは事業主借）: private_account_item)：payments指定時は必須</value>
        [DataMember(Name = "from_walletable_type", IsRequired = true, EmitDefaultValue = false)]
        public FromWalletableTypeEnum FromWalletableType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DealCreateParamsPayments" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DealCreateParamsPayments() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DealCreateParamsPayments" /> class.
        /// </summary>
        /// <param name="amount">支払金額：payments指定時は必須 (required).</param>
        /// <param name="date">支払日：payments指定時は必須 (required).</param>
        /// <param name="fromWalletableId">口座ID（from_walletable_typeがprivate_account_itemの場合は勘定科目ID）：payments指定時は必須 (required).</param>
        /// <param name="fromWalletableType">口座区分 (銀行口座: bank_account, クレジットカード: credit_card, 現金: wallet, プライベート資金（法人の場合は役員借入金もしくは役員借入金、個人の場合は事業主貸もしくは事業主借）: private_account_item)：payments指定時は必須 (required).</param>
        public DealCreateParamsPayments(long amount = default(long), string date = default(string), int fromWalletableId = default(int), FromWalletableTypeEnum fromWalletableType = default(FromWalletableTypeEnum))
        {
            this.Amount = amount;
            // to ensure "date" is required (not null)
            if (date == null) {
                throw new ArgumentNullException("date is a required property for DealCreateParamsPayments and cannot be null");
            }
            this.Date = date;
            this.FromWalletableId = fromWalletableId;
            this.FromWalletableType = fromWalletableType;
        }

        /// <summary>
        /// 支払金額：payments指定時は必須
        /// </summary>
        /// <value>支払金額：payments指定時は必須</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = false)]
        public long Amount { get; set; }

        /// <summary>
        /// 支払日：payments指定時は必須
        /// </summary>
        /// <value>支払日：payments指定時は必須</value>
        [DataMember(Name = "date", IsRequired = true, EmitDefaultValue = false)]
        public string Date { get; set; }

        /// <summary>
        /// 口座ID（from_walletable_typeがprivate_account_itemの場合は勘定科目ID）：payments指定時は必須
        /// </summary>
        /// <value>口座ID（from_walletable_typeがprivate_account_itemの場合は勘定科目ID）：payments指定時は必須</value>
        [DataMember(Name = "from_walletable_id", IsRequired = true, EmitDefaultValue = false)]
        public int FromWalletableId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DealCreateParamsPayments {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  FromWalletableId: ").Append(FromWalletableId).Append("\n");
            sb.Append("  FromWalletableType: ").Append(FromWalletableType).Append("\n");
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
            return this.Equals(input as DealCreateParamsPayments);
        }

        /// <summary>
        /// Returns true if DealCreateParamsPayments instances are equal
        /// </summary>
        /// <param name="input">Instance of DealCreateParamsPayments to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DealCreateParamsPayments input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.FromWalletableId == input.FromWalletableId ||
                    this.FromWalletableId.Equals(input.FromWalletableId)
                ) && 
                (
                    this.FromWalletableType == input.FromWalletableType ||
                    this.FromWalletableType.Equals(input.FromWalletableType)
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
                hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                if (this.Date != null)
                {
                    hashCode = (hashCode * 59) + this.Date.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.FromWalletableId.GetHashCode();
                hashCode = (hashCode * 59) + this.FromWalletableType.GetHashCode();
                return hashCode;
            }
        }

    }

}
