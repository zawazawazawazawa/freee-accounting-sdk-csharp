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

    public partial class SectionsIndexResponse
    {
        /// <summary>
        /// Initializes a new instance of the SectionsIndexResponse class.
        /// </summary>
        public SectionsIndexResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SectionsIndexResponse class.
        /// </summary>
        public SectionsIndexResponse(IList<SectionsIndexResponseSectionsItem> sections)
        {
            Sections = sections;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sections")]
        public IList<SectionsIndexResponseSectionsItem> Sections { get; set; }

    }
}
