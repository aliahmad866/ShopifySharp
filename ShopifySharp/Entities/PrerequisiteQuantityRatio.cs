using System;
using Newtonsoft.Json;

namespace ShopifySharp
{
    public class PrerequisiteQuantityRatio
    {
        [JsonProperty("prerequisite_quantity")]
        public long? PrerequisiteQuantity { get; set; }

        [JsonProperty("entitled_quantity")]
        public int? EntitledQuantity { get; set; }
    }
}
