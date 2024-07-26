// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace SevDesk.Api.V2.Models
{
    /// <summary>
    /// Invoice model
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class Model_Invoice : IAdditionalDataHolder, IParsable
    {
        /// <summary>The interval in which recurring invoices are due as ISO-8601 duration.&lt;br&gt;     Necessary attribute for all recurring invoices.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountIntervall { get; private set; }
#nullable restore
#else
        public string AccountIntervall { get; private set; }
#endif
        /// <summary>Timestamp when the next invoice will be generated by this recurring invoice.</summary>
        public int? AccountNextInvoice { get; private set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Complete address of the recipient including name, street, city, zip and country.     * Line breaks can be used and will be displayed on the invoice pdf.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Address { get; set; }
#nullable restore
#else
        public string Address { get; set; }
#endif
        /// <summary>Can be omitted as complete address is defined in address attribute</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::SevDesk.Api.V2.Models.Model_Invoice_addressCountry? AddressCountry { get; set; }
#nullable restore
#else
        public global::SevDesk.Api.V2.Models.Model_Invoice_addressCountry AddressCountry { get; set; }
#endif
        /// <summary>The contact used in the invoice</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::SevDesk.Api.V2.Models.Model_Invoice_contact? Contact { get; set; }
#nullable restore
#else
        public global::SevDesk.Api.V2.Models.Model_Invoice_contact Contact { get; set; }
#endif
        /// <summary>The user who acts as a contact person for the invoice</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::SevDesk.Api.V2.Models.Model_Invoice_contactPerson? ContactPerson { get; set; }
#nullable restore
#else
        public global::SevDesk.Api.V2.Models.Model_Invoice_contactPerson ContactPerson { get; set; }
#endif
        /// <summary>Date of invoice creation</summary>
        public DateTimeOffset? Create { get; private set; }
        /// <summary>Will be filled automatically by our system and can&apos;t be changed</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::SevDesk.Api.V2.Models.Model_Invoice_createUser? CreateUser { get; private set; }
#nullable restore
#else
        public global::SevDesk.Api.V2.Models.Model_Invoice_createUser CreateUser { get; private set; }
#endif
        /// <summary>Currency used in the invoice. Needs to be currency code according to ISO-4217</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Currency { get; set; }
#nullable restore
#else
        public string Currency { get; set; }
#endif
        /// <summary>Internal note of the customer. Contains data entered into field &apos;Referenz/Bestellnummer&apos;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerInternalNote { get; set; }
#nullable restore
#else
        public string CustomerInternalNote { get; set; }
#endif
        /// <summary>Timestamp. This can also be a date range if you also use the attribute deliveryDateUntil</summary>
        public DateTimeOffset? DeliveryDate { get; set; }
        /// <summary>If the delivery date should be a time range, another timestamp can be provided in this attribute     * to define a range from timestamp used in deliveryDate attribute to the timestamp used here.</summary>
        public int? DeliveryDateUntil { get; set; }
        /// <summary>If you want to give a discount, define the percentage here. Otherwise provide zero as value</summary>
        public int? Discount { get; set; }
        /// <summary>Defines how many reminders have already been sent for the invoice.    Starts with 1 (Payment reminder) and should be incremented by one every time another reminder is sent.</summary>
        public int? DunningLevel { get; private set; }
        /// <summary>Enshrined invoices cannot be changed. Can only be set via [Invoice/{invoiceId}/enshrine](#tag/Invoice/operation/invoiceEnshrine). This operation cannot be undone.</summary>
        public DateTimeOffset? Enshrined { get; private set; }
        /// <summary>Certain html tags can be used here to format your text</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FootText { get; set; }
#nullable restore
#else
        public string FootText { get; set; }
#endif
        /// <summary>Normally consist of prefix plus the invoice number</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Header { get; set; }
#nullable restore
#else
        public string Header { get; set; }
#endif
        /// <summary>Certain html tags can be used here to format your text</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HeadText { get; set; }
#nullable restore
#else
        public string HeadText { get; set; }
#endif
        /// <summary>The invoice id. &lt;span style=&apos;color:red&apos;&gt;Required&lt;/span&gt; if you want to create or update an invoice position for an existing invoice</summary>
        public int? Id { get; set; }
        /// <summary>Needs to be provided as timestamp or dd.mm.yyyy**Requirements:*** For final invoices (invoiceType = &apos;ER&apos;), the invoiceDate must be later than or equal to the invoiceDate of related advance (invoiceType = &apos;AR&apos;) / partial (invoiceType = &apos;TR&apos;) invoices.&lt;/li&gt;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InvoiceDate { get; set; }
#nullable restore
#else
        public string InvoiceDate { get; set; }
#endif
        /// <summary>The invoice number</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InvoiceNumber { get; set; }
#nullable restore
#else
        public string InvoiceNumber { get; set; }
#endif
        /// <summary>Type of the invoice. For more information on the different types, check     &lt;a href=&apos;#tag/Invoice/Types-and-status-of-invoices&apos;&gt;this&lt;/a&gt; section</summary>
        public global::SevDesk.Api.V2.Models.Model_Invoice_invoiceType? InvoiceType { get; set; }
        /// <summary>The mapAll property</summary>
        public bool? MapAll { get; set; }
        /// <summary>The invoice object name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ObjectName { get; set; }
#nullable restore
#else
        public string ObjectName { get; set; }
#endif
        /// <summary>Origin of the invoice. Could f.e. be an order</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::SevDesk.Api.V2.Models.Model_Invoice_origin? Origin { get; set; }
#nullable restore
#else
        public global::SevDesk.Api.V2.Models.Model_Invoice_origin Origin { get; set; }
#endif
        /// <summary>Amount which has already been paid for this invoice by the customer</summary>
        public float? PaidAmount { get; private set; }
        /// <summary>Needs to be timestamp or dd.mm.yyyy</summary>
        public DateTimeOffset? PayDate { get; set; }
        /// <summary>Payment method used for the invoice</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::SevDesk.Api.V2.Models.Model_Invoice_paymentMethod? PaymentMethod { get; set; }
#nullable restore
#else
        public global::SevDesk.Api.V2.Models.Model_Invoice_paymentMethod PaymentMethod { get; set; }
#endif
        /// <summary>The date the invoice was sent to the customer</summary>
        public DateTimeOffset? SendDate { get; set; }
        /// <summary>Type which was used to send the invoice.</summary>
        public global::SevDesk.Api.V2.Models.Model_Invoice_sendType? SendType { get; set; }
        /// <summary>Client to which invoice belongs. Will be filled automatically</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::SevDesk.Api.V2.Models.Model_Invoice_sevClient? SevClient { get; private set; }
#nullable restore
#else
        public global::SevDesk.Api.V2.Models.Model_Invoice_sevClient SevClient { get; private set; }
#endif
        /// <summary>If true, the net amount of each position will be shown on the invoice. Otherwise gross amount</summary>
        public bool? ShowNet { get; set; }
        /// <summary>Defines if the client uses the small settlement scheme.    If yes, the invoice must not contain any vat</summary>
        public bool? SmallSettlement { get; set; }
        /// <summary>Please have a look in our     &lt;a href=&apos;#tag/Invoice/Types-and-status-of-invoices&apos;&gt;Types and status of invoices&lt;/a&gt;     to see what the different status codes mean</summary>
        public global::SevDesk.Api.V2.Models.Model_Invoice_status? Status { get; set; }
        /// <summary>Sum of all discounts in the invoice</summary>
        public float? SumDiscounts { get; private set; }
        /// <summary>Discounts sum of the invoice in the foreign currency</summary>
        public float? SumDiscountsForeignCurrency { get; private set; }
        /// <summary>Gross sum of the invoice</summary>
        public float? SumGross { get; private set; }
        /// <summary>Gross accounting sum of the invoice. Is usually the same as sumGross</summary>
        public float? SumGrossAccounting { get; private set; }
        /// <summary>Gross sum of the invoice in the foreign currency</summary>
        public float? SumGrossForeignCurrency { get; private set; }
        /// <summary>Net sum of the invoice</summary>
        public float? SumNet { get; private set; }
        /// <summary>Net accounting sum of the invoice. Is usually the same as sumNet</summary>
        public float? SumNetAccounting { get; private set; }
        /// <summary>Net sum of the invoice in the foreign currency</summary>
        public float? SumNetForeignCurrency { get; private set; }
        /// <summary>Tax sum of the invoice</summary>
        public float? SumTax { get; private set; }
        /// <summary>Tax accounting sum of the invoice. Is usually the same as sumTax</summary>
        public float? SumTaxAccounting { get; private set; }
        /// <summary>Tax sum of the invoice in the foreign currency</summary>
        public float? SumTaxForeignCurrency { get; private set; }
        /// <summary>This is not used anymore. Use the taxRate of the individual positions instead.</summary>
        public float? TaxRate { get; set; }
        /// <summary>**Use this in sevdesk-Update 2.0 (replaces taxType / taxSet).**</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::SevDesk.Api.V2.Models.Model_Invoice_taxRule? TaxRule { get; set; }
#nullable restore
#else
        public global::SevDesk.Api.V2.Models.Model_Invoice_taxRule TaxRule { get; set; }
#endif
        /// <summary>**Use this in sevdesk-Update 1.0 (instead of taxRule).**Tax set of the invoice. Needs to be added if you chose the tax type custom</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::SevDesk.Api.V2.Models.Model_Invoice_taxSet? TaxSet { get; set; }
#nullable restore
#else
        public global::SevDesk.Api.V2.Models.Model_Invoice_taxSet TaxSet { get; set; }
#endif
        /// <summary>A common tax text would be &apos;Umsatzsteuer 19%&apos;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TaxText { get; set; }
#nullable restore
#else
        public string TaxText { get; set; }
#endif
        /// <summary>**Use this in sevdesk-Update 1.0 (instead of taxRule).**Tax type of the invoice.There are four tax types:1. default - Umsatzsteuer ausweisen2. eu - Steuerfreie innergemeinschaftliche Lieferung (Europäische Union)3. noteu - Steuerschuldnerschaft des Leistungsempfängers (außerhalb EU, z. B. Schweiz)4. custom - Using custom tax set5. ss - Not subject to VAT according to §19 1 UStGTax rates are heavily connected to the tax type used.</summary>
        public global::SevDesk.Api.V2.Models.Model_Invoice_taxType? TaxType { get; set; }
        /// <summary>The time the customer has to pay the invoice in days</summary>
        public int? TimeToPay { get; set; }
        /// <summary>Date of last invoice update</summary>
        public DateTimeOffset? Update { get; private set; }
        /// <summary>
        /// Instantiates a new <see cref="global::SevDesk.Api.V2.Models.Model_Invoice"/> and sets the default values.
        /// </summary>
        public Model_Invoice()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::SevDesk.Api.V2.Models.Model_Invoice"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::SevDesk.Api.V2.Models.Model_Invoice CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::SevDesk.Api.V2.Models.Model_Invoice();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "accountIntervall", n => { AccountIntervall = n.GetStringValue(); } },
                { "accountNextInvoice", n => { AccountNextInvoice = n.GetIntValue(); } },
                { "address", n => { Address = n.GetStringValue(); } },
                { "addressCountry", n => { AddressCountry = n.GetObjectValue<global::SevDesk.Api.V2.Models.Model_Invoice_addressCountry>(global::SevDesk.Api.V2.Models.Model_Invoice_addressCountry.CreateFromDiscriminatorValue); } },
                { "contact", n => { Contact = n.GetObjectValue<global::SevDesk.Api.V2.Models.Model_Invoice_contact>(global::SevDesk.Api.V2.Models.Model_Invoice_contact.CreateFromDiscriminatorValue); } },
                { "contactPerson", n => { ContactPerson = n.GetObjectValue<global::SevDesk.Api.V2.Models.Model_Invoice_contactPerson>(global::SevDesk.Api.V2.Models.Model_Invoice_contactPerson.CreateFromDiscriminatorValue); } },
                { "create", n => { Create = n.GetDateTimeOffsetValue(); } },
                { "createUser", n => { CreateUser = n.GetObjectValue<global::SevDesk.Api.V2.Models.Model_Invoice_createUser>(global::SevDesk.Api.V2.Models.Model_Invoice_createUser.CreateFromDiscriminatorValue); } },
                { "currency", n => { Currency = n.GetStringValue(); } },
                { "customerInternalNote", n => { CustomerInternalNote = n.GetStringValue(); } },
                { "deliveryDate", n => { DeliveryDate = n.GetDateTimeOffsetValue(); } },
                { "deliveryDateUntil", n => { DeliveryDateUntil = n.GetIntValue(); } },
                { "discount", n => { Discount = n.GetIntValue(); } },
                { "dunningLevel", n => { DunningLevel = n.GetIntValue(); } },
                { "enshrined", n => { Enshrined = n.GetDateTimeOffsetValue(); } },
                { "footText", n => { FootText = n.GetStringValue(); } },
                { "headText", n => { HeadText = n.GetStringValue(); } },
                { "header", n => { Header = n.GetStringValue(); } },
                { "id", n => { Id = n.GetIntValue(); } },
                { "invoiceDate", n => { InvoiceDate = n.GetStringValue(); } },
                { "invoiceNumber", n => { InvoiceNumber = n.GetStringValue(); } },
                { "invoiceType", n => { InvoiceType = n.GetEnumValue<global::SevDesk.Api.V2.Models.Model_Invoice_invoiceType>(); } },
                { "mapAll", n => { MapAll = n.GetBoolValue(); } },
                { "objectName", n => { ObjectName = n.GetStringValue(); } },
                { "origin", n => { Origin = n.GetObjectValue<global::SevDesk.Api.V2.Models.Model_Invoice_origin>(global::SevDesk.Api.V2.Models.Model_Invoice_origin.CreateFromDiscriminatorValue); } },
                { "paidAmount", n => { PaidAmount = n.GetFloatValue(); } },
                { "payDate", n => { PayDate = n.GetDateTimeOffsetValue(); } },
                { "paymentMethod", n => { PaymentMethod = n.GetObjectValue<global::SevDesk.Api.V2.Models.Model_Invoice_paymentMethod>(global::SevDesk.Api.V2.Models.Model_Invoice_paymentMethod.CreateFromDiscriminatorValue); } },
                { "sendDate", n => { SendDate = n.GetDateTimeOffsetValue(); } },
                { "sendType", n => { SendType = n.GetEnumValue<global::SevDesk.Api.V2.Models.Model_Invoice_sendType>(); } },
                { "sevClient", n => { SevClient = n.GetObjectValue<global::SevDesk.Api.V2.Models.Model_Invoice_sevClient>(global::SevDesk.Api.V2.Models.Model_Invoice_sevClient.CreateFromDiscriminatorValue); } },
                { "showNet", n => { ShowNet = n.GetBoolValue(); } },
                { "smallSettlement", n => { SmallSettlement = n.GetBoolValue(); } },
                { "status", n => { Status = n.GetEnumValue<global::SevDesk.Api.V2.Models.Model_Invoice_status>(); } },
                { "sumDiscounts", n => { SumDiscounts = n.GetFloatValue(); } },
                { "sumDiscountsForeignCurrency", n => { SumDiscountsForeignCurrency = n.GetFloatValue(); } },
                { "sumGross", n => { SumGross = n.GetFloatValue(); } },
                { "sumGrossAccounting", n => { SumGrossAccounting = n.GetFloatValue(); } },
                { "sumGrossForeignCurrency", n => { SumGrossForeignCurrency = n.GetFloatValue(); } },
                { "sumNet", n => { SumNet = n.GetFloatValue(); } },
                { "sumNetAccounting", n => { SumNetAccounting = n.GetFloatValue(); } },
                { "sumNetForeignCurrency", n => { SumNetForeignCurrency = n.GetFloatValue(); } },
                { "sumTax", n => { SumTax = n.GetFloatValue(); } },
                { "sumTaxAccounting", n => { SumTaxAccounting = n.GetFloatValue(); } },
                { "sumTaxForeignCurrency", n => { SumTaxForeignCurrency = n.GetFloatValue(); } },
                { "taxRate", n => { TaxRate = n.GetFloatValue(); } },
                { "taxRule", n => { TaxRule = n.GetObjectValue<global::SevDesk.Api.V2.Models.Model_Invoice_taxRule>(global::SevDesk.Api.V2.Models.Model_Invoice_taxRule.CreateFromDiscriminatorValue); } },
                { "taxSet", n => { TaxSet = n.GetObjectValue<global::SevDesk.Api.V2.Models.Model_Invoice_taxSet>(global::SevDesk.Api.V2.Models.Model_Invoice_taxSet.CreateFromDiscriminatorValue); } },
                { "taxText", n => { TaxText = n.GetStringValue(); } },
                { "taxType", n => { TaxType = n.GetEnumValue<global::SevDesk.Api.V2.Models.Model_Invoice_taxType>(); } },
                { "timeToPay", n => { TimeToPay = n.GetIntValue(); } },
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
            writer.WriteStringValue("address", Address);
            writer.WriteObjectValue<global::SevDesk.Api.V2.Models.Model_Invoice_addressCountry>("addressCountry", AddressCountry);
            writer.WriteObjectValue<global::SevDesk.Api.V2.Models.Model_Invoice_contact>("contact", Contact);
            writer.WriteObjectValue<global::SevDesk.Api.V2.Models.Model_Invoice_contactPerson>("contactPerson", ContactPerson);
            writer.WriteStringValue("currency", Currency);
            writer.WriteStringValue("customerInternalNote", CustomerInternalNote);
            writer.WriteDateTimeOffsetValue("deliveryDate", DeliveryDate);
            writer.WriteIntValue("deliveryDateUntil", DeliveryDateUntil);
            writer.WriteIntValue("discount", Discount);
            writer.WriteStringValue("footText", FootText);
            writer.WriteStringValue("header", Header);
            writer.WriteStringValue("headText", HeadText);
            writer.WriteIntValue("id", Id);
            writer.WriteStringValue("invoiceDate", InvoiceDate);
            writer.WriteStringValue("invoiceNumber", InvoiceNumber);
            writer.WriteEnumValue<global::SevDesk.Api.V2.Models.Model_Invoice_invoiceType>("invoiceType", InvoiceType);
            writer.WriteBoolValue("mapAll", MapAll);
            writer.WriteStringValue("objectName", ObjectName);
            writer.WriteObjectValue<global::SevDesk.Api.V2.Models.Model_Invoice_origin>("origin", Origin);
            writer.WriteDateTimeOffsetValue("payDate", PayDate);
            writer.WriteObjectValue<global::SevDesk.Api.V2.Models.Model_Invoice_paymentMethod>("paymentMethod", PaymentMethod);
            writer.WriteDateTimeOffsetValue("sendDate", SendDate);
            writer.WriteEnumValue<global::SevDesk.Api.V2.Models.Model_Invoice_sendType>("sendType", SendType);
            writer.WriteBoolValue("showNet", ShowNet);
            writer.WriteBoolValue("smallSettlement", SmallSettlement);
            writer.WriteEnumValue<global::SevDesk.Api.V2.Models.Model_Invoice_status>("status", Status);
            writer.WriteFloatValue("taxRate", TaxRate);
            writer.WriteObjectValue<global::SevDesk.Api.V2.Models.Model_Invoice_taxRule>("taxRule", TaxRule);
            writer.WriteObjectValue<global::SevDesk.Api.V2.Models.Model_Invoice_taxSet>("taxSet", TaxSet);
            writer.WriteStringValue("taxText", TaxText);
            writer.WriteEnumValue<global::SevDesk.Api.V2.Models.Model_Invoice_taxType>("taxType", TaxType);
            writer.WriteIntValue("timeToPay", TimeToPay);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
