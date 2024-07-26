// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace SevDesk.Api.V2.Models
{
    /// <summary>
    /// Voucher model
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class Model_VoucherUpdate : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Cost centre for the voucher</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::SevDesk.Api.V2.Models.Model_VoucherUpdate_costCentre? CostCentre { get; set; }
#nullable restore
#else
        public global::SevDesk.Api.V2.Models.Model_VoucherUpdate_costCentre CostCentre { get; set; }
#endif
        /// <summary>Defines if your voucher is a credit (C) or debit (D)</summary>
        public global::SevDesk.Api.V2.Models.Model_VoucherUpdate_creditDebit? CreditDebit { get; set; }
        /// <summary>specifies which currency the voucher should have. Attention: If the currency differs from the default currency stored in the account, then either the &quot;propertyForeignCurrencyDeadline&quot; or &quot;propertyExchangeRate&quot; parameter must be specified. If both parameters are specified, then the &quot;propertyForeignCurrencyDeadline&quot; parameter is preferred</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Currency { get; set; }
#nullable restore
#else
        public string Currency { get; set; }
#endif
        /// <summary>Needs to be provided as timestamp or dd.mm.yyyy</summary>
        public DateTimeOffset? DeliveryDate { get; set; }
        /// <summary>Needs to be provided as timestamp or dd.mm.yyyy</summary>
        public DateTimeOffset? DeliveryDateUntil { get; set; }
        /// <summary>The description of the voucher. Essentially the voucher number.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The document of the voucher.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::SevDesk.Api.V2.Models.Model_VoucherUpdate_document? Document { get; set; }
#nullable restore
#else
        public global::SevDesk.Api.V2.Models.Model_VoucherUpdate_document Document { get; set; }
#endif
        /// <summary>Amount which has already been paid for this voucher by the customer</summary>
        public float? PaidAmount { get; private set; }
        /// <summary>Needs to be timestamp or dd.mm.yyyy</summary>
        public DateTimeOffset? PayDate { get; set; }
        /// <summary>Payment deadline of the voucher.</summary>
        public DateTimeOffset? PaymentDeadline { get; set; }
        /// <summary>Defines the exchange rate</summary>
        public float? PropertyExchangeRate { get; set; }
        /// <summary>Defines the exchange rate day and and then the exchange rate is set from sevdesk. Needs to be provided as timestamp or dd.mm.yyyy</summary>
        public DateTimeOffset? PropertyForeignCurrencyDeadline { get; set; }
        /// <summary>&lt;b&gt;Not supported in sevdesk-Update 2.0.&lt;/b&gt;&lt;br&gt;&lt;br&gt;    Please have a look in &lt;a href=&apos;#tag/Voucher/Types-and-status-of-vouchers&apos;&gt;status of vouchers&lt;/a&gt;    to see what the different status codes mean</summary>
        public double? Status { get; set; }
        /// <summary>The contact used in the voucher as a supplier.&lt;br&gt;If you don&apos;t have a contact as a supplier, you can set this object to null.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::SevDesk.Api.V2.Models.Model_VoucherUpdate_supplier? Supplier { get; set; }
#nullable restore
#else
        public global::SevDesk.Api.V2.Models.Model_VoucherUpdate_supplier Supplier { get; set; }
#endif
        /// <summary>The supplier name.&lt;br&gt;     The value you provide here will determine what supplier name is shown for the voucher in case you did not provide a supplier.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SupplierName { get; set; }
#nullable restore
#else
        public string SupplierName { get; set; }
#endif
        /// <summary>**Use this in sevdesk-Update 2.0 (replaces taxType / taxSet).**</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::SevDesk.Api.V2.Models.Model_VoucherUpdate_taxRule? TaxRule { get; set; }
#nullable restore
#else
        public global::SevDesk.Api.V2.Models.Model_VoucherUpdate_taxRule TaxRule { get; set; }
#endif
        /// <summary>**Use this in sevdesk-Update 2.0 (replaces taxType / taxSet).**Tax set of the voucher. Needs to be added if you chose the taxType=custom.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::SevDesk.Api.V2.Models.Model_VoucherUpdate_taxSet? TaxSet { get; set; }
#nullable restore
#else
        public global::SevDesk.Api.V2.Models.Model_VoucherUpdate_taxSet TaxSet { get; set; }
#endif
        /// <summary>**Use this in sevdesk-Update 1.0 (instead of taxRule).**Tax type of the voucher.There are four tax types:1. default - Umsatzsteuer ausweisen2. eu - Steuerfreie innergemeinschaftliche Lieferung (Europäische Union)3. noteu - Steuerschuldnerschaft des Leistungsempfängers (außerhalb EU, z. B. Schweiz)4. custom - Using custom tax set5. ss - Not subject to VAT according to §19 1 UStGTax rates are heavily connected to the tax type used.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TaxType { get; set; }
#nullable restore
#else
        public string TaxType { get; set; }
#endif
        /// <summary>Needs to be provided as timestamp or dd.mm.yyyy</summary>
        public DateTimeOffset? VoucherDate { get; set; }
        /// <summary>Type of the voucher. For more information on the different types, check &lt;a href=&apos;#tag/Voucher/Types-and-status-of-vouchers&apos;&gt;this&lt;/a&gt;</summary>
        public global::SevDesk.Api.V2.Models.Model_VoucherUpdate_voucherType? VoucherType { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::SevDesk.Api.V2.Models.Model_VoucherUpdate"/> and sets the default values.
        /// </summary>
        public Model_VoucherUpdate()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::SevDesk.Api.V2.Models.Model_VoucherUpdate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::SevDesk.Api.V2.Models.Model_VoucherUpdate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::SevDesk.Api.V2.Models.Model_VoucherUpdate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "costCentre", n => { CostCentre = n.GetObjectValue<global::SevDesk.Api.V2.Models.Model_VoucherUpdate_costCentre>(global::SevDesk.Api.V2.Models.Model_VoucherUpdate_costCentre.CreateFromDiscriminatorValue); } },
                { "creditDebit", n => { CreditDebit = n.GetEnumValue<global::SevDesk.Api.V2.Models.Model_VoucherUpdate_creditDebit>(); } },
                { "currency", n => { Currency = n.GetStringValue(); } },
                { "deliveryDate", n => { DeliveryDate = n.GetDateTimeOffsetValue(); } },
                { "deliveryDateUntil", n => { DeliveryDateUntil = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "document", n => { Document = n.GetObjectValue<global::SevDesk.Api.V2.Models.Model_VoucherUpdate_document>(global::SevDesk.Api.V2.Models.Model_VoucherUpdate_document.CreateFromDiscriminatorValue); } },
                { "paidAmount", n => { PaidAmount = n.GetFloatValue(); } },
                { "payDate", n => { PayDate = n.GetDateTimeOffsetValue(); } },
                { "paymentDeadline", n => { PaymentDeadline = n.GetDateTimeOffsetValue(); } },
                { "propertyExchangeRate", n => { PropertyExchangeRate = n.GetFloatValue(); } },
                { "propertyForeignCurrencyDeadline", n => { PropertyForeignCurrencyDeadline = n.GetDateTimeOffsetValue(); } },
                { "status", n => { Status = n.GetDoubleValue(); } },
                { "supplier", n => { Supplier = n.GetObjectValue<global::SevDesk.Api.V2.Models.Model_VoucherUpdate_supplier>(global::SevDesk.Api.V2.Models.Model_VoucherUpdate_supplier.CreateFromDiscriminatorValue); } },
                { "supplierName", n => { SupplierName = n.GetStringValue(); } },
                { "taxRule", n => { TaxRule = n.GetObjectValue<global::SevDesk.Api.V2.Models.Model_VoucherUpdate_taxRule>(global::SevDesk.Api.V2.Models.Model_VoucherUpdate_taxRule.CreateFromDiscriminatorValue); } },
                { "taxSet", n => { TaxSet = n.GetObjectValue<global::SevDesk.Api.V2.Models.Model_VoucherUpdate_taxSet>(global::SevDesk.Api.V2.Models.Model_VoucherUpdate_taxSet.CreateFromDiscriminatorValue); } },
                { "taxType", n => { TaxType = n.GetStringValue(); } },
                { "voucherDate", n => { VoucherDate = n.GetDateTimeOffsetValue(); } },
                { "voucherType", n => { VoucherType = n.GetEnumValue<global::SevDesk.Api.V2.Models.Model_VoucherUpdate_voucherType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::SevDesk.Api.V2.Models.Model_VoucherUpdate_costCentre>("costCentre", CostCentre);
            writer.WriteEnumValue<global::SevDesk.Api.V2.Models.Model_VoucherUpdate_creditDebit>("creditDebit", CreditDebit);
            writer.WriteStringValue("currency", Currency);
            writer.WriteDateTimeOffsetValue("deliveryDate", DeliveryDate);
            writer.WriteDateTimeOffsetValue("deliveryDateUntil", DeliveryDateUntil);
            writer.WriteStringValue("description", Description);
            writer.WriteObjectValue<global::SevDesk.Api.V2.Models.Model_VoucherUpdate_document>("document", Document);
            writer.WriteDateTimeOffsetValue("payDate", PayDate);
            writer.WriteDateTimeOffsetValue("paymentDeadline", PaymentDeadline);
            writer.WriteFloatValue("propertyExchangeRate", PropertyExchangeRate);
            writer.WriteDateTimeOffsetValue("propertyForeignCurrencyDeadline", PropertyForeignCurrencyDeadline);
            writer.WriteDoubleValue("status", Status);
            writer.WriteObjectValue<global::SevDesk.Api.V2.Models.Model_VoucherUpdate_supplier>("supplier", Supplier);
            writer.WriteStringValue("supplierName", SupplierName);
            writer.WriteObjectValue<global::SevDesk.Api.V2.Models.Model_VoucherUpdate_taxRule>("taxRule", TaxRule);
            writer.WriteObjectValue<global::SevDesk.Api.V2.Models.Model_VoucherUpdate_taxSet>("taxSet", TaxSet);
            writer.WriteStringValue("taxType", TaxType);
            writer.WriteDateTimeOffsetValue("voucherDate", VoucherDate);
            writer.WriteEnumValue<global::SevDesk.Api.V2.Models.Model_VoucherUpdate_voucherType>("voucherType", VoucherType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
