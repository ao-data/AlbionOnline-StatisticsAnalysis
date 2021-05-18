using Newtonsoft.Json;

namespace StatisticsAnalysisTool.Models
{
    public class Channeling
    {
        [JsonProperty(PropertyName = "channelingAnimation")]
        public string ChannelingAnimation { get; set; }

        [JsonProperty(PropertyName = "initialEffectInterval")]
        public double InitialEffectInterval { get; set; }

        [JsonProperty(PropertyName = "effectCount")]
        public int EffectCount { get; set; }

        [JsonProperty(PropertyName = "effectInterval")]
        public double EffectInterval { get; set; }

        [JsonProperty(PropertyName = "energyUsage")]
        public double EnergyUsage { get; set; }

        [JsonProperty(PropertyName = "disruptionFactor")]
        public double DisruptionFactor { get; set; }

        [JsonProperty(PropertyName = "directAttributeChange")]
        public DirectAttributeChange DirectAttributeChange { get; set; }

        [JsonProperty(PropertyName = "buffOverTime")]
        public object BuffOverTime { get; set; }

        [JsonProperty(PropertyName = "damageShield")]
        public object DamageShield { get; set; }
    }
}