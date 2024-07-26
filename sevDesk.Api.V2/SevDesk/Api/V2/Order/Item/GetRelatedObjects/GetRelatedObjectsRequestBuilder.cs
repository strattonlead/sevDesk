// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace SevDesk.Api.V2.Order.Item.GetRelatedObjects
{
    /// <summary>
    /// Builds and executes requests for operations under \Order\{orderId}\getRelatedObjects
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class GetRelatedObjectsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::SevDesk.Api.V2.Order.Item.GetRelatedObjects.GetRelatedObjectsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetRelatedObjectsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Order/{orderId}/getRelatedObjects{?embed*,includeItself*,sortByType*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::SevDesk.Api.V2.Order.Item.GetRelatedObjects.GetRelatedObjectsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetRelatedObjectsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Order/{orderId}/getRelatedObjects{?embed*,includeItself*,sortByType*}", rawUrl)
        {
        }
        /// <summary>
        /// Get related objects of a specified order
        /// </summary>
        /// <returns>A <see cref="global::SevDesk.Api.V2.Order.Item.GetRelatedObjects.GetRelatedObjectsGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::SevDesk.Api.V2.Order.Item.GetRelatedObjects.GetRelatedObjectsGetResponse?> GetAsGetRelatedObjectsGetResponseAsync(Action<RequestConfiguration<global::SevDesk.Api.V2.Order.Item.GetRelatedObjects.GetRelatedObjectsRequestBuilder.GetRelatedObjectsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::SevDesk.Api.V2.Order.Item.GetRelatedObjects.GetRelatedObjectsGetResponse> GetAsGetRelatedObjectsGetResponseAsync(Action<RequestConfiguration<global::SevDesk.Api.V2.Order.Item.GetRelatedObjects.GetRelatedObjectsRequestBuilder.GetRelatedObjectsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::SevDesk.Api.V2.Order.Item.GetRelatedObjects.GetRelatedObjectsGetResponse>(requestInfo, global::SevDesk.Api.V2.Order.Item.GetRelatedObjects.GetRelatedObjectsGetResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get related objects of a specified order
        /// </summary>
        /// <returns>A <see cref="global::SevDesk.Api.V2.Order.Item.GetRelatedObjects.GetRelatedObjectsResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This method is obsolete. Use GetAsGetRelatedObjectsGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::SevDesk.Api.V2.Order.Item.GetRelatedObjects.GetRelatedObjectsResponse?> GetAsync(Action<RequestConfiguration<global::SevDesk.Api.V2.Order.Item.GetRelatedObjects.GetRelatedObjectsRequestBuilder.GetRelatedObjectsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::SevDesk.Api.V2.Order.Item.GetRelatedObjects.GetRelatedObjectsResponse> GetAsync(Action<RequestConfiguration<global::SevDesk.Api.V2.Order.Item.GetRelatedObjects.GetRelatedObjectsRequestBuilder.GetRelatedObjectsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::SevDesk.Api.V2.Order.Item.GetRelatedObjects.GetRelatedObjectsResponse>(requestInfo, global::SevDesk.Api.V2.Order.Item.GetRelatedObjects.GetRelatedObjectsResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get related objects of a specified order
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::SevDesk.Api.V2.Order.Item.GetRelatedObjects.GetRelatedObjectsRequestBuilder.GetRelatedObjectsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::SevDesk.Api.V2.Order.Item.GetRelatedObjects.GetRelatedObjectsRequestBuilder.GetRelatedObjectsRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::SevDesk.Api.V2.Order.Item.GetRelatedObjects.GetRelatedObjectsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::SevDesk.Api.V2.Order.Item.GetRelatedObjects.GetRelatedObjectsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::SevDesk.Api.V2.Order.Item.GetRelatedObjects.GetRelatedObjectsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get related objects of a specified order
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
        public partial class GetRelatedObjectsRequestBuilderGetQueryParameters 
        {
            /// <summary>Get some additional information. Embed can handle multiple values, they must be separated by comma.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("embed")]
            public string[]? Embed { get; set; }
#nullable restore
#else
            [QueryParameter("embed")]
            public string[] Embed { get; set; }
#endif
            /// <summary>Define if the related objects include the order itself</summary>
            [QueryParameter("includeItself")]
            public bool? IncludeItself { get; set; }
            /// <summary>Define if you want the related objects sorted by type</summary>
            [QueryParameter("sortByType")]
            public bool? SortByType { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
        public partial class GetRelatedObjectsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::SevDesk.Api.V2.Order.Item.GetRelatedObjects.GetRelatedObjectsRequestBuilder.GetRelatedObjectsRequestBuilderGetQueryParameters>
        {
        }
    }
}