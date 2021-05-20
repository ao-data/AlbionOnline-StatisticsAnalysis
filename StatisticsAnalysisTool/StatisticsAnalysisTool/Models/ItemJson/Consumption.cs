using Newtonsoft.Json;

namespace StatisticsAnalysisTool.Models.ItemJson
{
    public class Consumption
    {
        [JsonProperty("food")]
        public Food Food { get; set; }
    }
}