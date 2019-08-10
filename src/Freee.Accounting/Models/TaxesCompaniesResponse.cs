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

    public partial class TaxesCompaniesResponse
    {
        /// <summary>
        /// Initializes a new instance of the TaxesCompaniesResponse class.
        /// </summary>
        public TaxesCompaniesResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TaxesCompaniesResponse class.
        /// </summary>
        public TaxesCompaniesResponse(IList<TaxesCompaniesResponseTaxesItem> taxes)
        {
            Taxes = taxes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "taxes")]
        public IList<TaxesCompaniesResponseTaxesItem> Taxes { get; set; }

    }
}
