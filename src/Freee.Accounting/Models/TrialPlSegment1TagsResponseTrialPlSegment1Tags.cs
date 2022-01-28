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
    /// TrialPlSegment1TagsResponseTrialPlSegment1Tags
    /// </summary>
    [DataContract(Name = "trialPlSegment_1TagsResponse_trial_pl_segment_1_tags")]
    public partial class TrialPlSegment1TagsResponseTrialPlSegment1Tags : IEquatable<TrialPlSegment1TagsResponseTrialPlSegment1Tags>
    {
        /// <summary>
        /// 勘定科目の表示（勘定科目: account_item, 決算書表示:group）(条件に指定した時のみ含まれる）
        /// </summary>
        /// <value>勘定科目の表示（勘定科目: account_item, 決算書表示:group）(条件に指定した時のみ含まれる）</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AccountItemDisplayTypeEnum
        {
            /// <summary>
            /// Enum AccountItem for value: account_item
            /// </summary>
            [EnumMember(Value = "account_item")]
            AccountItem = 1,

            /// <summary>
            /// Enum Group for value: group
            /// </summary>
            [EnumMember(Value = "group")]
            Group = 2

        }


        /// <summary>
        /// 勘定科目の表示（勘定科目: account_item, 決算書表示:group）(条件に指定した時のみ含まれる）
        /// </summary>
        /// <value>勘定科目の表示（勘定科目: account_item, 決算書表示:group）(条件に指定した時のみ含まれる）</value>
        [DataMember(Name = "account_item_display_type", EmitDefaultValue = false)]
        public AccountItemDisplayTypeEnum? AccountItemDisplayType { get; set; }
        /// <summary>
        /// 決算整理仕訳のみ: only, 決算整理仕訳以外: without(条件に指定した時のみ含まれる）
        /// </summary>
        /// <value>決算整理仕訳のみ: only, 決算整理仕訳以外: without(条件に指定した時のみ含まれる）</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AdjustmentEnum
        {
            /// <summary>
            /// Enum Only for value: only
            /// </summary>
            [EnumMember(Value = "only")]
            Only = 1,

            /// <summary>
            /// Enum Without for value: without
            /// </summary>
            [EnumMember(Value = "without")]
            Without = 2

        }


        /// <summary>
        /// 決算整理仕訳のみ: only, 決算整理仕訳以外: without(条件に指定した時のみ含まれる）
        /// </summary>
        /// <value>決算整理仕訳のみ: only, 決算整理仕訳以外: without(条件に指定した時のみ含まれる）</value>
        [DataMember(Name = "adjustment", EmitDefaultValue = false)]
        public AdjustmentEnum? Adjustment { get; set; }
        /// <summary>
        /// 未承認を除く: without_in_progress (デフォルト), 全てのステータス: all(条件に指定した時のみ含まれる）
        /// </summary>
        /// <value>未承認を除く: without_in_progress (デフォルト), 全てのステータス: all(条件に指定した時のみ含まれる）</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ApprovalFlowStatusEnum
        {
            /// <summary>
            /// Enum WithoutInProgress for value: without_in_progress
            /// </summary>
            [EnumMember(Value = "without_in_progress")]
            WithoutInProgress = 1,

            /// <summary>
            /// Enum All for value: all
            /// </summary>
            [EnumMember(Value = "all")]
            All = 2

        }


        /// <summary>
        /// 未承認を除く: without_in_progress (デフォルト), 全てのステータス: all(条件に指定した時のみ含まれる）
        /// </summary>
        /// <value>未承認を除く: without_in_progress (デフォルト), 全てのステータス: all(条件に指定した時のみ含まれる）</value>
        [DataMember(Name = "approval_flow_status", EmitDefaultValue = false)]
        public ApprovalFlowStatusEnum? ApprovalFlowStatus { get; set; }
        /// <summary>
        /// 内訳の表示（取引先: partner, 品目: item, 部門: section, 勘定科目: account_item）(条件に指定した時のみ含まれる）
        /// </summary>
        /// <value>内訳の表示（取引先: partner, 品目: item, 部門: section, 勘定科目: account_item）(条件に指定した時のみ含まれる）</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BreakdownDisplayTypeEnum
        {
            /// <summary>
            /// Enum Partner for value: partner
            /// </summary>
            [EnumMember(Value = "partner")]
            Partner = 1,

            /// <summary>
            /// Enum Item for value: item
            /// </summary>
            [EnumMember(Value = "item")]
            Item = 2,

            /// <summary>
            /// Enum Section for value: section
            /// </summary>
            [EnumMember(Value = "section")]
            Section = 3,

            /// <summary>
            /// Enum AccountItem for value: account_item
            /// </summary>
            [EnumMember(Value = "account_item")]
            AccountItem = 4

        }


        /// <summary>
        /// 内訳の表示（取引先: partner, 品目: item, 部門: section, 勘定科目: account_item）(条件に指定した時のみ含まれる）
        /// </summary>
        /// <value>内訳の表示（取引先: partner, 品目: item, 部門: section, 勘定科目: account_item）(条件に指定した時のみ含まれる）</value>
        [DataMember(Name = "breakdown_display_type", EmitDefaultValue = false)]
        public BreakdownDisplayTypeEnum? BreakdownDisplayType { get; set; }
        /// <summary>
        /// 配賦仕訳のみ：only,配賦仕訳以外：without(条件に指定した時のみ含まれる）
        /// </summary>
        /// <value>配賦仕訳のみ：only,配賦仕訳以外：without(条件に指定した時のみ含まれる）</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CostAllocationEnum
        {
            /// <summary>
            /// Enum Only for value: only
            /// </summary>
            [EnumMember(Value = "only")]
            Only = 1,

            /// <summary>
            /// Enum Without for value: without
            /// </summary>
            [EnumMember(Value = "without")]
            Without = 2

        }


        /// <summary>
        /// 配賦仕訳のみ：only,配賦仕訳以外：without(条件に指定した時のみ含まれる）
        /// </summary>
        /// <value>配賦仕訳のみ：only,配賦仕訳以外：without(条件に指定した時のみ含まれる）</value>
        [DataMember(Name = "cost_allocation", EmitDefaultValue = false)]
        public CostAllocationEnum? CostAllocation { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrialPlSegment1TagsResponseTrialPlSegment1Tags" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TrialPlSegment1TagsResponseTrialPlSegment1Tags() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrialPlSegment1TagsResponseTrialPlSegment1Tags" /> class.
        /// </summary>
        /// <param name="accountItemDisplayType">勘定科目の表示（勘定科目: account_item, 決算書表示:group）(条件に指定した時のみ含まれる）.</param>
        /// <param name="adjustment">決算整理仕訳のみ: only, 決算整理仕訳以外: without(条件に指定した時のみ含まれる）.</param>
        /// <param name="approvalFlowStatus">未承認を除く: without_in_progress (デフォルト), 全てのステータス: all(条件に指定した時のみ含まれる）.</param>
        /// <param name="balances">balances (required).</param>
        /// <param name="breakdownDisplayType">内訳の表示（取引先: partner, 品目: item, 部門: section, 勘定科目: account_item）(条件に指定した時のみ含まれる）.</param>
        /// <param name="companyId">事業所ID (required).</param>
        /// <param name="costAllocation">配賦仕訳のみ：only,配賦仕訳以外：without(条件に指定した時のみ含まれる）.</param>
        /// <param name="createdAt">作成日時.</param>
        /// <param name="endDate">発生日で絞込：終了日(yyyy-mm-dd)(条件に指定した時のみ含まれる）.</param>
        /// <param name="endMonth">発生月で絞込：終了会計月(1-12)(条件に指定した時のみ含まれる）.</param>
        /// <param name="fiscalYear">会計年度(条件に指定した時、または条件に月、日条件がない時のみ含まれる）.</param>
        /// <param name="itemId">品目ID(条件に指定した時のみ含まれる）.</param>
        /// <param name="partnerCode">取引先コード(条件に指定した時のみ含まれる）.</param>
        /// <param name="partnerId">取引先ID(条件に指定した時のみ含まれる）.</param>
        /// <param name="sectionId">部門ID(条件に指定した時のみ含まれる）.</param>
        /// <param name="segment1TagIds">出力するセグメント1の指定 (required).</param>
        /// <param name="startDate">発生日で絞込：開始日(yyyy-mm-dd)(条件に指定した時のみ含まれる）.</param>
        /// <param name="startMonth">発生月で絞込：開始会計月(1-12)(条件に指定した時のみ含まれる）.</param>
        public TrialPlSegment1TagsResponseTrialPlSegment1Tags(AccountItemDisplayTypeEnum? accountItemDisplayType = default(AccountItemDisplayTypeEnum?), AdjustmentEnum? adjustment = default(AdjustmentEnum?), ApprovalFlowStatusEnum? approvalFlowStatus = default(ApprovalFlowStatusEnum?), List<TrialPlSegment1TagsResponseTrialPlSegment1TagsBalances> balances = default(List<TrialPlSegment1TagsResponseTrialPlSegment1TagsBalances>), BreakdownDisplayTypeEnum? breakdownDisplayType = default(BreakdownDisplayTypeEnum?), int companyId = default(int), CostAllocationEnum? costAllocation = default(CostAllocationEnum?), string createdAt = default(string), string endDate = default(string), int endMonth = default(int), int fiscalYear = default(int), int itemId = default(int), string partnerCode = default(string), int partnerId = default(int), int sectionId = default(int), string segment1TagIds = default(string), string startDate = default(string), int startMonth = default(int))
        {
            // to ensure "balances" is required (not null)
            if (balances == null) {
                throw new ArgumentNullException("balances is a required property for TrialPlSegment1TagsResponseTrialPlSegment1Tags and cannot be null");
            }
            this.Balances = balances;
            this.CompanyId = companyId;
            // to ensure "segment1TagIds" is required (not null)
            if (segment1TagIds == null) {
                throw new ArgumentNullException("segment1TagIds is a required property for TrialPlSegment1TagsResponseTrialPlSegment1Tags and cannot be null");
            }
            this.Segment1TagIds = segment1TagIds;
            this.AccountItemDisplayType = accountItemDisplayType;
            this.Adjustment = adjustment;
            this.ApprovalFlowStatus = approvalFlowStatus;
            this.BreakdownDisplayType = breakdownDisplayType;
            this.CostAllocation = costAllocation;
            this.CreatedAt = createdAt;
            this.EndDate = endDate;
            this.EndMonth = endMonth;
            this.FiscalYear = fiscalYear;
            this.ItemId = itemId;
            this.PartnerCode = partnerCode;
            this.PartnerId = partnerId;
            this.SectionId = sectionId;
            this.StartDate = startDate;
            this.StartMonth = startMonth;
        }

        /// <summary>
        /// Gets or Sets Balances
        /// </summary>
        [DataMember(Name = "balances", IsRequired = true, EmitDefaultValue = false)]
        public List<TrialPlSegment1TagsResponseTrialPlSegment1TagsBalances> Balances { get; set; }

        /// <summary>
        /// 事業所ID
        /// </summary>
        /// <value>事業所ID</value>
        [DataMember(Name = "company_id", IsRequired = true, EmitDefaultValue = false)]
        public int CompanyId { get; set; }

        /// <summary>
        /// 作成日時
        /// </summary>
        /// <value>作成日時</value>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 発生日で絞込：終了日(yyyy-mm-dd)(条件に指定した時のみ含まれる）
        /// </summary>
        /// <value>発生日で絞込：終了日(yyyy-mm-dd)(条件に指定した時のみ含まれる）</value>
        [DataMember(Name = "end_date", EmitDefaultValue = false)]
        public string EndDate { get; set; }

        /// <summary>
        /// 発生月で絞込：終了会計月(1-12)(条件に指定した時のみ含まれる）
        /// </summary>
        /// <value>発生月で絞込：終了会計月(1-12)(条件に指定した時のみ含まれる）</value>
        [DataMember(Name = "end_month", EmitDefaultValue = false)]
        public int EndMonth { get; set; }

        /// <summary>
        /// 会計年度(条件に指定した時、または条件に月、日条件がない時のみ含まれる）
        /// </summary>
        /// <value>会計年度(条件に指定した時、または条件に月、日条件がない時のみ含まれる）</value>
        [DataMember(Name = "fiscal_year", EmitDefaultValue = false)]
        public int FiscalYear { get; set; }

        /// <summary>
        /// 品目ID(条件に指定した時のみ含まれる）
        /// </summary>
        /// <value>品目ID(条件に指定した時のみ含まれる）</value>
        [DataMember(Name = "item_id", EmitDefaultValue = false)]
        public int ItemId { get; set; }

        /// <summary>
        /// 取引先コード(条件に指定した時のみ含まれる）
        /// </summary>
        /// <value>取引先コード(条件に指定した時のみ含まれる）</value>
        [DataMember(Name = "partner_code", EmitDefaultValue = false)]
        public string PartnerCode { get; set; }

        /// <summary>
        /// 取引先ID(条件に指定した時のみ含まれる）
        /// </summary>
        /// <value>取引先ID(条件に指定した時のみ含まれる）</value>
        [DataMember(Name = "partner_id", EmitDefaultValue = false)]
        public int PartnerId { get; set; }

        /// <summary>
        /// 部門ID(条件に指定した時のみ含まれる）
        /// </summary>
        /// <value>部門ID(条件に指定した時のみ含まれる）</value>
        [DataMember(Name = "section_id", EmitDefaultValue = false)]
        public int SectionId { get; set; }

        /// <summary>
        /// 出力するセグメント1の指定
        /// </summary>
        /// <value>出力するセグメント1の指定</value>
        [DataMember(Name = "segment_1_tag_ids", IsRequired = true, EmitDefaultValue = false)]
        public string Segment1TagIds { get; set; }

        /// <summary>
        /// 発生日で絞込：開始日(yyyy-mm-dd)(条件に指定した時のみ含まれる）
        /// </summary>
        /// <value>発生日で絞込：開始日(yyyy-mm-dd)(条件に指定した時のみ含まれる）</value>
        [DataMember(Name = "start_date", EmitDefaultValue = false)]
        public string StartDate { get; set; }

        /// <summary>
        /// 発生月で絞込：開始会計月(1-12)(条件に指定した時のみ含まれる）
        /// </summary>
        /// <value>発生月で絞込：開始会計月(1-12)(条件に指定した時のみ含まれる）</value>
        [DataMember(Name = "start_month", EmitDefaultValue = false)]
        public int StartMonth { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TrialPlSegment1TagsResponseTrialPlSegment1Tags {\n");
            sb.Append("  AccountItemDisplayType: ").Append(AccountItemDisplayType).Append("\n");
            sb.Append("  Adjustment: ").Append(Adjustment).Append("\n");
            sb.Append("  ApprovalFlowStatus: ").Append(ApprovalFlowStatus).Append("\n");
            sb.Append("  Balances: ").Append(Balances).Append("\n");
            sb.Append("  BreakdownDisplayType: ").Append(BreakdownDisplayType).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  CostAllocation: ").Append(CostAllocation).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  EndMonth: ").Append(EndMonth).Append("\n");
            sb.Append("  FiscalYear: ").Append(FiscalYear).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  PartnerCode: ").Append(PartnerCode).Append("\n");
            sb.Append("  PartnerId: ").Append(PartnerId).Append("\n");
            sb.Append("  SectionId: ").Append(SectionId).Append("\n");
            sb.Append("  Segment1TagIds: ").Append(Segment1TagIds).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  StartMonth: ").Append(StartMonth).Append("\n");
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
            return this.Equals(input as TrialPlSegment1TagsResponseTrialPlSegment1Tags);
        }

        /// <summary>
        /// Returns true if TrialPlSegment1TagsResponseTrialPlSegment1Tags instances are equal
        /// </summary>
        /// <param name="input">Instance of TrialPlSegment1TagsResponseTrialPlSegment1Tags to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrialPlSegment1TagsResponseTrialPlSegment1Tags input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountItemDisplayType == input.AccountItemDisplayType ||
                    this.AccountItemDisplayType.Equals(input.AccountItemDisplayType)
                ) && 
                (
                    this.Adjustment == input.Adjustment ||
                    this.Adjustment.Equals(input.Adjustment)
                ) && 
                (
                    this.ApprovalFlowStatus == input.ApprovalFlowStatus ||
                    this.ApprovalFlowStatus.Equals(input.ApprovalFlowStatus)
                ) && 
                (
                    this.Balances == input.Balances ||
                    this.Balances != null &&
                    input.Balances != null &&
                    this.Balances.SequenceEqual(input.Balances)
                ) && 
                (
                    this.BreakdownDisplayType == input.BreakdownDisplayType ||
                    this.BreakdownDisplayType.Equals(input.BreakdownDisplayType)
                ) && 
                (
                    this.CompanyId == input.CompanyId ||
                    this.CompanyId.Equals(input.CompanyId)
                ) && 
                (
                    this.CostAllocation == input.CostAllocation ||
                    this.CostAllocation.Equals(input.CostAllocation)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.EndMonth == input.EndMonth ||
                    this.EndMonth.Equals(input.EndMonth)
                ) && 
                (
                    this.FiscalYear == input.FiscalYear ||
                    this.FiscalYear.Equals(input.FiscalYear)
                ) && 
                (
                    this.ItemId == input.ItemId ||
                    this.ItemId.Equals(input.ItemId)
                ) && 
                (
                    this.PartnerCode == input.PartnerCode ||
                    (this.PartnerCode != null &&
                    this.PartnerCode.Equals(input.PartnerCode))
                ) && 
                (
                    this.PartnerId == input.PartnerId ||
                    this.PartnerId.Equals(input.PartnerId)
                ) && 
                (
                    this.SectionId == input.SectionId ||
                    this.SectionId.Equals(input.SectionId)
                ) && 
                (
                    this.Segment1TagIds == input.Segment1TagIds ||
                    (this.Segment1TagIds != null &&
                    this.Segment1TagIds.Equals(input.Segment1TagIds))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.StartMonth == input.StartMonth ||
                    this.StartMonth.Equals(input.StartMonth)
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
                hashCode = (hashCode * 59) + this.AccountItemDisplayType.GetHashCode();
                hashCode = (hashCode * 59) + this.Adjustment.GetHashCode();
                hashCode = (hashCode * 59) + this.ApprovalFlowStatus.GetHashCode();
                if (this.Balances != null)
                {
                    hashCode = (hashCode * 59) + this.Balances.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.BreakdownDisplayType.GetHashCode();
                hashCode = (hashCode * 59) + this.CompanyId.GetHashCode();
                hashCode = (hashCode * 59) + this.CostAllocation.GetHashCode();
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.EndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EndMonth.GetHashCode();
                hashCode = (hashCode * 59) + this.FiscalYear.GetHashCode();
                hashCode = (hashCode * 59) + this.ItemId.GetHashCode();
                if (this.PartnerCode != null)
                {
                    hashCode = (hashCode * 59) + this.PartnerCode.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PartnerId.GetHashCode();
                hashCode = (hashCode * 59) + this.SectionId.GetHashCode();
                if (this.Segment1TagIds != null)
                {
                    hashCode = (hashCode * 59) + this.Segment1TagIds.GetHashCode();
                }
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.StartMonth.GetHashCode();
                return hashCode;
            }
        }

    }

}
