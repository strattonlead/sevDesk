// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace SevDesk.Api.V2.Models
{
    /// <summary>
    /// creditNote model
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class Model_creditNote : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Complete address of the recipient including name, street, city, zip and country.&lt;br&gt;     Line breaks can be used and will be displayed on the invoice pdf.</summary>
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
        public global::SevDesk.Api.V2.Models.Model_creditNote_addressCountry? AddressCountry { get; set; }
#nullable restore
#else
        public global::SevDesk.Api.V2.Models.Model_creditNote_addressCountry AddressCountry { get; set; }
#endif
        /// <summary>Defines the booking category, for more information see the section [Credit note booking categories](#tag/CreditNote/Credit-note-booking-categories)The booking category of the credit note.**Must be &lt;code&gt;UNDERACHIEVEMENT&lt;/code&gt; in sevdesk-Update 2.0.**</summary>
        public global::SevDesk.Api.V2.Models.Model_creditNote_bookingCategory? BookingCategory { get; set; }
        /// <summary>The contact used in the creditNote</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::SevDesk.Api.V2.Models.Model_creditNote_contact? Contact { get; set; }
#nullable restore
#else
        public global::SevDesk.Api.V2.Models.Model_creditNote_contact Contact { get; set; }
#endif
        /// <summary>The user who acts as a contact person for the creditNote</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::SevDesk.Api.V2.Models.Model_creditNote_contactPerson? ContactPerson { get; set; }
#nullable restore
#else
        public global::SevDesk.Api.V2.Models.Model_creditNote_contactPerson ContactPerson { get; set; }
#endif
        /// <summary>Date of creditNote creation</summary>
        public DateTimeOffset? Create { get; private set; }
        /// <summary>Will be filled automatically by our system and can&apos;t be changed</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::SevDesk.Api.V2.Models.Model_creditNote_createUser? CreateUser { get; private set; }
#nullable restore
#else
        public global::SevDesk.Api.V2.Models.Model_creditNote_createUser CreateUser { get; private set; }
#endif
        /// <summary>Needs to be provided as timestamp or dd.mm.yyyy</summary>
        public DateTimeOffset? CreditNoteDate { get; set; }
        /// <summary>The creditNote number</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreditNoteNumber { get; set; }
#nullable restore
#else
        public string CreditNoteNumber { get; set; }
#endif
        /// <summary>Currency used in the creditNote. Needs to be currency code according to ISO-4217</summary>
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
        /// <summary>Certain html tags can be used here to format your text</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FootText { get; set; }
#nullable restore
#else
        public string FootText { get; set; }
#endif
        /// <summary>Normally consist of prefix plus the creditNote number</summary>
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
        /// <summary>The creditNote id. &lt;span style=&apos;color:red&apos;&gt;Required&lt;/span&gt; if you want to create/update an credit note position for an existing credit note&quot;</summary>
        public int? Id { get; set; }
        /// <summary>The mapAll property</summary>
        public bool? MapAll { get; set; }
        /// <summary>The creditNote object name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ObjectName { get; set; }
#nullable restore
#else
        public string ObjectName { get; set; }
#endif
        /// <summary>The date the creditNote was sent to the customer</summary>
        public DateTimeOffset? SendDate { get; set; }
        /// <summary>Type which was used to send the creditNote. IMPORTANT: Please refer to the creditNote section of the     *     API-Overview to understand how this attribute can be used before using it!</summary>
        public global::SevDesk.Api.V2.Models.Model_creditNote_sendType? SendType { get; set; }
        /// <summary>Client to which creditNote belongs. Will be filled automatically</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::SevDesk.Api.V2.Models.Model_creditNote_sevClient? SevClient { get; private set; }
#nullable restore
#else
        public global::SevDesk.Api.V2.Models.Model_creditNote_sevClient SevClient { get; private set; }
#endif
        /// <summary>If true, the net amount of each position will be shown on the creditNote. Otherwise gross amount</summary>
        public bool? ShowNet { get; set; }
        /// <summary>Defines if the client uses the small settlement scheme.    If yes, the creditNote must not contain any vat</summary>
        public bool? SmallSettlement { get; set; }
        /// <summary>Please have a look in     &lt;a href=&apos;#tag/CreditNote/Status-of-credit-notes&apos;&gt;status of credit note&lt;/a&gt;    to see what the different status codes mean</summary>
        public global::SevDesk.Api.V2.Models.Model_creditNote_status? Status { get; set; }
        /// <summary>Sum of all discounts in the creditNote</summary>
        public float? SumDiscounts { get; private set; }
        /// <summary>Discounts sum of the creditNote in the foreign currency</summary>
        public float? SumDiscountsForeignCurrency { get; private set; }
        /// <summary>Gross sum of the creditNote</summary>
        public float? SumGross { get; private set; }
        /// <summary>Gross sum of the creditNote in the foreign currency</summary>
        public float? SumGrossForeignCurrency { get; private set; }
        /// <summary>Net sum of the creditNote</summary>
        public float? SumNet { get; private set; }
        /// <summary>Net sum of the creditNote in the foreign currency</summary>
        public float? SumNetForeignCurrency { get; private set; }
        /// <summary>Tax sum of the creditNote</summary>
        public float? SumTax { get; private set; }
        /// <summary>Tax sum of the creditNote in the foreign currency</summary>
        public float? SumTaxForeignCurrency { get; private set; }
        /// <summary>This is not used anymore. Use the taxRate of the individual positions instead.</summary>
        public float? TaxRate { get; set; }
        /// <summary>**Use this in sevdesk-Update 2.0 (replaces taxType / taxSet).**</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::SevDesk.Api.V2.Models.Model_creditNote_taxRule? TaxRule { get; set; }
#nullable restore
#else
        public global::SevDesk.Api.V2.Models.Model_creditNote_taxRule TaxRule { get; set; }
#endif
        /// <summary>**Use this in sevdesk-Update 1.0 (instead of taxRule).**Tax set of the creditNote. Needs to be added if you chose the tax type custom</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::SevDesk.Api.V2.Models.Model_creditNote_taxSet? TaxSet { get; set; }
#nullable restore
#else
        public global::SevDesk.Api.V2.Models.Model_creditNote_taxSet TaxSet { get; set; }
#endif
        /// <summary>A common tax text would be &apos;Umsatzsteuer 19%&apos;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TaxText { get; set; }
#nullable restore
#else
        public string TaxText { get; set; }
#endif
        /// <summary>**Use this in sevdesk-Update 1.0 (instead of taxRule).**Tax type of the creditNote.There are four tax types:1. default - Umsatzsteuer ausweisen2. eu - Steuerfreie innergemeinschaftliche Lieferung (Europäische Union)3. noteu - Steuerschuldnerschaft des Leistungsempfängers (außerhalb EU, z. B. Schweiz)4. custom - Using custom tax set5. ss - Not subject to VAT according to §19 1 UStGTax rates are heavily connected to the tax type used.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TaxType { get; set; }
#nullable restore
#else
        public string TaxType { get; set; }
#endif
        /// <summary>Date of last creditNote update</summary>
        public DateTimeOffset? Update { get; private set; }
        /// <summary>
        /// Instantiates a new <see cref="global::SevDesk.Api.V2.Models.Model_creditNote"/> and sets the default values.
        /// </summary>
        public Model_creditNote()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::SevDesk.Api.V2.Models.Model_creditNote"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::SevDesk.Api.V2.Models.Model_creditNote CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::SevDesk.Api.V2.Models.Model_creditNote();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "address", n => { Address = n.GetStringValue(); } },
                { "addressCountry", n => { AddressCountry = n.GetObjectValue<global::SevDesk.Api.V2.Models.Model_creditNote_addressCountry>(global::SevDesk.Api.V2.Models.Model_creditNote_addressCountry.CreateFromDiscriminatorValue); } },
                { "bookingCategory", n => { BookingCategory = n.GetEnumValue<global::SevDesk.Api.V2.Models.Model_creditNote_bookingCategory>(); } },
                { "contact", n => { Contact = n.GetObjectValue<global::SevDesk.Api.V2.Models.Model_creditNote_contact>(global::SevDesk.Api.V2.Models.Model_creditNote_contact.CreateFromDiscriminatorValue); } },
                { "contactPerson", n => { ContactPerson = n.GetObjectValue<global::SevDesk.Api.V2.Models.Model_creditNote_contactPerson>(global::SevDesk.Api.V2.Models.Model_creditNote_contactPerson.CreateFromDiscriminatorValue); } },
                { "create", n => { Create = n.GetDateTimeOffsetValue(); } },
                { "createUser", n => { CreateUser = n.GetObjectValue<global::SevDesk.Api.V2.Models.Model_creditNote_createUser>(global::SevDesk.Api.V2.Models.Model_creditNote_createUser.CreateFromDiscriminatorValue); } },
                { "creditNoteDate", n => { CreditNoteDate = n.GetDateTimeOffsetValue(); } },
                { "creditNoteNumber", n => { CreditNoteNumber = n.GetStringValue(); } },
                { "currency", n => { Currency = n.GetStringValue(); } },
                { "customerInternalNote", n => { CustomerInternalNote = n.GetStringValue(); } },
                { "footText", n => { FootText = n.GetStringValue(); } },
                { "headText", n => { HeadText = n.GetStringValue(); } },
                { "header", n => { Header = n.GetStringValue(); } },
                { "id", n => { Id = n.GetIntValue(); } },
                { "mapAll", n => { MapAll = n.GetBoolValue(); } },
                { "objectName", n => { ObjectName = n.GetStringValue(); } },
                { "sendDate", n => { SendDate = n.GetDateTimeOffsetValue(); } },
                { "sendType", n => { SendType = n.GetEnumValue<global::SevDesk.Api.V2.Models.Model_creditNote_sendType>(); } },
                { "sevClient", n => { SevClient = n.GetObjectValue<global::SevDesk.Api.V2.Models.Model_creditNote_sevClient>(global::SevDesk.Api.V2.Models.Model_creditNote_sevClient.CreateFromDiscriminatorValue); } },
                { "showNet", n => { ShowNet = n.GetBoolValue(); } },
                { "smallSettlement", n => { SmallSettlement = n.GetBoolValue(); } },
                { "status", n => { Status = n.GetEnumValue<global::SevDesk.Api.V2.Models.Model_creditNote_status>(); } },
                { "sumDiscounts", n => { SumDiscounts = n.GetFloatValue(); } },
                { "sumDiscountsForeignCurrency", n => { SumDiscountsForeignCurrency = n.GetFloatValue(); } },
                { "sumGross", n => { SumGross = n.GetFloatValue(); } },
                { "sumGrossForeignCurrency", n => { SumGrossForeignCurrency = n.GetFloatValue(); } },
                { "sumNet", n => { SumNet = n.GetFloatValue(); } },
                { "sumNetForeignCurrency", n => { SumNetForeignCurrency = n.GetFloatValue(); } },
                { "sumTax", n => { SumTax = n.GetFloatValue(); } },
                { "sumTaxForeignCurrency", n => { SumTaxForeignCurrency = n.GetFloatValue(); } },
                { "taxRate", n => { TaxRate = n.GetFloatValue(); } },
                { "taxRule", n => { TaxRule = n.GetObjectValue<global::SevDesk.Api.V2.Models.Model_creditNote_taxRule>(global::SevDesk.Api.V2.Models.Model_creditNote_taxRule.CreateFromDiscriminatorValue); } },
                { "taxSet", n => { TaxSet = n.GetObjectValue<global::SevDesk.Api.V2.Models.Model_creditNote_taxSet>(global::SevDesk.Api.V2.Models.Model_creditNote_taxSet.CreateFromDiscriminatorValue); } },
                { "taxText", n => { TaxText = n.GetStringValue(); } },
                { "taxType", n => { TaxType = n.GetStringValue(); } },
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
            writer.WriteObjectValue<global::SevDesk.Api.V2.Models.Model_creditNote_addressCountry>("addressCountry", AddressCountry);
            writer.WriteEnumValue<global::SevDesk.Api.V2.Models.Model_creditNote_bookingCategory>("bookingCategory", BookingCategory);
            writer.WriteObjectValue<global::SevDesk.Api.V2.Models.Model_creditNote_contact>("contact", Contact);
            writer.WriteObjectValue<global::SevDesk.Api.V2.Models.Model_creditNote_contactPerson>("contactPerson", ContactPerson);
            writer.WriteDateTimeOffsetValue("creditNoteDate", CreditNoteDate);
            writer.WriteStringValue("creditNoteNumber", CreditNoteNumber);
            writer.WriteStringValue("currency", Currency);
            writer.WriteStringValue("customerInternalNote", CustomerInternalNote);
            writer.WriteStringValue("footText", FootText);
            writer.WriteStringValue("header", Header);
            writer.WriteStringValue("headText", HeadText);
            writer.WriteIntValue("id", Id);
            writer.WriteBoolValue("mapAll", MapAll);
            writer.WriteStringValue("objectName", ObjectName);
            writer.WriteDateTimeOffsetValue("sendDate", SendDate);
            writer.WriteEnumValue<global::SevDesk.Api.V2.Models.Model_creditNote_sendType>("sendType", SendType);
            writer.WriteBoolValue("showNet", ShowNet);
            writer.WriteBoolValue("smallSettlement", SmallSettlement);
            writer.WriteEnumValue<global::SevDesk.Api.V2.Models.Model_creditNote_status>("status", Status);
            writer.WriteFloatValue("taxRate", TaxRate);
            writer.WriteObjectValue<global::SevDesk.Api.V2.Models.Model_creditNote_taxRule>("taxRule", TaxRule);
            writer.WriteObjectValue<global::SevDesk.Api.V2.Models.Model_creditNote_taxSet>("taxSet", TaxSet);
            writer.WriteStringValue("taxText", TaxText);
            writer.WriteStringValue("taxType", TaxType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}