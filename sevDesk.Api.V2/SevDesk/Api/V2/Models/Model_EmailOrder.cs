// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace SevDesk.Api.V2.Models
{
    /// <summary>
    /// Email model
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class Model_EmailOrder : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Date the mail arrived</summary>
        public DateTimeOffset? Arrived { get; set; }
        /// <summary>A list of mail addresses which are in the bcc</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Bcc { get; set; }
#nullable restore
#else
        public string Bcc { get; set; }
#endif
        /// <summary>A list of mail addresses which are in the cc</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Cc { get; set; }
#nullable restore
#else
        public string Cc { get; set; }
#endif
        /// <summary>Date of mail creation</summary>
        public DateTimeOffset? Create { get; private set; }
        /// <summary>The sender of the email</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? From { get; set; }
#nullable restore
#else
        public string From { get; set; }
#endif
        /// <summary>The email id</summary>
        public int? Id { get; private set; }
        /// <summary>Order model</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::SevDesk.Api.V2.Models.Model_OrderResponse? Object { get; set; }
#nullable restore
#else
        public global::SevDesk.Api.V2.Models.Model_OrderResponse Object { get; set; }
#endif
        /// <summary>The email object name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ObjectName { get; private set; }
#nullable restore
#else
        public string ObjectName { get; private set; }
#endif
        /// <summary>Client to which mail belongs. Will be filled automatically</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::SevDesk.Api.V2.Models.Model_EmailOrder_sevClient? SevClient { get; private set; }
#nullable restore
#else
        public global::SevDesk.Api.V2.Models.Model_EmailOrder_sevClient SevClient { get; private set; }
#endif
        /// <summary>The subject of the email</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Subject { get; set; }
#nullable restore
#else
        public string Subject { get; set; }
#endif
        /// <summary>The text of the email</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Text { get; set; }
#nullable restore
#else
        public string Text { get; set; }
#endif
        /// <summary>The recipient of the email</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? To { get; set; }
#nullable restore
#else
        public string To { get; set; }
#endif
        /// <summary>Date of last mail update</summary>
        public DateTimeOffset? Update { get; private set; }
        /// <summary>
        /// Instantiates a new <see cref="global::SevDesk.Api.V2.Models.Model_EmailOrder"/> and sets the default values.
        /// </summary>
        public Model_EmailOrder()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::SevDesk.Api.V2.Models.Model_EmailOrder"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::SevDesk.Api.V2.Models.Model_EmailOrder CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::SevDesk.Api.V2.Models.Model_EmailOrder();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "arrived", n => { Arrived = n.GetDateTimeOffsetValue(); } },
                { "bcc", n => { Bcc = n.GetStringValue(); } },
                { "cc", n => { Cc = n.GetStringValue(); } },
                { "create", n => { Create = n.GetDateTimeOffsetValue(); } },
                { "from", n => { From = n.GetStringValue(); } },
                { "id", n => { Id = n.GetIntValue(); } },
                { "object", n => { Object = n.GetObjectValue<global::SevDesk.Api.V2.Models.Model_OrderResponse>(global::SevDesk.Api.V2.Models.Model_OrderResponse.CreateFromDiscriminatorValue); } },
                { "objectName", n => { ObjectName = n.GetStringValue(); } },
                { "sevClient", n => { SevClient = n.GetObjectValue<global::SevDesk.Api.V2.Models.Model_EmailOrder_sevClient>(global::SevDesk.Api.V2.Models.Model_EmailOrder_sevClient.CreateFromDiscriminatorValue); } },
                { "subject", n => { Subject = n.GetStringValue(); } },
                { "text", n => { Text = n.GetStringValue(); } },
                { "to", n => { To = n.GetStringValue(); } },
                { "update", n => { Update = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("arrived", Arrived);
            writer.WriteStringValue("bcc", Bcc);
            writer.WriteStringValue("cc", Cc);
            writer.WriteStringValue("from", From);
            writer.WriteObjectValue<global::SevDesk.Api.V2.Models.Model_OrderResponse>("object", Object);
            writer.WriteStringValue("subject", Subject);
            writer.WriteStringValue("text", Text);
            writer.WriteStringValue("to", To);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
