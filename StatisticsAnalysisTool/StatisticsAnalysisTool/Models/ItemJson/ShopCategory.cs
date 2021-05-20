using Newtonsoft.Json;
using System.Collections.Generic;

namespace StatisticsAnalysisTool.Models.ItemJson
{
    public class ShopCategory
    {
        [JsonProperty("@id")]
        public string Id { get; set; }

        [JsonProperty("@value")]
        public string Value { get; set; }
        public List<ShopSubCategory> ShopSubCategory { get; set; }
    }
}