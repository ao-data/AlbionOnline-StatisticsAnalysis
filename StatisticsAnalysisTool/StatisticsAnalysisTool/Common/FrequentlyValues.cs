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

        // BaseFame array = { Normal, Rune, Soul, Relic, Avalon }
        private static readonly double[] BaseFameT2 = { 1.5, -1, -1, -1, -1 };
        private static readonly double[] BaseFameT3 = { 7.5, -1, -1, -1, -1 };
        private static readonly double[] BaseFameT4 = { 22.5, 24.75, 27.00, 29.95, 31.50 };
        private static readonly double[] BaseFameT41 = { 37.5, 41.25, 45.00, 0, 0 };
        private static readonly double[] BaseFameT42 = { 52.5, 57.75, 63.00, 68.25, 0 };
        private static readonly double[] BaseFameT43 = { 67.5, 0, 0, 0, 0 };
        private static readonly double[] BaseFameT5 = { 90, 0, 0, 0, 0 };
        private static readonly double[] BaseFameT51 = { 172.50, 0, 0, 0, 0 };
        private static readonly double[] BaseFameT52 = { 255, 0, 0, 0, 0 };
        private static readonly double[] BaseFameT53 = { 377.50, 0, 0, 0, 0 };
        private static readonly double[] BaseFameT6 = { 270, 0, 0, 0, 0 };
        private static readonly double[] BaseFameT61 = { 266.25, 585.75, 0, 0, 0 };
        private static readonly double[] BaseFameT62 = { 420, 0, 954, 0, 0 };
        private static readonly double[] BaseFameT63 = { 0, 0, 0, 0, 0 };
        private static readonly double[] BaseFameT7 = { 645, 0, 0, 0, 0 };
        private static readonly double[] BaseFameT71 = { 1282.50, 0, 0, 0, 0 };
        private static readonly double[] BaseFameT72 = { 0, 2112, 0, 0, 0 };
        private static readonly double[] BaseFameT73 = { 0, 0, 0, 0, 0 };
        private static readonly double[] BaseFameT8 = { 1395, 0, 0, 0, 0 };
        private static readonly double[] BaseFameT81 = { 2782.5, 0, 0, 0, 0 };
        private static readonly double[] BaseFameT82 = { 0, 0, 0, 0, 0 };
        private static readonly double[] BaseFameT83 = { 0, 0, 0, 0, 0 };

        private static readonly double[][] BaseFameTier2Area = { BaseFameT2 };
        private static readonly double[][] BaseFameTier3Area = { BaseFameT3 };
        private static readonly double[][] BaseFameTier4Area = { BaseFameT4, BaseFameT41, BaseFameT42, BaseFameT43 };
        private static readonly double[][] BaseFameTier5Area = { BaseFameT5, BaseFameT51, BaseFameT52, BaseFameT53 };
        private static readonly double[][] BaseFameTier6Area = { BaseFameT6, BaseFameT61, BaseFameT62, BaseFameT63 };
        private static readonly double[][] BaseFameTier7Area = { BaseFameT7, BaseFameT71, BaseFameT72, BaseFameT73 };
        private static readonly double[][] BaseFameTier8Area = { BaseFameT8, BaseFameT81, BaseFameT82, BaseFameT83 };

        public static readonly double[][][] BaseFame = { BaseFameTier2Area, BaseFameTier3Area, BaseFameTier4Area, BaseFameTier5Area, BaseFameTier6Area, BaseFameTier7Area, BaseFameTier8Area };
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