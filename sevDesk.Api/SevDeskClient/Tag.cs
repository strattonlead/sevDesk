using Newtonsoft.Json;

namespace SevDeskClient
{
    public class Tag : SevClientObject
    {
        [JsonProperty("objectName")]
        public override string ObjectName { get; set; } = "Tag";
        public string create { get; set; }
        public string name { get; set; }
        public string objectType { get; set; }
        public string color { get; set; }

        public Tag() { }
    }
}
