using System;
using Newtonsoft.Json;

namespace ShopifySharp
{
    public class PrerequisiteValueQuantityRange
    {
        [JsonProperty("less_than_or_equal_to")]
        public long? LessThanOrEqualTo { get; set; }

        [JsonProperty("greater_than_or_equal_to")]
        public long? GreaterThanOrEqualTo { get; set; }
    }
}
