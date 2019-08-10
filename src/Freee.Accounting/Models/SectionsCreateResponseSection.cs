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

    public partial class SectionsCreateResponseSection
    {
        /// <summary>
        /// Initializes a new instance of the SectionsCreateResponseSection
        /// class.
        /// </summary>
        public SectionsCreateResponseSection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SectionsCreateResponseSection
        /// class.
        /// </summary>
        /// <param name="id">部門ID</param>
        /// <param name="name">部門名 (30文字以内)</param>
        /// <param name="companyId">事業所ID</param>
        /// <param name="longName">正式名称（255文字以内）</param>
        /// <param name="shortcut1">ショートカット１ (20文字以内)</param>
        /// <param name="shortcut2">ショートカット２ (20文字以内)</param>
        public SectionsCreateResponseSection(int id, string name, int companyId, string longName = default(string), string shortcut1 = default(string), string shortcut2 = default(string))
        {
            Id = id;
            Name = name;
            LongName = longName;
            CompanyId = companyId;
            Shortcut1 = shortcut1;
            Shortcut2 = shortcut2;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets 部門ID
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets 部門名 (30文字以内)
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets 正式名称（255文字以内）
        /// </summary>
        [JsonProperty(PropertyName = "long_name")]
        public string LongName { get; set; }

        /// <summary>
        /// Gets or sets 事業所ID
        /// </summary>
        [JsonProperty(PropertyName = "company_id")]
        public int CompanyId { get; set; }

        /// <summary>
        /// Gets or sets ショートカット１ (20文字以内)
        /// </summary>
        [JsonProperty(PropertyName = "shortcut1")]
        public string Shortcut1 { get; set; }

        /// <summary>
        /// Gets or sets ショートカット２ (20文字以内)
        /// </summary>
        [JsonProperty(PropertyName = "shortcut2")]
        public string Shortcut2 { get; set; }

    }
}
