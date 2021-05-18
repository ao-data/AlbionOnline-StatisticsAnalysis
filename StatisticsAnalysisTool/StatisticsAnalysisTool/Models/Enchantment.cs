using Newtonsoft.Json;

namespace StatisticsAnalysisTool.Models
{
    public class Enchantment
    {
        [JsonProperty(PropertyName = "enchantmentLevel")]
        public int EnchantmentLevel { get; set; }

        [JsonProperty(PropertyName = "itemPower")]
        public int ItemPower { get; set; }

        [JsonProperty(PropertyName = "durability")]
        public int Durability { get; set; }

        [JsonProperty(PropertyName = "craftingRequirements")]
        public CraftingRequirements CraftingRequirements { get; set; }
    }
}