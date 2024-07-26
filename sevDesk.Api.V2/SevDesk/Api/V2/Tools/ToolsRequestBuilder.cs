// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using SevDesk.Api.V2.Tools.BookkeepingSystemVersion;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace SevDesk.Api.V2.Tools
{
    /// <summary>
    /// Builds and executes requests for operations under \Tools
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class ToolsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The bookkeepingSystemVersion property</summary>
        public global::SevDesk.Api.V2.Tools.BookkeepingSystemVersion.BookkeepingSystemVersionRequestBuilder BookkeepingSystemVersion
        {
            get => new global::SevDesk.Api.V2.Tools.BookkeepingSystemVersion.BookkeepingSystemVersionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::SevDesk.Api.V2.Tools.ToolsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ToolsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Tools", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::SevDesk.Api.V2.Tools.ToolsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ToolsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Tools", rawUrl)
        {
        }
    }
}