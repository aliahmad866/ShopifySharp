using System;
using Newtonsoft.Json;

namespace ShopifySharp
{
    public class PrerequisiteAmountModel
    {
        [JsonProperty("prerequisite_amount")]
        public decimal? PrerequisiteAmount { get; set; }
    }
}
