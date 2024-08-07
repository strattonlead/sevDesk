// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace SevDesk.Api.V2.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    /// <summary>Defines the booking category, for more information see the section [Credit note booking categories](#tag/CreditNote/Credit-note-booking-categories)The booking category of the credit note.**Must be &lt;code&gt;UNDERACHIEVEMENT&lt;/code&gt; in sevdesk-Update 2.0.**</summary>
    public enum Model_creditNote_bookingCategory
    {
        [EnumMember(Value = "PROVISION")]
        #pragma warning disable CS1591
        PROVISION,
        #pragma warning restore CS1591
        [EnumMember(Value = "ROYALTY_ASSIGNED")]
        #pragma warning disable CS1591
        ROYALTY_ASSIGNED,
        #pragma warning restore CS1591
        [EnumMember(Value = "ROYALTY_UNASSIGNED")]
        #pragma warning disable CS1591
        ROYALTY_UNASSIGNED,
        #pragma warning restore CS1591
        [EnumMember(Value = "UNDERACHIEVEMENT")]
        #pragma warning disable CS1591
        UNDERACHIEVEMENT,
        #pragma warning restore CS1591
        [EnumMember(Value = "ACCOUNTING_TYPE")]
        #pragma warning disable CS1591
        ACCOUNTING_TYPE,
        #pragma warning restore CS1591
    }
}
