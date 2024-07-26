// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using SevDesk.Api.V2.Contact.Mapper.CheckCustomerNumberAvailability;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace SevDesk.Api.V2.Contact.Mapper
{
    /// <summary>
    /// Builds and executes requests for operations under \Contact\Mapper
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class MapperRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The checkCustomerNumberAvailability property</summary>
        public global::SevDesk.Api.V2.Contact.Mapper.CheckCustomerNumberAvailability.CheckCustomerNumberAvailabilityRequestBuilder CheckCustomerNumberAvailability
        {
            get => new global::SevDesk.Api.V2.Contact.Mapper.CheckCustomerNumberAvailability.CheckCustomerNumberAvailabilityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::SevDesk.Api.V2.Contact.Mapper.MapperRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MapperRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Contact/Mapper", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::SevDesk.Api.V2.Contact.Mapper.MapperRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MapperRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Contact/Mapper", rawUrl)
        {
        }
    }
}