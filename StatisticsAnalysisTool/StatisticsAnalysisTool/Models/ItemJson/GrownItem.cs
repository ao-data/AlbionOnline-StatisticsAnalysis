using Newtonsoft.Json;

namespace StatisticsAnalysisTool.Models.ItemJson
{
    public class GrownItem
    {
        [JsonProperty("@uniquename")]
        public string UniqueName { get; set; }

        [JsonProperty("@growtime")]
        public string GrowTime { get; set; }

        [JsonProperty("@fame")]
        public string Fame { get; set; }

        [JsonProperty("offspring")]
        public OffSpring OffSpring { get; set; }
    }
}