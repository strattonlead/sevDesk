// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace SevDesk.Api.V2.CheckAccountTransaction.Item.Enshrine
{
    [Obsolete("This class is obsolete. Use EnshrinePutResponse instead.")]
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    #pragma warning disable CS1591
    public partial class EnshrineResponse : global::SevDesk.Api.V2.CheckAccountTransaction.Item.Enshrine.EnshrinePutResponse, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::SevDesk.Api.V2.CheckAccountTransaction.Item.Enshrine.EnshrineResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::SevDesk.Api.V2.CheckAccountTransaction.Item.Enshrine.EnshrineResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::SevDesk.Api.V2.CheckAccountTransaction.Item.Enshrine.EnshrineResponse();
        }
    }
}
