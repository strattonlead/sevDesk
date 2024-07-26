// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace SevDesk.Api.V2.ReceiptGuidance.ForAccountNumber
{
    /// <summary>
    /// Builds and executes requests for operations under \ReceiptGuidance\forAccountNumber
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class ForAccountNumberRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::SevDesk.Api.V2.ReceiptGuidance.ForAccountNumber.ForAccountNumberRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ForAccountNumberRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/ReceiptGuidance/forAccountNumber?accountNumber={accountNumber}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::SevDesk.Api.V2.ReceiptGuidance.ForAccountNumber.ForAccountNumberRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ForAccountNumberRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/ReceiptGuidance/forAccountNumber?accountNumber={accountNumber}", rawUrl)
        {
        }
        /// <summary>
        /// You can use this endpoint to get additional information about the account that you may want to use.
        /// </summary>
        /// <returns>A <see cref="global::SevDesk.Api.V2.ReceiptGuidance.ForAccountNumber.ForAccountNumberGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::SevDesk.Api.V2.ReceiptGuidance.ForAccountNumber.ForAccountNumberGetResponse?> GetAsForAccountNumberGetResponseAsync(Action<RequestConfiguration<global::SevDesk.Api.V2.ReceiptGuidance.ForAccountNumber.ForAccountNumberRequestBuilder.ForAccountNumberRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::SevDesk.Api.V2.ReceiptGuidance.ForAccountNumber.ForAccountNumberGetResponse> GetAsForAccountNumberGetResponseAsync(Action<RequestConfiguration<global::SevDesk.Api.V2.ReceiptGuidance.ForAccountNumber.ForAccountNumberRequestBuilder.ForAccountNumberRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::SevDesk.Api.V2.ReceiptGuidance.ForAccountNumber.ForAccountNumberGetResponse>(requestInfo, global::SevDesk.Api.V2.ReceiptGuidance.ForAccountNumber.ForAccountNumberGetResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// You can use this endpoint to get additional information about the account that you may want to use.
        /// </summary>
        /// <returns>A <see cref="global::SevDesk.Api.V2.ReceiptGuidance.ForAccountNumber.ForAccountNumberResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This method is obsolete. Use GetAsForAccountNumberGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::SevDesk.Api.V2.ReceiptGuidance.ForAccountNumber.ForAccountNumberResponse?> GetAsync(Action<RequestConfiguration<global::SevDesk.Api.V2.ReceiptGuidance.ForAccountNumber.ForAccountNumberRequestBuilder.ForAccountNumberRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::SevDesk.Api.V2.ReceiptGuidance.ForAccountNumber.ForAccountNumberResponse> GetAsync(Action<RequestConfiguration<global::SevDesk.Api.V2.ReceiptGuidance.ForAccountNumber.ForAccountNumberRequestBuilder.ForAccountNumberRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::SevDesk.Api.V2.ReceiptGuidance.ForAccountNumber.ForAccountNumberResponse>(requestInfo, global::SevDesk.Api.V2.ReceiptGuidance.ForAccountNumber.ForAccountNumberResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// You can use this endpoint to get additional information about the account that you may want to use.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::SevDesk.Api.V2.ReceiptGuidance.ForAccountNumber.ForAccountNumberRequestBuilder.ForAccountNumberRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::SevDesk.Api.V2.ReceiptGuidance.ForAccountNumber.ForAccountNumberRequestBuilder.ForAccountNumberRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::SevDesk.Api.V2.ReceiptGuidance.ForAccountNumber.ForAccountNumberRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::SevDesk.Api.V2.ReceiptGuidance.ForAccountNumber.ForAccountNumberRequestBuilder WithUrl(string rawUrl)
        {
            return new global::SevDesk.Api.V2.ReceiptGuidance.ForAccountNumber.ForAccountNumberRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// You can use this endpoint to get additional information about the account that you may want to use.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
        public partial class ForAccountNumberRequestBuilderGetQueryParameters 
        {
            /// <summary>The datev account number you want to get additional information of</summary>
            [QueryParameter("accountNumber")]
            public int? AccountNumber { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
        public partial class ForAccountNumberRequestBuilderGetRequestConfiguration : RequestConfiguration<global::SevDesk.Api.V2.ReceiptGuidance.ForAccountNumber.ForAccountNumberRequestBuilder.ForAccountNumberRequestBuilderGetQueryParameters>
        {
        }
    }
}