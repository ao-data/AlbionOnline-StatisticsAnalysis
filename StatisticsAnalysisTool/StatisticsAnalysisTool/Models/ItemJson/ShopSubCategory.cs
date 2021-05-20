using Newtonsoft.Json;

namespace StatisticsAnalysisTool.Models.ItemJson
{
    public class ShopSubCategory
    {
        [JsonProperty("@id")]
        public string Id { get; set; }

        [JsonProperty("@value")]
        public string Value { get; set; }
    }
}