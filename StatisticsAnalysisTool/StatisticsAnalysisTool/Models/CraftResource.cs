using Newtonsoft.Json;
using StatisticsAnalysisTool.Common;

namespace StatisticsAnalysisTool.Models
{
    public class CraftResource
    {
        [JsonProperty("@uniquename")]
        public string UniqueName { get; set; }

        [JsonProperty("@count")]
        public int Count { get; set; }

        [JsonProperty("@maxreturnamount")]
        public int MaxReturnAmount { get; set; }

        [JsonProperty("@enchantmentlevel")]
        public int EnchantmentLevel { get; set; }

        public string LocalizedName => ItemController.GetItemByUniqueName(UniqueName).LocalizedName;
    }
}