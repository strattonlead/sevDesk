// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace SevDesk.Api.V2.Models
{
    /// <summary>
    /// Contact communication way model
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class Model_CommunicationWayResponse : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The contact to which this communication way belongs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::SevDesk.Api.V2.Models.Model_CommunicationWayResponse_contact? Contact { get; private set; }
#nullable restore
#else
        public global::SevDesk.Api.V2.Models.Model_CommunicationWayResponse_contact Contact { get; private set; }
#endif
        /// <summary>Date of communication way creation</summary>
        public DateTimeOffset? Create { get; private set; }
        /// <summary>The communication way id</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; private set; }
#nullable restore
#else
        public string Id { get; private set; }
#endif
        /// <summary>The key of the communication way.&lt;br&gt;Similar to the category of addresses.&lt;br&gt;For all communication way keys please send a GET to /CommunicationWayKey.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::SevDesk.Api.V2.Models.Model_CommunicationWayResponse_key? Key { get; private set; }
#nullable restore
#else
        public global::SevDesk.Api.V2.Models.Model_CommunicationWayResponse_key Key { get; private set; }
#endif
        /// <summary>Defines whether the communication way is the main communication way for the contact.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Main { get; private set; }
#nullable restore
#else
        public string Main { get; private set; }
#endif
        /// <summary>The communication way object name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ObjectName { get; private set; }
#nullable restore
#else
        public string ObjectName { get; private set; }
#endif
        /// <summary>Client to which communication way key belongs. Will be filled automatically</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::SevDesk.Api.V2.Models.Model_CommunicationWayResponse_sevClient? SevClient { get; private set; }
#nullable restore
#else
        public global::SevDesk.Api.V2.Models.Model_CommunicationWayResponse_sevClient SevClient { get; private set; }
#endif
        /// <summary>Type of the communication way</summary>
        public global::SevDesk.Api.V2.Models.Model_CommunicationWayResponse_type? Type { get; private set; }
        /// <summary>Date of last communication way update</summary>
        public DateTimeOffset? Update { get; private set; }
        /// <summary>The value of the communication way.&lt;br&gt;     For example the phone number, e-mail address or website.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Value { get; private set; }
#nullable restore
#else
        public string Value { get; private set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::SevDesk.Api.V2.Models.Model_CommunicationWayResponse"/> and sets the default values.
        /// </summary>
        public Model_CommunicationWayResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::SevDesk.Api.V2.Models.Model_CommunicationWayResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::SevDesk.Api.V2.Models.Model_CommunicationWayResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::SevDesk.Api.V2.Models.Model_CommunicationWayResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "contact", n => { Contact = n.GetObjectValue<global::SevDesk.Api.V2.Models.Model_CommunicationWayResponse_contact>(global::SevDesk.Api.V2.Models.Model_CommunicationWayResponse_contact.CreateFromDiscriminatorValue); } },
                { "create", n => { Create = n.GetDateTimeOffsetValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "key", n => { Key = n.GetObjectValue<global::SevDesk.Api.V2.Models.Model_CommunicationWayResponse_key>(global::SevDesk.Api.V2.Models.Model_CommunicationWayResponse_key.CreateFromDiscriminatorValue); } },
                { "main", n => { Main = n.GetStringValue(); } },
                { "objectName", n => { ObjectName = n.GetStringValue(); } },
                { "sevClient", n => { SevClient = n.GetObjectValue<global::SevDesk.Api.V2.Models.Model_CommunicationWayResponse_sevClient>(global::SevDesk.Api.V2.Models.Model_CommunicationWayResponse_sevClient.CreateFromDiscriminatorValue); } },
                { "type", n => { Type = n.GetEnumValue<global::SevDesk.Api.V2.Models.Model_CommunicationWayResponse_type>(); } },
                { "update", n => { Update = n.GetDateTimeOffsetValue(); } },
                { "value", n => { Value = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
