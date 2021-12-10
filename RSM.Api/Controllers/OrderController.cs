using eKYC.UI.Filters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nancy.Json;
using RSM.BAL.Common;
using RSM.BAL.DomainModels.Models;
using RSM.BAL.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrder _order;
        public OrderController(IOrder order)
        {
            _order = order;
        }
        #region PlaceFreshLumpsumOrder
        /// <param name="token"></param>
        /// <param name="cliencode"></param>
        /// <param name="txntype"></param>
        /// <param name="physical"></param>
        /// <param name="folionumber"></param>
        /// <param name="amount"></param>
        /// <param name="reinvestmentflag"></param>
        /// <param name="sessionid"></param>
        /// <param name="mfimfd"></param>
        /// <param name="remarks"></param>
        /// <returns></returns>
        [HttpGet]
        [UserAuthenticationFilter]
        public string[] PlaceFreshLumpsumOrder(int token, string cliencode, string txntype, string physical, string folionumber, double amount, string reinvestmentflag, string sessionid, string mfimfd, string remarks)
        {
            List<string> result = new List<string>();
            BSEResponse orderResponse = new BSEResponse();
            List<ClientHolding> lstHoldings = new List<ClientHolding>();
            try
            {
                cliencode = CommonFunctions.Decrypt(cliencode);
                sessionid = CommonFunctions.Decrypt(sessionid);
                ///
                MFOrderRequest orderRequest = new MFOrderRequest
                {
                    Token = token,
                    TxnType = txntype,
                    Amount = amount,
                    ReinvestmentFlag = reinvestmentflag,
                    PhysicalFlag = physical,
                    FolioNo = folionumber,
                    ClientCode = cliencode,
                    RequestedBy = cliencode,
                    SessionID = sessionid,
                    EUINFlag = "Y",
                    EUINNumber = "E091038",
                    OrderSource = "Website",
                    //DPC = physical == "D" ? "Y" : "N",
                    //change for DPC check always send Y  by chetan on 20180921
                    DPC = "Y",
                    //
                    IsSpread = "N",
                    ValidateMargin = "Y",
                    // MFIMFD = "MFI",
                    MFIMFD = mfimfd,
                    OrderType = "FRESH",
                    TXNID = "0",
                    CloseAccountFlag = "N",
                    BrokerRefNo = "|||NETBANKING||", //added for fetching payment status
                    ModelPortFolioName = string.IsNullOrEmpty(remarks) ? string.Empty : remarks
                };
                orderResponse = _order.PlaceMFOrder(orderRequest, (txntype == "AP" ? "Additional" : "Fresh") + " Purchase Order");
                if (orderResponse == null)
                {
                    orderResponse.ErrorCode = 10000;
                    orderResponse.ErrorMessage = "Order cannot be placed";
                }
            }
            catch (Exception ex)
            {
                orderResponse.ErrorCode = 19999;
                orderResponse.ErrorMessage = ex.Message;
                //CommonFunctions.LogError(ex);

            }
            finally
            {
                var serialize = new JavaScriptSerializer();
                result.Add(serialize.Serialize(orderResponse));

                var input = new { token = token, cliencode = cliencode, txntype = txntype, physical = physical, folionumber = folionumber, amount = amount, reinvestmentflag = reinvestmentflag, sessionid = sessionid };
                result.Add(serialize.Serialize(input));
            }
            return result.ToArray();
        }
        #endregion


        public string PlaceAddtionalPurchaseOrder(int token, string mode, string foliono, double amount, string userid, string sessionid, string mfimfd)
        {
            string result = "";
            BSEResponse orderResponse = new BSEResponse();
            try
            {
                userid = CommonFunctions.Decrypt(userid);
                sessionid = CommonFunctions.Decrypt(sessionid);
                MFOrderRequest orderRequest = new MFOrderRequest
                {
                    Token = token,
                    PhysicalFlag = mode,
                    FolioNo = foliono,
                    Amount = amount,
                    ClientCode = userid,
                    RequestedBy = userid,
                    SessionID = sessionid,
                    TxnType = "AP",
                    OrderType = "FRESH",
                    TXNID = "0",
                    DPC = mode == "D" ? "Y" : "N",
                    EUINFlag = "Y",
                    EUINNumber = "E091038",
                    OrderSource = "Website",
                    MinRedeemFlag = "Y",
                    IsSpread = "N",
                    ValidateMargin = "Y",
                    CheckHoldings = "Y",
                    MFIMFD = mfimfd,
                    CloseAccountFlag = "N",
                    BrokerRefNo = "|||NETBANKING||" //added for fetching payment status
                };
                orderResponse = _order.PlaceMFOrder(orderRequest, "Addtional Purchase Order");
                if (orderResponse == null)
                {
                    orderResponse.ErrorCode = 10000;
                    orderResponse.ErrorMessage = "Order cannot be placed";
                }
            }
            catch (Exception ex)
            {
                orderResponse.ErrorCode = 19999;
                orderResponse.ErrorMessage = "Order cannot be placed";
                CommonFunctions.LogError(ex);

            }
            finally
            {
                result = new JavaScriptSerializer().Serialize(orderResponse);
            }
            return result;
        }

        public string PlaceSIPOrder(int token, string schemecode, string isin, string mode, string foliono, double amount, string frequency, bool gfot, string sipstartdate, string tenure, bool forever,
            string mandateid, string mandatetype, string clientcode, string sessionid, string mfimfd)
        {
            string result = "";
            BSEResponse orderResponse = new BSEResponse();
            try
            {
                int start; string enddate = "";
                DateTime dtStart = Convert.ToDateTime(sipstartdate);
                start = dtStart.Day;
                ///
                if (forever)
                    tenure = "999";
                enddate = dtStart.AddMonths(Convert.ToInt32(tenure)).ToString("yyyy-MM-dd");

                ///
                if (!string.IsNullOrEmpty(mandatetype))
                {
                    mandatetype = mandatetype.ToUpper() == "X" ? "XSIP" : "ISIP";
                }
                else
                {
                    mandatetype = "SIP";
                    mandateid = string.Empty;
                }
                ///
                clientcode = CommonFunctions.Decrypt(clientcode);
                sessionid = CommonFunctions.Decrypt(sessionid);
                MFOrderRequest orderRequest = new MFOrderRequest
                {
                    Token = token,
                    ISIN = isin,
                    TxnType = mandatetype,
                    Amount = amount,
                    SIPFrequency = frequency.ToUpper(),
                    Tenure = tenure,
                    PhysicalFlag = mode,
                    FolioNo = foliono,
                    StartDay = start,
                    StartDate = dtStart.ToString("yyyy-MM-dd"),
                    EndDate = enddate,
                    GenrateToday = gfot ? "Y" : "N",
                    MandateID = mandateid,
                    ClientCode = clientcode,
                    RequestedBy = clientcode,
                    SessionID = sessionid,
                    EUINFlag = "Y",
                    EUINNumber = "E091038",
                    OrderSource = "Website",
                    OrderType = "FRESH",
                    TXNID = "0",
                    // DPC = mode == "D" ? "Y" : "N",
                    //change for DPC check always send Y  by chetan on 20180921
                    DPC = "Y",
                    MinRedeemFlag = "Y",
                    IsSpread = "N",
                    ValidateMargin = "Y",
                    CheckHoldings = "Y",
                    MFIMFD = mfimfd,
                    CloseAccountFlag = "N"
                };
                ///
                orderResponse = _order.PlaceMFOrder(orderRequest, mandatetype + " Order");
                if (orderResponse == null)
                {
                    orderResponse.ErrorCode = 10000;
                    orderResponse.ErrorMessage = "Order cannot be placed";
                }
            }
            catch (Exception ex)
            {
                orderResponse.ErrorCode = 19999;
                orderResponse.ErrorMessage = ex.Message;
                CommonFunctions.LogError(ex);

            }
            finally
            {
                result = new JavaScriptSerializer().Serialize(orderResponse);
            }
            return result;
        }

        public string PlaceRedemptionOrder(int token, string schemecode, string isin, string mode, string foliono, bool redeemInUnits, double units, double amount,
            string clientcode, string sessionid, string creditin, string closeaccountflag, string mfimfd)
        {
            string result = "";
            BSEResponse orderResponse = new BSEResponse();
            try
            {
                clientcode = CommonFunctions.Decrypt(clientcode);
                sessionid = CommonFunctions.Decrypt(sessionid);
                MFOrderRequest orderRequest = new MFOrderRequest
                {
                    Token = token,
                    SchemeCode = schemecode,
                    ISIN = isin,
                    PhysicalFlag = mode.ToUpper(),
                    FolioNo = mode.ToUpper() == "P" ? foliono : "",
                    Units = redeemInUnits && closeaccountflag == "N" ? units : 0,
                    Amount = !redeemInUnits && closeaccountflag == "N" ? amount : 0,
                    ClientCode = clientcode,
                    RequestedBy = clientcode,
                    SessionID = sessionid,
                    CloseAccountFlag = closeaccountflag,
                    EUINFlag = "Y",
                    EUINNumber = "E091038",
                    OrderSource = "Website",
                    TxnType = "R",
                    OrderType = "FRESH",
                    TXNID = "0",
                    DPC = "Y",
                    MinRedeemFlag = "Y",
                    IsSpread = "N",
                    ValidateMargin = "Y",
                    CheckHoldings = "Y",
                    // MFIMFD = creditin == "bank" ? "MFD" : "MFI"
                    MFIMFD = mfimfd
                };

                orderResponse = _order.PlaceMFOrder(orderRequest, "Redemption Order");
                if (orderResponse == null)
                {
                    orderResponse.ErrorCode = 10000;
                    orderResponse.ErrorMessage = "Order cannot be placed";
                }
            }
            catch (Exception ex)
            {
                orderResponse.ErrorCode = 19999;
                orderResponse.ErrorMessage = ex.Message;
                CommonFunctions.LogError(ex);

            }
            finally
            {
                result = new JavaScriptSerializer().Serialize(orderResponse);
            }
            return result;
        }

        public string PlaceSwitchOrder(int token, string mode, string foliono, bool switchUnits, double units, double amount, string switchschemeisin, string switchschemeschemecode, string closeaccount,
            string userid, string sessionid, string mfimfd)
        {
            string result = "";
            BSEResponse orderResponse = new BSEResponse();
            try
            {
                userid = CommonFunctions.Decrypt(userid);
                sessionid = CommonFunctions.Decrypt(sessionid);
                MFOrderRequest orderRequest = new MFOrderRequest
                {
                    Token = token,
                    Units = switchUnits && closeaccount == "N" ? units : 0,
                    Amount = !switchUnits && closeaccount == "N" ? amount : 0,
                    PhysicalFlag = mode.ToUpper(),
                    FolioNo = mode.ToUpper() == "P" ? foliono : "",
                    SwitchSchemeISIN = switchschemeisin,
                    SwitchSchemeSchemeCode = switchschemeschemecode,
                    CloseAccountFlag = closeaccount,
                    ClientCode = userid,
                    RequestedBy = userid,
                    SessionID = sessionid,
                    TxnType = "SWITCH",
                    OrderType = "FRESH",
                    TXNID = "0",
                    DPC = "Y",
                    EUINFlag = "Y",
                    EUINNumber = "E091038",
                    OrderSource = "Website",
                    MinRedeemFlag = "Y",
                    IsSpread = "N",
                    ValidateMargin = "Y",
                    CheckHoldings = "Y",
                    MFIMFD = mfimfd
                };
                ///
                orderResponse = _order.PlaceMFOrder(orderRequest, "Switch Order");
                if (orderResponse == null)
                {
                    orderResponse.ErrorCode = 10000;
                    orderResponse.ErrorMessage = "Order cannot be placed";
                }
            }
            catch (Exception ex)
            {
                orderResponse.ErrorCode = 19999;
                orderResponse.ErrorMessage = ex.Message;
                CommonFunctions.LogError(ex);

            }
            finally
            {
                result = new JavaScriptSerializer().Serialize(orderResponse);
            }
            return result;
        }

        public string PlaceSWPOrder(int token, string isin, string mode, string foliono, bool redeemInUnits, double units, double amount, string creditin, string frequency, bool gfot, string sipstartdate
            , string tenure, bool forever, string clientcode, string sessionid, string mfimfd)
        {
            string result = "";
            BSEResponse orderResponse = new BSEResponse();
            try
            {
                int start; string enddate = "";
                DateTime dtStart = Convert.ToDateTime(sipstartdate);
                start = dtStart.Day;
                ///
                if (forever)
                    tenure = "999";
                enddate = dtStart.AddMonths(Convert.ToInt32(tenure)).ToString("yyyy-MM-dd");
                clientcode = CommonFunctions.Decrypt(clientcode);
                sessionid = CommonFunctions.Decrypt(sessionid);
                MFOrderRequest orderRequest = new MFOrderRequest
                {
                    Token = token,
                    ISIN = isin,
                    TxnType = "SWP",
                    Units = redeemInUnits ? units : 0,
                    Amount = !redeemInUnits ? amount : 0,
                    SIPFrequency = frequency.ToUpper(),
                    Tenure = tenure,
                    PhysicalFlag = mode.ToUpper(),
                    FolioNo = mode.ToUpper() == "P" ? foliono : "",
                    StartDay = start,
                    StartDate = dtStart.ToString("yyyy-MM-dd"),
                    EndDate = enddate,
                    GenrateToday = gfot ? "Y" : "N",
                    ClientCode = clientcode,
                    RequestedBy = clientcode,
                    SessionID = sessionid,
                    EUINFlag = "Y",
                    EUINNumber = "E091038",
                    OrderSource = "Website",
                    OrderType = "FRESH",
                    TXNID = "0",
                    DPC = "Y",
                    MinRedeemFlag = "Y",
                    IsSpread = "N",
                    ValidateMargin = "Y",
                    CheckHoldings = "Y",
                    CloseAccountFlag = "N",
                    /// MFIMFD = creditin == "bank" ? "MFD" : "MFI",
                    MFIMFD = mfimfd
                };
                ///
                orderResponse = _order.PlaceMFOrder(orderRequest, "SWP Order");
                if (orderResponse == null)
                {
                    orderResponse.ErrorCode = 10000;
                    orderResponse.ErrorMessage = "Order cannot be placed";
                }
            }
            catch (Exception ex)
            {
                orderResponse.ErrorCode = 19999;
                orderResponse.ErrorMessage = ex.Message;
                CommonFunctions.LogError(ex);

            }
            finally
            {
                result = new JavaScriptSerializer().Serialize(orderResponse);
            }
            return result;
        }

        public string PlaceSTPOrder(int token, string mode, string foliono, bool switchUnits, double units, double amount, string switchschemeisin, string switchschemeschemecode, string closeaccount,
            string frequency, bool gfot, string sipstartdate, string tenure, bool forever, string clientcode, string sessionid, string mfimfd)
        {
            string result = "";
            BSEResponse orderResponse = new BSEResponse();
            try
            {
                int start; string enddate = "";
                DateTime dtStart = Convert.ToDateTime(sipstartdate);
                start = dtStart.Day;
                ///
                if (forever)
                    tenure = "999";
                enddate = dtStart.AddMonths(Convert.ToInt32(tenure)).ToString("yyyy-MM-dd");
                clientcode = CommonFunctions.Decrypt(clientcode);
                sessionid = CommonFunctions.Decrypt(sessionid);
                MFOrderRequest orderRequest = new MFOrderRequest
                {
                    Token = token,
                    Units = switchUnits && closeaccount == "N" ? units : 0,
                    Amount = !switchUnits && closeaccount == "N" ? amount : 0,
                    PhysicalFlag = mode.ToUpper(),
                    FolioNo = mode.ToUpper() == "P" ? foliono : "",
                    SwitchSchemeISIN = switchschemeisin,
                    SwitchSchemeSchemeCode = switchschemeschemecode,
                    CloseAccountFlag = closeaccount,
                    TxnType = "STP",
                    SIPFrequency = frequency.ToUpper(),
                    Tenure = tenure,
                    StartDay = start,
                    StartDate = dtStart.ToString("yyyy-MM-dd"),
                    EndDate = enddate,
                    GenrateToday = gfot ? "Y" : "N",
                    ClientCode = clientcode,
                    RequestedBy = clientcode,
                    SessionID = sessionid,
                    EUINFlag = "Y",
                    EUINNumber = "E091038",
                    OrderSource = "Website",
                    OrderType = "FRESH",
                    TXNID = "0",
                    DPC = "Y",
                    MinRedeemFlag = "Y",
                    IsSpread = "N",
                    ValidateMargin = "Y",
                    CheckHoldings = "Y",
                    MFIMFD = mfimfd
                };
                ///
                orderResponse = _order.PlaceMFOrder(orderRequest, "STP Order");
                if (orderResponse == null)
                {
                    orderResponse.ErrorCode = 10000;
                    orderResponse.ErrorMessage = "Order cannot be placed";
                }
            }
            catch (Exception ex)
            {
                orderResponse.ErrorCode = 19999;
                orderResponse.ErrorMessage = ex.Message;
                CommonFunctions.LogError(ex);
            }
            finally
            {
                result = new JavaScriptSerializer().Serialize(orderResponse);
            }
            return result;
        }

        public string ModifyOrder(string txnid, string txntype, string units, string amount, bool closeaccount, string userid, string sessionid)
        {
            string result = "";
            BSEResponse orderResponse = new BSEResponse();
            try
            {
                userid = CommonFunctions.Decrypt(userid);
                sessionid = CommonFunctions.Decrypt(sessionid);
                MFOrderRequest orderRequest = new MFOrderRequest
                {
                    TXNID = txnid,
                    Units = Convert.ToDouble(units),
                    Amount = Convert.ToDouble(amount),
                    TxnType = txntype,
                    ClientCode = userid,
                    RequestedBy = userid,
                    SessionID = sessionid,
                    EUINFlag = "Y",
                    EUINNumber = "E091038",
                    OrderSource = "Website",
                    OrderType = "MODIFY",
                    DPC = "Y",
                    MinRedeemFlag = "Y",
                    IsSpread = "N",
                    ValidateMargin = "Y",
                    CheckHoldings = "Y",
                    // MFIMFD = "MFI",
                    CloseAccountFlag = closeaccount ? "Y" : "N"
                };
                orderResponse = _order.PlaceMFOrder(orderRequest, "Modify Order");
                if (orderResponse == null)
                {
                    orderResponse.ErrorCode = 10000;
                    orderResponse.ErrorMessage = "Order cannot be modified.";
                }
            }
            catch (Exception ex)
            {
                orderResponse.ErrorCode = 19999;
                orderResponse.ErrorMessage = "Order cannot be modified.";
                CommonFunctions.LogError(ex);
            }
            finally
            {
                result = new JavaScriptSerializer().Serialize(orderResponse);
            }
            return result;
        }


    }
}
