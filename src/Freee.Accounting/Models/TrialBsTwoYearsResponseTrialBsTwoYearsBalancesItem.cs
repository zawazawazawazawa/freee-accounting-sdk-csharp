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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class TrialBsTwoYearsResponseTrialBsTwoYearsBalancesItem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// TrialBsTwoYearsResponseTrialBsTwoYearsBalancesItem class.
        /// </summary>
        public TrialBsTwoYearsResponseTrialBsTwoYearsBalancesItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// TrialBsTwoYearsResponseTrialBsTwoYearsBalancesItem class.
        /// </summary>
        /// <param name="accountItemId">勘定科目ID(勘定科目の時のみ含まれる)</param>
        /// <param name="accountItemName">勘定科目名(勘定科目の時のみ含まれる)</param>
        /// <param name="partners">breakdown_display_type:partner,
        /// account_item_display_type:account_item指定時のみ含まれる</param>
        /// <param name="items">breakdown_display_type:item,
        /// account_item_display_type:account_item指定時のみ含まれる</param>
        /// <param
        /// name="accountCategoryId">勘定科目カテゴリーID(勘定科目カテゴリーの時のみ含まれる)</param>
        /// <param
        /// name="accountCategoryName">勘定科目カテゴリー名(勘定科目カテゴリーの時のみ含まれる)</param>
        /// <param name="totalLine">合計行(勘定科目カテゴリー名の時のみ含まれる)</param>
        /// <param name="hierarchyLevel">階層レベル</param>
        /// <param
        /// name="parentAccountCategoryId">上位科目カテゴリーID(上層が存在する場合含まれる)</param>
        /// <param
        /// name="parentAccountCategoryName">上位勘定科目カテゴリー名(上層が存在する場合含まれる)</param>
        /// <param name="lastYearClosingBalance">前年度期末残高</param>
        /// <param name="closingBalance">期末残高</param>
        /// <param name="yearOnYear">前年比</param>
        public TrialBsTwoYearsResponseTrialBsTwoYearsBalancesItem(int? accountItemId = default(int?), string accountItemName = default(string), IList<TrialBsTwoYearsResponseTrialBsTwoYearsBalancesItemPartnersItem> partners = default(IList<TrialBsTwoYearsResponseTrialBsTwoYearsBalancesItemPartnersItem>), IList<TrialBsTwoYearsResponseTrialBsTwoYearsBalancesItemItemsItem> items = default(IList<TrialBsTwoYearsResponseTrialBsTwoYearsBalancesItemItemsItem>), int? accountCategoryId = default(int?), string accountCategoryName = default(string), bool? totalLine = default(bool?), int? hierarchyLevel = default(int?), int? parentAccountCategoryId = default(int?), string parentAccountCategoryName = default(string), int? lastYearClosingBalance = default(int?), int? closingBalance = default(int?), double? yearOnYear = default(double?))
        {
            AccountItemId = accountItemId;
            AccountItemName = accountItemName;
            Partners = partners;
            Items = items;
            AccountCategoryId = accountCategoryId;
            AccountCategoryName = accountCategoryName;
            TotalLine = totalLine;
            HierarchyLevel = hierarchyLevel;
            ParentAccountCategoryId = parentAccountCategoryId;
            ParentAccountCategoryName = parentAccountCategoryName;
            LastYearClosingBalance = lastYearClosingBalance;
            ClosingBalance = closingBalance;
            YearOnYear = yearOnYear;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets 勘定科目ID(勘定科目の時のみ含まれる)
        /// </summary>
        [JsonProperty(PropertyName = "account_item_id")]
        public int? AccountItemId { get; set; }

        /// <summary>
        /// Gets or sets 勘定科目名(勘定科目の時のみ含まれる)
        /// </summary>
        [JsonProperty(PropertyName = "account_item_name")]
        public string AccountItemName { get; set; }

        /// <summary>
        /// Gets or sets breakdown_display_type:partner,
        /// account_item_display_type:account_item指定時のみ含まれる
        /// </summary>
        [JsonProperty(PropertyName = "partners")]
        public IList<TrialBsTwoYearsResponseTrialBsTwoYearsBalancesItemPartnersItem> Partners { get; set; }

        /// <summary>
        /// Gets or sets breakdown_display_type:item,
        /// account_item_display_type:account_item指定時のみ含まれる
        /// </summary>
        [JsonProperty(PropertyName = "items")]
        public IList<TrialBsTwoYearsResponseTrialBsTwoYearsBalancesItemItemsItem> Items { get; set; }

        /// <summary>
        /// Gets or sets 勘定科目カテゴリーID(勘定科目カテゴリーの時のみ含まれる)
        /// </summary>
        [JsonProperty(PropertyName = "account_category_id")]
        public int? AccountCategoryId { get; set; }

        /// <summary>
        /// Gets or sets 勘定科目カテゴリー名(勘定科目カテゴリーの時のみ含まれる)
        /// </summary>
        [JsonProperty(PropertyName = "account_category_name")]
        public string AccountCategoryName { get; set; }

        /// <summary>
        /// Gets or sets 合計行(勘定科目カテゴリー名の時のみ含まれる)
        /// </summary>
        [JsonProperty(PropertyName = "total_line")]
        public bool? TotalLine { get; set; }

        /// <summary>
        /// Gets or sets 階層レベル
        /// </summary>
        [JsonProperty(PropertyName = "hierarchy_level")]
        public int? HierarchyLevel { get; set; }

        /// <summary>
        /// Gets or sets 上位科目カテゴリーID(上層が存在する場合含まれる)
        /// </summary>
        [JsonProperty(PropertyName = "parent_account_category_id")]
        public int? ParentAccountCategoryId { get; set; }

        /// <summary>
        /// Gets or sets 上位勘定科目カテゴリー名(上層が存在する場合含まれる)
        /// </summary>
        [JsonProperty(PropertyName = "parent_account_category_name")]
        public string ParentAccountCategoryName { get; set; }

        /// <summary>
        /// Gets or sets 前年度期末残高
        /// </summary>
        [JsonProperty(PropertyName = "last_year_closing_balance")]
        public int? LastYearClosingBalance { get; set; }

        /// <summary>
        /// Gets or sets 期末残高
        /// </summary>
        [JsonProperty(PropertyName = "closing_balance")]
        public int? ClosingBalance { get; set; }

        /// <summary>
        /// Gets or sets 前年比
        /// </summary>
        [JsonProperty(PropertyName = "year_on_year")]
        public double? YearOnYear { get; set; }

    }
}
