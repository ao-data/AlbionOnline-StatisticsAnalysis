using Newtonsoft.Json;
using System.Collections.Generic;

namespace StatisticsAnalysisTool.Models.ItemJson
{
    public class GatherFame
    {
        [JsonProperty("@mintier")]
        public string Mintier { get; set; }

        [JsonProperty("@value")]
        public string Value { get; set; }

        [JsonProperty("validitem")]
        public List<ValidItem> ValidItem { get; set; }
    }
}