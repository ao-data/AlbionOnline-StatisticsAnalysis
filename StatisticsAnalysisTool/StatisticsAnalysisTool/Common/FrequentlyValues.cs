using StatisticsAnalysisTool.Enumerations;
using System.Collections.Generic;

namespace StatisticsAnalysisTool.Common
{
    public static class FrequentlyValues
    {
        public static readonly Dictionary<ItemTier, string> ItemTiers = new Dictionary<ItemTier, string>
        {
            {ItemTier.Unknown, string.Empty},
            {ItemTier.T1, "Tier 1"},
            {ItemTier.T2, "Tier 2"},
            {ItemTier.T3, "Tier 3"},
            {ItemTier.T4, "Tier 4"},
            {ItemTier.T5, "Tier 5"},
            {ItemTier.T6, "Tier 6"},
            {ItemTier.T7, "Tier 7"},
            {ItemTier.T8, "Tier 8"}
        };

        public static readonly Dictionary<ItemLevel, string> ItemLevels = new Dictionary<ItemLevel, string>
        {
            {ItemLevel.Unknown, string.Empty},
            {ItemLevel.Level0, "0"},
            {ItemLevel.Level1, "1"},
            {ItemLevel.Level2, "2"},
            {ItemLevel.Level3, "3"}
        };

        public static readonly Dictionary<ItemQuality, int> ItemQualities = new Dictionary<ItemQuality, int>
        {
            {ItemQuality.Unknown, -1},
            {ItemQuality.Normal, 1},
            {ItemQuality.Good, 2},
            {ItemQuality.Outstanding, 3},
            {ItemQuality.Excellent, 4},
            {ItemQuality.Masterpiece, 5}
        };

        public static readonly Dictionary<GameLanguage, string> GameLanguages = new Dictionary<GameLanguage, string>
        {
            {GameLanguage.UnitedStates, "EN-US"},
            {GameLanguage.Germany, "DE-DE"},
            {GameLanguage.Russia, "RU-RU"},
            {GameLanguage.Poland, "PL-PL"},
            {GameLanguage.Brazil, "PT-BR"},
            {GameLanguage.France, "FR-FR"},
            {GameLanguage.Spain, "ES-ES"},
            {GameLanguage.Chinese, "ZH-CN"}
        };

        public static double GetBaseFame(ItemTier tier, ItemLevel level, Artifact artifact)
        {
            return (tier, level, artifact) switch
            {
                (ItemTier.T2, ItemLevel.Level0, Artifact.Unknown) => 1.5,

                (ItemTier.T3, ItemLevel.Level0, Artifact.Unknown) => 7.5,

                (ItemTier.T4, ItemLevel.Level0, Artifact.Unknown) => 22.5,
                (ItemTier.T4, ItemLevel.Level0, Artifact.Runes) => 24.75,
                (ItemTier.T4, ItemLevel.Level0, Artifact.Souls) => 27.00,
                (ItemTier.T4, ItemLevel.Level0, Artifact.Relics) => 29.25,
                (ItemTier.T4, ItemLevel.Level0, Artifact.Avalon) => 31.50,
                (ItemTier.T4, ItemLevel.Level1, Artifact.Unknown) => 37.50,
                (ItemTier.T4, ItemLevel.Level1, Artifact.Runes) => 41.25,
                (ItemTier.T4, ItemLevel.Level1, Artifact.Souls) => 45.00,
                (ItemTier.T4, ItemLevel.Level1, Artifact.Relics) => 0,
                (ItemTier.T4, ItemLevel.Level1, Artifact.Avalon) => 0,
                (ItemTier.T4, ItemLevel.Level2, Artifact.Unknown) => 52.5,
                (ItemTier.T4, ItemLevel.Level2, Artifact.Runes) => 57.75,
                (ItemTier.T4, ItemLevel.Level2, Artifact.Souls) => 63.00,
                (ItemTier.T4, ItemLevel.Level2, Artifact.Relics) => 68.25,
                (ItemTier.T4, ItemLevel.Level2, Artifact.Avalon) => 0,
                (ItemTier.T4, ItemLevel.Level3, Artifact.Unknown) => 67.50,
                (ItemTier.T4, ItemLevel.Level3, Artifact.Runes) => 0,
                (ItemTier.T4, ItemLevel.Level3, Artifact.Souls) => 0,
                (ItemTier.T4, ItemLevel.Level3, Artifact.Relics) => 0,
                (ItemTier.T4, ItemLevel.Level3, Artifact.Avalon) => 0,

                (ItemTier.T5, ItemLevel.Level0, Artifact.Unknown) => 90,
                (ItemTier.T5, ItemLevel.Level0, Artifact.Runes) => 0,
                (ItemTier.T5, ItemLevel.Level0, Artifact.Souls) => 0,
                (ItemTier.T5, ItemLevel.Level0, Artifact.Relics) => 0,
                (ItemTier.T5, ItemLevel.Level0, Artifact.Avalon) => 0,
                (ItemTier.T5, ItemLevel.Level1, Artifact.Unknown) => 172.50,
                (ItemTier.T5, ItemLevel.Level1, Artifact.Runes) => 0,
                (ItemTier.T5, ItemLevel.Level1, Artifact.Souls) => 0,
                (ItemTier.T5, ItemLevel.Level1, Artifact.Relics) => 0,
                (ItemTier.T5, ItemLevel.Level1, Artifact.Avalon) => 0,
                (ItemTier.T5, ItemLevel.Level2, Artifact.Unknown) => 255,
                (ItemTier.T5, ItemLevel.Level2, Artifact.Runes) => 0,
                (ItemTier.T5, ItemLevel.Level2, Artifact.Souls) => 0,
                (ItemTier.T5, ItemLevel.Level2, Artifact.Relics) => 0,
                (ItemTier.T5, ItemLevel.Level2, Artifact.Avalon) => 0,
                (ItemTier.T5, ItemLevel.Level3, Artifact.Unknown) => 337.50,
                (ItemTier.T5, ItemLevel.Level3, Artifact.Runes) => 0,
                (ItemTier.T5, ItemLevel.Level3, Artifact.Souls) => 0,
                (ItemTier.T5, ItemLevel.Level3, Artifact.Relics) => 0,
                (ItemTier.T5, ItemLevel.Level3, Artifact.Avalon) => 0,

                (ItemTier.T6, ItemLevel.Level0, Artifact.Unknown) => 270,
                (ItemTier.T6, ItemLevel.Level0, Artifact.Runes) => 0,
                (ItemTier.T6, ItemLevel.Level0, Artifact.Souls) => 0,
                (ItemTier.T6, ItemLevel.Level0, Artifact.Relics) => 0,
                (ItemTier.T6, ItemLevel.Level0, Artifact.Avalon) => 0,
                (ItemTier.T6, ItemLevel.Level1, Artifact.Unknown) => 266.25,
                (ItemTier.T6, ItemLevel.Level1, Artifact.Runes) => 585.75,
                (ItemTier.T6, ItemLevel.Level1, Artifact.Souls) => 0,
                (ItemTier.T6, ItemLevel.Level1, Artifact.Relics) => 0,
                (ItemTier.T6, ItemLevel.Level1, Artifact.Avalon) => 0,
                (ItemTier.T6, ItemLevel.Level2, Artifact.Unknown) => 420,
                (ItemTier.T6, ItemLevel.Level2, Artifact.Runes) => 0,
                (ItemTier.T6, ItemLevel.Level2, Artifact.Souls) => 954,
                (ItemTier.T6, ItemLevel.Level2, Artifact.Relics) => 0,
                (ItemTier.T6, ItemLevel.Level2, Artifact.Avalon) => 0,
                (ItemTier.T6, ItemLevel.Level3, Artifact.Unknown) => 0,
                (ItemTier.T6, ItemLevel.Level3, Artifact.Runes) => 0,
                (ItemTier.T6, ItemLevel.Level3, Artifact.Souls) => 0,
                (ItemTier.T6, ItemLevel.Level3, Artifact.Relics) => 0,
                (ItemTier.T6, ItemLevel.Level3, Artifact.Avalon) => 0,

                (ItemTier.T7, ItemLevel.Level0, Artifact.Unknown) => 645,
                (ItemTier.T7, ItemLevel.Level0, Artifact.Runes) => 0,
                (ItemTier.T7, ItemLevel.Level0, Artifact.Souls) => 0,
                (ItemTier.T7, ItemLevel.Level0, Artifact.Relics) => 0,
                (ItemTier.T7, ItemLevel.Level0, Artifact.Avalon) => 0,
                (ItemTier.T7, ItemLevel.Level1, Artifact.Unknown) => 1282.50,
                (ItemTier.T7, ItemLevel.Level1, Artifact.Runes) => 0,
                (ItemTier.T7, ItemLevel.Level1, Artifact.Souls) => 0,
                (ItemTier.T7, ItemLevel.Level1, Artifact.Relics) => 0,
                (ItemTier.T7, ItemLevel.Level1, Artifact.Avalon) => 0,
                (ItemTier.T7, ItemLevel.Level2, Artifact.Unknown) => 0,
                (ItemTier.T7, ItemLevel.Level2, Artifact.Runes) => 2112.00,
                (ItemTier.T7, ItemLevel.Level2, Artifact.Souls) => 0,
                (ItemTier.T7, ItemLevel.Level2, Artifact.Relics) => 0,
                (ItemTier.T7, ItemLevel.Level2, Artifact.Avalon) => 0,
                (ItemTier.T7, ItemLevel.Level3, Artifact.Unknown) => 0,
                (ItemTier.T7, ItemLevel.Level3, Artifact.Runes) => 0,
                (ItemTier.T7, ItemLevel.Level3, Artifact.Souls) => 0,
                (ItemTier.T7, ItemLevel.Level3, Artifact.Relics) => 0,
                (ItemTier.T7, ItemLevel.Level3, Artifact.Avalon) => 0,

                (ItemTier.T8, ItemLevel.Level0, Artifact.Unknown) => 1395,
                (ItemTier.T8, ItemLevel.Level0, Artifact.Runes) => 0,
                (ItemTier.T8, ItemLevel.Level0, Artifact.Souls) => 0,
                (ItemTier.T8, ItemLevel.Level0, Artifact.Relics) => 0,
                (ItemTier.T8, ItemLevel.Level0, Artifact.Avalon) => 0,
                (ItemTier.T8, ItemLevel.Level1, Artifact.Unknown) => 2782.50,
                (ItemTier.T8, ItemLevel.Level1, Artifact.Runes) => 0,
                (ItemTier.T8, ItemLevel.Level1, Artifact.Souls) => 0,
                (ItemTier.T8, ItemLevel.Level1, Artifact.Relics) => 0,
                (ItemTier.T8, ItemLevel.Level1, Artifact.Avalon) => 0,
                (ItemTier.T8, ItemLevel.Level2, Artifact.Unknown) => 0,
                (ItemTier.T8, ItemLevel.Level2, Artifact.Runes) => 0,
                (ItemTier.T8, ItemLevel.Level2, Artifact.Souls) => 0,
                (ItemTier.T8, ItemLevel.Level2, Artifact.Relics) => 0,
                (ItemTier.T8, ItemLevel.Level2, Artifact.Avalon) => 0,
                (ItemTier.T8, ItemLevel.Level3, Artifact.Unknown) => 0,
                (ItemTier.T8, ItemLevel.Level3, Artifact.Runes) => 0,
                (ItemTier.T8, ItemLevel.Level3, Artifact.Souls) => 0,
                (ItemTier.T8, ItemLevel.Level3, Artifact.Relics) => 0,
                (ItemTier.T8, ItemLevel.Level3, Artifact.Avalon) => 0,

                _ => -1
            };
        }
    }

    public enum ItemTier
    {
        Unknown = -1,
        T1 = 1,
        T2 = 2,
        T3 = 3,
        T4 = 4,
        T5 = 5,
        T6 = 6,
        T7 = 7,
        T8 = 8
    }

    public enum ItemLevel
    {
        Unknown = -1,
        Level0 = 0,
        Level1 = 1,
        Level2 = 2,
        Level3 = 3
    }

    public enum ItemQuality
    {
        Unknown = -1,
        Normal = 0,
        Good = 1,
        Outstanding = 2,
        Excellent = 3,
        Masterpiece = 4
    }
}