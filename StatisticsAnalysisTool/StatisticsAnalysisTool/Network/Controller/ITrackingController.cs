using StatisticsAnalysisTool.Enumerations;
using StatisticsAnalysisTool.GameData;
using StatisticsAnalysisTool.Models;
using StatisticsAnalysisTool.Network.Notification;
using StatisticsAnalysisTool.Network.Time;
using System;

namespace StatisticsAnalysisTool.Network.Controller
{
    public interface ITrackingController
    {
        CombatController CombatController { get; }

        DungeonController DungeonController { get; }

        EntityController EntityController { get; }

        CountUpTimer CountUpTimer { get; }

        event Action<ClusterInfo> OnChangeCluster;

        void RegisterEvents();

        void UnregisterEvents();

        void DamageMeterUpdate(long objectId, GameTimeStamp timeStamp, double healthChange, double newHealthValue, EffectType effectType, EffectOrigin effectOrigin, long causerId, int causingSpellType);

        bool IsMainWindowNull();

        ClusterInfo CurrentCluster { get; }

        void SetNewCluster(MapType mapType, Guid? mapGuid, string clusterIndex, string mainClusterIndex);

        void AddNotification(TrackingNotification item);

        void RemovesUnnecessaryNotifications();
    }
}