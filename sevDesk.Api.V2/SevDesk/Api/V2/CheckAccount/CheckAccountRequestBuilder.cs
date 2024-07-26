// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using SevDesk.Api.V2.CheckAccount.Factory;
using SevDesk.Api.V2.CheckAccount.Item;
using SevDesk.Api.V2.Models;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace SevDesk.Api.V2.CheckAccount
{
    /// <summary>
    /// Builds and executes requests for operations under \CheckAccount
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class CheckAccountRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The Factory property</summary>
        public global::SevDesk.Api.V2.CheckAccount.Factory.FactoryRequestBuilder Factory
        {
            get => new global::SevDesk.Api.V2.CheckAccount.Factory.FactoryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the sevDesk.Api.V2.CheckAccount.item collection</summary>
        /// <param name="position">ID of check account</param>
        /// <returns>A <see cref="global::SevDesk.Api.V2.CheckAccount.Item.WithCheckAccountItemRequestBuilder"/></returns>
        public global::SevDesk.Api.V2.CheckAccount.Item.WithCheckAccountItemRequestBuilder this[int position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("checkAccountId", position);
                return new global::SevDesk.Api.V2.CheckAccount.Item.WithCheckAccountItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the sevDesk.Api.V2.CheckAccount.item collection</summary>
        /// <param name="position">ID of check account</param>
        /// <returns>A <see cref="global::SevDesk.Api.V2.CheckAccount.Item.WithCheckAccountItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public global::SevDesk.Api.V2.CheckAccount.Item.WithCheckAccountItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("checkAccountId", position);
                return new global::SevDesk.Api.V2.CheckAccount.Item.WithCheckAccountItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::SevDesk.Api.V2.CheckAccount.CheckAccountRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CheckAccountRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/CheckAccount", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::SevDesk.Api.V2.CheckAccount.CheckAccountRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CheckAccountRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/CheckAccount", rawUrl)
        {
        }
        /// <summary>
        /// Retrieve all check accounts
        /// </summary>
        /// <returns>A <see cref="global::SevDesk.Api.V2.CheckAccount.CheckAccountGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::SevDesk.Api.V2.CheckAccount.CheckAccountGetResponse?> GetAsCheckAccountGetResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::SevDesk.Api.V2.CheckAccount.CheckAccountGetResponse> GetAsCheckAccountGetResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::SevDesk.Api.V2.CheckAccount.CheckAccountGetResponse>(requestInfo, global::SevDesk.Api.V2.CheckAccount.CheckAccountGetResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieve all check accounts
        /// </summary>
        /// <returns>A <see cref="global::SevDesk.Api.V2.CheckAccount.CheckAccountResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This method is obsolete. Use GetAsCheckAccountGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::SevDesk.Api.V2.CheckAccount.CheckAccountResponse?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::SevDesk.Api.V2.CheckAccount.CheckAccountResponse> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::SevDesk.Api.V2.CheckAccount.CheckAccountResponse>(requestInfo, global::SevDesk.Api.V2.CheckAccount.CheckAccountResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Creates a new banking account on which transactions can be created.
        /// </summary>
        /// <returns>A <see cref="global::SevDesk.Api.V2.CheckAccount.CheckAccountPostResponse"/></returns>
        /// <param name="body">CheckAccount model. Responsible for the payment accounts.</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::SevDesk.Api.V2.CheckAccount.CheckAccountPostResponse?> PostAsCheckAccountPostResponseAsync(global::SevDesk.Api.V2.Models.Model_CheckAccount body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::SevDesk.Api.V2.CheckAccount.CheckAccountPostResponse> PostAsCheckAccountPostResponseAsync(global::SevDesk.Api.V2.Models.Model_CheckAccount body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<global::SevDesk.Api.V2.CheckAccount.CheckAccountPostResponse>(requestInfo, global::SevDesk.Api.V2.CheckAccount.CheckAccountPostResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Creates a new banking account on which transactions can be created.
        /// </summary>
        /// <returns>A <see cref="global::SevDesk.Api.V2.CheckAccount.CheckAccountResponse"/></returns>
        /// <param name="body">CheckAccount model. Responsible for the payment accounts.</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This method is obsolete. Use PostAsCheckAccountPostResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::SevDesk.Api.V2.CheckAccount.CheckAccountResponse?> PostAsync(global::SevDesk.Api.V2.Models.Model_CheckAccount body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::SevDesk.Api.V2.CheckAccount.CheckAccountResponse> PostAsync(global::SevDesk.Api.V2.Models.Model_CheckAccount body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<global::SevDesk.Api.V2.CheckAccount.CheckAccountResponse>(requestInfo, global::SevDesk.Api.V2.CheckAccount.CheckAccountResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieve all check accounts
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
        /// Creates a new banking account on which transactions can be created.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">CheckAccount model. Responsible for the payment accounts.</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::SevDesk.Api.V2.Models.Model_CheckAccount body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::SevDesk.Api.V2.Models.Model_CheckAccount body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::SevDesk.Api.V2.CheckAccount.CheckAccountRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::SevDesk.Api.V2.CheckAccount.CheckAccountRequestBuilder WithUrl(string rawUrl)
        {
            return new global::SevDesk.Api.V2.CheckAccount.CheckAccountRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
        public partial class CheckAccountRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
        public partial class CheckAccountRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}