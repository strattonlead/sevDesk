// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace SevDesk.Api.V2.CreditNote.Factory.CreateFromVoucher
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    #pragma warning disable CS1591
    public partial class CreateFromVoucherPostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The voucher property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::SevDesk.Api.V2.CreditNote.Factory.CreateFromVoucher.CreateFromVoucherPostRequestBody_voucher? Voucher { get; set; }
#nullable restore
#else
        public global::SevDesk.Api.V2.CreditNote.Factory.CreateFromVoucher.CreateFromVoucherPostRequestBody_voucher Voucher { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::SevDesk.Api.V2.CreditNote.Factory.CreateFromVoucher.CreateFromVoucherPostRequestBody"/> and sets the default values.
        /// </summary>
        public CreateFromVoucherPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::SevDesk.Api.V2.CreditNote.Factory.CreateFromVoucher.CreateFromVoucherPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::SevDesk.Api.V2.CreditNote.Factory.CreateFromVoucher.CreateFromVoucherPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::SevDesk.Api.V2.CreditNote.Factory.CreateFromVoucher.CreateFromVoucherPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "voucher", n => { Voucher = n.GetObjectValue<global::SevDesk.Api.V2.CreditNote.Factory.CreateFromVoucher.CreateFromVoucherPostRequestBody_voucher>(global::SevDesk.Api.V2.CreditNote.Factory.CreateFromVoucher.CreateFromVoucherPostRequestBody_voucher.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::SevDesk.Api.V2.CreditNote.Factory.CreateFromVoucher.CreateFromVoucherPostRequestBody_voucher>("voucher", Voucher);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
