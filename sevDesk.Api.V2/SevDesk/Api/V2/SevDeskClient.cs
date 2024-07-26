// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Serialization.Form;
using Microsoft.Kiota.Serialization.Json;
using Microsoft.Kiota.Serialization.Multipart;
using Microsoft.Kiota.Serialization.Text;
using SevDesk.Api.V2.AccountingContact;
using SevDesk.Api.V2.CheckAccount;
using SevDesk.Api.V2.CheckAccountTransaction;
using SevDesk.Api.V2.CommunicationWay;
using SevDesk.Api.V2.CommunicationWayKey;
using SevDesk.Api.V2.Contact;
using SevDesk.Api.V2.ContactAddress;
using SevDesk.Api.V2.ContactCustomField;
using SevDesk.Api.V2.ContactCustomFieldSetting;
using SevDesk.Api.V2.CreditNote;
using SevDesk.Api.V2.CreditNotePos;
using SevDesk.Api.V2.DocServer;
using SevDesk.Api.V2.Export;
using SevDesk.Api.V2.Invoice;
using SevDesk.Api.V2.InvoicePos;
using SevDesk.Api.V2.Order;
using SevDesk.Api.V2.OrderPos;
using SevDesk.Api.V2.Part;
using SevDesk.Api.V2.ReceiptGuidance;
using SevDesk.Api.V2.Report;
using SevDesk.Api.V2.SevClient;
using SevDesk.Api.V2.Tag;
using SevDesk.Api.V2.TagRelation;
using SevDesk.Api.V2.Textparser;
using SevDesk.Api.V2.Tools;
using SevDesk.Api.V2.Voucher;
using SevDesk.Api.V2.VoucherPos;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace SevDesk.Api.V2
{
    /// <summary>
    /// The main entry point of the SDK, exposes the configuration and the fluent API.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class SevDeskClient : BaseRequestBuilder
    {
        /// <summary>The AccountingContact property</summary>
        public global::SevDesk.Api.V2.AccountingContact.AccountingContactRequestBuilder AccountingContact
        {
            get => new global::SevDesk.Api.V2.AccountingContact.AccountingContactRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The CheckAccount property</summary>
        public global::SevDesk.Api.V2.CheckAccount.CheckAccountRequestBuilder CheckAccount
        {
            get => new global::SevDesk.Api.V2.CheckAccount.CheckAccountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The CheckAccountTransaction property</summary>
        public global::SevDesk.Api.V2.CheckAccountTransaction.CheckAccountTransactionRequestBuilder CheckAccountTransaction
        {
            get => new global::SevDesk.Api.V2.CheckAccountTransaction.CheckAccountTransactionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The CommunicationWay property</summary>
        public global::SevDesk.Api.V2.CommunicationWay.CommunicationWayRequestBuilder CommunicationWay
        {
            get => new global::SevDesk.Api.V2.CommunicationWay.CommunicationWayRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The CommunicationWayKey property</summary>
        public global::SevDesk.Api.V2.CommunicationWayKey.CommunicationWayKeyRequestBuilder CommunicationWayKey
        {
            get => new global::SevDesk.Api.V2.CommunicationWayKey.CommunicationWayKeyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Contact property</summary>
        public global::SevDesk.Api.V2.Contact.ContactRequestBuilder Contact
        {
            get => new global::SevDesk.Api.V2.Contact.ContactRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The ContactAddress property</summary>
        public global::SevDesk.Api.V2.ContactAddress.ContactAddressRequestBuilder ContactAddress
        {
            get => new global::SevDesk.Api.V2.ContactAddress.ContactAddressRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The ContactCustomField property</summary>
        public global::SevDesk.Api.V2.ContactCustomField.ContactCustomFieldRequestBuilder ContactCustomField
        {
            get => new global::SevDesk.Api.V2.ContactCustomField.ContactCustomFieldRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The ContactCustomFieldSetting property</summary>
        public global::SevDesk.Api.V2.ContactCustomFieldSetting.ContactCustomFieldSettingRequestBuilder ContactCustomFieldSetting
        {
            get => new global::SevDesk.Api.V2.ContactCustomFieldSetting.ContactCustomFieldSettingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The CreditNote property</summary>
        public global::SevDesk.Api.V2.CreditNote.CreditNoteRequestBuilder CreditNote
        {
            get => new global::SevDesk.Api.V2.CreditNote.CreditNoteRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The CreditNotePos property</summary>
        public global::SevDesk.Api.V2.CreditNotePos.CreditNotePosRequestBuilder CreditNotePos
        {
            get => new global::SevDesk.Api.V2.CreditNotePos.CreditNotePosRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The DocServer property</summary>
        public global::SevDesk.Api.V2.DocServer.DocServerRequestBuilder DocServer
        {
            get => new global::SevDesk.Api.V2.DocServer.DocServerRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Export property</summary>
        public global::SevDesk.Api.V2.Export.ExportRequestBuilder Export
        {
            get => new global::SevDesk.Api.V2.Export.ExportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Invoice property</summary>
        public global::SevDesk.Api.V2.Invoice.InvoiceRequestBuilder Invoice
        {
            get => new global::SevDesk.Api.V2.Invoice.InvoiceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The InvoicePos property</summary>
        public global::SevDesk.Api.V2.InvoicePos.InvoicePosRequestBuilder InvoicePos
        {
            get => new global::SevDesk.Api.V2.InvoicePos.InvoicePosRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Order property</summary>
        public global::SevDesk.Api.V2.Order.OrderRequestBuilder Order
        {
            get => new global::SevDesk.Api.V2.Order.OrderRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The OrderPos property</summary>
        public global::SevDesk.Api.V2.OrderPos.OrderPosRequestBuilder OrderPos
        {
            get => new global::SevDesk.Api.V2.OrderPos.OrderPosRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Part property</summary>
        public global::SevDesk.Api.V2.Part.PartRequestBuilder Part
        {
            get => new global::SevDesk.Api.V2.Part.PartRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The ReceiptGuidance property</summary>
        public global::SevDesk.Api.V2.ReceiptGuidance.ReceiptGuidanceRequestBuilder ReceiptGuidance
        {
            get => new global::SevDesk.Api.V2.ReceiptGuidance.ReceiptGuidanceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Report property</summary>
        public global::SevDesk.Api.V2.Report.ReportRequestBuilder Report
        {
            get => new global::SevDesk.Api.V2.Report.ReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The SevClient property</summary>
        public global::SevDesk.Api.V2.SevClient.SevClientRequestBuilder SevClient
        {
            get => new global::SevDesk.Api.V2.SevClient.SevClientRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Tag property</summary>
        public global::SevDesk.Api.V2.Tag.TagRequestBuilder Tag
        {
            get => new global::SevDesk.Api.V2.Tag.TagRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The TagRelation property</summary>
        public global::SevDesk.Api.V2.TagRelation.TagRelationRequestBuilder TagRelation
        {
            get => new global::SevDesk.Api.V2.TagRelation.TagRelationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Textparser property</summary>
        public global::SevDesk.Api.V2.Textparser.TextparserRequestBuilder Textparser
        {
            get => new global::SevDesk.Api.V2.Textparser.TextparserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Tools property</summary>
        public global::SevDesk.Api.V2.Tools.ToolsRequestBuilder Tools
        {
            get => new global::SevDesk.Api.V2.Tools.ToolsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Voucher property</summary>
        public global::SevDesk.Api.V2.Voucher.VoucherRequestBuilder Voucher
        {
            get => new global::SevDesk.Api.V2.Voucher.VoucherRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The VoucherPos property</summary>
        public global::SevDesk.Api.V2.VoucherPos.VoucherPosRequestBuilder VoucherPos
        {
            get => new global::SevDesk.Api.V2.VoucherPos.VoucherPosRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::SevDesk.Api.V2.SevDeskClient"/> and sets the default values.
        /// </summary>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SevDeskClient(IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}", new Dictionary<string, object>())
        {
            ApiClientBuilder.RegisterDefaultSerializer<JsonSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<TextSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<FormSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<MultipartSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<JsonParseNodeFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<TextParseNodeFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<FormParseNodeFactory>();
            if (string.IsNullOrEmpty(RequestAdapter.BaseUrl))
            {
                RequestAdapter.BaseUrl = "https://my.sevdesk.de/api/v1";
            }
            PathParameters.TryAdd("baseurl", RequestAdapter.BaseUrl);
        }
    }
}
