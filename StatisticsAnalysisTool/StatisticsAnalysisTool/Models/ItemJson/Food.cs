using Newtonsoft.Json;

namespace StatisticsAnalysisTool.Models.ItemJson
{
    public class Food
    {
        [JsonProperty("@nutritionmax")]
        public string NutritionMax { get; set; }

        [JsonProperty("@secondspernutrition")]
        public string SecondsPerNutrition { get; set; }

        [JsonProperty("acceptedfood")]
        public AcceptedFood AcceptedFood { get; set; }
    }
}