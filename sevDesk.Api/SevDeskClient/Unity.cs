using Newtonsoft.Json;

namespace SevDeskClient
{
    public class Unity : SevClientObject
    {
        [JsonProperty("id")]
        public override string Id { get; set; } = "1";

        [JsonProperty("objectName")]
        public override string ObjectName { get; set; } = "Unity";
        public string create { get; set; }
        public string name { get; set; }
        public string translationCode { get; set; }
        public string unitySystem { get; set; }

        public Unity() { }

    }
}
