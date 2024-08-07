// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace SevDesk.Api.V2.Models
{
    /// <summary>
    /// CheckAccount model. Responsible for the payment accounts.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class Model_CheckAccount : IAdditionalDataHolder, IParsable
    {
        /// <summary>The booking account used for this bank account, e.g. 1800 in SKR04 and 1200 in SKR03. Must be unique among all your CheckAccounts. Ignore to use a sensible default.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountingNumber { get; set; }
#nullable restore
#else
        public string AccountingNumber { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Defines if transactions on this account are automatically mapped to invoice and vouchers when imported if possible.</summary>
        public int? AutoMapTransactions { get; set; }
        /// <summary>Bank server of check account</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BankServer { get; private set; }
#nullable restore
#else
        public string BankServer { get; private set; }
#endif
        /// <summary>Date of check account creation</summary>
        public DateTimeOffset? Create { get; private set; }
        /// <summary>The currency of the check account.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Currency { get; set; }
#nullable restore
#else
        public string Currency { get; set; }
#endif
        /// <summary>Defines if this check account is the default account.</summary>
        public int? DefaultAccount { get; set; }
        /// <summary>The check account id</summary>
        public int? Id { get; private set; }
        /// <summary>Import type. Transactions can be imported by this method on the check account.</summary>
        public global::SevDesk.Api.V2.Models.Model_CheckAccount_importType? ImportType { get; set; }
        /// <summary>Name of the check account</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The check account object name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ObjectName { get; private set; }
#nullable restore
#else
        public string ObjectName { get; private set; }
#endif
        /// <summary>Client to which check account belongs. Will be filled automatically</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::SevDesk.Api.V2.Models.Model_CheckAccount_sevClient? SevClient { get; private set; }
#nullable restore
#else
        public global::SevDesk.Api.V2.Models.Model_CheckAccount_sevClient SevClient { get; private set; }
#endif
        /// <summary>Status of the check account. 0 &lt;-&gt; Archived - 100 &lt;-&gt; Active</summary>
        public int? Status { get; set; }
        /// <summary>The type of the check account. Account with a CSV or MT940 import are regarded as online.&lt;br&gt;     Apart from that, created check accounts over the API need to be offline, as online accounts with an active connection     to a bank application can not be managed over the API.</summary>
        public global::SevDesk.Api.V2.Models.Model_CheckAccount_type? Type { get; set; }
        /// <summary>Date of last check account update</summary>
        public DateTimeOffset? Update { get; private set; }
        /// <summary>
        /// Instantiates a new <see cref="global::SevDesk.Api.V2.Models.Model_CheckAccount"/> and sets the default values.
        /// </summary>
        public Model_CheckAccount()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::SevDesk.Api.V2.Models.Model_CheckAccount"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::SevDesk.Api.V2.Models.Model_CheckAccount CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::SevDesk.Api.V2.Models.Model_CheckAccount();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "accountingNumber", n => { AccountingNumber = n.GetStringValue(); } },
                { "autoMapTransactions", n => { AutoMapTransactions = n.GetIntValue(); } },
                { "bankServer", n => { BankServer = n.GetStringValue(); } },
                { "create", n => { Create = n.GetDateTimeOffsetValue(); } },
                { "currency", n => { Currency = n.GetStringValue(); } },
                { "defaultAccount", n => { DefaultAccount = n.GetIntValue(); } },
                { "id", n => { Id = n.GetIntValue(); } },
                { "importType", n => { ImportType = n.GetEnumValue<global::SevDesk.Api.V2.Models.Model_CheckAccount_importType>(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "objectName", n => { ObjectName = n.GetStringValue(); } },
                { "sevClient", n => { SevClient = n.GetObjectValue<global::SevDesk.Api.V2.Models.Model_CheckAccount_sevClient>(global::SevDesk.Api.V2.Models.Model_CheckAccount_sevClient.CreateFromDiscriminatorValue); } },
                { "status", n => { Status = n.GetIntValue(); } },
                { "type", n => { Type = n.GetEnumValue<global::SevDesk.Api.V2.Models.Model_CheckAccount_type>(); } },
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
            writer.WriteStringValue("accountingNumber", AccountingNumber);
            writer.WriteIntValue("autoMapTransactions", AutoMapTransactions);
            writer.WriteStringValue("currency", Currency);
            writer.WriteIntValue("defaultAccount", DefaultAccount);
            writer.WriteEnumValue<global::SevDesk.Api.V2.Models.Model_CheckAccount_importType>("importType", ImportType);
            writer.WriteStringValue("name", Name);
            writer.WriteIntValue("status", Status);
            writer.WriteEnumValue<global::SevDesk.Api.V2.Models.Model_CheckAccount_type>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
