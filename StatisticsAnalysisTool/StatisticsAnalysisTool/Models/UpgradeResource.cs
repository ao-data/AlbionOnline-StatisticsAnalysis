using Newtonsoft.Json;

namespace StatisticsAnalysisTool.Models
{
    public class UpgradeResource
    {
        [JsonProperty("@uniquename")]
        public string UniqueName { get; set; }

        [JsonProperty("@count")]
        public string Count { get; set; }
    }
}