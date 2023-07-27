using Newtonsoft.Json;

namespace SevDeskClient
{

    public abstract class SevClientObject
    {
        [JsonProperty("id")]
        public virtual string Id { get; set; }

        [JsonProperty("objectName")]
        public virtual string ObjectName { get; set; }
    }

    public abstract class SevClientStreamObject : SevClientObject { }
}
