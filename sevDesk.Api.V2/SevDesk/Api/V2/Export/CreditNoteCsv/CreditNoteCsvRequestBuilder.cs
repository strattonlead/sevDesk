// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace SevDesk.Api.V2.Export.CreditNoteCsv
{
    /// <summary>
    /// Builds and executes requests for operations under \Export\creditNoteCsv
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class CreditNoteCsvRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::SevDesk.Api.V2.Export.CreditNoteCsv.CreditNoteCsvRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CreditNoteCsvRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Export/creditNoteCsv?sevQuery={sevQuery}{&download*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::SevDesk.Api.V2.Export.CreditNoteCsv.CreditNoteCsvRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CreditNoteCsvRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Export/creditNoteCsv?sevQuery={sevQuery}{&download*}", rawUrl)
        {
        }
        /// <summary>
        /// Export all credit notes as csv
        /// </summary>
        /// <returns>A <see cref="global::SevDesk.Api.V2.Export.CreditNoteCsv.CreditNoteCsvGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::SevDesk.Api.V2.Export.CreditNoteCsv.CreditNoteCsvGetResponse?> GetAsCreditNoteCsvGetResponseAsync(Action<RequestConfiguration<global::SevDesk.Api.V2.Export.CreditNoteCsv.CreditNoteCsvRequestBuilder.CreditNoteCsvRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::SevDesk.Api.V2.Export.CreditNoteCsv.CreditNoteCsvGetResponse> GetAsCreditNoteCsvGetResponseAsync(Action<RequestConfiguration<global::SevDesk.Api.V2.Export.CreditNoteCsv.CreditNoteCsvRequestBuilder.CreditNoteCsvRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::SevDesk.Api.V2.Export.CreditNoteCsv.CreditNoteCsvGetResponse>(requestInfo, global::SevDesk.Api.V2.Export.CreditNoteCsv.CreditNoteCsvGetResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Export all credit notes as csv
        /// </summary>
        /// <returns>A <see cref="global::SevDesk.Api.V2.Export.CreditNoteCsv.CreditNoteCsvResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This method is obsolete. Use GetAsCreditNoteCsvGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::SevDesk.Api.V2.Export.CreditNoteCsv.CreditNoteCsvResponse?> GetAsync(Action<RequestConfiguration<global::SevDesk.Api.V2.Export.CreditNoteCsv.CreditNoteCsvRequestBuilder.CreditNoteCsvRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::SevDesk.Api.V2.Export.CreditNoteCsv.CreditNoteCsvResponse> GetAsync(Action<RequestConfiguration<global::SevDesk.Api.V2.Export.CreditNoteCsv.CreditNoteCsvRequestBuilder.CreditNoteCsvRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::SevDesk.Api.V2.Export.CreditNoteCsv.CreditNoteCsvResponse>(requestInfo, global::SevDesk.Api.V2.Export.CreditNoteCsv.CreditNoteCsvResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Export all credit notes as csv
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::SevDesk.Api.V2.Export.CreditNoteCsv.CreditNoteCsvRequestBuilder.CreditNoteCsvRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::SevDesk.Api.V2.Export.CreditNoteCsv.CreditNoteCsvRequestBuilder.CreditNoteCsvRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::SevDesk.Api.V2.Export.CreditNoteCsv.CreditNoteCsvRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::SevDesk.Api.V2.Export.CreditNoteCsv.CreditNoteCsvRequestBuilder WithUrl(string rawUrl)
        {
            return new global::SevDesk.Api.V2.Export.CreditNoteCsv.CreditNoteCsvRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Export all credit notes as csv
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
        public partial class CreditNoteCsvRequestBuilderGetQueryParameters 
        {
            [QueryParameter("download")]
            public bool? Download { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sevQuery")]
            public string? SevQuery { get; set; }
#nullable restore
#else
            [QueryParameter("sevQuery")]
            public string SevQuery { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
        public partial class CreditNoteCsvRequestBuilderGetRequestConfiguration : RequestConfiguration<global::SevDesk.Api.V2.Export.CreditNoteCsv.CreditNoteCsvRequestBuilder.CreditNoteCsvRequestBuilderGetQueryParameters>
        {
        }
    }
}
