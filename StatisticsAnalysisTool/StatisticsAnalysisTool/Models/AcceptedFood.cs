using Newtonsoft.Json;

namespace StatisticsAnalysisTool.Models
{
    public class AcceptedFood
    {
        [JsonProperty("@foodcategory")]
        public string FoodCategory { get; set; }
    }
}