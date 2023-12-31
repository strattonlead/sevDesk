﻿using Newtonsoft.Json;
using System;

namespace SevDeskClient
{
    public class ContactCustomField : SevClientObject
    {

        [JsonProperty("objectName")]
        public override string ObjectName { get; set; } = "ContactCustomField";

        [JsonProperty("additionalInformation")]
        public object AdditionalInformation { get; set; }

        [JsonProperty("create")]
        public DateTime? Create { get; set; }

        [JsonProperty("update")]
        public DateTime? _Update { get; set; }

        [JsonProperty("contact")]
        public Contact Contact { get; set; }

        [JsonProperty("contactCustomFieldSetting")]
        public ContactCustomFieldSetting ContactCustomFieldSetting { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
