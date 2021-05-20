using Newtonsoft.Json;

namespace StatisticsAnalysisTool.Models.ItemJson
{
    public class JournalItem
    {
        [JsonProperty("@salvageable")]
        public string Salvageable { get; set; }

        [JsonProperty("@uniquename")]
        public string UniqueName { get; set; }

        [JsonProperty("@tier")]
        public string Tier { get; set; }

        [JsonProperty("@maxfame")]
        public string MaxFame { get; set; }

        [JsonProperty("@baselootamount")]
        public string BaseLootAmount { get; set; }

        [JsonProperty("@shopcategory")]
        public string ShopCategory { get; set; }

        [JsonProperty("@shopsubcategory1")]
        public string ShopSubCategory1 { get; set; }

        [JsonProperty("@weight")]
        public string Weight { get; set; }

        [JsonProperty("@unlockedtocraft")]
        public string UnlockedToCraft { get; set; }

        [JsonProperty("@craftfamegainfactor")]
        public string CraftFamegainFactor { get; set; }

        [JsonProperty("@fasttravelfactor")]
        public string FastTravelFactor { get; set; }

        [JsonProperty("craftingrequirements")]
        public CraftingRequirements CraftingRequirements { get; set; }

        [JsonProperty("famefillingmissions")]
        public FameFillingMissions FameFillingMissions { get; set; }

        [JsonProperty("lootlist")]
        public LootList LootList { get; set; }

        [JsonProperty("labourercontract")]
        public LabourerContract LabourerContract { get; set; }

        [JsonProperty("mountskin")]
        public MountSkin MountSkin { get; set; }

        [JsonProperty("crystalleagueitem")]
        public CrystalLeagueItem CrystalLeagueItem { get; set; }
    }
}