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

    public partial class RenewsUpdateParams
    {
        /// <summary>
        /// Initializes a new instance of the RenewsUpdateParams class.
        /// </summary>
        public RenewsUpdateParams()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RenewsUpdateParams class.
        /// </summary>
        /// <param name="companyId">事業所ID</param>
        /// <param name="updateDate">更新日 (yyyy-mm-dd)</param>
        /// <param name="details">+更新の明細行</param>
        public RenewsUpdateParams(int companyId, string updateDate, IList<RenewsUpdateDetailParams> details)
        {
            CompanyId = companyId;
            UpdateDate = updateDate;
            Details = details;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets 事業所ID
        /// </summary>
        [JsonProperty(PropertyName = "company_id")]
        public int CompanyId { get; set; }

        /// <summary>
        /// Gets or sets 更新日 (yyyy-mm-dd)
        /// </summary>
        [JsonProperty(PropertyName = "update_date")]
        public string UpdateDate { get; set; }

        /// <summary>
        /// Gets or sets +更新の明細行
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public IList<RenewsUpdateDetailParams> Details { get; set; }

    }
}
