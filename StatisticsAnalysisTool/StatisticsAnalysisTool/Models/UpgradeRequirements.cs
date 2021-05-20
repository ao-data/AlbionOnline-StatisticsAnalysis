using Newtonsoft.Json;

namespace StatisticsAnalysisTool.Models
{
    public class UpgradeRequirements
    {
        [JsonProperty(PropertyName = "upgraderesource")]
        public UpgradeResource UpgradeResource { get; set; }
    }
}