using Newtonsoft.Json;

namespace StatisticsAnalysisTool.Models.ItemJson
{
    public class FameFillingMissions
    {
        [JsonProperty("gatherfame")]
        public GatherFame GatherFame { get; set; }
    }
}