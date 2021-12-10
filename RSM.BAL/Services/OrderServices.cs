using RSM.BAL.DomainModels.Models;
using RSM.BAL.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using Nancy.Json;
using RSM.BAL.Common;

namespace RSM.BAL.Services
{
    public class OrderServices : IOrder
    {
        private const string
           ReportsUrl = @"BSEStarMFAPI/BSEStarMFServices.DownloadReport",
           PlaceOrderUrl = @"BSEStarMFAPI/BSEStarMFServices.PlaceOrder",
           InvestorDetailsUrl = @"InvestorAPI/InvestorService.DownloadReport",
           UpdateDetailsUrl = @"BSEStarMFAPI/BSEStarMFServices.UpdateMandateRegistration",
            PaymemtStatusUrl = @"BSEStarMFAPI/BSEStarMFExchangeServices.GetExchangeOrderStatus",
           PaymentGateWayUrl = @"BSEStarMFAPI/BSEStarMFExchangeServices.BSEStarMFPaymentGatewayService";
        public BSEResponse PlaceMFOrder(MFOrderRequest request, string OrderDescription)
        {
            BSEResponse orderResponse;
            try
            {
                orderResponse = CommonFunctions.ExecuteRequest(PlaceOrderUrl, new JavaScriptSerializer().Serialize(request), OrderDescription, request.ClientCode);
            }
            catch (Exception)
            {
                throw;
            }
            return orderResponse;
        }
    }
}
