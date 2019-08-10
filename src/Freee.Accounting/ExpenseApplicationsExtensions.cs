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
    /// Extension methods for ExpenseApplications.
    /// </summary>
    public static partial class ExpenseApplicationsExtensions
    {
            /// <summary>
            /// 経費申請の作成
            /// </summary>
            /// <remarks>
            /// 指定した事業所の経費申請を作成する
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// 経費申請の作成
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExpenseApplicationsResponse> CreateAsync(this IExpenseApplications operations, CreateExpenseApplicationParams parameters = default(CreateExpenseApplicationParams), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// 経費申請の更新
            /// </summary>
            /// <remarks>
            /// 指定した事業所の経費申請を更新する
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='parameters'>
            /// 経費申請の更新
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExpenseApplicationsResponse> UpdateAsync(this IExpenseApplications operations, int id, UpdateExpenseApplicationParams parameters = default(UpdateExpenseApplicationParams), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(id, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// 経費申請の削除
            /// </summary>
            /// <remarks>
            /// 指定した事業所の経費申請を削除する
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='companyId'>
            /// 事業所ID
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DestroyAsync(this IExpenseApplications operations, int id, int companyId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DestroyWithHttpMessagesAsync(id, companyId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
