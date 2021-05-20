using Newtonsoft.Json;

namespace StatisticsAnalysisTool.Models
{
    public class CraftSpell
    {
        [JsonProperty("@uniquename")]
        public string UniqueName { get; set; }

        [JsonProperty("@slots")]
        public string Slots { get; set; }

        [JsonProperty("@tag")]
        public string Tag { get; set; }
    }
}