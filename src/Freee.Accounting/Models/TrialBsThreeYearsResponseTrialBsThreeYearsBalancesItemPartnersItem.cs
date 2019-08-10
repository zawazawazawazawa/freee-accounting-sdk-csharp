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

    public partial class TrialBsThreeYearsResponseTrialBsThreeYearsBalancesItemPartnersItem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// TrialBsThreeYearsResponseTrialBsThreeYearsBalancesItemPartnersItem
        /// class.
        /// </summary>
        public TrialBsThreeYearsResponseTrialBsThreeYearsBalancesItemPartnersItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// TrialBsThreeYearsResponseTrialBsThreeYearsBalancesItemPartnersItem
        /// class.
        /// </summary>
        /// <param name="id">取引先ID</param>
        /// <param name="name">取引先名</param>
        /// <param name="twoYearsBeforeClosingBalance">前々年度期末残高</param>
        /// <param name="lastYearClosingBalance">前年度期末残高</param>
        /// <param name="closingBalance">期末残高</param>
        /// <param name="yearOnYear">前年比</param>
        public TrialBsThreeYearsResponseTrialBsThreeYearsBalancesItemPartnersItem(int id, string name = default(string), int? twoYearsBeforeClosingBalance = default(int?), int? lastYearClosingBalance = default(int?), int? closingBalance = default(int?), double? yearOnYear = default(double?))
        {
            Id = id;
            Name = name;
            TwoYearsBeforeClosingBalance = twoYearsBeforeClosingBalance;
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
        /// Gets or sets 取引先ID
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets 取引先名
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets 前々年度期末残高
        /// </summary>
        [JsonProperty(PropertyName = "two_years_before_closing_balance")]
        public int? TwoYearsBeforeClosingBalance { get; set; }

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
