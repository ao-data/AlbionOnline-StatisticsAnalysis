using Newtonsoft.Json;

namespace StatisticsAnalysisTool.Models
{
    public class Buff
    {
        [JsonProperty(PropertyName = "type")] public string Type { get; set; }

        [JsonProperty(PropertyName = "value")] public double Value { get; set; }
    }
}