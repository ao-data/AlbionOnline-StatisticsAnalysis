using Newtonsoft.Json;

namespace StatisticsAnalysisTool.Models.ItemJson
{
    public class RepairKit
    {
        [JsonProperty("@repaircostfactor")]
        public string RepairCostFactor { get; set; }

        [JsonProperty("@maxtier")]
        public string MaxTier { get; set; }
    }
}