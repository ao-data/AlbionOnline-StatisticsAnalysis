using System.Collections.Generic;
using Newtonsoft.Json;

namespace StatisticsAnalysisTool.Models
{
    public class Enchantments
    {
        [JsonProperty(PropertyName = "enchantmentLevel")]
        public List<Enchantment> EnchantmentsList { get; set; }
    }
}