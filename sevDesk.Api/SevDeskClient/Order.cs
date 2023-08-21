using Newtonsoft.Json;
using System;

namespace SevDeskClient
{
    public class Order : SevClientStreamObject
    {
        [JsonProperty("objectName")]
        public override string ObjectName { get; set; } = "Order";

        [JsonProperty("TaxType")]
        public string TaxType { get; set; }

        [JsonProperty("taxSet")]
        public string TaxSet { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("taxText")]
        public string TaxText { get; set; } = "zzgl. Umsatzsteuer 19%";

        [JsonProperty("taxRate")]
        public int TaxRate { get; set; }

        [JsonProperty("contactPerson")]
        public SevUser ContactPerson { get; set; }

        [JsonProperty("smallSettlement"), JsonConverter(typeof(StringToBoolConverter))]
        public bool SmallSettlement { get; set; }

        [JsonProperty("orderDate")]
        public DateTime OrderDate { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("showNet"), JsonConverter(typeof(StringToBoolConverter))]
        public bool ShowNet { get; set; }

        [JsonProperty("customerInternalNote")]
        public string CustomerInternalNote { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("sendType")]
        public string SendType { get; set; }

        [JsonProperty("origin")]
        public int Origin { get; set; }

        [JsonProperty("typeOrigin")]
        public string TypeOrigin { get; set; }

        [JsonProperty("orderNumber")]
        public string OrderNumber { get; set; }

        [JsonProperty("contact")]
        public Contact Contact { get; set; }

        [JsonProperty("header")]
        public string Header { get; set; }

        [JsonProperty("headText")]
        public string HeadText { get; set; }

        [JsonProperty("footText")]
        public string FootText { get; set; }

        [JsonProperty("paymentTerms")]
        public string PaymentTerms { get; set; }

        [JsonProperty("deliveryTerms")]
        public string DeliveryTerms { get; set; }

        [JsonProperty("sendDate")]
        public DateTime? SendDate { get; set; }

        [JsonProperty("orderType")]
        public string OrderType { get; set; }

        [JsonProperty("mapAll")]
        public bool MapAll => true;
    }
}
