using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.Linq;

namespace StatisticsAnalysisTool.Models
{
    public class CraftingRequirements
    {
        [JsonProperty(PropertyName = "time")] 
        public double Time { get; set; }

        [JsonProperty(PropertyName = "silver")]
        public int Silver { get; set; }

        [JsonProperty(PropertyName = "craftingFocus")]
        public int CraftingFocus { get; set; }

        [JsonProperty(PropertyName = "craftResourceList")]
        public ObservableCollection<CraftResource> CraftResource { get; set; }

        [JsonIgnore]
        public int TotalAmountResources => CraftResource?.Sum(x => x?.Count) ?? 0;
    }
}