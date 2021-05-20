using Newtonsoft.Json;
using System.Collections.Generic;

namespace StatisticsAnalysisTool.Models.ItemJson
{
    public class ShopCategories
    {
        [JsonProperty("shopcategory")]
        public List<ShopCategory> ShopCategory { get; set; }
    }
}