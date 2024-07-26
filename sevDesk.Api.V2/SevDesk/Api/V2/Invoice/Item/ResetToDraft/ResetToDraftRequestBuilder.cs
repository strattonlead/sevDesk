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
namespace SevDesk.Api.V2.Invoice.Item.ResetToDraft
{
    /// <summary>
    /// Builds and executes requests for operations under \Invoice\{invoiceId}\resetToDraft
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class ResetToDraftRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::SevDesk.Api.V2.Invoice.Item.ResetToDraft.ResetToDraftRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ResetToDraftRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Invoice/{invoiceId}/resetToDraft", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::SevDesk.Api.V2.Invoice.Item.ResetToDraft.ResetToDraftRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ResetToDraftRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Invoice/{invoiceId}/resetToDraft", rawUrl)
        {
        }
        /// <summary>
        /// Resets the status to &quot;Draft&quot; (`&quot;status&quot;: &quot;100&quot;`).&lt;br&gt;This is only possible if the invoice has the status &quot;Open&quot; (`&quot;status&quot;: &quot;200&quot;`).&lt;br&gt;If it has a higher status use [Invoice/{invoiceId}/resetToOpen](#tag/Invoice/operation/invoiceResetToOpen) first.This endpoint cannot be used for recurring invoices (`&quot;invoiceType&quot;: &quot;WKR&quot;`).&lt;br&gt;Use [Invoice/Factory/saveInvoice](#tag/Invoice/operation/createInvoiceByFactory) instead.
        /// </summary>
        /// <returns>A <see cref="global::SevDesk.Api.V2.Invoice.Item.ResetToDraft.ResetToDraftPutResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::SevDesk.Api.V2.Models.ValidationError">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::SevDesk.Api.V2.Invoice.Item.ResetToDraft.ResetToDraftPutResponse?> PutAsResetToDraftPutResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::SevDesk.Api.V2.Invoice.Item.ResetToDraft.ResetToDraftPutResponse> PutAsResetToDraftPutResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToPutRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "422", global::SevDesk.Api.V2.Models.ValidationError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::SevDesk.Api.V2.Invoice.Item.ResetToDraft.ResetToDraftPutResponse>(requestInfo, global::SevDesk.Api.V2.Invoice.Item.ResetToDraft.ResetToDraftPutResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Resets the status to &quot;Draft&quot; (`&quot;status&quot;: &quot;100&quot;`).&lt;br&gt;This is only possible if the invoice has the status &quot;Open&quot; (`&quot;status&quot;: &quot;200&quot;`).&lt;br&gt;If it has a higher status use [Invoice/{invoiceId}/resetToOpen](#tag/Invoice/operation/invoiceResetToOpen) first.This endpoint cannot be used for recurring invoices (`&quot;invoiceType&quot;: &quot;WKR&quot;`).&lt;br&gt;Use [Invoice/Factory/saveInvoice](#tag/Invoice/operation/createInvoiceByFactory) instead.
        /// </summary>
        /// <returns>A <see cref="global::SevDesk.Api.V2.Invoice.Item.ResetToDraft.ResetToDraftResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::SevDesk.Api.V2.Models.ValidationError">When receiving a 422 status code</exception>
        [Obsolete("This method is obsolete. Use PutAsResetToDraftPutResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::SevDesk.Api.V2.Invoice.Item.ResetToDraft.ResetToDraftResponse?> PutAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::SevDesk.Api.V2.Invoice.Item.ResetToDraft.ResetToDraftResponse> PutAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToPutRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "422", global::SevDesk.Api.V2.Models.ValidationError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::SevDesk.Api.V2.Invoice.Item.ResetToDraft.ResetToDraftResponse>(requestInfo, global::SevDesk.Api.V2.Invoice.Item.ResetToDraft.ResetToDraftResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Resets the status to &quot;Draft&quot; (`&quot;status&quot;: &quot;100&quot;`).&lt;br&gt;This is only possible if the invoice has the status &quot;Open&quot; (`&quot;status&quot;: &quot;200&quot;`).&lt;br&gt;If it has a higher status use [Invoice/{invoiceId}/resetToOpen](#tag/Invoice/operation/invoiceResetToOpen) first.This endpoint cannot be used for recurring invoices (`&quot;invoiceType&quot;: &quot;WKR&quot;`).&lt;br&gt;Use [Invoice/Factory/saveInvoice](#tag/Invoice/operation/createInvoiceByFactory) instead.
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
        /// <returns>A <see cref="global::SevDesk.Api.V2.Invoice.Item.ResetToDraft.ResetToDraftRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::SevDesk.Api.V2.Invoice.Item.ResetToDraft.ResetToDraftRequestBuilder WithUrl(string rawUrl)
        {
            return new global::SevDesk.Api.V2.Invoice.Item.ResetToDraft.ResetToDraftRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
        public partial class ResetToDraftRequestBuilderPutRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}