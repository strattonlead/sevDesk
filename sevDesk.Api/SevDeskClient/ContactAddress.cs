using Newtonsoft.Json;

namespace SevDeskClient
{
    public class ContactAddress : SevClientObject
    {
        [JsonProperty("objectName")]
        public override string ObjectName { get; set; } = "ContactAddress";
        public string create { get; set; }
        public string update { get; set; }
        public Contact contact { get; set; }
        public string street { get; set; }
        public string zip { get; set; }
        public string city { get; set; }
        public StaticCountry country { get; set; }
        public Category category { get; set; }
        public string name { get; set; }
        public ContactAddress() { }
    }
}
