// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using SevDesk.Api.V2.Models;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace SevDesk.Api.V2.Order.Factory.CreatePackingListFromOrder
{
    /// <summary>
    /// Builds and executes requests for operations under \Order\Factory\createPackingListFromOrder
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class CreatePackingListFromOrderRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::SevDesk.Api.V2.Order.Factory.CreatePackingListFromOrder.CreatePackingListFromOrderRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CreatePackingListFromOrderRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Order/Factory/createPackingListFromOrder?order[id]={order%5Bid%5D}&order[objectName]={order%5BobjectName%5D}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::SevDesk.Api.V2.Order.Factory.CreatePackingListFromOrder.CreatePackingListFromOrderRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CreatePackingListFromOrderRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Order/Factory/createPackingListFromOrder?order[id]={order%5Bid%5D}&order[objectName]={order%5BobjectName%5D}", rawUrl)
        {
        }
        /// <summary>
        /// Create packing list from order
        /// </summary>
        /// <returns>A <see cref="global::SevDesk.Api.V2.Models.Model_OrderResponse"/></returns>
        /// <param name="body">order model</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::SevDesk.Api.V2.Models.Model_OrderResponse?> PostAsync(global::SevDesk.Api.V2.Models.Model_CreatePackingListFromOrder body, Action<RequestConfiguration<global::SevDesk.Api.V2.Order.Factory.CreatePackingListFromOrder.CreatePackingListFromOrderRequestBuilder.CreatePackingListFromOrderRequestBuilderPostQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::SevDesk.Api.V2.Models.Model_OrderResponse> PostAsync(global::SevDesk.Api.V2.Models.Model_CreatePackingListFromOrder body, Action<RequestConfiguration<global::SevDesk.Api.V2.Order.Factory.CreatePackingListFromOrder.CreatePackingListFromOrderRequestBuilder.CreatePackingListFromOrderRequestBuilderPostQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<global::SevDesk.Api.V2.Models.Model_OrderResponse>(requestInfo, global::SevDesk.Api.V2.Models.Model_OrderResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create packing list from order
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">order model</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::SevDesk.Api.V2.Models.Model_CreatePackingListFromOrder body, Action<RequestConfiguration<global::SevDesk.Api.V2.Order.Factory.CreatePackingListFromOrder.CreatePackingListFromOrderRequestBuilder.CreatePackingListFromOrderRequestBuilderPostQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::SevDesk.Api.V2.Models.Model_CreatePackingListFromOrder body, Action<RequestConfiguration<global::SevDesk.Api.V2.Order.Factory.CreatePackingListFromOrder.CreatePackingListFromOrderRequestBuilder.CreatePackingListFromOrderRequestBuilderPostQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::SevDesk.Api.V2.Order.Factory.CreatePackingListFromOrder.CreatePackingListFromOrderRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::SevDesk.Api.V2.Order.Factory.CreatePackingListFromOrder.CreatePackingListFromOrderRequestBuilder WithUrl(string rawUrl)
        {
            return new global::SevDesk.Api.V2.Order.Factory.CreatePackingListFromOrder.CreatePackingListFromOrderRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Create packing list from order
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
        public partial class CreatePackingListFromOrderRequestBuilderPostQueryParameters 
        {
            /// <summary>the id of the order</summary>
            [QueryParameter("order%5Bid%5D")]
            public int? Orderid { get; set; }
            /// <summary>Model name, which is &apos;Order&apos;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("order%5BobjectName%5D")]
            public string? OrderobjectName { get; set; }
#nullable restore
#else
            [QueryParameter("order%5BobjectName%5D")]
            public string OrderobjectName { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
        public partial class CreatePackingListFromOrderRequestBuilderPostRequestConfiguration : RequestConfiguration<global::SevDesk.Api.V2.Order.Factory.CreatePackingListFromOrder.CreatePackingListFromOrderRequestBuilder.CreatePackingListFromOrderRequestBuilderPostQueryParameters>
        {
        }
    }
}
