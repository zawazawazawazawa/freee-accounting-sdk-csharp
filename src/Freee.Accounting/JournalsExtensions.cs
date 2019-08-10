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
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Journals.
    /// </summary>
    public static partial class JournalsExtensions
    {
            /// <summary>
            /// ダウンロード要求
            /// </summary>
            /// <remarks>
            /// ユーザが所属する事業所の仕訳帳のダウンロードをリクエストします 生成されるファイルに関しては、&lt;a
            /// href="https://support.freee.co.jp/hc/ja/articles/204599604#2"&gt;ヘルプページ&lt;/a&gt;をご参照ください
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='downloadType'>
            /// ダウンロード形式. Possible values include: 'csv', 'pdf', 'yayoi', 'generic'
            /// </param>
            /// <param name='companyId'>
            /// 事業所ID
            /// </param>
            /// <param name='visibleTags'>
            /// 補助科目やコメントとして出力する項目
            /// </param>
            /// <param name='startDate'>
            /// 取得開始日 (yyyy-mm-dd)
            /// </param>
            /// <param name='endDate'>
            /// 取得終了日 (yyyy-mm-dd)
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JournalsEnqueueJournalsResponse> GetAsync(this IJournals operations, string downloadType, int companyId, IList<string> visibleTags = default(IList<string>), string startDate = default(string), string endDate = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(downloadType, companyId, visibleTags, startDate, endDate, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// ステータス確認
            /// </summary>
            /// <remarks>
            /// ダウンロードリクエストのステータスを確認する
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='companyId'>
            /// 事業所ID
            /// </param>
            /// <param name='id'>
            /// 受け付けID
            /// </param>
            /// <param name='visibleTags'>
            /// 補助科目やコメントとして出力する項目
            /// </param>
            /// <param name='startDate'>
            /// 取得開始日 (yyyy-mm-dd)
            /// </param>
            /// <param name='endDate'>
            /// 取得終了日 (yyyy-mm-dd)
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JournalsStatusResponse> GetStatusAsync(this IJournals operations, int companyId, int id, IList<string> visibleTags = default(IList<string>), string startDate = default(string), string endDate = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetStatusWithHttpMessagesAsync(companyId, id, visibleTags, startDate, endDate, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// ダウンロード実行
            /// </summary>
            /// <remarks>
            /// ダウンロードを実行する
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// 受け付けID
            /// </param>
            /// <param name='companyId'>
            /// 事業所ID
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DownloadAsync(this IJournals operations, int id, int companyId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DownloadWithHttpMessagesAsync(id, companyId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
