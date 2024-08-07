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
    public partial class Model_TagCreateResponse_object : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Id of the invoice/order/voucher/creditNote</summary>
        public int? Id { get; set; }
        /// <summary>Model name</summary>
        public global::SevDesk.Api.V2.Models.Model_TagCreateResponse_object_objectName? ObjectName { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::SevDesk.Api.V2.Models.Model_TagCreateResponse_object"/> and sets the default values.
        /// </summary>
        public Model_TagCreateResponse_object()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::SevDesk.Api.V2.Models.Model_TagCreateResponse_object"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::SevDesk.Api.V2.Models.Model_TagCreateResponse_object CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::SevDesk.Api.V2.Models.Model_TagCreateResponse_object();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "id", n => { Id = n.GetIntValue(); } },
                { "objectName", n => { ObjectName = n.GetEnumValue<global::SevDesk.Api.V2.Models.Model_TagCreateResponse_object_objectName>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("id", Id);
            writer.WriteEnumValue<global::SevDesk.Api.V2.Models.Model_TagCreateResponse_object_objectName>("objectName", ObjectName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
