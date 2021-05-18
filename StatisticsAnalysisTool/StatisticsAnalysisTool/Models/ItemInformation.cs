using Newtonsoft.Json;
using StatisticsAnalysisTool.Common;
using System;
using System.Net;
using Formatting = StatisticsAnalysisTool.Common.Formatting;

namespace StatisticsAnalysisTool.Models
{
    public class ItemInformation
    {
        [JsonProperty(PropertyName = "itemType")]
        public string ItemType { get; set; }

        [JsonProperty(PropertyName = "uniqueName")]
        public string UniqueName { get; set; }

        [JsonProperty(PropertyName = "uiSprite")]
        public string UiSprite { get; set; }

        [JsonProperty(PropertyName = "uiSpriteOverlay1")]
        public object UiSpriteOverlay1 { get; set; }

        [JsonProperty(PropertyName = "uiSpriteOverlay2")]
        public object UiSpriteOverlay2 { get; set; }

        [JsonProperty(PropertyName = "uiSpriteOverlay3")]
        public object UiSpriteOverlay3 { get; set; }

        [JsonProperty(PropertyName = "uiAtlas")]
        public object UiAtlas { get; set; }

        [JsonProperty(PropertyName = "showinmarketplace")]
        public bool ShowInMarketplace { get; set; }

        [JsonProperty(PropertyName = "level")] public int Level { get; set; }

        [JsonProperty(PropertyName = "tier")] public int Tier { get; set; }

        [JsonProperty(PropertyName = "enchantmentLevel")]
        public int EnchantmentLevel { get; set; }

        [JsonProperty(PropertyName = "categoryId")]
        public string CategoryId { get; set; }

        [JsonProperty(PropertyName = "categoryName")]
        public string CategoryName { get; set; }

        [JsonProperty(PropertyName = "revision")]
        public int Revision { get; set; }

        [JsonProperty(PropertyName = "enchantments")]
        public object Enchantments { get; set; }

        //[JsonProperty(PropertyName = "activeSlots")]
        //public ActiveSlots ActiveSlots { get; set; }
        //[JsonProperty(PropertyName = "passiveSlots")]
        //public PassiveSlots PassiveSlots { get; set; }
        [JsonProperty(PropertyName = "localizedNames")]
        public LocalizedNames LocalizedNames { get; set; }

        [JsonProperty(PropertyName = "localizedDescriptions")]
        public LocalizedDescriptions LocalizedDescriptions { get; set; }

        [JsonProperty(PropertyName = "slotType")]
        public string SlotType { get; set; }

        [JsonProperty("physicalAttackDamageBonus")]
        public double PhysicalAttackDamageBonus { get; set; }

        [JsonProperty("skinCount")] 
        public object SkinCount { get; set; }

        [JsonProperty("physicalArmor")] 
        public int PhysicalArmor { get; set; }

        [JsonProperty("magicResistance")] 
        public int MagicResistance { get; set; }

        [JsonProperty("magicAttackDamageBonus")]
        public object MagicAttackDamageBonus { get; set; }

        [JsonProperty("itemPowerProgressionType")]
        public string ItemPowerProgressionType { get; set; }

        [JsonProperty("craftingRequirements")] 
        public CraftingRequirements CraftingRequirements { get; set; }

        [JsonProperty(PropertyName = "unlockedToEquip")]
        public bool? UnlockedToEquip { get; set; }

        [JsonProperty(PropertyName = "mountHitPointsRegeneration")]
        public int? MountHitPointsRegeneration { get; set; }

        [JsonProperty(PropertyName = "prefabScaling")]
        public double? PrefabScaling { get; set; }

        [JsonProperty(PropertyName = "abilityPower")]
        public int? AbilityPower { get; set; }

        [JsonProperty(PropertyName = "attackDamage")]
        public int? AttackDamage { get; set; }

        [JsonProperty(PropertyName = "attackSpeed")]
        public double? AttackSpeed { get; set; }

        [JsonProperty(PropertyName = "attackRange")]
        public double? AttackRange { get; set; }

        [JsonProperty(PropertyName = "weight")]
        public double? Weight { get; set; }

        [JsonProperty(PropertyName = "activeSpellSlots")]
        public int? ActiveSpellSlots { get; set; }

        [JsonProperty(PropertyName = "passiveSpellSlots")]
        public int? PassiveSpellSlots { get; set; }

        [JsonProperty(PropertyName = "durability")]
        public int? Durability { get; set; }

        [JsonProperty(PropertyName = "durabilityLossAttack")]
        public int? DurabilityLossAttack { get; set; }

        [JsonProperty(PropertyName = "durabilityLossSpelluse")]
        public int? DurabilityLossSpellUse { get; set; }

        [JsonProperty(PropertyName = "durabilityLossReceivedattack")]
        public int? DurabilityLossReceivedAttack { get; set; }

        [JsonProperty(PropertyName = "durabilityLossReceivedspell")]
        public int? DurabilityLossReceivedSpell { get; set; }

        [JsonProperty(PropertyName = "hitpointsMax")]
        public int? HitPointsMax { get; set; }

        [JsonProperty(PropertyName = "itemPower")]
        public int? ItemPower { get; set; }

        [JsonProperty(PropertyName = "dismountTime")]
        public int? DismountTime { get; set; }

        [JsonProperty(PropertyName = "mountHitPointsMax")]
        public int? MountHitPointsMax { get; set; }

        [JsonProperty(PropertyName = "prefabName")]
        public string PrefabName { get; set; }

        [JsonProperty(PropertyName = "dismountedBuff")]
        public int? DismountedBuff { get; set; }

        [JsonProperty(PropertyName = "spriteName")]
        public string SpriteName { get; set; }

        [JsonProperty(PropertyName = "stackable")]
        public bool Stackable { get; set; }

        [JsonProperty(PropertyName = "equipable")]
        public bool Equipable { get; set; }

        [JsonProperty(PropertyName = "lastUpdate")]
        public DateTime LastUpdate { get; set; }

        [JsonIgnore] 
        public string LastFullItemInformationUpdate => Formatting.CurrentDateTimeFormat(LastUpdate) ?? string.Empty;

        public CategoryObject CategoryObject => CategoryController.GetCategory(CategoryId);
        public HttpStatusCode HttpStatus { get; set; }
    }
}