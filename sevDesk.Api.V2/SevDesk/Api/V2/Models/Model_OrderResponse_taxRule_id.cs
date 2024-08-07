// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace SevDesk.Api.V2.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    /// <summary>**Use this in sevdesk-Update 2.0 (replaces taxType / taxSet).**Defines the vat-regulation.For &quot;Regelbesteuerung&quot; it can be one of:  - `1` - Umsatzsteuerpflichtige Umsätze - tax rates: 0.0, 7.0, 19.0 - replaces `&quot;taxType&quot;: &quot;default&quot;`  - `2` - Ausfuhren - allowedTaxRates: 0.0  - `3` - Innergemeinschaftliche Lieferungen - tax rates: 0.0, 7.0, 19.0 - replaces `&quot;taxType&quot;: &quot;eu&quot;`  - `4` - Steuerfreie Umsätze §4 UStG - tax rates: 0.0  - `5` - Reverse Charge gem. §13b UStG - tax rates: 0.0For small business owner (&quot;Kleinunternehmer&quot;) it can be:  - `11` - Steuer nicht erhoben nach §19UStG - tax rates: 0.0 - replaces `&quot;taxType&quot;: &quot;ss&quot;`</summary>
    public enum Model_OrderResponse_taxRule_id
    {
        [EnumMember(Value = "1")]
        #pragma warning disable CS1591
        One,
        #pragma warning restore CS1591
        [EnumMember(Value = "2")]
        #pragma warning disable CS1591
        Two,
        #pragma warning restore CS1591
        [EnumMember(Value = "3")]
        #pragma warning disable CS1591
        Three,
        #pragma warning restore CS1591
        [EnumMember(Value = "4")]
        #pragma warning disable CS1591
        Four,
        #pragma warning restore CS1591
        [EnumMember(Value = "5")]
        #pragma warning disable CS1591
        Five,
        #pragma warning restore CS1591
        [EnumMember(Value = "11")]
        #pragma warning disable CS1591
        OneOne,
        #pragma warning restore CS1591
    }
}
