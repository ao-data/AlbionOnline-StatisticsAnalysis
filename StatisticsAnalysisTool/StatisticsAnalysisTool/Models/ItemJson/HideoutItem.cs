using Newtonsoft.Json;

namespace StatisticsAnalysisTool.Models.ItemJson
{
    public class HideoutItem
    {
        [JsonProperty("@uniquename")]
        public string UniqueName { get; set; }

        [JsonProperty("@itemvalue")]
        public string ItemValue { get; set; }

        [JsonProperty("@tier")]
        public string Tier { get; set; }

        [JsonProperty("@mindistance")]
        public string MinDistance { get; set; }

        [JsonProperty("@mindistanceintunnel")]
        public string MinDistanceInTunnel { get; set; }

        [JsonProperty("@placementduration")]
        public string PlacementDuration { get; set; }

        [JsonProperty("@primetimedurationminutes")]
        public string PrimeTimeDurationMinutes { get; set; }

        [JsonProperty("@maxstacksize")]
        public string MaxStackSize { get; set; }

        [JsonProperty("@weight")]
        public string Weight { get; set; }

        [JsonProperty("@unlockedtocraft")]
        public string UnlockedToCraft { get; set; }

        [JsonProperty("@shopcategory")]
        public string ShopCategory { get; set; }

        [JsonProperty("@shopsubcategory1")]
        public string ShopSubCategory1 { get; set; }

        [JsonProperty("@uicraftsoundstart")]
        public string UiCraftSoundStart { get; set; }

        [JsonProperty("@uicraftsoundfinish")]
        public string UiCraftSoundFinish { get; set; }

        [JsonProperty("craftingrequirements")]
        public CraftingRequirements CraftingRequirements { get; set; }
    }
}