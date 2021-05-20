using Newtonsoft.Json;
using StatisticsAnalysisTool.Common;
using System.Collections.Generic;

namespace StatisticsAnalysisTool.Models.ItemJson
{
    public class LootList
    {
        [JsonProperty("loot")]
        [JsonConverter(typeof(SingleValueArrayConverter<Loot>))]
        public List<Loot> Loot { get; set; }
    }
}