using Newtonsoft.Json;

namespace SevDeskClient
{
    public class StaticCountry : SevClientObject
    {
        [JsonProperty("id")]
        public override string Id { get; set; } = "1";

        [JsonProperty("objectName")]
        public override string ObjectName { get; set; } = "StaticCountry";

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nameEn")]
        public string NameEn { get; set; }

        [JsonProperty("translationCode")]
        public string TranslationCode { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }
    }
}
