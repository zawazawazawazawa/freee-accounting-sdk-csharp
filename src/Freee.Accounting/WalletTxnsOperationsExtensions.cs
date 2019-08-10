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
    /// Extension methods for WalletTxnsOperations.
    /// </summary>
    public static partial class WalletTxnsOperationsExtensions
    {
            /// <summary>
            /// 明細一覧の取得
            /// </summary>
            /// <remarks>
            /// 指定した事業所の明細一覧を取得する
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='companyId'>
            /// 事業所ID
            /// </param>
            /// <param name='walletableType'>
            /// 口座区分 (銀行口座: bank_account, クレジットカード: credit_card, 現金: wallet). Possible
            /// values include: 'bank_account', 'credit_card', 'wallet'
            /// </param>
            /// <param name='walletableId'>
            /// 口座ID
            /// </param>
            /// <param name='startDate'>
            /// 取引日で絞込：開始日 (yyyy-mm-dd)
            /// </param>
            /// <param name='endDate'>
            /// 取引日で絞込：終了日 (yyyy-mm-dd)
            /// </param>
            /// <param name='entrySide'>
            /// 入金／出金 (入金: income, 出金: expense). Possible values include: 'income',
            /// 'expense'
            /// </param>
            /// <param name='offset'>
            /// 取得レコードのオフセット (デフォルト: 0)
            /// </param>
            /// <param name='limit'>
            /// 取得レコードの件数 (デフォルト: 20, 最大: 100)
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WalletTxnsIndexResponse> ListAsync(this IWalletTxnsOperations operations, int companyId, string walletableType = default(string), int? walletableId = default(int?), string startDate = default(string), string endDate = default(string), string entrySide = default(string), int? offset = default(int?), int? limit = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(companyId, walletableType, walletableId, startDate, endDate, entrySide, offset, limit, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// 明細の作成
            /// </summary>
            /// <remarks>
            /// 指定した事業所の明細を作成する
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// 明細の作成
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WalletTxnsCreateResponse> CreateAsync(this IWalletTxnsOperations operations, CreateWalletTxnParams parameters = default(CreateWalletTxnParams), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
