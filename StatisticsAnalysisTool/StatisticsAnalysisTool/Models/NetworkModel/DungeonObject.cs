﻿using Newtonsoft.Json;
using StatisticsAnalysisTool.Common;
using StatisticsAnalysisTool.Enumerations;
using StatisticsAnalysisTool.Models.NetworkModel;
using System;
using System.Collections.Generic;
using System.Linq;
using ValueType = StatisticsAnalysisTool.Enumerations.ValueType;

namespace StatisticsAnalysisTool.Network.Notification
{
    public class DungeonObject
    {
        [JsonIgnore]
        public List<TimeCollectObject> DungeonRunTimes { get; } = new List<TimeCollectObject>();
        public TimeSpan TotalRunTime { get; set; }
        public List<Guid> GuidList { get; set; } = new List<Guid>();
        public DateTime EnterDungeonFirstTime { get; set; }
        public string MainMapIndex { get; set; }
        public List<DungeonEventObject> DungeonEventObjects { get; set; } = new List<DungeonEventObject>();
        public DungeonStatus Status { get; set; }
        public double Fame { get; set; }
        public double ReSpec { get; set; }
        public double Silver { get; set; }
        public double FactionCoins { get; set; }
        public double FactionFlags { get; set; }
        public string DiedName { get; set; }
        public string KilledBy { get; set; }
        public bool DiedInDungeon { get; set; }
        public Faction Faction { get; set; } = Faction.Unknown;
        public DungeonMode Mode { get; set; } = DungeonMode.Unknown;
        public CityFaction CityFaction { get; set; } = CityFaction.Unknown;

        [JsonIgnore]
        public string DungeonHash => $"{EnterDungeonFirstTime.Ticks}{string.Join(",", GuidList)}";
        
        private double? _lastReSpecValue;
        
        public void Add(double value, ValueType type, CityFaction cityFaction = CityFaction.Unknown)
        {
            switch (type)
            {
                case ValueType.Fame:
                    Fame += value;
                    return;
                case ValueType.ReSpec:
                    var internalReSpecValue = Utilities.AddValue(value, _lastReSpecValue, out _lastReSpecValue);
                    if (internalReSpecValue <= 0)
                    {
                        return;
                    }

                    ReSpec += internalReSpecValue;
                    return;
                case ValueType.Silver:
                    Silver += value;
                    return;
                case ValueType.FactionFame:
                    FactionFlags += value;
                    return;
                case ValueType.FactionPoints:
                    FactionCoins += value;
                    if (cityFaction != CityFaction.Unknown)
                    {
                        CityFaction = cityFaction;
                    }
                    return;
            }
        }
        
        public void AddStartTime(DateTime time)
        {
            if (DungeonRunTimes.Any(x => x.EndTime == null))
            {
                var dun = DungeonRunTimes.FirstOrDefault(x => x.EndTime == null);
                if (dun != null)
                {
                    dun.EndTime = time;
                    DungeonRunTimes.Add(new TimeCollectObject(time));
                }
            }
            else
            {
                DungeonRunTimes.Add(new TimeCollectObject(time));
            }

            SetCombatTimeSpan();
        }

        public void AddEndTime(DateTime time)
        {
            var dun = DungeonRunTimes.FirstOrDefault(x => x.EndTime == null);
            if (dun != null && dun.StartTime < time)
            {
                dun.EndTime = time;
                SetCombatTimeSpan();
            }
        }

        private void SetCombatTimeSpan()
        {
            foreach (var time in DungeonRunTimes.Where(x => x.EndTime != null).ToList())
            {
                TotalRunTime += time.TimeSpan;
                DungeonRunTimes.Remove(time);
            }
        }
    }
}