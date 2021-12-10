using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RSM.BAL.DomainModels.Models
{

    public class Constants
    {
        public const string ActiveLoginCheck = "ActiveLoginCheck";
        public const string UserSessionID = "c1u1s1";
        public const string UserID = "B0C3497F-D967-42CE-A3DA-047A03B763D5";
        public const string StocksCache = "StocksCache";
        public const string MutualFundCache = "MutualFundCache";
        public const string CART_ITEMS = "CART_ITEMS";
        public const string TOKEN = "c2u1t1";
        public const string ACCID = "c3u1a1";
        public const string StockDefaultDP = "MCAP,YIELD";
        public const string MFDefaultDP = "_1YRRET,RISK_GRADE";
        public const string UploadFolderPath = "~/uploadedfiles/";
        public const string ClientType = "ClientType";
        public const string FullName = "FullName";
        public const string ElmahLogError = "LogError";
        public const string BSEStarRequestedBy = "RequestedBy";
        public const string BSEStarEUINNo = "EUINNumber";
        public const string BSEStarEUINFlag = "EUINFlag";
        public const string BSEStarOrderSource = "OrderSource";
        public const string MandateFileDownload = "MandateFileDownload";
        public const string MFCACHEREFRESHTIME = "MFCacheRefreshTime";
        public const string MostBoughtDate = "MostBoughtDate";
        public const string NFOcloseDate = "NFOcloseDate";
        public const string AccordWssEndpoint = "AccordWss";
        public const string RelianceMoneySF = "RelianceMoneySF";
        public const string PreplodDBNestVWAP = "PreplodDBNestVWAP";
        public const string MFTransaction = "MFTransaction";
        public const string RMLDB = "RMLDB";
        public const string RMLDB1 = "RMLDB1";
        public const string cdsledis = "cdsledis";
        //public const string userdetails = "userdetails"; // live
        public const string userdetails = "userdetailsnew"; // pre production
       // public const string UserDetails = "userdetails"; // live
        public const string rtrade = "rtrade";
        public const string mailsign = "RMLDBmailsign";
        public const string AzureSearchEndpoint = "AzureSearchEndpoint";
        public const string LogQueryCRMAPIEndpoint = "LogQueryCRMAPIEndpoint";
        public const string partnerleadendpoint = "partnerleadendpoint"; // partner with us lead endpoint 20190405
        public const string BrokerName = "brokername";
        public const string BrokerBranchId = "brokerbranchid";
        public const string ClientCode = "clientcode";
        public const string PANVerificationEndpoint = "PANVerificationEndpoint";
        public const string TICKPROURL = "TickProURL";
        public const string MyprofileFundTransferLink = "MyprofileFundTransferLink";
        public const string MyprofileFundWithdrawalLink = "MyprofileFundWithdrawalLink";
        public const string MyprofileFundHistoryLink = "MyprofileFundHistoryLink";
        public const string MyprofileDPReportLink = "MyprofileDPReportLink";
        public const string MyprofileLimitCardLink = "MyprofileLimitCardLink";
        public const string MyprofileT7Link = "MyprofileT7Link";
        public const string MyprofileT90Link = "MyprofileT90Link";
        public const string MyprofileSegmentActivationLink = "MyprofileSegmentActivationLink";
        public const string MyprofileDebitCardRegistrationLink = "MyprofileDebitCardRegistrationLink";
        public const string MyprofileSebiPayoutInstructionsLink = "MyprofileSebiPayoutInstructionsLink";
        public const string MyprofileRMaxLink = "MyprofileRMaxLink";
        public const string MyprofileRValueLink = "MyprofileRValueLink";
        public const string MyprofileRRefLink = "MyprofileRRefLink";
        public const string MaintenanceMode = "MaintenanceMode";
        public const string ClientCodeEncryptionURL = "ClientCodeEncryptionURL";
        public const string AadhaarNumberRedirectURL = "AadhaarNumberRedirectURL";
        public const string LeadGenerationAPIEndpoint = "LeadGenerationAPIEndpoint";
        public const string LeadUserName = "LeadUserName";
        public const string LeadPassword = "LeadPassword";
        public const string RelianceETF = "RelianceMoneyETF";
        public const string Source = "source";
        public const string MyprofileMTFConsentLink = "MyprofileMTFConsentLink";
        public const string EXEValidationSession = "exevalidationsession";
        public const string DecodeCount = "DecodeCount";
        public const string EncodeCount = "EncodeCount";
        public const string SESSIONID = "c4u1a1";
        public const string JKEY = "c5u1a1";
        public const string Encrypturl = "Encrypturl";
        //ipo static content data
        public const string MerchantId = "MerchantId";
        public const string MerchantTrnxId = "MerchantTrnxId";
        public const string MerchantKey = "MerchantKey";

        public const string CashePartnerName = "CashePartnerName";
        public const string CasheSecretKey = "CasheSecretKey";
        public const string CasheRequest = "CasheRequest";



    }



public class ConstantsDpText
    {
        public const string PE = "Profit/Earning";
        public const string YIELD = "Dividend Yield";
        public const string EPS = "Earning Per Share";
        public const string MCAP = "Market Capital";
        public const string ROE = "Return On Equity";
        public const string IntCoverage = "Interest Coverage";
        public const string DebtEq = "Debt Equity";
    }

    public class Gainers
    {
        public string STK_EXCHANGE { get; set; }
        public string SCRIPCODE { get; set; }
        public string FINCODE { get; set; }
        public string SYMBOL { get; set; }
        public string S_NAME { get; set; }
        public string SCRIP_GROUP { get; set; }
        public decimal OPEN_PRICE { get; set; }
        public decimal HIGH_PRICE { get; set; }
        public decimal LOW_PRICE { get; set; }
        public decimal CLOSE_PRICE { get; set; }
        public decimal PREVCLOSE { get; set; }
        public decimal PERCHG { get; set; }
        public decimal NETCHG { get; set; }
        public decimal VOLUME { get; set; }
        public decimal VALUE { get; set; }
        public decimal FHigh { get; set; }
        public decimal FLow { get; set; }
        public int WEEKRANGE { get; set; }
    }

    public class UPICredentials
    {
        public const string MerchantId = "MerchantId";
        public const string MerchantTrnxId = "MerchantTrnxId";
        public const string MerchantKey = "MerchantKey";
        public const string PFXpath = "PFXpath";
        public const string PFXpwd = "PFXpwd";
        public const string upiApi = "upiApi";
        public const string ClientID = "YESclientid";
        public const string ClientSecret = "YESclientsecret";
    }

    public class MaildetailsBol
    {
        public const string EmailHost = "EmailHost";
        public const string fromAddress = "fromAddress";
        public const string fromPassword = "fromPassword";
        public const string Port = "Port";
    }
    public class ipvuatBol
    {
        public const string ipvuatURL = "ipvuatURL";
    }

    public class ReferAndEarn
    {
        public const string Referandearn = "Referandearn";
    }


}
