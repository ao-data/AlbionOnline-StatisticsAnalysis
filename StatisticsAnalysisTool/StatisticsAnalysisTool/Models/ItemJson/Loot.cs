using Newtonsoft.Json;

namespace StatisticsAnalysisTool.Models.ItemJson
{
    public class Loot
    {
        [JsonProperty("@itemname")]
        public string ItemName { get; set; }

        [JsonProperty("@itemamount")]
        public string ItemAmount { get; set; }

        [JsonProperty("@weight")]
        public string Weight { get; set; }

        [JsonProperty("@labourerfame")]
        public string LabourerFame { get; set; }
    }
}