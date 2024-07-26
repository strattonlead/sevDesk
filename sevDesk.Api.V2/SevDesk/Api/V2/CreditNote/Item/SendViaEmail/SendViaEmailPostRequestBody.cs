// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace SevDesk.Api.V2.CreditNote.Item.SendViaEmail
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    #pragma warning disable CS1591
    public partial class SendViaEmailPostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Additional attachments to the mail. String of IDs of existing documents in your     *                      sevdesk account separated by &apos;,&apos;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AdditionalAttachments { get; set; }
#nullable restore
#else
        public string AdditionalAttachments { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>String of mail addresses to be put as bcc separated by &apos;,&apos;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BccEmail { get; set; }
#nullable restore
#else
        public string BccEmail { get; set; }
#endif
        /// <summary>String of mail addresses to be put as cc separated by &apos;,&apos;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CcEmail { get; set; }
#nullable restore
#else
        public string CcEmail { get; set; }
#endif
        /// <summary>Should a copy of this email be sent to you?</summary>
        public bool? Copy { get; set; }
        /// <summary>The subject of the email.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Subject { get; set; }
#nullable restore
#else
        public string Subject { get; set; }
#endif
        /// <summary>The text of the email. Can contain html.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Text { get; set; }
#nullable restore
#else
        public string Text { get; set; }
#endif
        /// <summary>The recipient of the email.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ToEmail { get; set; }
#nullable restore
#else
        public string ToEmail { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::SevDesk.Api.V2.CreditNote.Item.SendViaEmail.SendViaEmailPostRequestBody"/> and sets the default values.
        /// </summary>
        public SendViaEmailPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::SevDesk.Api.V2.CreditNote.Item.SendViaEmail.SendViaEmailPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::SevDesk.Api.V2.CreditNote.Item.SendViaEmail.SendViaEmailPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::SevDesk.Api.V2.CreditNote.Item.SendViaEmail.SendViaEmailPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "additionalAttachments", n => { AdditionalAttachments = n.GetStringValue(); } },
                { "bccEmail", n => { BccEmail = n.GetStringValue(); } },
                { "ccEmail", n => { CcEmail = n.GetStringValue(); } },
                { "copy", n => { Copy = n.GetBoolValue(); } },
                { "subject", n => { Subject = n.GetStringValue(); } },
                { "text", n => { Text = n.GetStringValue(); } },
                { "toEmail", n => { ToEmail = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("additionalAttachments", AdditionalAttachments);
            writer.WriteStringValue("bccEmail", BccEmail);
            writer.WriteStringValue("ccEmail", CcEmail);
            writer.WriteBoolValue("copy", Copy);
            writer.WriteStringValue("subject", Subject);
            writer.WriteStringValue("text", Text);
            writer.WriteStringValue("toEmail", ToEmail);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
