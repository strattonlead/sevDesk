// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace SevDesk.Api.V2.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    #pragma warning disable CS1591
    public partial class Model_CreditNote_sendByWithRender : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The docId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DocId { get; set; }
#nullable restore
#else
        public string DocId { get; set; }
#endif
        /// <summary>The pages property</summary>
        public int? Pages { get; set; }
        /// <summary>The parameters property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::SevDesk.Api.V2.Models.Model_CreditNote_sendByWithRender_parameters>? Parameters { get; set; }
#nullable restore
#else
        public List<global::SevDesk.Api.V2.Models.Model_CreditNote_sendByWithRender_parameters> Parameters { get; set; }
#endif
        /// <summary>The thumbs property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Thumbs { get; set; }
#nullable restore
#else
        public UntypedNode Thumbs { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::SevDesk.Api.V2.Models.Model_CreditNote_sendByWithRender"/> and sets the default values.
        /// </summary>
        public Model_CreditNote_sendByWithRender()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::SevDesk.Api.V2.Models.Model_CreditNote_sendByWithRender"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::SevDesk.Api.V2.Models.Model_CreditNote_sendByWithRender CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::SevDesk.Api.V2.Models.Model_CreditNote_sendByWithRender();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "docId", n => { DocId = n.GetStringValue(); } },
                { "pages", n => { Pages = n.GetIntValue(); } },
                { "parameters", n => { Parameters = n.GetCollectionOfObjectValues<global::SevDesk.Api.V2.Models.Model_CreditNote_sendByWithRender_parameters>(global::SevDesk.Api.V2.Models.Model_CreditNote_sendByWithRender_parameters.CreateFromDiscriminatorValue)?.AsList(); } },
                { "thumbs", n => { Thumbs = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("docId", DocId);
            writer.WriteIntValue("pages", Pages);
            writer.WriteCollectionOfObjectValues<global::SevDesk.Api.V2.Models.Model_CreditNote_sendByWithRender_parameters>("parameters", Parameters);
            writer.WriteObjectValue<UntypedNode>("thumbs", Thumbs);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}