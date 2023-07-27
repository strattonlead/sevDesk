using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace SevDeskClient
{

    public class TagRelation : SevClientObject
    {
        [JsonProperty("objectName")]
        public override string ObjectName { get; set; } = "TagRelation";
        /// <summary>date the tag relation was created</summary>
        public System.DateTimeOffset? Create { get; set; }

        /// <summary>tag which is has a relation to another object</summary>
        [Newtonsoft.Json.JsonProperty("tag")]
        public Tag Tag { get; set; }

        /// <summary>object type to which the tag is related</summary>
        [JsonProperty("object"), JsonConverter(typeof(SevClientDataConverter))]
        public SevClientObject Object { get; set; }

        /// <summary>sevClient is the unique Id every customer has and is used in nearly all operations</summary>
        //[Newtonsoft.Json.JsonProperty("sevClient", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        //public object SevClient { get; set; }
        public TagRelation()
        {
        }
    }
}
