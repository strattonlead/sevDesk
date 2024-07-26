// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace SevDesk.Api.V2.Models
{
    /// <summary>
    /// **Use this in sevdesk-Update 2.0 (replaces taxType / taxSet).**
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class Model_Invoice_taxRule : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>**Use this in sevdesk-Update 2.0 (replaces taxType / taxSet).**Defines the vat-regulation.For &quot;Regelbesteuerung&quot; it can be one of:  - `1` - Umsatzsteuerpflichtige Umsätze - tax rates: 0.0, 7.0, 19.0 - replaces `&quot;taxType&quot;: &quot;default&quot;`  - `2` - Ausfuhren - allowedTaxRates: 0.0  - `3` - Innergemeinschaftliche Lieferungen - tax rates: 0.0, 7.0, 19.0 - replaces `&quot;taxType&quot;: &quot;eu&quot;`  - `4` - Steuerfreie Umsätze §4 UStG - tax rates: 0.0  - `5` - Reverse Charge gem. §13b UStG - tax rates: 0.0For small business owner (&quot;Kleinunternehmer&quot;) it can be:  - `11` - Steuer nicht erhoben nach §19UStG - tax rates: 0.0 - replaces `&quot;taxType&quot;: &quot;ss&quot;`</summary>
        public global::SevDesk.Api.V2.Models.Model_Invoice_taxRule_id? Id { get; set; }
        /// <summary>Name of the object. Must always be TaxRule`</summary>
        public global::SevDesk.Api.V2.Models.Model_Invoice_taxRule_objectName? ObjectName { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::SevDesk.Api.V2.Models.Model_Invoice_taxRule"/> and sets the default values.
        /// </summary>
        public Model_Invoice_taxRule()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::SevDesk.Api.V2.Models.Model_Invoice_taxRule"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::SevDesk.Api.V2.Models.Model_Invoice_taxRule CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::SevDesk.Api.V2.Models.Model_Invoice_taxRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "id", n => { Id = n.GetEnumValue<global::SevDesk.Api.V2.Models.Model_Invoice_taxRule_id>(); } },
                { "objectName", n => { ObjectName = n.GetEnumValue<global::SevDesk.Api.V2.Models.Model_Invoice_taxRule_objectName>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::SevDesk.Api.V2.Models.Model_Invoice_taxRule_id>("id", Id);
            writer.WriteEnumValue<global::SevDesk.Api.V2.Models.Model_Invoice_taxRule_objectName>("objectName", ObjectName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
