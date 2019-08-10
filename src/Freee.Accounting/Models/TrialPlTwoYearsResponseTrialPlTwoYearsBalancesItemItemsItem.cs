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

    public partial class TrialPlTwoYearsResponseTrialPlTwoYearsBalancesItemItemsItem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// TrialPlTwoYearsResponseTrialPlTwoYearsBalancesItemItemsItem class.
        /// </summary>
        public TrialPlTwoYearsResponseTrialPlTwoYearsBalancesItemItemsItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// TrialPlTwoYearsResponseTrialPlTwoYearsBalancesItemItemsItem class.
        /// </summary>
        /// <param name="id">品目ID</param>
        /// <param name="name">品目</param>
        /// <param name="lastYearClosingBalance">前年度期末残高</param>
        /// <param name="closingBalance">期末残高</param>
        /// <param name="yearOnYear">前年比</param>
        public TrialPlTwoYearsResponseTrialPlTwoYearsBalancesItemItemsItem(int id, string name = default(string), int? lastYearClosingBalance = default(int?), int? closingBalance = default(int?), double? yearOnYear = default(double?))
        {
            Id = id;
            Name = name;
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
        /// Gets or sets 品目ID
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets 品目
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

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
