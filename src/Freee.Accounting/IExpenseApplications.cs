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
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ExpenseApplications operations.
    /// </summary>
    public partial interface IExpenseApplications
    {
        /// <summary>
        /// 経費申請の作成
        /// </summary>
        /// <remarks>
        /// 指定した事業所の経費申請を作成する
        /// </remarks>
        /// <param name='parameters'>
        /// 経費申請の作成
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<ExpenseApplicationsResponse>> CreateWithHttpMessagesAsync(CreateExpenseApplicationParams parameters = default(CreateExpenseApplicationParams), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// 経費申請の更新
        /// </summary>
        /// <remarks>
        /// 指定した事業所の経費申請を更新する
        /// </remarks>
        /// <param name='id'>
        /// </param>
        /// <param name='parameters'>
        /// 経費申請の更新
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<ExpenseApplicationsResponse>> UpdateWithHttpMessagesAsync(int id, UpdateExpenseApplicationParams parameters = default(UpdateExpenseApplicationParams), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// 経費申請の削除
        /// </summary>
        /// <remarks>
        /// 指定した事業所の経費申請を削除する
        /// </remarks>
        /// <param name='id'>
        /// </param>
        /// <param name='companyId'>
        /// 事業所ID
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        Task<HttpOperationResponse> DestroyWithHttpMessagesAsync(int id, int companyId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
