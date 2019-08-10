// <auto-generated>
// Copyright (c) freee K.K. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license
// information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
//
// </auto-generated>

namespace Freee.Accounting
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Selectables.
    /// </summary>
    public static partial class SelectablesExtensions
    {
            /// <summary>
            /// フォーム用選択項目情報の取得
            /// </summary>
            /// <remarks>
            /// 指定した事業所のフォーム用選択項目情報を取得する
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='companyId'>
            /// 事業所ID
            /// </param>
            /// <param name='includes'>
            /// 取得する項目(項目: account_item). Possible values include: 'account_item'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SelectablesIndexResponse> GetFormsAsync(this ISelectables operations, int companyId, string includes = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetFormsWithHttpMessagesAsync(companyId, includes, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
