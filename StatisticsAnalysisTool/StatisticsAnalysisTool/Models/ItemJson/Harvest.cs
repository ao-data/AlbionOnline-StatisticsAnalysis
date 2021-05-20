using Newtonsoft.Json;

namespace StatisticsAnalysisTool.Models.ItemJson
{
    public class Harvest
    {
        [JsonProperty("@growtime")]
        public string GrowTime { get; set; }

        [JsonProperty("@lootlist")]
        public string LootList { get; set; }

        [JsonProperty("@lootchance")]
        public string LootChance { get; set; }

        [JsonProperty("@fame")]
        public string Fame { get; set; }

        [JsonProperty("Seed")]
        public Seed Seed { get; set; }
    }
}