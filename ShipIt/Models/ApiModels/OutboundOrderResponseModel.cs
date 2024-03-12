﻿namespace ShipIt.Models.ApiModels
{
    public class OutboundOrderResponse
    {
        public required int NumberOfTrucks {get; set;}

        public OutboundOrderResponse(int numberOfTrucks)
        {
            NumberOfTrucks = numberOfTrucks;
        }
    }
}
