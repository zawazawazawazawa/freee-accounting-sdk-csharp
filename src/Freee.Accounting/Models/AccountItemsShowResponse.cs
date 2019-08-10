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

    public partial class AccountItemsShowResponse
    {
        /// <summary>
        /// Initializes a new instance of the AccountItemsShowResponse class.
        /// </summary>
        public AccountItemsShowResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AccountItemsShowResponse class.
        /// </summary>
        public AccountItemsShowResponse(AccountItem accountItem)
        {
            AccountItem = accountItem;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "account_item")]
        public AccountItem AccountItem { get; set; }

    }
}
