using Newtonsoft.Json;
using System;

namespace SevDeskClient
{
    public class InvoicePos : SevClientObject
    {
        [JsonProperty("objectName")]
        public override string ObjectName { get; set; } = "InvoicePos";
        public string create { get; set; }
        public string update { get; set; }
        public Invoice invoice { get; set; }
        public Part part { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; } = 1;

        [JsonProperty("price")]
        public decimal Price { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
        public string priority { get; set; } = "0";
        public Unity unity { get; set; } = new Unity();

        [JsonProperty("positionNumber")]
        public int PositionNumber { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("discount")]
        public int Discount { get; set; }

        [JsonProperty("taxRate")]
        public int TaxRate { get; set; } = DateTime.Now > new DateTime(2020, 7, 1) & DateTime.Now < new DateTime(2020, 12, 31) ? 16 : 19;
        public string temporary { get; set; }
        public string sumNet { get; set; }
        public string sumGross { get; set; }
        public string sumDiscount { get; set; }
        public string sumTax { get; set; }
        public string sumNetAccounting { get; set; }
        public string sumTaxAccounting { get; set; }
        public string sumGrossAccounting { get; set; }

        [JsonProperty("priceNet")]
        public decimal PriceNet { get; set; }

        [JsonProperty("priceGross")]
        public decimal PriceGross { get; set; }

        [JsonProperty("priceTax")]
        public decimal PriceTax { get; set; }
        public string sumNetForeignCurrency { get; set; }
        public string sumTaxForeignCurrency { get; set; }
        public string sumGrossForeignCurrency { get; set; }
        public string sumDiscountForeignCurrency { get; set; }
        public string createNextPart { get; set; }

        [JsonProperty("mapAll")]
        public bool MapAll => true;

        public InvoicePos() { }

    }
}
