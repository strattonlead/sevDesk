// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using SevDesk.Api.V2.CheckAccount.Factory.ClearingAccount;
using SevDesk.Api.V2.CheckAccount.Factory.FileImportAccount;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace SevDesk.Api.V2.CheckAccount.Factory
{
    /// <summary>
    /// Builds and executes requests for operations under \CheckAccount\Factory
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class FactoryRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The clearingAccount property</summary>
        public global::SevDesk.Api.V2.CheckAccount.Factory.ClearingAccount.ClearingAccountRequestBuilder ClearingAccount
        {
            get => new global::SevDesk.Api.V2.CheckAccount.Factory.ClearingAccount.ClearingAccountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The fileImportAccount property</summary>
        public global::SevDesk.Api.V2.CheckAccount.Factory.FileImportAccount.FileImportAccountRequestBuilder FileImportAccount
        {
            get => new global::SevDesk.Api.V2.CheckAccount.Factory.FileImportAccount.FileImportAccountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::SevDesk.Api.V2.CheckAccount.Factory.FactoryRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FactoryRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/CheckAccount/Factory", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::SevDesk.Api.V2.CheckAccount.Factory.FactoryRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FactoryRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/CheckAccount/Factory", rawUrl)
        {
        }
    }
}
