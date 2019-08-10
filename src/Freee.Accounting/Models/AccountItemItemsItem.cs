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

    public partial class AccountItemItemsItem
    {
        /// <summary>
        /// Initializes a new instance of the AccountItemItemsItem class.
        /// </summary>
        public AccountItemItemsItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AccountItemItemsItem class.
        /// </summary>
        /// <param name="id">品目ID</param>
        /// <param name="name">品目</param>
        public AccountItemItemsItem(int id, string name)
        {
            Id = id;
            Name = name;
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

    }
}
