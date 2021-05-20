using Newtonsoft.Json;

namespace StatisticsAnalysisTool.Models
{
    public class Enchantment
    {
        [JsonProperty("@enchantmentlevel")]
        public string EnchantmentLevel { get; set; }

        [JsonProperty("@itempower")]
        public string ItemPower { get; set; }

        [JsonProperty("@durability")]
        public string Durability { get; set; }

        [JsonProperty(PropertyName = "craftingRequirements")]
        public CraftingRequirements CraftingRequirements { get; set; }

        [JsonProperty(PropertyName = "upgraderequirements")]
        public UpgradeRequirements UpgradeRequirements { get; set; }
    }
}