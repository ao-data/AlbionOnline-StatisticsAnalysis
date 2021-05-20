using Newtonsoft.Json;
using System.Collections.Generic;

namespace StatisticsAnalysisTool.Models
{
    public class Enchantments
    {
        [JsonProperty(PropertyName = "enchantment")]
        public List<Enchantment> EnchantmentsList { get; set; }
    }
}