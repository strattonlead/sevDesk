// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace SevDesk.Api.V2.Voucher.Item.BookAmount
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    #pragma warning disable CS1591
    public partial class BookAmountPutResponse : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The additionalInformation property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AdditionalInformation { get; set; }
#nullable restore
#else
        public string AdditionalInformation { get; set; }
#endif
        /// <summary>The ammountPayed property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AmmountPayed { get; set; }
#nullable restore
#else
        public string AmmountPayed { get; set; }
#endif
        /// <summary>The bookingDate property</summary>
        public DateTimeOffset? BookingDate { get; set; }
        /// <summary>Date of email creation</summary>
        public DateTimeOffset? Create { get; set; }
        /// <summary>The creditNote property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::SevDesk.Api.V2.Voucher.Item.BookAmount.BookAmountPutResponse_creditNote? CreditNote { get; set; }
#nullable restore
#else
        public global::SevDesk.Api.V2.Voucher.Item.BookAmount.BookAmountPutResponse_creditNote CreditNote { get; set; }
#endif
        /// <summary>The fromStatus property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FromStatus { get; set; }
#nullable restore
#else
        public string FromStatus { get; set; }
#endif
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The objectName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ObjectName { get; set; }
#nullable restore
#else
        public string ObjectName { get; set; }
#endif
        /// <summary>Client to which invoice belongs. Will be filled automatically</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::SevDesk.Api.V2.Voucher.Item.BookAmount.BookAmountPutResponse_sevClient? SevClient { get; set; }
#nullable restore
#else
        public global::SevDesk.Api.V2.Voucher.Item.BookAmount.BookAmountPutResponse_sevClient SevClient { get; set; }
#endif
        /// <summary>The toStatus property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ToStatus { get; set; }
#nullable restore
#else
        public string ToStatus { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::SevDesk.Api.V2.Voucher.Item.BookAmount.BookAmountPutResponse"/> and sets the default values.
        /// </summary>
        public BookAmountPutResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::SevDesk.Api.V2.Voucher.Item.BookAmount.BookAmountPutResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::SevDesk.Api.V2.Voucher.Item.BookAmount.BookAmountPutResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::SevDesk.Api.V2.Voucher.Item.BookAmount.BookAmountPutResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "additionalInformation", n => { AdditionalInformation = n.GetStringValue(); } },
                { "ammountPayed", n => { AmmountPayed = n.GetStringValue(); } },
                { "bookingDate", n => { BookingDate = n.GetDateTimeOffsetValue(); } },
                { "create", n => { Create = n.GetDateTimeOffsetValue(); } },
                { "creditNote", n => { CreditNote = n.GetObjectValue<global::SevDesk.Api.V2.Voucher.Item.BookAmount.BookAmountPutResponse_creditNote>(global::SevDesk.Api.V2.Voucher.Item.BookAmount.BookAmountPutResponse_creditNote.CreateFromDiscriminatorValue); } },
                { "fromStatus", n => { FromStatus = n.GetStringValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "objectName", n => { ObjectName = n.GetStringValue(); } },
                { "sevClient", n => { SevClient = n.GetObjectValue<global::SevDesk.Api.V2.Voucher.Item.BookAmount.BookAmountPutResponse_sevClient>(global::SevDesk.Api.V2.Voucher.Item.BookAmount.BookAmountPutResponse_sevClient.CreateFromDiscriminatorValue); } },
                { "toStatus", n => { ToStatus = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("additionalInformation", AdditionalInformation);
            writer.WriteStringValue("ammountPayed", AmmountPayed);
            writer.WriteDateTimeOffsetValue("bookingDate", BookingDate);
            writer.WriteDateTimeOffsetValue("create", Create);
            writer.WriteObjectValue<global::SevDesk.Api.V2.Voucher.Item.BookAmount.BookAmountPutResponse_creditNote>("creditNote", CreditNote);
            writer.WriteStringValue("fromStatus", FromStatus);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("objectName", ObjectName);
            writer.WriteObjectValue<global::SevDesk.Api.V2.Voucher.Item.BookAmount.BookAmountPutResponse_sevClient>("sevClient", SevClient);
            writer.WriteStringValue("toStatus", ToStatus);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
