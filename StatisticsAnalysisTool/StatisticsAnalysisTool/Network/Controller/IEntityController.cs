using StatisticsAnalysisTool.Common;
using StatisticsAnalysisTool.Enumerations;
using StatisticsAnalysisTool.Models;
using StatisticsAnalysisTool.Models.NetworkModel;
using StatisticsAnalysisTool.Network.Time;
using System;
using System.Collections.Generic;

namespace StatisticsAnalysisTool.Network.Controller
{
    public interface IEntityController
    {
        event Action<GameObject> OnAddEntity;

        void AddEntity(long objectId, Guid userGuid, string name, GameObjectType objectType, GameObjectSubType objectSubType);

        void RemoveAllEntities();

        KeyValuePair<Guid, PlayerGameObject>? GetEntity(long objectId);

        List<KeyValuePair<Guid, PlayerGameObject>> GetAllEntities(bool onlyInParty = false);

        bool IsEntityInParty(long objectId);

        KeyValuePair<Guid, PlayerGameObject>? GetLocalEntity();

        void AddToParty(Guid guid, string username);

        void RemoveFromParty(string username);

        void ResetPartyMember();

        void SetParty(Dictionary<Guid, string> party, bool resetPartyBefore = false);

        bool IsUserInParty(string name);

        bool IsUserInParty(long objectId);

        void SetCharacterEquipment(long objectId, CharacterEquipment equipment);

        void ResetTempCharacterEquipment();

        void AddEquipmentItem(EquipmentItem item);

        void AddSpellEffect(SpellEffect spell);

        void DetectUsedWeapon();

        void ResetEntitiesDamageStartTime();

        void ResetEntitiesDamageTimes();

        void ResetEntitiesDamage();

        void HealthUpdate(
            long objectId,
            GameTimeStamp TimeStamp,
            double HealthChange,
            double NewHealthValue,
            EffectType EffectType,
            EffectOrigin EffectOrigin,
            long CauserId,
            int CausingSpellType
        );

        event Action<long, GameTimeStamp, double, double, EffectType, EffectOrigin, long, int> OnHealthUpdate;

        FixPoint GetLastLocalEntityClusterTax(FixPoint yieldPreClusterTax);

        void SetLastLocalEntityClusterTax(FixPoint yieldPreTax, FixPoint clusterTax);

        void SetLastLocalEntityGuildTax(FixPoint yieldPreTax, FixPoint guildTax);

        FixPoint GetLastLocalEntityGuildTax(FixPoint yieldPreTax);
    }
}