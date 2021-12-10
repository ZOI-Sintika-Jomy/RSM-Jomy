using RSM.BAL.DomainModels.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RSM.BAL.Services.Interface
{
    public interface IOrder
    {
        BSEResponse PlaceMFOrder(MFOrderRequest request, string OrderDescription);
    }
}
