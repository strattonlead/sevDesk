using Newtonsoft.Json;
using System;

namespace SevDeskClient
{
    public class Category : SevClientObject
    {
        [JsonProperty("objectName")]
        public override string ObjectName { get; set; } = "Category";

        [JsonProperty("additionalInformation")]
        public object AdditionalInformation;

        [JsonProperty("create")]
        public DateTime? Create;

        [JsonProperty("update")]
        public DateTime? _Update;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("objectType")]
        public string ObjectType;

        [JsonProperty("priority")]
        public string Priority;

        [JsonProperty("code")]
        public string Code;

        [JsonProperty("color")]
        public string Color;

        [JsonProperty("postingAccount")]
        public object PostingAccount;

        [JsonProperty("type")]
        public string Type;

        [JsonProperty("translationCode")]
        public string TranslationCode;
    }

    public static class Categories
    {
        public static Category Supplier => new Category() { Id = "2" };
        public static Category Customer => new Category() { Id = "3" };
        public static Category Partner => new Category() { Id = "4" };
        public static Category ProspectCustomer => new Category() { Id = "28" };
    }
}
