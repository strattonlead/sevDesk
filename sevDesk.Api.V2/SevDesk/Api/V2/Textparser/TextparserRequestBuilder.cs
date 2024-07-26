// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using SevDesk.Api.V2.Textparser.FetchDictionaryEntriesByType;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace SevDesk.Api.V2.Textparser
{
    /// <summary>
    /// Builds and executes requests for operations under \Textparser
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class TextparserRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The fetchDictionaryEntriesByType property</summary>
        public global::SevDesk.Api.V2.Textparser.FetchDictionaryEntriesByType.FetchDictionaryEntriesByTypeRequestBuilder FetchDictionaryEntriesByType
        {
            get => new global::SevDesk.Api.V2.Textparser.FetchDictionaryEntriesByType.FetchDictionaryEntriesByTypeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::SevDesk.Api.V2.Textparser.TextparserRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TextparserRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Textparser", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::SevDesk.Api.V2.Textparser.TextparserRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TextparserRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Textparser", rawUrl)
        {
        }
    }
}