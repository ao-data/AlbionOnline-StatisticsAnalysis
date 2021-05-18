using Newtonsoft.Json;

namespace StatisticsAnalysisTool.Models
{
    public class BuffOverTime
    {
        [JsonProperty(PropertyName = "target")]
        public string Target { get; set; }

        [JsonProperty(PropertyName = "type")] public string Type { get; set; }

        [JsonProperty(PropertyName = "time")] public double Time { get; set; }

        [JsonProperty(PropertyName = "value")] public double Value { get; set; }

        [JsonProperty(PropertyName = "effectAreaRadius")]
        public object EffectAreaRadius { get; set; }
    }
}