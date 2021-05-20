using Newtonsoft.Json;

namespace StatisticsAnalysisTool.Models.ItemJson
{
    public class Seed
    {
        [JsonProperty("@chance")]
        public string Chance { get; set; }

        [JsonProperty("@amount")]
        public string Amount { get; set; }
    }
}