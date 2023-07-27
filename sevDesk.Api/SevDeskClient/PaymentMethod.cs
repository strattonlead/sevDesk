using Newtonsoft.Json;

namespace SevDeskClient
{
    public class PaymentMethod : SevClientObject
    {
        [JsonProperty("objectName")]
        public override string ObjectName { get; set; } = "PaymentMethod";
        public string create { get; set; }
        public string update { get; set; }
        public string name { get; set; }
        public string text { get; set; }

        public PaymentMethod() { }
    }
}
