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

    public partial class TaxesCompaniesResponseTaxesItem
    {
        /// <summary>
        /// Initializes a new instance of the TaxesCompaniesResponseTaxesItem
        /// class.
        /// </summary>
        public TaxesCompaniesResponseTaxesItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TaxesCompaniesResponseTaxesItem
        /// class.
        /// </summary>
        /// <param name="code">税区分コード</param>
        /// <param name="name">税区分名</param>
        /// <param name="nameJa">税区分名（日本語表示用）</param>
        /// <param name="displayCategory">税区分の表示カテゴリ（tax_5: 5%表示の税区分、tax_8:
        /// 8%表示の税区分、tax_r8: 軽減税率8%表示の税区分、tax_10: 10%表示の税区分、null: 税率未設定税区分）.
        /// Possible values include: 'tax_5', 'tax_8', 'tax_r8', 'tax_10',
        /// ''</param>
        /// <param name="available">true: 使用する、false: 使用しない</param>
        public TaxesCompaniesResponseTaxesItem(int code, string name, string nameJa, string displayCategory, bool available)
        {
            Code = code;
            Name = name;
            NameJa = nameJa;
            DisplayCategory = displayCategory;
            Available = available;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets 税区分コード
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public int Code { get; set; }

        /// <summary>
        /// Gets or sets 税区分名
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets 税区分名（日本語表示用）
        /// </summary>
        [JsonProperty(PropertyName = "name_ja")]
        public string NameJa { get; set; }

        /// <summary>
        /// Gets or sets 税区分の表示カテゴリ（tax_5: 5%表示の税区分、tax_8: 8%表示の税区分、tax_r8:
        /// 軽減税率8%表示の税区分、tax_10: 10%表示の税区分、null: 税率未設定税区分）. Possible values
        /// include: 'tax_5', 'tax_8', 'tax_r8', 'tax_10', ''
        /// </summary>
        [JsonProperty(PropertyName = "display_category")]
        public string DisplayCategory { get; set; }

        /// <summary>
        /// Gets or sets true: 使用する、false: 使用しない
        /// </summary>
        [JsonProperty(PropertyName = "available")]
        public bool Available { get; set; }

    }
}
