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

    public partial class JournalsDownloadNotFoundError
    {
        /// <summary>
        /// Initializes a new instance of the JournalsDownloadNotFoundError
        /// class.
        /// </summary>
        public JournalsDownloadNotFoundError()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JournalsDownloadNotFoundError
        /// class.
        /// </summary>
        /// <param name="message">Possible values include: 'レポートが見つかりません。',
        /// '不正な形式のレポートです。'</param>
        public JournalsDownloadNotFoundError(string message)
        {
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'レポートが見つかりません。',
        /// '不正な形式のレポートです。'
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

    }
}
