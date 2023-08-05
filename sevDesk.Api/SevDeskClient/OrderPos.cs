using Newtonsoft.Json;

namespace SevDeskClient
{
    public class OrderPos : SevClientStreamObject
    {
        [JsonProperty("objectName")]
        public override string ObjectName { get; set; } = "OrderPos";

        [JsonProperty("taxRate")]
        public decimal TaxRate { get; set; }

        [JsonProperty("unity")]
        public Unity Unity { get; set; }

        [JsonProperty("quantity")]
        public decimal Quantity { get; set; }

        [JsonProperty("order")]
        public Order Order { get; set; }

        [JsonProperty("discount")]
        public decimal Discount { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("positionNumber")]
        public int PositionNumber { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("price")]
        public decimal Price { get; set; }

        [JsonProperty("part")]
        public Part Part { get; set; }

        [JsonProperty("mapAll")]
        public bool MapAll => true;
    }
}
