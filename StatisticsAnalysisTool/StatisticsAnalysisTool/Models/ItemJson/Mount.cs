using Newtonsoft.Json;
using System.Collections.Generic;

namespace StatisticsAnalysisTool.Models.ItemJson
{
    public class Mount
    {
        [JsonProperty("@uniquename")]
        public string UniqueName { get; set; }

        [JsonProperty("@mountcategory")]
        public string MountCategory { get; set; }

        [JsonProperty("@maxqualitylevel")]
        public string MaxQualityLevel { get; set; }

        [JsonProperty("@itempower")]
        public string ItemPower { get; set; }

        [JsonProperty("@abilitypower")]
        public string AbilityPower { get; set; }

        [JsonProperty("@slottype")]
        public string SlotType { get; set; }

        [JsonProperty("@shopcategory")]
        public string ShopCategory { get; set; }

        [JsonProperty("@shopsubcategory1")]
        public string ShopSubCategory1 { get; set; }

        [JsonProperty("@mountedbuff")]
        public string MountedBuff { get; set; }

        [JsonProperty("@halfmountedbuff")]
        public string HalfMountedBuff { get; set; }

        [JsonProperty("@tier")]
        public string Tier { get; set; }

        [JsonProperty("@weight")]
        public string Weight { get; set; }

        [JsonProperty("@activespellslots")]
        public string ActiveSpellSlots { get; set; }

        [JsonProperty("@passivespellslots")]
        public string PassiveSpellSlots { get; set; }

        [JsonProperty("@durability")]
        public string Durability { get; set; }

        [JsonProperty("@durabilityloss_attack")]
        public string DurabilityLossAttack { get; set; }

        [JsonProperty("@durabilityloss_spelluse")]
        public string DurabilityLossSpellUse { get; set; }

        [JsonProperty("@durabilityloss_receivedattack")]
        public string DurabilityLossReceivedAttack { get; set; }

        [JsonProperty("@durabilityloss_receivedspell")]
        public string DurabilityLossReceivedSpell { get; set; }

        [JsonProperty("@durabilityloss_receivedattack_mounted")]
        public string DurabilityLossReceivedAttackMounted { get; set; }

        [JsonProperty("@durabilityloss_receivedspell_mounted")]
        public string DurabilityLossReceivedSpellMounted { get; set; }

        [JsonProperty("@durabilityloss_mounting")]
        public string DurabilityLossMounting { get; set; }

        [JsonProperty("@unlockedtocraft")]
        public string UnlockedToCraft { get; set; }

        [JsonProperty("@unlockedtoequip")]
        public string UnlockedToEquip { get; set; }

        [JsonProperty("@mounttime")]
        public string MountTime { get; set; }

        [JsonProperty("@dismounttime")]
        public string DismountTime { get; set; }

        [JsonProperty("@mounthitpointsmax")]
        public string MountHitPointsMax { get; set; }

        [JsonProperty("@mounthitpointsregeneration")]
        public string MountHitPointsRegeneration { get; set; }

        [JsonProperty("@prefabname")]
        public string PrefabName { get; set; }

        [JsonProperty("@prefabscaling")]
        public string PrefabScaling { get; set; }

        [JsonProperty("@despawneffect")]
        public string DeSpawnEffect { get; set; }

        [JsonProperty("@despawneffectscaling")]
        public string DeSpawnEffectScaling { get; set; }

        [JsonProperty("@remountdistance")]
        public string RemountDistance { get; set; }

        [JsonProperty("@halfmountrange")]
        public string HalfMountRange { get; set; }

        [JsonProperty("@forceddismountcooldown")]
        public string ForcedDismountCooldown { get; set; }

        [JsonProperty("@forceddismountspellcooldown")]
        public string ForcedDismountSpellCooldown { get; set; }

        [JsonProperty("@fulldismountcooldown")]
        public string FullDismountCooldown { get; set; }

        [JsonProperty("@remounttime")]
        public string RemountTime { get; set; }

        [JsonProperty("@uicraftsoundstart")]
        public string UiCraftSoundStart { get; set; }

        [JsonProperty("@uicraftsoundfinish")]
        public string UiCraftSoundFinish { get; set; }

        [JsonProperty("@dismountbuff")]
        public string DismountBuff { get; set; }

        [JsonProperty("@forceddismountbuff")]
        public string ForcedDismountBuff { get; set; }

        [JsonProperty("@showinmarketplace")]
        public string ShowInMarketplace { get; set; }

        [JsonProperty("craftingrequirements")]
        public CraftingRequirements CraftingRequirements { get; set; }

       [JsonProperty("craftingspelllist")]
       public CraftingSpellList CraftingSpellList { get; set; }

        //public SocketPreset SocketPreset { get; set; }
        //public AudioInfo AudioInfo { get; set; }
        //public AssetVfxPreset AssetVfxPreset { get; set; }
        //public FootStepVfxPreset FootStepVfxPreset { get; set; }
    }
}