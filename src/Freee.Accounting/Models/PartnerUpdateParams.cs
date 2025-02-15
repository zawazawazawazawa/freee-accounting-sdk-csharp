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
    /// PartnerUpdateParams
    /// </summary>
    [DataContract(Name = "partnerUpdateParams")]
    public partial class PartnerUpdateParams : IEquatable<PartnerUpdateParams>
    {
        /// <summary>
        /// 地域（JP: 国内、ZZ:国外）
        /// </summary>
        /// <value>地域（JP: 国内、ZZ:国外）</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CountryCodeEnum
        {
            /// <summary>
            /// Enum JP for value: JP
            /// </summary>
            [EnumMember(Value = "JP")]
            JP = 1,

            /// <summary>
            /// Enum ZZ for value: ZZ
            /// </summary>
            [EnumMember(Value = "ZZ")]
            ZZ = 2

        }


        /// <summary>
        /// 地域（JP: 国内、ZZ:国外）
        /// </summary>
        /// <value>地域（JP: 国内、ZZ:国外）</value>
        [DataMember(Name = "country_code", EmitDefaultValue = false)]
        public CountryCodeEnum? CountryCode { get; set; }
        /// <summary>
        /// 事業所種別（null: 未設定、1: 法人、2: 個人）
        /// </summary>
        /// <value>事業所種別（null: 未設定、1: 法人、2: 個人）</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OrgCodeEnum
        {
            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            NUMBER_1 = 1,

            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            NUMBER_2 = 2

        }


        /// <summary>
        /// 事業所種別（null: 未設定、1: 法人、2: 個人）
        /// </summary>
        /// <value>事業所種別（null: 未設定、1: 法人、2: 個人）</value>
        [DataMember(Name = "org_code", EmitDefaultValue = true)]
        public OrgCodeEnum? OrgCode { get; set; }
        /// <summary>
        /// 振込手数料負担（一括振込ファイル用）: (振込元(当方): payer, 振込先(先方): payee)
        /// </summary>
        /// <value>振込手数料負担（一括振込ファイル用）: (振込元(当方): payer, 振込先(先方): payee)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TransferFeeHandlingSideEnum
        {
            /// <summary>
            /// Enum Payer for value: payer
            /// </summary>
            [EnumMember(Value = "payer")]
            Payer = 1,

            /// <summary>
            /// Enum Payee for value: payee
            /// </summary>
            [EnumMember(Value = "payee")]
            Payee = 2

        }


        /// <summary>
        /// 振込手数料負担（一括振込ファイル用）: (振込元(当方): payer, 振込先(先方): payee)
        /// </summary>
        /// <value>振込手数料負担（一括振込ファイル用）: (振込元(当方): payer, 振込先(先方): payee)</value>
        [DataMember(Name = "transfer_fee_handling_side", EmitDefaultValue = false)]
        public TransferFeeHandlingSideEnum? TransferFeeHandlingSide { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PartnerUpdateParams" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PartnerUpdateParams() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PartnerUpdateParams" /> class.
        /// </summary>
        /// <param name="addressAttributes">addressAttributes.</param>
        /// <param name="companyId">事業所ID (required).</param>
        /// <param name="contactName">担当者 氏名 (255文字以内).</param>
        /// <param name="countryCode">地域（JP: 国内、ZZ:国外）.</param>
        /// <param name="defaultTitle">敬称（御中、様、(空白)の3つから選択）.</param>
        /// <param name="email">担当者 メールアドレス (255文字以内).</param>
        /// <param name="invoicePaymentTermAttributes">invoicePaymentTermAttributes.</param>
        /// <param name="longName">正式名称（255文字以内）.</param>
        /// <param name="name">取引先名 (255文字以内) (required).</param>
        /// <param name="nameKana">カナ名称（255文字以内）.</param>
        /// <param name="orgCode">事業所種別（null: 未設定、1: 法人、2: 個人）.</param>
        /// <param name="partnerBankAccountAttributes">partnerBankAccountAttributes.</param>
        /// <param name="partnerDocSettingAttributes">partnerDocSettingAttributes.</param>
        /// <param name="payerWalletableId">振込元口座ID（一括振込ファイル用）:（walletableのtypeが&#39;bank_account&#39;のidのみ指定できます。また、未設定にする場合は、nullを指定してください。）.</param>
        /// <param name="paymentTermAttributes">paymentTermAttributes.</param>
        /// <param name="phone">電話番号.</param>
        /// <param name="shortcut1">ショートカット１ (255文字以内).</param>
        /// <param name="shortcut2">ショートカット２ (255文字以内).</param>
        /// <param name="transferFeeHandlingSide">振込手数料負担（一括振込ファイル用）: (振込元(当方): payer, 振込先(先方): payee).</param>
        public PartnerUpdateParams(PartnerCreateParamsAddressAttributes addressAttributes = default(PartnerCreateParamsAddressAttributes), int companyId = default(int), string contactName = default(string), CountryCodeEnum? countryCode = default(CountryCodeEnum?), string defaultTitle = default(string), string email = default(string), PartnerCreateParamsInvoicePaymentTermAttributes invoicePaymentTermAttributes = default(PartnerCreateParamsInvoicePaymentTermAttributes), string longName = default(string), string name = default(string), string nameKana = default(string), OrgCodeEnum? orgCode = default(OrgCodeEnum?), PartnerCreateParamsPartnerBankAccountAttributes partnerBankAccountAttributes = default(PartnerCreateParamsPartnerBankAccountAttributes), PartnerCreateParamsPartnerDocSettingAttributes partnerDocSettingAttributes = default(PartnerCreateParamsPartnerDocSettingAttributes), int? payerWalletableId = default(int?), PartnerCreateParamsInvoicePaymentTermAttributes paymentTermAttributes = default(PartnerCreateParamsInvoicePaymentTermAttributes), string phone = default(string), string shortcut1 = default(string), string shortcut2 = default(string), TransferFeeHandlingSideEnum? transferFeeHandlingSide = default(TransferFeeHandlingSideEnum?))
        {
            this.CompanyId = companyId;
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for PartnerUpdateParams and cannot be null");
            }
            this.Name = name;
            this.AddressAttributes = addressAttributes;
            this.ContactName = contactName;
            this.CountryCode = countryCode;
            this.DefaultTitle = defaultTitle;
            this.Email = email;
            this.InvoicePaymentTermAttributes = invoicePaymentTermAttributes;
            this.LongName = longName;
            this.NameKana = nameKana;
            this.OrgCode = orgCode;
            this.PartnerBankAccountAttributes = partnerBankAccountAttributes;
            this.PartnerDocSettingAttributes = partnerDocSettingAttributes;
            this.PayerWalletableId = payerWalletableId;
            this.PaymentTermAttributes = paymentTermAttributes;
            this.Phone = phone;
            this.Shortcut1 = shortcut1;
            this.Shortcut2 = shortcut2;
            this.TransferFeeHandlingSide = transferFeeHandlingSide;
        }

        /// <summary>
        /// Gets or Sets AddressAttributes
        /// </summary>
        [DataMember(Name = "address_attributes", EmitDefaultValue = false)]
        public PartnerCreateParamsAddressAttributes AddressAttributes { get; set; }

        /// <summary>
        /// 事業所ID
        /// </summary>
        /// <value>事業所ID</value>
        [DataMember(Name = "company_id", IsRequired = true, EmitDefaultValue = false)]
        public int CompanyId { get; set; }

        /// <summary>
        /// 担当者 氏名 (255文字以内)
        /// </summary>
        /// <value>担当者 氏名 (255文字以内)</value>
        [DataMember(Name = "contact_name", EmitDefaultValue = false)]
        public string ContactName { get; set; }

        /// <summary>
        /// 敬称（御中、様、(空白)の3つから選択）
        /// </summary>
        /// <value>敬称（御中、様、(空白)の3つから選択）</value>
        [DataMember(Name = "default_title", EmitDefaultValue = false)]
        public string DefaultTitle { get; set; }

        /// <summary>
        /// 担当者 メールアドレス (255文字以内)
        /// </summary>
        /// <value>担当者 メールアドレス (255文字以内)</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets InvoicePaymentTermAttributes
        /// </summary>
        [DataMember(Name = "invoice_payment_term_attributes", EmitDefaultValue = false)]
        public PartnerCreateParamsInvoicePaymentTermAttributes InvoicePaymentTermAttributes { get; set; }

        /// <summary>
        /// 正式名称（255文字以内）
        /// </summary>
        /// <value>正式名称（255文字以内）</value>
        [DataMember(Name = "long_name", EmitDefaultValue = false)]
        public string LongName { get; set; }

        /// <summary>
        /// 取引先名 (255文字以内)
        /// </summary>
        /// <value>取引先名 (255文字以内)</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// カナ名称（255文字以内）
        /// </summary>
        /// <value>カナ名称（255文字以内）</value>
        [DataMember(Name = "name_kana", EmitDefaultValue = false)]
        public string NameKana { get; set; }

        /// <summary>
        /// Gets or Sets PartnerBankAccountAttributes
        /// </summary>
        [DataMember(Name = "partner_bank_account_attributes", EmitDefaultValue = false)]
        public PartnerCreateParamsPartnerBankAccountAttributes PartnerBankAccountAttributes { get; set; }

        /// <summary>
        /// Gets or Sets PartnerDocSettingAttributes
        /// </summary>
        [DataMember(Name = "partner_doc_setting_attributes", EmitDefaultValue = false)]
        public PartnerCreateParamsPartnerDocSettingAttributes PartnerDocSettingAttributes { get; set; }

        /// <summary>
        /// 振込元口座ID（一括振込ファイル用）:（walletableのtypeが&#39;bank_account&#39;のidのみ指定できます。また、未設定にする場合は、nullを指定してください。）
        /// </summary>
        /// <value>振込元口座ID（一括振込ファイル用）:（walletableのtypeが&#39;bank_account&#39;のidのみ指定できます。また、未設定にする場合は、nullを指定してください。）</value>
        [DataMember(Name = "payer_walletable_id", EmitDefaultValue = true)]
        public int? PayerWalletableId { get; set; }

        /// <summary>
        /// Gets or Sets PaymentTermAttributes
        /// </summary>
        [DataMember(Name = "payment_term_attributes", EmitDefaultValue = false)]
        public PartnerCreateParamsInvoicePaymentTermAttributes PaymentTermAttributes { get; set; }

        /// <summary>
        /// 電話番号
        /// </summary>
        /// <value>電話番号</value>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        public string Phone { get; set; }

        /// <summary>
        /// ショートカット１ (255文字以内)
        /// </summary>
        /// <value>ショートカット１ (255文字以内)</value>
        [DataMember(Name = "shortcut1", EmitDefaultValue = false)]
        public string Shortcut1 { get; set; }

        /// <summary>
        /// ショートカット２ (255文字以内)
        /// </summary>
        /// <value>ショートカット２ (255文字以内)</value>
        [DataMember(Name = "shortcut2", EmitDefaultValue = false)]
        public string Shortcut2 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PartnerUpdateParams {\n");
            sb.Append("  AddressAttributes: ").Append(AddressAttributes).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  ContactName: ").Append(ContactName).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  DefaultTitle: ").Append(DefaultTitle).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  InvoicePaymentTermAttributes: ").Append(InvoicePaymentTermAttributes).Append("\n");
            sb.Append("  LongName: ").Append(LongName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NameKana: ").Append(NameKana).Append("\n");
            sb.Append("  OrgCode: ").Append(OrgCode).Append("\n");
            sb.Append("  PartnerBankAccountAttributes: ").Append(PartnerBankAccountAttributes).Append("\n");
            sb.Append("  PartnerDocSettingAttributes: ").Append(PartnerDocSettingAttributes).Append("\n");
            sb.Append("  PayerWalletableId: ").Append(PayerWalletableId).Append("\n");
            sb.Append("  PaymentTermAttributes: ").Append(PaymentTermAttributes).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Shortcut1: ").Append(Shortcut1).Append("\n");
            sb.Append("  Shortcut2: ").Append(Shortcut2).Append("\n");
            sb.Append("  TransferFeeHandlingSide: ").Append(TransferFeeHandlingSide).Append("\n");
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
            return this.Equals(input as PartnerUpdateParams);
        }

        /// <summary>
        /// Returns true if PartnerUpdateParams instances are equal
        /// </summary>
        /// <param name="input">Instance of PartnerUpdateParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PartnerUpdateParams input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AddressAttributes == input.AddressAttributes ||
                    (this.AddressAttributes != null &&
                    this.AddressAttributes.Equals(input.AddressAttributes))
                ) && 
                (
                    this.CompanyId == input.CompanyId ||
                    this.CompanyId.Equals(input.CompanyId)
                ) && 
                (
                    this.ContactName == input.ContactName ||
                    (this.ContactName != null &&
                    this.ContactName.Equals(input.ContactName))
                ) && 
                (
                    this.CountryCode == input.CountryCode ||
                    this.CountryCode.Equals(input.CountryCode)
                ) && 
                (
                    this.DefaultTitle == input.DefaultTitle ||
                    (this.DefaultTitle != null &&
                    this.DefaultTitle.Equals(input.DefaultTitle))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.InvoicePaymentTermAttributes == input.InvoicePaymentTermAttributes ||
                    (this.InvoicePaymentTermAttributes != null &&
                    this.InvoicePaymentTermAttributes.Equals(input.InvoicePaymentTermAttributes))
                ) && 
                (
                    this.LongName == input.LongName ||
                    (this.LongName != null &&
                    this.LongName.Equals(input.LongName))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NameKana == input.NameKana ||
                    (this.NameKana != null &&
                    this.NameKana.Equals(input.NameKana))
                ) && 
                (
                    this.OrgCode == input.OrgCode ||
                    this.OrgCode.Equals(input.OrgCode)
                ) && 
                (
                    this.PartnerBankAccountAttributes == input.PartnerBankAccountAttributes ||
                    (this.PartnerBankAccountAttributes != null &&
                    this.PartnerBankAccountAttributes.Equals(input.PartnerBankAccountAttributes))
                ) && 
                (
                    this.PartnerDocSettingAttributes == input.PartnerDocSettingAttributes ||
                    (this.PartnerDocSettingAttributes != null &&
                    this.PartnerDocSettingAttributes.Equals(input.PartnerDocSettingAttributes))
                ) && 
                (
                    this.PayerWalletableId == input.PayerWalletableId ||
                    (this.PayerWalletableId != null &&
                    this.PayerWalletableId.Equals(input.PayerWalletableId))
                ) && 
                (
                    this.PaymentTermAttributes == input.PaymentTermAttributes ||
                    (this.PaymentTermAttributes != null &&
                    this.PaymentTermAttributes.Equals(input.PaymentTermAttributes))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.Shortcut1 == input.Shortcut1 ||
                    (this.Shortcut1 != null &&
                    this.Shortcut1.Equals(input.Shortcut1))
                ) && 
                (
                    this.Shortcut2 == input.Shortcut2 ||
                    (this.Shortcut2 != null &&
                    this.Shortcut2.Equals(input.Shortcut2))
                ) && 
                (
                    this.TransferFeeHandlingSide == input.TransferFeeHandlingSide ||
                    this.TransferFeeHandlingSide.Equals(input.TransferFeeHandlingSide)
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
                if (this.AddressAttributes != null)
                {
                    hashCode = (hashCode * 59) + this.AddressAttributes.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CompanyId.GetHashCode();
                if (this.ContactName != null)
                {
                    hashCode = (hashCode * 59) + this.ContactName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CountryCode.GetHashCode();
                if (this.DefaultTitle != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultTitle.GetHashCode();
                }
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.InvoicePaymentTermAttributes != null)
                {
                    hashCode = (hashCode * 59) + this.InvoicePaymentTermAttributes.GetHashCode();
                }
                if (this.LongName != null)
                {
                    hashCode = (hashCode * 59) + this.LongName.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.NameKana != null)
                {
                    hashCode = (hashCode * 59) + this.NameKana.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.OrgCode.GetHashCode();
                if (this.PartnerBankAccountAttributes != null)
                {
                    hashCode = (hashCode * 59) + this.PartnerBankAccountAttributes.GetHashCode();
                }
                if (this.PartnerDocSettingAttributes != null)
                {
                    hashCode = (hashCode * 59) + this.PartnerDocSettingAttributes.GetHashCode();
                }
                if (this.PayerWalletableId != null)
                {
                    hashCode = (hashCode * 59) + this.PayerWalletableId.GetHashCode();
                }
                if (this.PaymentTermAttributes != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentTermAttributes.GetHashCode();
                }
                if (this.Phone != null)
                {
                    hashCode = (hashCode * 59) + this.Phone.GetHashCode();
                }
                if (this.Shortcut1 != null)
                {
                    hashCode = (hashCode * 59) + this.Shortcut1.GetHashCode();
                }
                if (this.Shortcut2 != null)
                {
                    hashCode = (hashCode * 59) + this.Shortcut2.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TransferFeeHandlingSide.GetHashCode();
                return hashCode;
            }
        }

    }

}
