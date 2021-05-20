using Newtonsoft.Json;

namespace StatisticsAnalysisTool.Models.ItemJson
{
    public class MountSkin
    {
        [JsonProperty("@uniquename")]
        public string UniqueName { get; set; }

        [JsonProperty("@uisprite")]
        public string UiSprite { get; set; }

        [JsonProperty("@prefabname")]
        public string PrefabName { get; set; }

        [JsonProperty("@prefabscaling")]
        public string PrefabScaling { get; set; }

        [JsonProperty("@despawneffect")]
        public string DespawnEffect { get; set; }

        [JsonProperty("@despawneffectscaling")]
        public string DespawnEffectScaling { get; set; }
        //public SocketPreset SocketPreset { get; set; }
        //public AudioInfo AudioInfo { get; set; }
        //public FootStepVfxPreset FootStepVfxPreset { get; set; }
    }
}