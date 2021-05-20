using Newtonsoft.Json;

namespace StatisticsAnalysisTool.Models.ItemJson
{
    public class FarmableItem
    {
        [JsonProperty("@uniquename")]
        public string UniqueName { get; set; }

        [JsonProperty("@tier")]
        public int Tier { get; set; }

        [JsonProperty("@craftfamegainfactor")]
        public string CraftFameGainFactor { get; set; }

        [JsonProperty("@placefame")]
        public string PlaceFame { get; set; }

        [JsonProperty("@pickupable")]
        public string PickUpAble { get; set; }

        [JsonProperty("@destroyable")]
        public string Destroyable { get; set; }

        [JsonProperty("@unlockedtoplace")]
        public string UnlockedToPlace { get; set; }

        [JsonProperty("@maxstacksize")]
        public string MaxStackSize { get; set; }

        [JsonProperty("@shopcategory")]
        public string ShopCategory { get; set; }

        [JsonProperty("@shopsubcategory1")]
        public string ShopSubcategory1 { get; set; }

        [JsonProperty("@kind")]
        public string Kind { get; set; }

        [JsonProperty("@weight")]
        public string Weight { get; set; }

        [JsonProperty("@unlockedtocraft")]
        public string UnlockedToCraft { get; set; }

        [JsonProperty("@animationid")]
        public string AnimationId { get; set; }

        [JsonProperty("@activefarmfocuscost")]
        public string ActiveFarmFocusCost { get; set; }

        [JsonProperty("@activefarmmaxcycles")]
        public string ActiveFarmMaxCycles { get; set; }

        [JsonProperty("@activefarmactiondurationseconds")]
        public string ActiveFarmActionDurationSeconds { get; set; }

        [JsonProperty("@activefarmcyclelengthseconds")]
        public string ActiveFarmCycleLengthSeconds { get; set; }

        [JsonProperty("@activefarmbonus")]
        public string ActiveFarmBonus { get; set; }

        [JsonProperty("craftingrequirements")]
        public CraftingRequirements CraftingRequirements { get; set; }
        
        //public AudioInfo AudioInfo { get; set; }

        [JsonProperty("harvest")]
        public Harvest Harvest { get; set; }

        [JsonProperty("grownitem")]
        public GrownItem GrownItem { get; set; }

        [JsonProperty("consumption")]
        public Consumption Consumption { get; set; }
    }
}