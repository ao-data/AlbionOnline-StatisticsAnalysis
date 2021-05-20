using Newtonsoft.Json;

namespace StatisticsAnalysisTool.Models.ItemJson
{
    public class MainItemJson
    {
        [JsonProperty("items")]
        public Items Items { get; set; }
    }
}