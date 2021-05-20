using Newtonsoft.Json;
using StatisticsAnalysisTool.Common;
using System.Collections.Generic;

namespace StatisticsAnalysisTool.Models.ItemJson
{
    public class FurnitureItem
    {
        [JsonProperty("@uniquename")]
        public string UniqueName { get; set; }

        [JsonProperty("@shopcategory")]
        public string ShopCategory { get; set; }

        [JsonProperty("@shopsubcategory1")]
        public string ShopSubCategory1 { get; set; }

        [JsonProperty("@tier")]
        public string Tier { get; set; }

        [JsonProperty("@durability")]
        public string Durability { get; set; }

        [JsonProperty("@durabilitylossperdayfactor")]
        public string DurabilityLossPerDayFactor { get; set; }

        [JsonProperty("@weight")]
        public string Weight { get; set; }

        [JsonProperty("@unlockedtocraft")]
        public string UnlockedToCraft { get; set; }

        [JsonProperty("@placeableindoors")]
        public string PlaceableInDoors { get; set; }

        [JsonProperty("@placeableoutdoors")]
        public string PlaceableOutDoors { get; set; }

        [JsonProperty("@placeableindungeons")]
        public string PlaceableInDungeons { get; set; }

        [JsonProperty("@placeableinexpeditions")]
        public string PlaceableInExpeditions { get; set; }

        [JsonProperty("@accessrightspreset")]
        public string AccessRightsPreset { get; set; }

        [JsonProperty("@uicraftsoundstart")]
        public string UiCraftSoundStart { get; set; }

        [JsonProperty("@uicraftsoundfinish")]
        public string UiCraftSoundFinish { get; set; }

        [JsonProperty("craftingrequirements")]
        [JsonConverter(typeof(SingleValueArrayConverter<CraftingRequirements>))]
        public List<CraftingRequirements> CraftingRequirements { get; set; }

        [JsonProperty("repairkit")]
        public RepairKit RepairKit { get; set; }
    }
}