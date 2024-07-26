// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace SevDesk.Api.V2.Models
{
    /// <summary>
    /// Voucher position model
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class Model_VoucherPosResponse : IAdditionalDataHolder, IParsable
    {
        /// <summary>&lt;b&gt;Use this in sevdesk-Update 2.0 (replaces accountingType).&lt;/b&gt;     The account datev to which the position belongs.&lt;br&gt;     An account datev is the booking account to which the position belongs.&lt;br&gt;     For more information, please refer to &lt;a href=&apos;#tag/Voucher/Account-Datev&apos;&gt;this&lt;/a&gt; section.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::SevDesk.Api.V2.Models.Model_VoucherPosResponse_accountDatev? AccountDatev { get; set; }
#nullable restore
#else
        public global::SevDesk.Api.V2.Models.Model_VoucherPosResponse_accountDatev AccountDatev { get; set; }
#endif
        /// <summary>The accounting type to which the position belongs.&lt;br&gt;     An accounting type is the booking account to which the position belongs.&lt;br&gt;     For more information, please refer to &lt;a href=&apos;#tag/Voucher/Accounting-type&apos;&gt;this&lt;/a&gt; section.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::SevDesk.Api.V2.Models.Model_VoucherPosResponse_accountingType? AccountingType { get; set; }
#nullable restore
#else
        public global::SevDesk.Api.V2.Models.Model_VoucherPosResponse_accountingType AccountingType { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Comment for the voucher position.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Comment { get; set; }
#nullable restore
#else
        public string Comment { get; set; }
#endif
        /// <summary>Date of voucher position creation</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Create { get; private set; }
#nullable restore
#else
        public string Create { get; private set; }
#endif
        /// <summary>The accounting type to which the position belongs estimated by our voucher recognition.&lt;br&gt;    An accounting type is the booking account to which the position belongs.&lt;br&gt;    For more information, please refer to    &lt;a href=&apos;#tag/Voucher/Accounting-type&apos;&gt;this&lt;/a&gt; section.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::SevDesk.Api.V2.Models.Model_VoucherPosResponse_estimatedAccountingType? EstimatedAccountingType { get; private set; }
#nullable restore
#else
        public global::SevDesk.Api.V2.Models.Model_VoucherPosResponse_estimatedAccountingType EstimatedAccountingType { get; private set; }
#endif
        /// <summary>The voucher position id</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; private set; }
#nullable restore
#else
        public string Id { get; private set; }
#endif
        /// <summary>Determines whether position is regarded as an asset which can be depreciated.</summary>
        public bool? IsAsset { get; set; }
        /// <summary>Determines whether &apos;sumNet&apos; or &apos;sumGross&apos; is regarded.&lt;br&gt;     If both are not given, &apos;sum&apos; is regarded and treated as net or gross depending on &apos;net&apos;. All positions must be either net or gross, a mixture of the two is not possible.</summary>
        public bool? Net { get; set; }
        /// <summary>The voucher position object name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ObjectName { get; private set; }
#nullable restore
#else
        public string ObjectName { get; private set; }
#endif
        /// <summary>Client to which voucher position belongs. Will be filled automatically</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::SevDesk.Api.V2.Models.Model_VoucherPosResponse_sevClient? SevClient { get; private set; }
#nullable restore
#else
        public global::SevDesk.Api.V2.Models.Model_VoucherPosResponse_sevClient SevClient { get; private set; }
#endif
        /// <summary>Gross sum of the voucher position.&lt;br&gt;    Only regarded if &apos;net&apos; is &apos;false&apos;, otherwise its readOnly.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SumGross { get; set; }
#nullable restore
#else
        public string SumGross { get; set; }
#endif
        /// <summary>Gross accounting sum. Is equal to sumGross.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SumGrossAccounting { get; private set; }
#nullable restore
#else
        public string SumGrossAccounting { get; private set; }
#endif
        /// <summary>Net sum of the voucher position.&lt;br&gt;    Only regarded if &apos;net&apos; is &apos;true&apos;, otherwise its readOnly.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SumNet { get; set; }
#nullable restore
#else
        public string SumNet { get; set; }
#endif
        /// <summary>Net accounting sum. Is equal to sumNet.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SumNetAccounting { get; private set; }
#nullable restore
#else
        public string SumNetAccounting { get; private set; }
#endif
        /// <summary>Tax sum of the voucher position.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SumTax { get; private set; }
#nullable restore
#else
        public string SumTax { get; private set; }
#endif
        /// <summary>Tax accounting sum. Is equal to sumTax.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SumTaxAccounting { get; private set; }
#nullable restore
#else
        public string SumTaxAccounting { get; private set; }
#endif
        /// <summary>Tax rate of the voucher position.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TaxRate { get; set; }
#nullable restore
#else
        public string TaxRate { get; set; }
#endif
        /// <summary>Date of last voucher position update</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Update { get; private set; }
#nullable restore
#else
        public string Update { get; private set; }
#endif
        /// <summary>The voucher to which the position belongs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::SevDesk.Api.V2.Models.Model_VoucherPosResponse_voucher? Voucher { get; private set; }
#nullable restore
#else
        public global::SevDesk.Api.V2.Models.Model_VoucherPosResponse_voucher Voucher { get; private set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::SevDesk.Api.V2.Models.Model_VoucherPosResponse"/> and sets the default values.
        /// </summary>
        public Model_VoucherPosResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::SevDesk.Api.V2.Models.Model_VoucherPosResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::SevDesk.Api.V2.Models.Model_VoucherPosResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::SevDesk.Api.V2.Models.Model_VoucherPosResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "accountDatev", n => { AccountDatev = n.GetObjectValue<global::SevDesk.Api.V2.Models.Model_VoucherPosResponse_accountDatev>(global::SevDesk.Api.V2.Models.Model_VoucherPosResponse_accountDatev.CreateFromDiscriminatorValue); } },
                { "accountingType", n => { AccountingType = n.GetObjectValue<global::SevDesk.Api.V2.Models.Model_VoucherPosResponse_accountingType>(global::SevDesk.Api.V2.Models.Model_VoucherPosResponse_accountingType.CreateFromDiscriminatorValue); } },
                { "comment", n => { Comment = n.GetStringValue(); } },
                { "create", n => { Create = n.GetStringValue(); } },
                { "estimatedAccountingType", n => { EstimatedAccountingType = n.GetObjectValue<global::SevDesk.Api.V2.Models.Model_VoucherPosResponse_estimatedAccountingType>(global::SevDesk.Api.V2.Models.Model_VoucherPosResponse_estimatedAccountingType.CreateFromDiscriminatorValue); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "isAsset", n => { IsAsset = n.GetBoolValue(); } },
                { "net", n => { Net = n.GetBoolValue(); } },
                { "objectName", n => { ObjectName = n.GetStringValue(); } },
                { "sevClient", n => { SevClient = n.GetObjectValue<global::SevDesk.Api.V2.Models.Model_VoucherPosResponse_sevClient>(global::SevDesk.Api.V2.Models.Model_VoucherPosResponse_sevClient.CreateFromDiscriminatorValue); } },
                { "sumGross", n => { SumGross = n.GetStringValue(); } },
                { "sumGrossAccounting", n => { SumGrossAccounting = n.GetStringValue(); } },
                { "sumNet", n => { SumNet = n.GetStringValue(); } },
                { "sumNetAccounting", n => { SumNetAccounting = n.GetStringValue(); } },
                { "sumTax", n => { SumTax = n.GetStringValue(); } },
                { "sumTaxAccounting", n => { SumTaxAccounting = n.GetStringValue(); } },
                { "taxRate", n => { TaxRate = n.GetStringValue(); } },
                { "update", n => { Update = n.GetStringValue(); } },
                { "voucher", n => { Voucher = n.GetObjectValue<global::SevDesk.Api.V2.Models.Model_VoucherPosResponse_voucher>(global::SevDesk.Api.V2.Models.Model_VoucherPosResponse_voucher.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::SevDesk.Api.V2.Models.Model_VoucherPosResponse_accountDatev>("accountDatev", AccountDatev);
            writer.WriteObjectValue<global::SevDesk.Api.V2.Models.Model_VoucherPosResponse_accountingType>("accountingType", AccountingType);
            writer.WriteStringValue("comment", Comment);
            writer.WriteBoolValue("isAsset", IsAsset);
            writer.WriteBoolValue("net", Net);
            writer.WriteStringValue("sumGross", SumGross);
            writer.WriteStringValue("sumNet", SumNet);
            writer.WriteStringValue("taxRate", TaxRate);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}