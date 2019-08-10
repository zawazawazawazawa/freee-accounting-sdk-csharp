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

    public partial class UpdateExpenseApplicationParams
    {
        /// <summary>
        /// Initializes a new instance of the UpdateExpenseApplicationParams
        /// class.
        /// </summary>
        public UpdateExpenseApplicationParams()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UpdateExpenseApplicationParams
        /// class.
        /// </summary>
        /// <param name="companyId">事業所ID</param>
        /// <param name="title">申請タイトル</param>
        /// <param name="issueDate">申請日 (yyyy-mm-dd)</param>
        /// <param name="description">備考</param>
        /// <param
        /// name="editableOnWeb">会計freeeのWeb画面から申請内容を編集可能：falseの場合、Web上からの項目行の追加／削除・金額の編集が出来なくなります。APIでの編集は可能です。</param>
        /// <param name="sectionId">部門ID</param>
        /// <param name="tagIds">メモタグID</param>
        public UpdateExpenseApplicationParams(int companyId, string title, IList<UpdateExpenseApplicationParamsExpenseApplicationLinesItem> expenseApplicationLines, string issueDate = default(string), string description = default(string), bool? editableOnWeb = default(bool?), int? sectionId = default(int?), IList<int?> tagIds = default(IList<int?>))
        {
            CompanyId = companyId;
            Title = title;
            IssueDate = issueDate;
            Description = description;
            EditableOnWeb = editableOnWeb;
            SectionId = sectionId;
            TagIds = tagIds;
            ExpenseApplicationLines = expenseApplicationLines;
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
        /// Gets or sets 申請タイトル
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets 申請日 (yyyy-mm-dd)
        /// </summary>
        [JsonProperty(PropertyName = "issue_date")]
        public string IssueDate { get; set; }

        /// <summary>
        /// Gets or sets 備考
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets
        /// 会計freeeのWeb画面から申請内容を編集可能：falseの場合、Web上からの項目行の追加／削除・金額の編集が出来なくなります。APIでの編集は可能です。
        /// </summary>
        [JsonProperty(PropertyName = "editable_on_web")]
        public bool? EditableOnWeb { get; set; }

        /// <summary>
        /// Gets or sets 部門ID
        /// </summary>
        [JsonProperty(PropertyName = "section_id")]
        public int? SectionId { get; set; }

        /// <summary>
        /// Gets or sets メモタグID
        /// </summary>
        [JsonProperty(PropertyName = "tag_ids")]
        public IList<int?> TagIds { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "expense_application_lines")]
        public IList<UpdateExpenseApplicationParamsExpenseApplicationLinesItem> ExpenseApplicationLines { get; set; }

    }
}
