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
namespace SevDesk.Api.V2.Invoice.Item.SendViaEmail
{
    /// <summary>
    /// Builds and executes requests for operations under \Invoice\{invoiceId}\sendViaEmail
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class SendViaEmailRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::SevDesk.Api.V2.Invoice.Item.SendViaEmail.SendViaEmailRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SendViaEmailRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Invoice/{invoiceId}/sendViaEmail", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::SevDesk.Api.V2.Invoice.Item.SendViaEmail.SendViaEmailRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SendViaEmailRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Invoice/{invoiceId}/sendViaEmail", rawUrl)
        {
        }
        /// <summary>
        /// This endpoint sends the specified invoice to a customer via email.&lt;br&gt;    This will automatically mark the invoice as sent.&lt;br&gt;    Please note, that in production an invoice is not allowed to be changed after this happened!
        /// </summary>
        /// <returns>A <see cref="global::SevDesk.Api.V2.Models.Model_Email"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::SevDesk.Api.V2.Models.Model_Email?> PostAsync(global::SevDesk.Api.V2.Invoice.Item.SendViaEmail.SendViaEmailPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::SevDesk.Api.V2.Models.Model_Email> PostAsync(global::SevDesk.Api.V2.Invoice.Item.SendViaEmail.SendViaEmailPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<global::SevDesk.Api.V2.Models.Model_Email>(requestInfo, global::SevDesk.Api.V2.Models.Model_Email.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// This endpoint sends the specified invoice to a customer via email.&lt;br&gt;    This will automatically mark the invoice as sent.&lt;br&gt;    Please note, that in production an invoice is not allowed to be changed after this happened!
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::SevDesk.Api.V2.Invoice.Item.SendViaEmail.SendViaEmailPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::SevDesk.Api.V2.Invoice.Item.SendViaEmail.SendViaEmailPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::SevDesk.Api.V2.Invoice.Item.SendViaEmail.SendViaEmailRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::SevDesk.Api.V2.Invoice.Item.SendViaEmail.SendViaEmailRequestBuilder WithUrl(string rawUrl)
        {
            return new global::SevDesk.Api.V2.Invoice.Item.SendViaEmail.SendViaEmailRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
        public partial class SendViaEmailRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
