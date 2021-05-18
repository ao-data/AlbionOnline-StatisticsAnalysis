using Newtonsoft.Json;

namespace StatisticsAnalysisTool.Models
{
    public class DirectAttributeChange
    {
        [JsonProperty(PropertyName = "target")]
        public string Target { get; set; }

        [JsonProperty(PropertyName = "attribute")]
        public string Attribute { get; set; }

        [JsonProperty(PropertyName = "change")]
        public double Change { get; set; }

        [JsonProperty(PropertyName = "effectType")]
        public object EffectType { get; set; }

        [JsonProperty(PropertyName = "effectAreaRadius")]
        public object EffectAreaRadius { get; set; }
    }
}