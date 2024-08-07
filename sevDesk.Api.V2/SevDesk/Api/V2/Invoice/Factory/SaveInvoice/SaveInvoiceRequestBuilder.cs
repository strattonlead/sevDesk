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
namespace SevDesk.Api.V2.Invoice.Factory.SaveInvoice
{
    /// <summary>
    /// Builds and executes requests for operations under \Invoice\Factory\saveInvoice
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class SaveInvoiceRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::SevDesk.Api.V2.Invoice.Factory.SaveInvoice.SaveInvoiceRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SaveInvoiceRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Invoice/Factory/saveInvoice", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::SevDesk.Api.V2.Invoice.Factory.SaveInvoice.SaveInvoiceRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SaveInvoiceRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Invoice/Factory/saveInvoice", rawUrl)
        {
        }
        /// <summary>
        /// This endpoint offers you the following functionality.     &lt;ul&gt;        &lt;li&gt;Create invoices together with positions and discounts&lt;/li&gt;        &lt;li&gt;Delete positions while adding new ones&lt;/li&gt;        &lt;li&gt;Delete or add discounts, or both at the same time&lt;/li&gt;        &lt;li&gt;Automatically fill the address of the supplied contact into the invoice address&lt;/li&gt;     &lt;/ul&gt;     To make your own request sample slimmer, you can omit all parameters which are not required and nullable.     However, for a valid and logical bookkeeping document, you will also need some of them to ensure that all the necessary data is in the invoice.&lt;br&gt;&lt;br&gt; The list of parameters starts with the invoice array.&lt;br&gt; This array contains all required attributes for a complete invoice.&lt;br&gt; Most of the attributes are covered in the invoice attribute list, there are only two parameters standing out, namely &lt;b&gt;mapAll&lt;/b&gt; and &lt;b&gt;objectName&lt;/b&gt;.&lt;br&gt; These are just needed for our system and you always need to provide them.&lt;br&gt;&lt;br&gt; The list of parameters then continues with the invoice position array.&lt;br&gt; With this array you have the possibility to add multiple positions at once.&lt;br&gt; In the example it only contains one position, again together with the parameters &lt;b&gt;mapAll&lt;/b&gt; and &lt;b&gt;objectName&lt;/b&gt;, however, you can add more invoice positions by extending the array.&lt;br&gt; So if you wanted to add another position, you would add the same list of parameters with an incremented array index of &quot;1&quot; instead of &quot;0&quot;.&lt;br&gt;&lt;br&gt; The list ends with the four parameters invoicePosDelete, discountSave, discountDelete and takeDefaultAddress.&lt;br&gt; They only play a minor role if you only want to create an invoice but we will shortly explain what they can do.&lt;br&gt; With invoicePosDelete you have to option to delete invoice positions as this request can also be used to update invoices.&lt;br&gt; With discountSave you can add discounts to your invoice.&lt;br&gt; With discountDelete you can delete discounts from your invoice.&lt;br&gt; With takeDefaultAddress you can specify that the first address of the contact you are using for the invoice is taken for the invoice address attribute automatically, so you don&apos;t need to provide the address yourself.&lt;br&gt; If you want to know more about these parameters, for example if you want to use this request to update invoices, feel free to contact our support.&lt;br&gt;&lt;br&gt; Finally, after covering all parameters, they only important information left, is that the order of the last four attributes always needs to be kept.&lt;br&gt; You will also always need to provide all of them, as otherwise the request won&apos;t work properly.&lt;br&gt;&lt;br&gt; &lt;b&gt;Warning:&lt;/b&gt; You can not create a regular invoice with the &lt;b&gt;deliveryDate&lt;/b&gt; being later than the &lt;b&gt;invoiceDate&lt;/b&gt;.&lt;br&gt; To do that you will need to create a so called &lt;b&gt;Abschlagsrechnung&lt;/b&gt; by setting the &lt;b&gt;invoiceType&lt;/b&gt; parameter to &lt;b&gt;AR&lt;/b&gt;.
        /// </summary>
        /// <returns>A <see cref="global::SevDesk.Api.V2.Models.SaveInvoiceResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::SevDesk.Api.V2.Models.SaveInvoiceResponse?> PostAsync(global::SevDesk.Api.V2.Models.SaveInvoice body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::SevDesk.Api.V2.Models.SaveInvoiceResponse> PostAsync(global::SevDesk.Api.V2.Models.SaveInvoice body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<global::SevDesk.Api.V2.Models.SaveInvoiceResponse>(requestInfo, global::SevDesk.Api.V2.Models.SaveInvoiceResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// This endpoint offers you the following functionality.     &lt;ul&gt;        &lt;li&gt;Create invoices together with positions and discounts&lt;/li&gt;        &lt;li&gt;Delete positions while adding new ones&lt;/li&gt;        &lt;li&gt;Delete or add discounts, or both at the same time&lt;/li&gt;        &lt;li&gt;Automatically fill the address of the supplied contact into the invoice address&lt;/li&gt;     &lt;/ul&gt;     To make your own request sample slimmer, you can omit all parameters which are not required and nullable.     However, for a valid and logical bookkeeping document, you will also need some of them to ensure that all the necessary data is in the invoice.&lt;br&gt;&lt;br&gt; The list of parameters starts with the invoice array.&lt;br&gt; This array contains all required attributes for a complete invoice.&lt;br&gt; Most of the attributes are covered in the invoice attribute list, there are only two parameters standing out, namely &lt;b&gt;mapAll&lt;/b&gt; and &lt;b&gt;objectName&lt;/b&gt;.&lt;br&gt; These are just needed for our system and you always need to provide them.&lt;br&gt;&lt;br&gt; The list of parameters then continues with the invoice position array.&lt;br&gt; With this array you have the possibility to add multiple positions at once.&lt;br&gt; In the example it only contains one position, again together with the parameters &lt;b&gt;mapAll&lt;/b&gt; and &lt;b&gt;objectName&lt;/b&gt;, however, you can add more invoice positions by extending the array.&lt;br&gt; So if you wanted to add another position, you would add the same list of parameters with an incremented array index of &quot;1&quot; instead of &quot;0&quot;.&lt;br&gt;&lt;br&gt; The list ends with the four parameters invoicePosDelete, discountSave, discountDelete and takeDefaultAddress.&lt;br&gt; They only play a minor role if you only want to create an invoice but we will shortly explain what they can do.&lt;br&gt; With invoicePosDelete you have to option to delete invoice positions as this request can also be used to update invoices.&lt;br&gt; With discountSave you can add discounts to your invoice.&lt;br&gt; With discountDelete you can delete discounts from your invoice.&lt;br&gt; With takeDefaultAddress you can specify that the first address of the contact you are using for the invoice is taken for the invoice address attribute automatically, so you don&apos;t need to provide the address yourself.&lt;br&gt; If you want to know more about these parameters, for example if you want to use this request to update invoices, feel free to contact our support.&lt;br&gt;&lt;br&gt; Finally, after covering all parameters, they only important information left, is that the order of the last four attributes always needs to be kept.&lt;br&gt; You will also always need to provide all of them, as otherwise the request won&apos;t work properly.&lt;br&gt;&lt;br&gt; &lt;b&gt;Warning:&lt;/b&gt; You can not create a regular invoice with the &lt;b&gt;deliveryDate&lt;/b&gt; being later than the &lt;b&gt;invoiceDate&lt;/b&gt;.&lt;br&gt; To do that you will need to create a so called &lt;b&gt;Abschlagsrechnung&lt;/b&gt; by setting the &lt;b&gt;invoiceType&lt;/b&gt; parameter to &lt;b&gt;AR&lt;/b&gt;.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::SevDesk.Api.V2.Models.SaveInvoice body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::SevDesk.Api.V2.Models.SaveInvoice body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::SevDesk.Api.V2.Invoice.Factory.SaveInvoice.SaveInvoiceRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::SevDesk.Api.V2.Invoice.Factory.SaveInvoice.SaveInvoiceRequestBuilder WithUrl(string rawUrl)
        {
            return new global::SevDesk.Api.V2.Invoice.Factory.SaveInvoice.SaveInvoiceRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
        public partial class SaveInvoiceRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
