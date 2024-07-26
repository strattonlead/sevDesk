// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System;
namespace SevDesk.Api.V2.Models
{
    /// <summary>
    /// Contact model
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class Model_ContactResponse : IAdditionalDataHolder, IParsable
    {
        /// <summary>A academic title for the contact.Not to be used for organizations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AcademicTitle { get; private set; }
#nullable restore
#else
        public string AcademicTitle { get; private set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Additional information stored for the contact.</summary>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AdditionalInformation { get; private set; }
#nullable restore
#else
        public string AdditionalInformation { get; private set; }
#endif
        /// <summary>Bank account number (IBAN) of the contact.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BankAccount { get; private set; }
#nullable restore
#else
        public string BankAccount { get; private set; }
#endif
        /// <summary>Bank number of the bank used by the contact.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BankNumber { get; private set; }
#nullable restore
#else
        public string BankNumber { get; private set; }
#endif
        /// <summary>Birthday of the contact.&lt;br&gt;Not to be used for organizations.</summary>
        public Date? Birthday { get; private set; }
        /// <summary>Buyer reference of the contact.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BuyerReference { get; private set; }
#nullable restore
#else
        public string BuyerReference { get; private set; }
#endif
        /// <summary>Category of the contact.&lt;br&gt; For more information,     see &lt;a href=&apos;https://my.sevdesk.de/apiOverview/index.html#/doc-contacts#types&apos;&gt;here&lt;/a&gt;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::SevDesk.Api.V2.Models.Model_ContactResponse_category? Category { get; private set; }
#nullable restore
#else
        public global::SevDesk.Api.V2.Models.Model_ContactResponse_category Category { get; private set; }
#endif
        /// <summary>Date of contact creation</summary>
        public DateTimeOffset? Create { get; private set; }
        /// <summary>The customer number</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerNumber { get; private set; }
#nullable restore
#else
        public string CustomerNumber { get; private set; }
#endif
        /// <summary>Percentage of the invoice sum the contact gets back if he paid invoices in time.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultCashbackPercent { get; private set; }
#nullable restore
#else
        public string DefaultCashbackPercent { get; private set; }
#endif
        /// <summary>Absolute time in days which the contact has to pay his invoices and subsequently get a cashback.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultCashbackTime { get; private set; }
#nullable restore
#else
        public string DefaultCashbackTime { get; private set; }
#endif
        /// <summary>The default discount the contact gets for every invoice.&lt;br&gt;Depending on defaultDiscountPercentage attribute, in percent or absolute value.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultDiscountAmount { get; private set; }
#nullable restore
#else
        public string DefaultDiscountAmount { get; private set; }
#endif
        /// <summary>Defines if the discount is a percentage (true) or an absolute value (false).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultDiscountPercentage { get; private set; }
#nullable restore
#else
        public string DefaultDiscountPercentage { get; private set; }
#endif
        /// <summary>The payment goal in days which is set for every invoice of the contact.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultTimeToPay { get; private set; }
#nullable restore
#else
        public string DefaultTimeToPay { get; private set; }
#endif
        /// <summary>A description for the contact.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; private set; }
#nullable restore
#else
        public string Description { get; private set; }
#endif
        /// <summary>Defines if the contact is freed from paying vat.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExemptVat { get; private set; }
#nullable restore
#else
        public string ExemptVat { get; private set; }
#endif
        /// <summary>The last name of the contact.&lt;br&gt;Not to be used for organizations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Familyname { get; private set; }
#nullable restore
#else
        public string Familyname { get; private set; }
#endif
        /// <summary>Gender of the contact.&lt;br&gt;Not to be used for organizations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Gender { get; private set; }
#nullable restore
#else
        public string Gender { get; private set; }
#endif
        /// <summary>Defines whether the contact is a government agency (true) or not (false).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GovernmentAgency { get; private set; }
#nullable restore
#else
        public string GovernmentAgency { get; private set; }
#endif
        /// <summary>The contact id</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; private set; }
#nullable restore
#else
        public string Id { get; private set; }
#endif
        /// <summary>The organization name.&lt;br&gt;Be aware that the type of contact will depend on this attribute.&lt;br&gt;If it holds a value, the contact will be regarded as an organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; private set; }
#nullable restore
#else
        public string Name { get; private set; }
#endif
        /// <summary>Second name of the contact.&lt;br&gt;Not to be used for organizations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name2 { get; private set; }
#nullable restore
#else
        public string Name2 { get; private set; }
#endif
        /// <summary>The contact object name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ObjectName { get; private set; }
#nullable restore
#else
        public string ObjectName { get; private set; }
#endif
        /// <summary>The parent contact to which this contact belongs. Must be an organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::SevDesk.Api.V2.Models.Model_ContactResponse_parent? Parent { get; private set; }
#nullable restore
#else
        public global::SevDesk.Api.V2.Models.Model_ContactResponse_parent Parent { get; private set; }
#endif
        /// <summary>Client to which contact belongs. Will be filled automatically</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::SevDesk.Api.V2.Models.Model_ContactResponse_sevClient? SevClient { get; private set; }
#nullable restore
#else
        public global::SevDesk.Api.V2.Models.Model_ContactResponse_sevClient SevClient { get; private set; }
#endif
        /// <summary>Defines the status of the contact. 100 &lt;-&gt; Lead - 500 &lt;-&gt; Pending - 1000 &lt;-&gt; Active.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Status { get; private set; }
#nullable restore
#else
        public string Status { get; private set; }
#endif
        /// <summary>The &lt;b&gt;first&lt;/b&gt; name of the contact.&lt;br&gt;Yeah... not quite right in literally every way. We know.&lt;br&gt;Not to be used for organizations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Surename { get; private set; }
#nullable restore
#else
        public string Surename { get; private set; }
#endif
        /// <summary>The tax number of the contact.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TaxNumber { get; private set; }
#nullable restore
#else
        public string TaxNumber { get; private set; }
#endif
        /// <summary>The tax office of the contact (only for greek customers).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TaxOffice { get; private set; }
#nullable restore
#else
        public string TaxOffice { get; private set; }
#endif
        /// <summary>A non-academic title for the contact.Not to be used for organizations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Titel { get; private set; }
#nullable restore
#else
        public string Titel { get; private set; }
#endif
        /// <summary>Date of last contact update</summary>
        public DateTimeOffset? Update { get; private set; }
        /// <summary>Vat number of the contact.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VatNumber { get; private set; }
#nullable restore
#else
        public string VatNumber { get; private set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::SevDesk.Api.V2.Models.Model_ContactResponse"/> and sets the default values.
        /// </summary>
        public Model_ContactResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::SevDesk.Api.V2.Models.Model_ContactResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::SevDesk.Api.V2.Models.Model_ContactResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::SevDesk.Api.V2.Models.Model_ContactResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "academicTitle", n => { AcademicTitle = n.GetStringValue(); } },
                { "additionalInformation", n => { AdditionalInformation = n.GetStringValue(); } },
                { "bankAccount", n => { BankAccount = n.GetStringValue(); } },
                { "bankNumber", n => { BankNumber = n.GetStringValue(); } },
                { "birthday", n => { Birthday = n.GetDateValue(); } },
                { "buyerReference", n => { BuyerReference = n.GetStringValue(); } },
                { "category", n => { Category = n.GetObjectValue<global::SevDesk.Api.V2.Models.Model_ContactResponse_category>(global::SevDesk.Api.V2.Models.Model_ContactResponse_category.CreateFromDiscriminatorValue); } },
                { "create", n => { Create = n.GetDateTimeOffsetValue(); } },
                { "customerNumber", n => { CustomerNumber = n.GetStringValue(); } },
                { "defaultCashbackPercent", n => { DefaultCashbackPercent = n.GetStringValue(); } },
                { "defaultCashbackTime", n => { DefaultCashbackTime = n.GetStringValue(); } },
                { "defaultDiscountAmount", n => { DefaultDiscountAmount = n.GetStringValue(); } },
                { "defaultDiscountPercentage", n => { DefaultDiscountPercentage = n.GetStringValue(); } },
                { "defaultTimeToPay", n => { DefaultTimeToPay = n.GetStringValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "exemptVat", n => { ExemptVat = n.GetStringValue(); } },
                { "familyname", n => { Familyname = n.GetStringValue(); } },
                { "gender", n => { Gender = n.GetStringValue(); } },
                { "governmentAgency", n => { GovernmentAgency = n.GetStringValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "name2", n => { Name2 = n.GetStringValue(); } },
                { "objectName", n => { ObjectName = n.GetStringValue(); } },
                { "parent", n => { Parent = n.GetObjectValue<global::SevDesk.Api.V2.Models.Model_ContactResponse_parent>(global::SevDesk.Api.V2.Models.Model_ContactResponse_parent.CreateFromDiscriminatorValue); } },
                { "sevClient", n => { SevClient = n.GetObjectValue<global::SevDesk.Api.V2.Models.Model_ContactResponse_sevClient>(global::SevDesk.Api.V2.Models.Model_ContactResponse_sevClient.CreateFromDiscriminatorValue); } },
                { "status", n => { Status = n.GetStringValue(); } },
                { "surename", n => { Surename = n.GetStringValue(); } },
                { "taxNumber", n => { TaxNumber = n.GetStringValue(); } },
                { "taxOffice", n => { TaxOffice = n.GetStringValue(); } },
                { "titel", n => { Titel = n.GetStringValue(); } },
                { "update", n => { Update = n.GetDateTimeOffsetValue(); } },
                { "vatNumber", n => { VatNumber = n.GetStringValue(); } },
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