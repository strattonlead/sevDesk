// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace SevDesk.Api.V2.Voucher.Factory.UploadTempFile
{
    /// <summary>
    /// Builds and executes requests for operations under \Voucher\Factory\uploadTempFile
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class UploadTempFileRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::SevDesk.Api.V2.Voucher.Factory.UploadTempFile.UploadTempFileRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UploadTempFileRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Voucher/Factory/uploadTempFile", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::SevDesk.Api.V2.Voucher.Factory.UploadTempFile.UploadTempFileRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UploadTempFileRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Voucher/Factory/uploadTempFile", rawUrl)
        {
        }
        /// <summary>
        /// To attach a document to a voucher, you will need to upload it first for later use.&lt;br&gt; To do this, you can use this request.&lt;br&gt; When you successfully uploaded the file, you will get a sevdesk internal filename in the response.&lt;br&gt; The filename will be a hash generated from your uploaded file. You will need it in the next request!&lt;br&gt; After you got the just mentioned filename, you can enter it as a value for the filename parameter of the saveVoucher request.&lt;br&gt; If you provided all necessary parameters and kept all of them in the right order, the file will be attached to your voucher.
        /// </summary>
        /// <returns>A <see cref="global::SevDesk.Api.V2.Voucher.Factory.UploadTempFile.UploadTempFilePostResponse"/></returns>
        /// <param name="body">Binary request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::SevDesk.Api.V2.Voucher.Factory.UploadTempFile.UploadTempFilePostResponse?> PostAsUploadTempFilePostResponseAsync(Stream body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::SevDesk.Api.V2.Voucher.Factory.UploadTempFile.UploadTempFilePostResponse> PostAsUploadTempFilePostResponseAsync(Stream body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<global::SevDesk.Api.V2.Voucher.Factory.UploadTempFile.UploadTempFilePostResponse>(requestInfo, global::SevDesk.Api.V2.Voucher.Factory.UploadTempFile.UploadTempFilePostResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// To attach a document to a voucher, you will need to upload it first for later use.&lt;br&gt; To do this, you can use this request.&lt;br&gt; When you successfully uploaded the file, you will get a sevdesk internal filename in the response.&lt;br&gt; The filename will be a hash generated from your uploaded file. You will need it in the next request!&lt;br&gt; After you got the just mentioned filename, you can enter it as a value for the filename parameter of the saveVoucher request.&lt;br&gt; If you provided all necessary parameters and kept all of them in the right order, the file will be attached to your voucher.
        /// </summary>
        /// <returns>A <see cref="global::SevDesk.Api.V2.Voucher.Factory.UploadTempFile.UploadTempFileResponse"/></returns>
        /// <param name="body">Binary request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This method is obsolete. Use PostAsUploadTempFilePostResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::SevDesk.Api.V2.Voucher.Factory.UploadTempFile.UploadTempFileResponse?> PostAsync(Stream body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::SevDesk.Api.V2.Voucher.Factory.UploadTempFile.UploadTempFileResponse> PostAsync(Stream body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<global::SevDesk.Api.V2.Voucher.Factory.UploadTempFile.UploadTempFileResponse>(requestInfo, global::SevDesk.Api.V2.Voucher.Factory.UploadTempFile.UploadTempFileResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// To attach a document to a voucher, you will need to upload it first for later use.&lt;br&gt; To do this, you can use this request.&lt;br&gt; When you successfully uploaded the file, you will get a sevdesk internal filename in the response.&lt;br&gt; The filename will be a hash generated from your uploaded file. You will need it in the next request!&lt;br&gt; After you got the just mentioned filename, you can enter it as a value for the filename parameter of the saveVoucher request.&lt;br&gt; If you provided all necessary parameters and kept all of them in the right order, the file will be attached to your voucher.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">Binary request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Stream body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Stream body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetStreamContent(body, "form-data");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::SevDesk.Api.V2.Voucher.Factory.UploadTempFile.UploadTempFileRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::SevDesk.Api.V2.Voucher.Factory.UploadTempFile.UploadTempFileRequestBuilder WithUrl(string rawUrl)
        {
            return new global::SevDesk.Api.V2.Voucher.Factory.UploadTempFile.UploadTempFileRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
        public partial class UploadTempFileRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}