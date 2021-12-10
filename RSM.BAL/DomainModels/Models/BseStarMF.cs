using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
// using System.Runtime.Serialization;
namespace RSM.BAL.DomainModels.Models
{
    public enum BSEStarOrderBookStatus
    {
        ALL = -1,
        ACCEPTED = 1,
        REJECTED = 2
    }
    public class BSEResponse
    {
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public string Message { get; set; }
        public string ReportName { get; set; }
        public string ReportTable { get; set; }
        public string ReportTable1 { get; set; }
        public string ReportTable2 { get; set; }
        public string ReportTable3 { get; set; }
        public string ReportTable4 { get; set; }
        public string isCompressed { get; set; }
        public string OrderNumber { get; set; }
        public string Packet { get; set; }

        public string AAWId { get; set; }
        public string Status { get; set; }
        public string StatusCode { get; set; }
        public string ETFblockstatus { get; set; }



    }
    public class MFOrderRequest
    {
        public int Token { get; set; }
        public string ClientCode { get; set; }
        public string TxnType { get; set; }
        public double Amount { get; set; }
        public string ReinvestmentFlag { get; set; }
        public string SessionID { get; set; }
        public string RequestedBy { get; set; }
        public string KYCFlag { get; set; }
        public string OrderType { get; set; }
        public string TXNID { get; set; }
        public string DPC { get; set; }
        public string EUINFlag { get; set; }
        public string EUINNumber { get; set; }
        public string PhysicalFlag { get; set; }
        public string IsSpread { get; set; }
        public string OrderSource { get; set; }
        public string ValidateMargin { get; set; }
        public string MFIMFD { get; set; }
        public string FolioNo { get; set; }
        public string CloseAccountFlag { get; set; }
        public string MinRedeemFlag { get; set; }
        public string VcRemarks { get; set; }
        public double Units { get; set; }
        public string RedeemDate { get; set; }
        public double RedeemAmount { get; set; }
        public int StartDay { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string SIPFrequency { get; set; }
        public string GenrateToday { get; set; }
        public string Tenure { get; set; }
        public string MandateID { get; set; }
        public string Brokerage { get; set; }
        public string SwitchSchemeISIN { get; set; }
        public string SwitchSchemeSchemeCode { get; set; }
        public string SchemeCode { get; set; }
        public string Mode { get; set; }
        public string BrokerRefNo { get; set; }
        public string CheckHoldings { get; set; }
        public string ModelPortFolioName { get; set; }

        public string ISIN { get; set; }

    }
    public class SchemeDetails
    {
        public string TXNTYPE { get; set; }
        public string Token { get; set; }
        public string SchemeCode { get; set; }
        public string RnTSchemeCode { get; set; }
        public string AMCSchemeCode { get; set; }
        public string ISIN { get; set; }
        public string AMCCode { get; set; }
        public string AmcName { get; set; }
        public string SchemeName { get; set; }
        public string PurchaseTransactionMode { get; set; }
        public string MinPurAmt { get; set; }
        public string AddPurAmtMul { get; set; }
        public string MaxPurAmtMul { get; set; }
        public string PurAllowed { get; set; }
        public string PurCutoffTime { get; set; }
        public string RedTranMode { get; set; }
        public string MinRedQty { get; set; }
        public string RedQtyMul { get; set; }
        public string MaxRedQty { get; set; }
        public string RedAllowed { get; set; }
        public string RedCutoffTime { get; set; }
        public string RnTAgentCode { get; set; }
        public string AMCActFlag { get; set; }
        public string DivReFlag { get; set; }
        public string SchemeType { get; set; }
        public string SIPFLAG { get; set; }
        public string STPFLAG { get; set; }
        public string SWPFLAG { get; set; }
        public string SettlementType { get; set; }
        public string PurAmountMult { get; set; }
        public string NAVValue { get; set; }
        public string NAVDate { get; set; }
        public string NAVDiffrence { get; set; }
        public string AMC_IND { get; set; }
        public string FaceValue { get; set; }
        public string RedemptionAmountMinimum { get; set; }
        public string RedemptionAmountMaximum { get; set; }
        public string RedemptionAmountMultiple { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string NRIallowed { get; set; }
        public string ExitLoadFlag { get; set; }
        public string ExitLoad { get; set; }
        public string LockInPeriodFlag { get; set; }
        public string LockInPeriod { get; set; }
        public string SchemePlan { get; set; }
        public string SwitchFLAG { get; set; }
        public string ChannelPartnerCode { get; set; }
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }
    public class SchemeSIPDates
    {
        public string Token { get; set; }
        public string SIPFrequency { get; set; }
        public string SchemeName { get; set; }
        public string SchemeCode { get; set; }
        public string SchemeISIN { get; set; }
        public string AMCCode { get; set; }
        public string SIPMinimumGap { get; set; }
        public string SIPDates { get; set; }
        public string SIPMaximumGap { get; set; }
        public string SIPInstallmentGap { get; set; }
        public string SIPStatus { get; set; }
        public string SIPMinimumInstallmentAmount { get; set; }
        public string SIPMaximumInstallmentAmount { get; set; }
        public string SIPMultiplierAmount { get; set; }
        public string SIPMinimumInstallmentNumbers { get; set; }
        public string SIPMaximumInstallmentNumbers { get; set; }
        public string SettlementType { get; set; }
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }
    public class OrderBookItem
    {
        public string TxnDate { get; set; }
        public int TxnID { get; set; }
        public string TxnType { get; set; }
        public string SchemeName { get; set; }
        public string Option { get; set; }
        public string ClientCode { get; set; }
        public string ClientName { get; set; }
        public double NAV { get; set; }
        public string NAVDate { get; set; }
        public double Units { get; set; }
        public double Amount { get; set; }
        public string CloseAccountFlag { get; set; }
        public string ExchangeRefNo { get; set; }
        public string Status { get; set; }
        public int StartDay { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string SIPFrequency { get; set; }
        public string FolioNo { get; set; }
        public string GenrateToday { get; set; }
        public string IsSpread { get; set; }
        public string DPC { get; set; }
        public string PhysicalFlag { get; set; }
        public string RedeemDate { get; set; }
        public double RedeemAmount { get; set; }
        public string OrderRemarks { get; set; }
        public string OrderSource { get; set; }
        public string Tenure { get; set; }
        public string MandateID { get; set; }
        public string OrderedBy { get; set; }
        public string Mode { get; set; }
        public string ValidateMargin { get; set; }
        public string BrokerRefNo { get; set; }
        public string LimitValidation { get; set; }
        public string CheckHoldings { get; set; }
        public int Token { get; set; }
        public string ISIN { get; set; }
        public string SchemeCode { get; set; }
        public string SwitchISIN { get; set; }
        public string SwitchSchemeCode { get; set; }
        public string MinRedeemFlag { get; set; }
        public string ClientId { get; set; }
        public string RnTSchemeCode { get; set; }
        public string EUINFlag { get; set; }
        public string TermCondtion { get; set; }
        public string ModelPortFolioName { get; set; }
        public string MFIMFDFlag { get; set; }
        public double OrderNAV { get; set; }
        public string OrderNAVDate { get; set; }
        public string OrderType { get; set; }
        public string SubBrokerCode { get; set; }
        public string ARN { get; set; }
        public string PaymentMode { get; set; }
        public string AmcName { get; set; }
        public string ShortTxnType { get; set; }
        public string TRAXMODE { get; set; }
        public string SettlementType { get; set; }
        public string EUINNumber { get; set; }
        public string LastModifiedBy { get; set; }
        public string LastModifiedTime { get; set; }
        public string Source { get { return "dion"; } }
        public string PaymentStatus { get; set; }
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public string LastModifiedOn { get; set; }
        public string DIONPaymentStatus { get; set; }
        public string strTxnDate
            
        {
            get
            {
                return !string.IsNullOrEmpty(TxnDate) ? Convert.ToDateTime(TxnDate).ToString("dd MMM, yyyy hh:mm tt") : "";
            }
        }
        public string strNAVDate
        {
            get
            {
                return !string.IsNullOrEmpty(NAVDate) ? DateTime.Parse(NAVDate, new CultureInfo("en-GB")).ToString("dd MMM, yyyy") : "";
            }
        }
        public string strOrderNAVDate
        {
            get
            {
                return !string.IsNullOrEmpty(OrderNAVDate) ? Convert.ToDateTime(OrderNAVDate).ToString("dd MMM, yyyy") : "";
            }
        }
        public string strLastModifiedTime
        {
            get
            {
                return !string.IsNullOrEmpty(LastModifiedTime) ? Convert.ToDateTime(LastModifiedTime).ToString("dd MMM, yyyy hh:mm tt") : "";
            }
        }

        
        /* HOLD ORDER DETAILS FIELDS */
      
        public string Aging { get; set; }
        public string TxnDate1 { get; set; }
        public string isDividen { get; set; }
        public string TransactionType { get; set; }
        public string KYCFlag { get; set; }
        public string SysRefNo { get; set; }
        public string inBatchID { get; set; }
        public string inSubBatchID { get; set; }
        public string Brokerage { get; set; }
        public string SIPRegDate { get; set; }
    }
    public class ClientFolio
    {
        public string FOLIONO { get; set; }
        public double ALLOTEDUNIT { get; set; }
        public string SCHEMECODE { get; set; }
        public string ISIN { get; set; }
        public string Mode { get; set; }
        public string SchemeName { get; set; }
        public double MinRedQty { get; set; }
        public double RedQtyMul { get; set; }
        public double NAV { get; set; }
        public string DivReFlag { get; set; }
        public double AddPurAmtMul { get; set; }
        public double MaxPurAmtMul { get; set; }
        public double RedemptionAmountMinimum { get; set; }
        public double RedemptionAmountMultiple { get; set; }
        public double RedemptionAmountMaximum { get; set; }
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }
    public class ClientFolioDetails
    {
        public int ErrorCode { get; set; }
        public string Message { get; set; }
        public string ReportName { get; set; }
        public List<ClientFolio> ReportTable { get; set; }
        public object ReportTable1 { get; set; }
        public object ReportTable2 { get; set; }
        public object ReportTable3 { get; set; }
        public object ReportTable4 { get; set; }
        public bool isCompressed { get; set; }
    }
    public class ClientHolding
    {
        public string Clientcode { get; set; }
        public string ClientName { get; set; }
        public string schemeName { get; set; }
        public string SchemeCode { get; set; }
        public string ISIN { get; set; }
        public float OpenQty { get; set; }
        public float UsedQty { get; set; }
        public float AvailableUnits { get; set; }
        public string Entity { get; set; }
        public string FolioNo { get; set; }
        public string DPID { get; set; }
        public object Filler1 { get; set; }
        public object Filler2 { get; set; }
        public string Mode { get; set; }
        public string Type { get; set; }
        public float NAVValue { get; set; }
        public float CurrentValuation { get; set; }
        public string AMCCode { get; set; }
        public string AmcName { get; set; }
        public string Token { get; set; }
        public int ClientId { get; set; }
        public bool bolisCloseAccount { get; set; }
        public string RedemptionAmountMinimum { get; set; }
        public string RedemptionAmountMaximum { get; set; }
        public float RedemptionAmountMultiple { get; set; }
        public string SchemeType { get; set; }
        public string ISIN1 { get; set; }
        public string PurAllowed { get; set; }
        public string RedAllowed { get; set; }
        public string SwitchFLAG { get; set; }
        public string SWPFLAG { get; set; }
        public string STPFLAG { get; set; }
        public string SIPFLAG { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }
    public class SIPOrderBook
    {
        public string SIPRegDate { get; set; }
        public string SIPOrderNo { get; set; }
        public string TxnID { get; set; }
        public string SIPRegNo { get; set; }
        public string ClientCode { get; set; }
        public string SchemeName { get; set; }
        public string TxnType { get; set; }
        public string Amount { get; set; }
        public string SIPRegDate1 { get; set; }
        public string SIPStartDate { get; set; }
        public string SIPEndDate { get; set; }
        public string FolioNo { get; set; }
        public string Status { get; set; }
        public string OrderedBy { get; set; }
        public string SchemeCode { get; set; }
        public string ISIN { get; set; }
        public string Frequency { get; set; }
        public string TotalInstalments { get; set; }
        public string InstalementsPaid { get; set; }
        public string InstalmentsPending { get; set; }
        public string MandateID { get; set; }
        public string ReinvestmentFlag { get; set; }
        public string NAV { get; set; }
        public string ClientCode1 { get; set; }
        public string ClientName { get; set; }
        public string MFIMFDFlag { get; set; }
        public string ModelPortFolioName { get; set; }
        public string Remarks { get; set; }
        public string VaildCount { get; set; }
        public string invaildCount { get; set; }
        public string AmcName { get; set; }
        public string EUINNumber { get; set; }
        public string SubBrokerCode { get; set; }
        public string ARN { get; set; }
        public string PaymentMode { get; set; }
        public string SIPCancellationDate { get; set; }
        public string DPC { get; set; }
        public string FirstOrderToday { get; set; }
        public string EUINDECL { get; set; }
        public string TRAXMODE { get; set; }
        public string SettlementType { get; set; }
        public string ClientMode { get; set; }
        public string UserID { get; set; }
        public string UserType { get; set; }
        public string DueDate { get; set; }
        public string PrevPaiddate { get; set; }
        public string source { get; set; }
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }
    public class SIPDueReport
    {
        public string MemCd { get; set; }
        public string ClientCode { get; set; }
        public string ClientName { get; set; }
        public string InternalRefNo { get; set; }
        public string SIPRegnNumber { get; set; }
        public string RegnDate { get; set; }
        public string AMCNAME { get; set; }
        public string SchemeCode { get; set; }
        public string SchemeName { get; set; }
        public string FrequencyType { get; set; }
        public string InstallmentAmt { get; set; }
        public string DueDate { get; set; }
        public string PrevPaiddate { get; set; }
        public string NoOfInstallmentsPaid { get; set; }
        public string TotalInstallmentAmtPaid { get; set; }
        public string EntryBy { get; set; }
        public string MandateID { get; set; }
        public string SchType { get; set; }
        public string DPTrans { get; set; }
        public string FirstOrderToday { get; set; }
        public string CreatedOn { get; set; }
        public string ClientId { get; set; }
        public string ClientMode { get; set; }
        public string UserID { get; set; }
        public string UserType { get; set; }
        public string TRAXMODE { get; set; }
        public string FirstOrderToday1 { get; set; }
        public string MFIMFDFlag { get; set; }
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }

    }
    public class AccordSIPOrderBook
    {
        public string ClientCode { get; set; }
        public string folio_number { get; set; }
        public string SIP_Trxn_ID { get; set; }
        public string AMC { get; set; }
        public string SchemeName { get; set; }
        public string schemecode { get; set; }
        public string Inv_Amount { get; set; }
        public string SIPReg_Date { get; set; }
        public string start_date { get; set; }
        public string NextTransDate { get; set; }
        public string Frequency { get; set; }
        public string Total_Inst { get; set; }
        public string Total_Hit { get; set; }
        public string Total_Miss { get; set; }
        public string Total_Remain { get; set; }
        public string Status { get; set; }
        public string Source { get { return "accord"; } }
    }
    public class SIPOrderReport
    {
        public string ClientCode { get; set; }
        public string ReportName { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }

        public string RequestedBy { get; set; }
        public string Status { get; set; }
        public string SIPRegDate { get; set; }
        public int SIPOrderNo { get; set; }
        public int TxnID { get; set; }
        public string SIPRegNo { get; set; }

        public string SchemeName { get; set; }
        public string TxnType { get; set; }
        public Decimal Amount { get; set; }
        public string SIPRegDate1 { get; set; }
        public string SIPStartDate { get; set; }
        public string SIPEndDate { get; set; }
        public string FolioNo { get; set; }

        public string OrderedBy { get; set; }
        public string SchemeCode { get; set; }
        public string ISIN { get; set; }
        public string Frequency { get; set; }
        public int TotalInstalments { get; set; }
        public int InstalementsPaid { get; set; }
        public int InstalmentsPending { get; set; }
        public string MandateID { get; set; }
        public string ReinvestmentFlag { get; set; }
        public double NAV { get; set; }
        public string ClientCode1 { get; set; }
        public string ClientName { get; set; }
        public string MFIMFDFlag { get; set; }
        public string ModelPortFolioName { get; set; }
        public string Remarks { get; set; }
        public int VaildCount { get; set; }
        public int invaildCount { get; set; }
        public string AmcName { get; set; }
        public string EUINNumber { get; set; }
        public string SubBrokerCode { get; set; }
        public string ARN { get; set; }
        public string PaymentMode { get; set; }
        public string SIPCancellationDate { get; set; }
        public string DPC { get; set; }
        public string FirstOrderToday { get; set; }
        public string EUINDECL { get; set; }
        public string TRAXMODE { get; set; }
        public string SettlementType { get; set; }
        public string ClientMode { get; set; }
        public string UserID { get; set; }
        public string UserType { get; set; }
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }
    public class MandateReportItem
    {
        public string Id { get; set; }
        public string MandateId { get; set; }
        public string ClientCode { get; set; }
        public string ClientName { get; set; }
        public string Filler1 { get; set; }
        public string Filler2 { get; set; }
        public string Amount { get; set; }
        public string ModeOfPayment { get; set; }
        public string BankName { get; set; }
        public string Branch { get; set; }
        public string Filler3 { get; set; }
        public string Filler4 { get; set; }
        public string Filler5 { get; set; }
        public string MandateType { get; set; }
        public string Filler6 { get; set; }
        public string MandateDate { get; set; }
        public string MemberId { get; set; }
        public string Status { get; set; }
        public string Remarks { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedOn { get; set; }
        public string UpdatedOn1 { get; set; }
        public string APPROVEDDATE { get; set; }
        public string AccountNumber { get; set; }
        public string IFSCCODE { get; set; }
        public string MandateMode { get; set; }
        public string Message { get; set; }
        public string ReportName { get; set; }
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }
    public class UserInformation
    {
        public int inUserId { get; set; }
        public string vcClientCode { get; set; }
        public string vcClientName { get; set; }
        public string vcAddressLine1 { get; set; }
        public string vcAddressLine2 { get; set; }
        public string vcAddressLine3 { get; set; }
        public int inPinCode { get; set; }
        public int inCity { get; set; }
        public string vcCityName { get; set; }
        public int inState { get; set; }
        public string vcStateName { get; set; }
        public int inCountry { get; set; }
        public string vcCountryName { get; set; }
        public string dtClientDateOfBirth { get; set; }
        public string vcMobileNo { get; set; }



        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }
    public class BankDetails
    {
        public int inUserBankId { get; set; }
        public int inUserId { get; set; }
        public string vcAccountNo { get; set; }
        public int inAccountType { get; set; }
        public int inBank { get; set; }
        public object vcNeftCode { get; set; }
        public string vcBankBranch { get; set; }
        public string vcBankBranchCode { get; set; }
        public int inBankCity { get; set; }
        public bool bolIsActive { get; set; }
        public string vcDefinedCode { get; set; }
        public string vcMfBseCode { get; set; }
        public string BankName { get; set; }
        public string AccountType { get; set; }
        public string BankMode { get; set; }
        public bool ISIPAllowed { get; set; }
        public string vcIFSC { get; set; }
        public bool bolisDefault { get; set; }
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }
    public class MandateRegistration
    {
        public int AAWId { get; set; }
        public int ErrorCode { get; set; }
        public string Message { get; set; }
        public string Status { get; set; }
        public string StatusCode { get; set; }

        public string ErrorMessage { get; set; }
    }

    //public class MandateFile
    //{
    //    public string MandateDate { get; set; }
    //    public string AccountName1 { get; set; }
    //    public string AmountInWords { get; set; }
    //    public int Amount { get; set; }
    //    public string vcUMRN { get; set; }
    //    public string Frequency { get; set; }
    //    public string DebitType { get; set; }
    //    public string Reference1 { get; set; }
    //    public string Reference2 { get; set; }
    //    public string SponsorBankCode { get; set; }
    //    public string UtilityCode { get; set; }
    //    public string Authorize { get; set; }
    //    public string FromDate { get; set; }
    //    public object ToDate { get; set; }
    //    public int UntilControlled { get; set; }
    //    public object AccountName2 { get; set; }
    //    public object AccountName3 { get; set; }
    //    public string phoneNo { get; set; }
    //    public string EmailId { get; set; }
    //    public string AccountNo { get; set; }
    //    public object vcRtgsCode { get; set; }
    //    public string WithBank { get; set; }
    //    public object vcMicrCode { get; set; }
    //    public object vcNeftCode { get; set; }
    //    public string chkSB { get; set; }
    //    public int ErrorCode { get; set; }
    //    public string Message { get; set; }

    //    public string ErrorMessage { get; set; }
    //}

    public class RedemptionReport
    {
        public string ReportDate { get; set; }
        public string OrderNo { get; set; }
        public string SettNo { get; set; }
        public string OrderDate { get; set; }
        public string SchemeCode { get; set; }
        public string ISINNo { get; set; }
        public string Amount { get; set; }
        public string Quantity { get; set; }
        public string AllotedNAV { get; set; }
        public string AllotedUnit { get; set; }
        public string AllotedAmnt { get; set; }
        public string FolioNo { get; set; }
        public string RtaTransNo { get; set; }
        public string DPID { get; set; }
        public string RefNO { get; set; }
        public string Token { get; set; }
        public string ClientId { get; set; }
        public string ClientCode { get; set; }
        public string ClientName { get; set; }
        public string SETTTYPE { get; set; }
        public string ClientMode { get; set; }
        public string UserID { get; set; }
        public string UserType { get; set; }
        public string MFIMFDFlag { get; set; }
        public string SchemeName { get; set; }
        public string Mode
        {
            get
            {
                return !string.IsNullOrEmpty(DPID) ? "Demat" : "Folio";
            }
        }
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }
    public class AllotmentReport
    {
        public string ClientCode { get; set; }
        public string ClientName { get; set; }
        public string AllotmentID { get; set; }
        public string REPORTDATE { get; set; }
        public string ORDERNO { get; set; }
        public string SETTTYPE { get; set; }
        public string SETTNO { get; set; }
        public string ORDERDATE { get; set; }
        public string SCHEMECODE { get; set; }
        public string ISIN { get; set; }
        public string Amount { get; set; }
        public string Quantity { get; set; }
        public string MEMBERID { get; set; }
        public string BranchCode { get; set; }
        public string USERID { get; set; }
        public string FOLIONO { get; set; }
        public string RTASchemeCode { get; set; }
        public string RTATRANSNO { get; set; }
        public string BENEFICIARYID { get; set; }
        public string ALLOTTEDNAV { get; set; }
        public string ALLOTTEDUNIT { get; set; }
        public string ALLOTMENTAMT { get; set; }
        public string VALIDFLAG { get; set; }
        public string REMARKS { get; set; }
        public string SchemeName { get; set; }
        public string FolioNo1 { get; set; }
        public string NAV { get; set; }
        public string CurrentValue { get; set; }
        public string STT { get; set; }
        public string INTERNALREFNO { get; set; }
        public string OrderType { get; set; }
        public string SIPREGNNO { get; set; }
        public string SIPREGNDATE { get; set; }
        public string SubBRCode { get; set; }
        public string EUIN { get; set; }
        public string EUINDECL { get; set; }
        public string DPCFlag { get; set; }
        public string DPTrans { get; set; }
        public string OrderSubType { get; set; }
        public string CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
        public string ClientId { get; set; }
        public string Mode
        {
            get
            {
                return !string.IsNullOrEmpty(BENEFICIARYID) ? "Demat" : "Folio";
            }
        }
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }
    public class MFTradeBook
    {
        public string TxnID { get; set; }
        public string TxnType { get; set; }
        public string TxnDate { get; set; }
        public string ClientCode { get; set; }
        public string ClientName { get; set; }
        public string SchemeName { get; set; }
        public string SchemeCode { get; set; }
        public string ISINNo { get; set; }
        public string FolioNo { get; set; }
        public string NAV { get; set; }
        public string AllotedUnit { get; set; }
        public string CurrentValue { get; set; }
        //public string UnitsCreditedIn
        //{
        //    get
        //    {
        //        return string.IsNullOrEmpty(FolioNo) ? "Demat" : "Physical";
        //    }
        //}
        public string UnitsCreditedIn { get; set; }
        public string Remark { get; set; }
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }
    public class MFDPHoldings
    {
        public string Clientcode { get; set; }
        public string ClientName { get; set; }
        public string schemeName { get; set; }
        public string SchemeCode { get; set; }
        public string ISIN { get; set; }
        public float OpenQty { get; set; }
        public float UsedQty { get; set; }
        public float AvailableUnits { get; set; }
        public string Entity { get; set; }
        public string FolioNo { get; set; }
        public string DPID { get; set; }
        public object Filler1 { get; set; }
        public object Filler2 { get; set; }
        public string Mode { get; set; }
        public string Type { get; set; }
        public float NAVValue { get; set; }
        public float CurrentValuation { get; set; }
        public string AMCCode { get; set; }
        public string AmcName { get; set; }
        public string Token { get; set; }
        public int ClientId { get; set; }
        public bool bolisCloseAccount { get; set; }
        public string RedemptionAmountMinimum { get; set; }
        public string RedemptionAmountMaximum { get; set; }
        public float RedemptionAmountMultiple { get; set; }
        public string SchemeType { get; set; }
        public string ISIN1 { get; set; }
        public string PurAllowed { get; set; }
        public string RedAllowed { get; set; }
        public string SwitchFLAG { get; set; }
        public string SWPFLAG { get; set; }
        public string STPFLAG { get; set; }
        public string SIPFLAG { get; set; }
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }
    public class UserPermissions
    {
        [JsonProperty(PropertyName = "clientcode")]
        public string vcClientCode { get; set; }
        [JsonProperty(PropertyName = "kyc")]
        public bool bolIsKYC { get; set; }
        [JsonProperty(PropertyName = "starmf")]
        public string bolIsSTARMFAllowed { get; set; }
        [JsonProperty(PropertyName = "physical")]
        public string bolIsBSEPhyAllowed { get; set; }
        [JsonProperty(PropertyName = "demat")]
        public string bolIsBSEDEMATAllowed { get; set; }
        [JsonProperty(PropertyName = "mfd")]
        public string bolIsBSEMFDAllowed { get; set; }
        [JsonProperty(PropertyName = "mfi")]
        public string bolIsBSEMFIAllowed { get; set; }
        [JsonProperty(PropertyName = "dpid")]
        public string vcDPId { get; set; }
        [JsonProperty(PropertyName = "txnmode")]
        public string vcTxnMode { get; set; }
        [JsonProperty(PropertyName = "config")]
        public string vcConfigurationType { get; set; }
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }
    public class AccordSIPTerminator
    {
        public string ClientCode { get; set; }
        public string SIP_Trxn_ID { get; set; }
        public int StatusCode { get; set; }
    }
}
