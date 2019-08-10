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
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Receipts operations.
    /// </summary>
    public partial class Receipts : IServiceOperations<AccountingClient>, IReceipts
    {
        /// <summary>
        /// Initializes a new instance of the Receipts class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public Receipts(AccountingClient client)
        {
            if (client == null)
            {
                throw new System.ArgumentNullException("client");
            }
            Client = client;
        }

        /// <summary>
        /// Gets a reference to the AccountingClient
        /// </summary>
        public AccountingClient Client { get; private set; }

        /// <summary>
        /// ファイルボックス 証憑ファイルアップロード
        /// </summary>
        /// <remarks>
        /// ファイルボックスに証憑ファイルをアップロードする
        /// </remarks>
        /// <param name='companyId'>
        /// 事業所ID
        /// </param>
        /// <param name='receipt'>
        /// 証憑ファイル
        /// </param>
        /// <param name='description'>
        /// メモ (255文字以内)
        /// </param>
        /// <param name='issueDate'>
        /// 取引日 (yyyy-mm-dd)
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<HttpOperationResponse<ReceiptCreateResponse>> CreateWithHttpMessagesAsync(int companyId, Stream receipt, string description = default(string), string issueDate = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (receipt == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "receipt");
            }
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("companyId", companyId);
                tracingParameters.Add("description", description);
                tracingParameters.Add("issueDate", issueDate);
                tracingParameters.Add("receipt", receipt);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "Create", tracingParameters);
            }
            // Construct URL
            var _baseUrl = Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "receipts").ToString();
            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("POST");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers


            if (customHeaders != null)
            {
                foreach(var _header in customHeaders)
                {
                    if (_httpRequest.Headers.Contains(_header.Key))
                    {
                        _httpRequest.Headers.Remove(_header.Key);
                    }
                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }
            }

            // Serialize Request
            string _requestContent = null;
            MultipartFormDataContent _multiPartContent = new MultipartFormDataContent();
            if (companyId != null)
            {
                StringContent _companyId = new StringContent(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(companyId, Client.SerializationSettings).Trim('"'), System.Text.Encoding.UTF8);
                _multiPartContent.Add(_companyId, "company_id");
            }
            if (description != null)
            {
                StringContent _description = new StringContent(description, System.Text.Encoding.UTF8);
                _multiPartContent.Add(_description, "description");
            }
            if (issueDate != null)
            {
                StringContent _issueDate = new StringContent(issueDate, System.Text.Encoding.UTF8);
                _multiPartContent.Add(_issueDate, "issue_date");
            }
            if (receipt != null)
            {
                StreamContent _receipt = new StreamContent(receipt);
                _receipt.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                ContentDispositionHeaderValue _contentDispositionHeaderValue = new ContentDispositionHeaderValue("form-data");
                _contentDispositionHeaderValue.Name = "receipt";
                // get filename from stream if it's a file otherwise, just use  'unknown'
                var _fileStream = receipt as FileStream;
                var _fileName = (_fileStream != null ? _fileStream.Name : null) ?? "unknown";
                if(System.Linq.Enumerable.Any(_fileName, c => c > 127) )
                {
                    // non ASCII chars detected, need UTF encoding:
                    _contentDispositionHeaderValue.FileNameStar = _fileName;
                }
                else
                {
                    // ASCII only
                    _contentDispositionHeaderValue.FileName = _fileName;
                }
                _receipt.Headers.ContentDisposition = _contentDispositionHeaderValue;
                _multiPartContent.Add(_receipt, "receipt");
            }
            _httpRequest.Content = _multiPartContent;
            // Set Credentials
            if (Client.Credentials != null)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await Client.Credentials.ProcessHttpRequestAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            }
            // Send Request
            if (_shouldTrace)
            {
                ServiceClientTracing.SendRequest(_invocationId, _httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await Client.HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            if (_shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(_invocationId, _httpResponse);
            }
            HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;
            if ((int)_statusCode != 201)
            {
                var ex = new HttpOperationException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                if (_httpResponse.Content != null) {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                }
                else {
                    _responseContent = string.Empty;
                }
                ex.Request = new HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent);
                if (_shouldTrace)
                {
                    ServiceClientTracing.Error(_invocationId, ex);
                }
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw ex;
            }
            // Create Result
            var _result = new HttpOperationResponse<ReceiptCreateResponse>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            // Deserialize Response
            if ((int)_statusCode == 201)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<ReceiptCreateResponse>(_responseContent, Client.DeserializationSettings);
                }
                catch (JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            if (_shouldTrace)
            {
                ServiceClientTracing.Exit(_invocationId, _result);
            }
            return _result;
        }

    }
}
