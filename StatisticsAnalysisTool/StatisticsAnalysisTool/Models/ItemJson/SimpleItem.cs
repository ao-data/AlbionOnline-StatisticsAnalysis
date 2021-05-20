using Newtonsoft.Json;

namespace StatisticsAnalysisTool.Models.ItemJson
{
    public class SimpleItem
    {
        [JsonProperty("@uniquename")]
        public string UniqueName { get; set; }

        [JsonProperty("@tier")]
        public string Tier { get; set; }

        [JsonProperty("@weight")]
        public string Weight { get; set; }

        [JsonProperty("@maxstacksize")]
        public string MaxStackSize { get; set; }

        [JsonProperty("@uisprite")]
        public string UiSprite { get; set; }

        [JsonProperty("@shopcategory")]
        public string ShopCategory { get; set; }

        [JsonProperty("@shopsubcategory1")]
        public string ShopSubCategory1 { get; set; }

        [JsonProperty("@unlockedtocraft")]
        public string UnlockedToCraft { get; set; }
    }
}