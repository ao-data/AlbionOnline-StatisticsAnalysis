﻿using Newtonsoft.Json;

namespace StatisticsAnalysisTool.Models.ItemJson
{
    public class CrystalLeagueItem
    {
        [JsonProperty("@uniquename")]
        public string UniqueName { get; set; }

        [JsonProperty("@matchlevel")]
        public string MatchLevel { get; set; }

        [JsonProperty("@seasoncategory")]
        public string SeasonCategory { get; set; }

        [JsonProperty("@uisprite")]
        public string UiSprite { get; set; }

        [JsonProperty("@shopcategory")]
        public string ShopCategory { get; set; }

        [JsonProperty("@shopsubcategory1")]
        public string ShopSubCategory1 { get; set; }

        [JsonProperty("@tier")]
        public string Tier { get; set; }

        [JsonProperty("@enchantmentlevel")]
        public string EnchantmentLevel { get; set; }

        [JsonProperty("@resourcetype")]
        public string ResourceType { get; set; }

        [JsonProperty("@weight")]
        public string Weight { get; set; }

        [JsonProperty("@maxstacksize")]
        public string MaxStackSize { get; set; }

        [JsonProperty("@namelocatag")]
        public string NameLocaTag { get; set; }

        [JsonProperty("@descriptionlocatag")]
        public string DescriptionLocaTag { get; set; }

        [JsonProperty("@descvariable0")]
        public string DescVariable0 { get; set; }

        [JsonProperty("@salvageable")]
        public string Salvageable { get; set; }

        [JsonProperty("@itemvalue")]
        public string ItemValue { get; set; }

        [JsonProperty("@tradable")]
        public string Tradable { get; set; }

        [JsonProperty("@unlockedtocraft")]
        public string UnlockedToCraft { get; set; }

        [JsonProperty("@canbestoredinbattlevault")]
        public string CanBeStoredInbBattleVault { get; set; }

        [JsonProperty("craftingrequirements")]
        public CraftingRequirements CraftingRequirements { get; set; }
    }
}