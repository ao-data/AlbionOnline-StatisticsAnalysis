using Newtonsoft.Json;
using StatisticsAnalysisTool.Common;
using System.Collections.Generic;

namespace StatisticsAnalysisTool.Models
{
    public class CraftingSpellList
    {
        [JsonProperty(PropertyName = "craftspell")]
        [JsonConverter(typeof(SingleValueArrayConverter<CraftSpell>))]
        public List<CraftSpell> CraftSpell { get; set; }
    }
}