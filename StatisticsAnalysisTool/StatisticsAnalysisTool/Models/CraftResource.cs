using Newtonsoft.Json;
using StatisticsAnalysisTool.Common;

namespace StatisticsAnalysisTool.Models
{
    public class CraftResource
    {
        [JsonProperty(PropertyName = "uniqueName")]
        public string UniqueName { get; set; }

        [JsonProperty(PropertyName = "count")]
        public int Count { get; set; }

        public string LocalizedName => ItemController.GetItemByUniqueName(UniqueName).LocalizedName;
    }
}