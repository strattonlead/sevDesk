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
namespace SevDesk.Api.V2.Invoice.Item.Enshrine
{
    /// <summary>
    /// Builds and executes requests for operations under \Invoice\{invoiceId}\enshrine
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class EnshrineRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::SevDesk.Api.V2.Invoice.Item.Enshrine.EnshrineRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EnshrineRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Invoice/{invoiceId}/enshrine", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::SevDesk.Api.V2.Invoice.Item.Enshrine.EnshrineRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EnshrineRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Invoice/{invoiceId}/enshrine", rawUrl)
        {
        }
        /// <summary>
        /// Sets the current date and time as a value for the property `enshrined`.&lt;br&gt;This operation is only possible if the status is &quot;Open&quot; (`&quot;status&quot;: &quot;200&quot;`) or higher.Enshrined invoices cannot be changed. This operation cannot be undone.
        /// </summary>
        /// <returns>A <see cref="global::SevDesk.Api.V2.Invoice.Item.Enshrine.EnshrinePutResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::SevDesk.Api.V2.Models.ValidationError">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::SevDesk.Api.V2.Invoice.Item.Enshrine.EnshrinePutResponse?> PutAsEnshrinePutResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::SevDesk.Api.V2.Invoice.Item.Enshrine.EnshrinePutResponse> PutAsEnshrinePutResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToPutRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "422", global::SevDesk.Api.V2.Models.ValidationError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::SevDesk.Api.V2.Invoice.Item.Enshrine.EnshrinePutResponse>(requestInfo, global::SevDesk.Api.V2.Invoice.Item.Enshrine.EnshrinePutResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Sets the current date and time as a value for the property `enshrined`.&lt;br&gt;This operation is only possible if the status is &quot;Open&quot; (`&quot;status&quot;: &quot;200&quot;`) or higher.Enshrined invoices cannot be changed. This operation cannot be undone.
        /// </summary>
        /// <returns>A <see cref="global::SevDesk.Api.V2.Invoice.Item.Enshrine.EnshrineResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::SevDesk.Api.V2.Models.ValidationError">When receiving a 422 status code</exception>
        [Obsolete("This method is obsolete. Use PutAsEnshrinePutResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::SevDesk.Api.V2.Invoice.Item.Enshrine.EnshrineResponse?> PutAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::SevDesk.Api.V2.Invoice.Item.Enshrine.EnshrineResponse> PutAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToPutRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "422", global::SevDesk.Api.V2.Models.ValidationError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::SevDesk.Api.V2.Invoice.Item.Enshrine.EnshrineResponse>(requestInfo, global::SevDesk.Api.V2.Invoice.Item.Enshrine.EnshrineResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Sets the current date and time as a value for the property `enshrined`.&lt;br&gt;This operation is only possible if the status is &quot;Open&quot; (`&quot;status&quot;: &quot;200&quot;`) or higher.Enshrined invoices cannot be changed. This operation cannot be undone.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.PUT, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::SevDesk.Api.V2.Invoice.Item.Enshrine.EnshrineRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::SevDesk.Api.V2.Invoice.Item.Enshrine.EnshrineRequestBuilder WithUrl(string rawUrl)
        {
            return new global::SevDesk.Api.V2.Invoice.Item.Enshrine.EnshrineRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
        public partial class EnshrineRequestBuilderPutRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
