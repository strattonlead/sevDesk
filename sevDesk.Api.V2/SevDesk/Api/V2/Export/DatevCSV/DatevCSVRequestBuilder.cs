// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace SevDesk.Api.V2.Export.DatevCSV
{
    /// <summary>
    /// Builds and executes requests for operations under \Export\datevCSV
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class DatevCSVRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::SevDesk.Api.V2.Export.DatevCSV.DatevCSVRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DatevCSVRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Export/datevCSV?endDate={endDate}&scope={scope}&startDate={startDate}{&Download*,enshrine*,withEnshrinedDocuments*,withUnpaidDocuments*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::SevDesk.Api.V2.Export.DatevCSV.DatevCSVRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DatevCSVRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Export/datevCSV?endDate={endDate}&scope={scope}&startDate={startDate}{&Download*,enshrine*,withEnshrinedDocuments*,withUnpaidDocuments*}", rawUrl)
        {
        }
        /// <summary>
        /// Datev export as zip with csv´s. Before you can perform the datev export, you must first set the &quot;accountingYearBegin&quot;. To do this, you must use the &lt;a href=&apos;#tag/Export/operation/updateExportConfig&apos;&gt;updateExportConfig&lt;/a&gt; endpoint.
        /// </summary>
        /// <returns>A <see cref="global::SevDesk.Api.V2.Export.DatevCSV.DatevCSVGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::SevDesk.Api.V2.Export.DatevCSV.DatevCSVGetResponse?> GetAsDatevCSVGetResponseAsync(Action<RequestConfiguration<global::SevDesk.Api.V2.Export.DatevCSV.DatevCSVRequestBuilder.DatevCSVRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::SevDesk.Api.V2.Export.DatevCSV.DatevCSVGetResponse> GetAsDatevCSVGetResponseAsync(Action<RequestConfiguration<global::SevDesk.Api.V2.Export.DatevCSV.DatevCSVRequestBuilder.DatevCSVRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::SevDesk.Api.V2.Export.DatevCSV.DatevCSVGetResponse>(requestInfo, global::SevDesk.Api.V2.Export.DatevCSV.DatevCSVGetResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Datev export as zip with csv´s. Before you can perform the datev export, you must first set the &quot;accountingYearBegin&quot;. To do this, you must use the &lt;a href=&apos;#tag/Export/operation/updateExportConfig&apos;&gt;updateExportConfig&lt;/a&gt; endpoint.
        /// </summary>
        /// <returns>A <see cref="global::SevDesk.Api.V2.Export.DatevCSV.DatevCSVResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This method is obsolete. Use GetAsDatevCSVGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::SevDesk.Api.V2.Export.DatevCSV.DatevCSVResponse?> GetAsync(Action<RequestConfiguration<global::SevDesk.Api.V2.Export.DatevCSV.DatevCSVRequestBuilder.DatevCSVRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::SevDesk.Api.V2.Export.DatevCSV.DatevCSVResponse> GetAsync(Action<RequestConfiguration<global::SevDesk.Api.V2.Export.DatevCSV.DatevCSVRequestBuilder.DatevCSVRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::SevDesk.Api.V2.Export.DatevCSV.DatevCSVResponse>(requestInfo, global::SevDesk.Api.V2.Export.DatevCSV.DatevCSVResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Datev export as zip with csv´s. Before you can perform the datev export, you must first set the &quot;accountingYearBegin&quot;. To do this, you must use the &lt;a href=&apos;#tag/Export/operation/updateExportConfig&apos;&gt;updateExportConfig&lt;/a&gt; endpoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::SevDesk.Api.V2.Export.DatevCSV.DatevCSVRequestBuilder.DatevCSVRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::SevDesk.Api.V2.Export.DatevCSV.DatevCSVRequestBuilder.DatevCSVRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::SevDesk.Api.V2.Export.DatevCSV.DatevCSVRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::SevDesk.Api.V2.Export.DatevCSV.DatevCSVRequestBuilder WithUrl(string rawUrl)
        {
            return new global::SevDesk.Api.V2.Export.DatevCSV.DatevCSVRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Datev export as zip with csv´s. Before you can perform the datev export, you must first set the &quot;accountingYearBegin&quot;. To do this, you must use the &lt;a href=&apos;#tag/Export/operation/updateExportConfig&apos;&gt;updateExportConfig&lt;/a&gt; endpoint.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
        public partial class DatevCSVRequestBuilderGetQueryParameters 
        {
            /// <summary>Specifies if the document is downloaded</summary>
            public bool? Download { get; set; }
            /// <summary>the end date of the export as timestamp</summary>
            [QueryParameter("endDate")]
            public int? EndDate { get; set; }
            /// <summary>Specify if you want to enshrine all models which were included in the export</summary>
            [QueryParameter("enshrine")]
            public bool? Enshrine { get; set; }
            /// <summary>Define what you want to include in the datev export. This parameter takes a string of 5 letters. Each stands for a model that should be included. Possible letters are: ‘E’ (Earnings), ‘X’ (Expenditure), ‘T’ (Transactions), ‘C’ (Cashregister), ‘D’ (Assets). By providing one of those letter you specify that it should be included in the datev export. Some combinations are: ‘EXTCD’, ‘EXTD’ …</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("scope")]
            public string? Scope { get; set; }
#nullable restore
#else
            [QueryParameter("scope")]
            public string Scope { get; set; }
#endif
            /// <summary>the start date of the export as timestamp</summary>
            [QueryParameter("startDate")]
            public int? StartDate { get; set; }
            /// <summary>include enshrined documents</summary>
            [QueryParameter("withEnshrinedDocuments")]
            public bool? WithEnshrinedDocuments { get; set; }
            /// <summary>include unpaid documents</summary>
            [QueryParameter("withUnpaidDocuments")]
            public bool? WithUnpaidDocuments { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
        public partial class DatevCSVRequestBuilderGetRequestConfiguration : RequestConfiguration<global::SevDesk.Api.V2.Export.DatevCSV.DatevCSVRequestBuilder.DatevCSVRequestBuilderGetQueryParameters>
        {
        }
    }
}
