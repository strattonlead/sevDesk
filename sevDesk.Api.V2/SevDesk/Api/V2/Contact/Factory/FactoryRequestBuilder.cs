// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using SevDesk.Api.V2.Contact.Factory.FindContactsByCustomFieldValue;
using SevDesk.Api.V2.Contact.Factory.GetNextCustomerNumber;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace SevDesk.Api.V2.Contact.Factory
{
    /// <summary>
    /// Builds and executes requests for operations under \Contact\Factory
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class FactoryRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The findContactsByCustomFieldValue property</summary>
        public global::SevDesk.Api.V2.Contact.Factory.FindContactsByCustomFieldValue.FindContactsByCustomFieldValueRequestBuilder FindContactsByCustomFieldValue
        {
            get => new global::SevDesk.Api.V2.Contact.Factory.FindContactsByCustomFieldValue.FindContactsByCustomFieldValueRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getNextCustomerNumber property</summary>
        public global::SevDesk.Api.V2.Contact.Factory.GetNextCustomerNumber.GetNextCustomerNumberRequestBuilder GetNextCustomerNumber
        {
            get => new global::SevDesk.Api.V2.Contact.Factory.GetNextCustomerNumber.GetNextCustomerNumberRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::SevDesk.Api.V2.Contact.Factory.FactoryRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FactoryRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Contact/Factory", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::SevDesk.Api.V2.Contact.Factory.FactoryRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FactoryRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Contact/Factory", rawUrl)
        {
        }
    }
}
