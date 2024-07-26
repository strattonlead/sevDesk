// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace SevDesk.Api.V2.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    /// <summary>**Use this in sevdesk-Update 1.0 (instead of taxRule).**Tax type of the invoice.There are four tax types:1. default - Umsatzsteuer ausweisen2. eu - Steuerfreie innergemeinschaftliche Lieferung (Europäische Union)3. noteu - Steuerschuldnerschaft des Leistungsempfängers (außerhalb EU, z. B. Schweiz)4. custom - Using custom tax set5. ss - Not subject to VAT according to §19 1 UStGTax rates are heavily connected to the tax type used.</summary>
    public enum Model_InvoiceResponse_taxType
    {
        [EnumMember(Value = "default")]
        #pragma warning disable CS1591
        Default,
        #pragma warning restore CS1591
        [EnumMember(Value = "eu")]
        #pragma warning disable CS1591
        Eu,
        #pragma warning restore CS1591
        [EnumMember(Value = "noteu")]
        #pragma warning disable CS1591
        Noteu,
        #pragma warning restore CS1591
        [EnumMember(Value = "custom")]
        #pragma warning disable CS1591
        Custom,
        #pragma warning restore CS1591
    }
}
