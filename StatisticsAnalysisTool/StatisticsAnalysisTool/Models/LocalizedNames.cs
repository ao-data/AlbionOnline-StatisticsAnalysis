using Newtonsoft.Json;

namespace StatisticsAnalysisTool.Models
{
    public class LocalizedNames
    {
        [JsonProperty(PropertyName = "EN-US")] public string EnUs { get; set; }

        [JsonProperty(PropertyName = "DE-DE")] public string DeDe { get; set; }

        [JsonProperty(PropertyName = "KO-KR")] public string KoKr { get; set; }

        [JsonProperty(PropertyName = "RU-RU")] public string RuRu { get; set; }

        [JsonProperty(PropertyName = "PL-PL")] public string PlPl { get; set; }

        [JsonProperty(PropertyName = "PT-BR")] public string PtBr { get; set; }

        [JsonProperty(PropertyName = "FR-FR")] public string FrFr { get; set; }

        [JsonProperty(PropertyName = "ES-ES")] public string EsEs { get; set; }

        [JsonProperty(PropertyName = "ZH-CN")] public string ZhCn { get; set; }
    }
}