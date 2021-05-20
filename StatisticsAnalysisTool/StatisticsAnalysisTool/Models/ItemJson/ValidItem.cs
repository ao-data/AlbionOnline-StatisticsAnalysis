using Newtonsoft.Json;

namespace StatisticsAnalysisTool.Models.ItemJson
{
    public class ValidItem
    {
        [JsonProperty("@id")]
        public string Id { get; set; }
    }
}