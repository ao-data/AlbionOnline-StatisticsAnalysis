﻿using Albion.Network;
using StatisticsAnalysisTool.Enumerations;
using StatisticsAnalysisTool.Network.Controller;
using StatisticsAnalysisTool.Network.Events;
using System.Threading.Tasks;

namespace StatisticsAnalysisTool.Network.Handler
{
    public class InventoryPutItemEventHandler : EventPacketHandler<InventoryPutItemEvent>
    {
        private readonly TrackingController _trackingController;

        public InventoryPutItemEventHandler(TrackingController trackingController) : base((int) EventCodes.InventoryPutItem)
        {
            _trackingController = trackingController;
        }

        protected override async Task OnActionAsync(InventoryPutItemEvent value)
        {
            //_trackingController.LootController.AddPutLoot(value.ObjectId, value.InteractGuid);
            await Task.CompletedTask;
        }
    }
}