// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace SevDesk.Api.V2.Contact.Factory.FindContactsByCustomFieldValue
{
    /// <summary>
    /// Builds and executes requests for operations under \Contact\Factory\findContactsByCustomFieldValue
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class FindContactsByCustomFieldValueRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::SevDesk.Api.V2.Contact.Factory.FindContactsByCustomFieldValue.FindContactsByCustomFieldValueRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FindContactsByCustomFieldValueRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Contact/Factory/findContactsByCustomFieldValue?customFieldName={customFieldName}&value={value}{&customFieldSetting%5Bid%5D*,customFieldSetting%5BobjectName%5D*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::SevDesk.Api.V2.Contact.Factory.FindContactsByCustomFieldValue.FindContactsByCustomFieldValueRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FindContactsByCustomFieldValueRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Contact/Factory/findContactsByCustomFieldValue?customFieldName={customFieldName}&value={value}{&customFieldSetting%5Bid%5D*,customFieldSetting%5BobjectName%5D*}", rawUrl)
        {
        }
        /// <summary>
        /// Returns an array of contacts having a certain custom field value set.
        /// </summary>
        /// <returns>A <see cref="global::SevDesk.Api.V2.Contact.Factory.FindContactsByCustomFieldValue.FindContactsByCustomFieldValueGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::SevDesk.Api.V2.Contact.Factory.FindContactsByCustomFieldValue.FindContactsByCustomFieldValueGetResponse?> GetAsFindContactsByCustomFieldValueGetResponseAsync(Action<RequestConfiguration<global::SevDesk.Api.V2.Contact.Factory.FindContactsByCustomFieldValue.FindContactsByCustomFieldValueRequestBuilder.FindContactsByCustomFieldValueRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::SevDesk.Api.V2.Contact.Factory.FindContactsByCustomFieldValue.FindContactsByCustomFieldValueGetResponse> GetAsFindContactsByCustomFieldValueGetResponseAsync(Action<RequestConfiguration<global::SevDesk.Api.V2.Contact.Factory.FindContactsByCustomFieldValue.FindContactsByCustomFieldValueRequestBuilder.FindContactsByCustomFieldValueRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::SevDesk.Api.V2.Contact.Factory.FindContactsByCustomFieldValue.FindContactsByCustomFieldValueGetResponse>(requestInfo, global::SevDesk.Api.V2.Contact.Factory.FindContactsByCustomFieldValue.FindContactsByCustomFieldValueGetResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns an array of contacts having a certain custom field value set.
        /// </summary>
        /// <returns>A <see cref="global::SevDesk.Api.V2.Contact.Factory.FindContactsByCustomFieldValue.FindContactsByCustomFieldValueResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This method is obsolete. Use GetAsFindContactsByCustomFieldValueGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::SevDesk.Api.V2.Contact.Factory.FindContactsByCustomFieldValue.FindContactsByCustomFieldValueResponse?> GetAsync(Action<RequestConfiguration<global::SevDesk.Api.V2.Contact.Factory.FindContactsByCustomFieldValue.FindContactsByCustomFieldValueRequestBuilder.FindContactsByCustomFieldValueRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::SevDesk.Api.V2.Contact.Factory.FindContactsByCustomFieldValue.FindContactsByCustomFieldValueResponse> GetAsync(Action<RequestConfiguration<global::SevDesk.Api.V2.Contact.Factory.FindContactsByCustomFieldValue.FindContactsByCustomFieldValueRequestBuilder.FindContactsByCustomFieldValueRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::SevDesk.Api.V2.Contact.Factory.FindContactsByCustomFieldValue.FindContactsByCustomFieldValueResponse>(requestInfo, global::SevDesk.Api.V2.Contact.Factory.FindContactsByCustomFieldValue.FindContactsByCustomFieldValueResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns an array of contacts having a certain custom field value set.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::SevDesk.Api.V2.Contact.Factory.FindContactsByCustomFieldValue.FindContactsByCustomFieldValueRequestBuilder.FindContactsByCustomFieldValueRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::SevDesk.Api.V2.Contact.Factory.FindContactsByCustomFieldValue.FindContactsByCustomFieldValueRequestBuilder.FindContactsByCustomFieldValueRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::SevDesk.Api.V2.Contact.Factory.FindContactsByCustomFieldValue.FindContactsByCustomFieldValueRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::SevDesk.Api.V2.Contact.Factory.FindContactsByCustomFieldValue.FindContactsByCustomFieldValueRequestBuilder WithUrl(string rawUrl)
        {
            return new global::SevDesk.Api.V2.Contact.Factory.FindContactsByCustomFieldValue.FindContactsByCustomFieldValueRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns an array of contacts having a certain custom field value set.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
        public partial class FindContactsByCustomFieldValueRequestBuilderGetQueryParameters 
        {
            /// <summary>The ContactCustomFieldSetting name, if no ContactCustomFieldSetting is provided.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("customFieldName")]
            public string? CustomFieldName { get; set; }
#nullable restore
#else
            [QueryParameter("customFieldName")]
            public string CustomFieldName { get; set; }
#endif
            /// <summary>ID of ContactCustomFieldSetting for which the value has to be checked.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("customFieldSetting%5Bid%5D")]
            public string? CustomFieldSettingid { get; set; }
#nullable restore
#else
            [QueryParameter("customFieldSetting%5Bid%5D")]
            public string CustomFieldSettingid { get; set; }
#endif
            /// <summary>Object name. Only needed if you also defined the ID of a ContactCustomFieldSetting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("customFieldSetting%5BobjectName%5D")]
            public string? CustomFieldSettingobjectName { get; set; }
#nullable restore
#else
            [QueryParameter("customFieldSetting%5BobjectName%5D")]
            public string CustomFieldSettingobjectName { get; set; }
#endif
            /// <summary>The value to be checked.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("value")]
            public string? Value { get; set; }
#nullable restore
#else
            [QueryParameter("value")]
            public string Value { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
        public partial class FindContactsByCustomFieldValueRequestBuilderGetRequestConfiguration : RequestConfiguration<global::SevDesk.Api.V2.Contact.Factory.FindContactsByCustomFieldValue.FindContactsByCustomFieldValueRequestBuilder.FindContactsByCustomFieldValueRequestBuilderGetQueryParameters>
        {
        }
    }
}