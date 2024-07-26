// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using SevDesk.Api.V2.ContactCustomFieldSetting.Item;
using SevDesk.Api.V2.Models;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace SevDesk.Api.V2.ContactCustomFieldSetting
{
    /// <summary>
    /// Builds and executes requests for operations under \ContactCustomFieldSetting
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class ContactCustomFieldSettingRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the sevDesk.Api.V2.ContactCustomFieldSetting.item collection</summary>
        /// <param name="position">ID of contact field to return</param>
        /// <returns>A <see cref="global::SevDesk.Api.V2.ContactCustomFieldSetting.Item.WithContactCustomFieldSettingItemRequestBuilder"/></returns>
        public global::SevDesk.Api.V2.ContactCustomFieldSetting.Item.WithContactCustomFieldSettingItemRequestBuilder this[int position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("contactCustomFieldSettingId", position);
                return new global::SevDesk.Api.V2.ContactCustomFieldSetting.Item.WithContactCustomFieldSettingItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the sevDesk.Api.V2.ContactCustomFieldSetting.item collection</summary>
        /// <param name="position">ID of contact field to return</param>
        /// <returns>A <see cref="global::SevDesk.Api.V2.ContactCustomFieldSetting.Item.WithContactCustomFieldSettingItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public global::SevDesk.Api.V2.ContactCustomFieldSetting.Item.WithContactCustomFieldSettingItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("contactCustomFieldSettingId", position);
                return new global::SevDesk.Api.V2.ContactCustomFieldSetting.Item.WithContactCustomFieldSettingItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::SevDesk.Api.V2.ContactCustomFieldSetting.ContactCustomFieldSettingRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ContactCustomFieldSettingRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/ContactCustomFieldSetting", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::SevDesk.Api.V2.ContactCustomFieldSetting.ContactCustomFieldSettingRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ContactCustomFieldSettingRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/ContactCustomFieldSetting", rawUrl)
        {
        }
        /// <summary>
        /// Retrieve all contact field settings
        /// </summary>
        /// <returns>A <see cref="global::SevDesk.Api.V2.ContactCustomFieldSetting.ContactCustomFieldSettingGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::SevDesk.Api.V2.ContactCustomFieldSetting.ContactCustomFieldSettingGetResponse?> GetAsContactCustomFieldSettingGetResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::SevDesk.Api.V2.ContactCustomFieldSetting.ContactCustomFieldSettingGetResponse> GetAsContactCustomFieldSettingGetResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::SevDesk.Api.V2.ContactCustomFieldSetting.ContactCustomFieldSettingGetResponse>(requestInfo, global::SevDesk.Api.V2.ContactCustomFieldSetting.ContactCustomFieldSettingGetResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieve all contact field settings
        /// </summary>
        /// <returns>A <see cref="global::SevDesk.Api.V2.ContactCustomFieldSetting.ContactCustomFieldSettingResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This method is obsolete. Use GetAsContactCustomFieldSettingGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::SevDesk.Api.V2.ContactCustomFieldSetting.ContactCustomFieldSettingResponse?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::SevDesk.Api.V2.ContactCustomFieldSetting.ContactCustomFieldSettingResponse> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::SevDesk.Api.V2.ContactCustomFieldSetting.ContactCustomFieldSettingResponse>(requestInfo, global::SevDesk.Api.V2.ContactCustomFieldSetting.ContactCustomFieldSettingResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create contact field setting
        /// </summary>
        /// <returns>A <see cref="global::SevDesk.Api.V2.ContactCustomFieldSetting.ContactCustomFieldSettingPostResponse"/></returns>
        /// <param name="body">contact field settings model</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::SevDesk.Api.V2.ContactCustomFieldSetting.ContactCustomFieldSettingPostResponse?> PostAsContactCustomFieldSettingPostResponseAsync(global::SevDesk.Api.V2.Models.Model_ContactCustomFieldSetting body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::SevDesk.Api.V2.ContactCustomFieldSetting.ContactCustomFieldSettingPostResponse> PostAsContactCustomFieldSettingPostResponseAsync(global::SevDesk.Api.V2.Models.Model_ContactCustomFieldSetting body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<global::SevDesk.Api.V2.ContactCustomFieldSetting.ContactCustomFieldSettingPostResponse>(requestInfo, global::SevDesk.Api.V2.ContactCustomFieldSetting.ContactCustomFieldSettingPostResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create contact field setting
        /// </summary>
        /// <returns>A <see cref="global::SevDesk.Api.V2.ContactCustomFieldSetting.ContactCustomFieldSettingResponse"/></returns>
        /// <param name="body">contact field settings model</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This method is obsolete. Use PostAsContactCustomFieldSettingPostResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::SevDesk.Api.V2.ContactCustomFieldSetting.ContactCustomFieldSettingResponse?> PostAsync(global::SevDesk.Api.V2.Models.Model_ContactCustomFieldSetting body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::SevDesk.Api.V2.ContactCustomFieldSetting.ContactCustomFieldSettingResponse> PostAsync(global::SevDesk.Api.V2.Models.Model_ContactCustomFieldSetting body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<global::SevDesk.Api.V2.ContactCustomFieldSetting.ContactCustomFieldSettingResponse>(requestInfo, global::SevDesk.Api.V2.ContactCustomFieldSetting.ContactCustomFieldSettingResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieve all contact field settings
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Create contact field setting
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">contact field settings model</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::SevDesk.Api.V2.Models.Model_ContactCustomFieldSetting body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::SevDesk.Api.V2.Models.Model_ContactCustomFieldSetting body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::SevDesk.Api.V2.ContactCustomFieldSetting.ContactCustomFieldSettingRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::SevDesk.Api.V2.ContactCustomFieldSetting.ContactCustomFieldSettingRequestBuilder WithUrl(string rawUrl)
        {
            return new global::SevDesk.Api.V2.ContactCustomFieldSetting.ContactCustomFieldSettingRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
        public partial class ContactCustomFieldSettingRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
        public partial class ContactCustomFieldSettingRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
