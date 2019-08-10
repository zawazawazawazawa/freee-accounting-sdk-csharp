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

    public partial class TrialPlResponse
    {
        /// <summary>
        /// Initializes a new instance of the TrialPlResponse class.
        /// </summary>
        public TrialPlResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TrialPlResponse class.
        /// </summary>
        public TrialPlResponse(TrialPlResponseTrialPl trialPl)
        {
            TrialPl = trialPl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "trial_pl")]
        public TrialPlResponseTrialPl TrialPl { get; set; }

    }
}
