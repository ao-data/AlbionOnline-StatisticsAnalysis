using Newtonsoft.Json;

namespace StatisticsAnalysisTool.Models.ItemJson
{
    public class ConsumableFromInventoryItem
    {
        [JsonProperty("@uniquename")]
        public string UniqueName { get; set; }

        [JsonProperty("@tradable")]
        public string Tradable { get; set; }

        [JsonProperty("@uisprite")]
        public string UiSprite { get; set; }

        [JsonProperty("@abilitypower")]
        public string AbilityPower { get; set; }

        [JsonProperty("@consumespell")]
        public string ConsumeSpell { get; set; }

        [JsonProperty("@shopcategory")]
        public string ShopCategory { get; set; }

        [JsonProperty("@shopsubcategory1")]
        public string ShopSubCategory1 { get; set; }

        [JsonProperty("@tier")]
        public string Tier { get; set; }

        [JsonProperty("@weight")]
        public string Weight { get; set; }

        [JsonProperty("@dummyitempower")]
        public string DummyItemPower { get; set; }

        [JsonProperty("@maxstacksize")]
        public string MaxStackSize { get; set; }

        [JsonProperty("@unlockedtocraft")]
        public string UnlockedToCraft { get; set; }

        [JsonProperty("@uicraftsoundstart")]
        public string UiCraftSoundStart { get; set; }

        [JsonProperty("@uicraftsoundfinish")]
        public string UiCraftSoundFinish { get; set; }
    }
}