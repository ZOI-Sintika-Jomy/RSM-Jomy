using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace RSM.BAL.DomainModels.Models
{
    public class ConsolidatedPortfolioMFResponse
    {
        public string Asset_Class { get; set; }
        public float CostValue { get; set; }
        public float Mkt_Value { get; set; }
        public float UnRealised { get; set; }
        public float AbsPer { get; set; }
        public float CurrAllocation { get; set; }
        public int Sequence { get; set; }
    }

    public class AccordWSSResponse
    {
        public WSSresponse1[] Table { get; set; }
        public WSSresponse2[] Table1 { get; set; }
    }

    public class WSSresponse1
    {
        public string Asset_Class { get; set; }
        public string CostValue { get; set; }
        public string Mkt_Value { get; set; }
        public string UnRealised { get; set; }
        public string AbsPer { get; set; }
        public string CurrAllocation { get; set; }

        public int Sequence { get; set; }

        public double _CostValue
        {
            get { return !string.IsNullOrEmpty(CostValue) ? Convert.ToDouble(CostValue.Replace(",", "")) : 0; }
        }
        public double _Mkt_Value
        {
            get { return !string.IsNullOrEmpty(Mkt_Value) ? Convert.ToDouble(Mkt_Value.Replace(",", "")) : 0; }
        }
        public double _UnRealised
        {
            get { return !string.IsNullOrEmpty(UnRealised) ? Convert.ToDouble(UnRealised.Replace(",", "")) : 0; }
        }
        public double _AbsPer
        {
            get { return !string.IsNullOrEmpty(AbsPer) ? Convert.ToDouble(AbsPer.Replace(",", "")) : 0; }
        }
        public double _CurrAllocation
        {
            get { return !string.IsNullOrEmpty(CurrAllocation) ? Convert.ToDouble(CurrAllocation.Replace(",", "")) : 0; }
        }
    }
    public class WSSresponse2
    {
        public string Asset_Class { get; set; }
        public string CostValue { get; set; }
        public string Mkt_Value { get; set; }
        public string UnRealised { get; set; }
        public string AbsPer { get; set; }
        public string CurrAllocation { get; set; }

        public double _CostValue
        {
            get { return !string.IsNullOrEmpty(CostValue) ? Convert.ToDouble(CostValue.Replace(",", "")) : 0; }
        }
        public double _Mkt_Value
        {
            get { return !string.IsNullOrEmpty(Mkt_Value) ? Convert.ToDouble(Mkt_Value.Replace(",", "")) : 0; }
        }
        public double _UnRealised
        {
            get { return !string.IsNullOrEmpty(UnRealised) ? Convert.ToDouble(UnRealised.Replace(",", "")) : 0; }
        }
        public double _AbsPer
        {
            get { return !string.IsNullOrEmpty(AbsPer) ? Convert.ToDouble(AbsPer.Replace(",", "")) : 0; }
        }
        public double _CurrAllocation
        {
            get { return !string.IsNullOrEmpty(CurrAllocation) ? Convert.ToDouble(CurrAllocation.Replace(",", "")) : 0; }
        }

    }

    public class UserDetails
    {
        public ProfileDetail[] Table { get; set; }
    }
    public class ProfileDetail
    {
        public long ClientID { get; set; }
        public string ClientCode { get; set; }
        public string ClientName { get; set; }
        public string ClientPAN { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        public string MaritalStatus { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
    }

    public class AllTransactionDetails
    {
        public string Product { get; set; }
        public string ProductName { get; set; }
        public string TransactionDate { get; set; }
        public string Company { get; set; }

        public string ApplicationNo { get; set; }

        public string Investment_Amount { get; set; }
    }

    public class MFDetails
    {
        public string Folio_Number { get; set; }
        public string Scheme_Name { get; set; }
        public string Balance_Units { get; set; }
        public string Current_Amount { get; set; }
        public string PnL { get; set; }
        public string Mode_Of_Holding { get; set; }

        public string CAGR { get; set; }
    }

    public class rootFDDetails
    {
        public List<FD_Details> Table { get; set; }
    }
    public class FD_Details
    {
        //public string Product { get; set; }
        //public string ProductName { get; set; }
        //public DateTime TransactionDate { get; set; }
        //public string Company { get; set; }

        //public string ApplicationNo { get; set; }

        //public string Investment_Amount { get; set; }

        public string BranchName { get; set; }
        public string EmployeeName { get; set; }
        public string AgentName { get; set; }
        public string ClientName { get; set; }
        public string ClientPAN { get; set; }
        public string CompanyName { get; set; }
        public string SchemeName { get; set; }
        public string ApplicationNo { get; set; }
        public string ApplicationType { get; set; }
        public string ChequeNo { get; set; }
        public string Amount { get; set; }
        public string Duration { get; set; }
        public string InterestRate { get; set; }
        public string DepositType { get; set; }
        public string InterestFrequency { get; set; }
        public string MaturityDate { get; set; }
        public string FDStatus { get; set; }
    }

    public class rootBondsDetails
    {
        public List<BondsDetails> Table { get; set; }
    }
    public class BondsDetails
    {
        public string rowid { get; set; }
        public string dep_Type { get; set; }
        public string foliono { get; set; }
        public string Qtn { get; set; }
        public string MktPrice { get; set; }
        public string gainloss { get; set; }
        public string Inv_Date { get; set; }
        public string Inv_amt { get; set; }
        public string CurrentValue { get; set; }
        public string period { get; set; }
        public string interest { get; set; }
        public string IntPayoutEarn { get; set; }
        public string Mat_Date { get; set; }
        public string Maturity_Value { get; set; }
        public string Instrument { get; set; }
        public string Userid { get; set; }
        public string Category { get; set; }
        public string YTM { get; set; }
    }

    public class rootLIDetails
    {
        public List<LIDetails> Table { get; set; }
    }
    public class LIDetails
    {
        public string Product { get; set; }
        public string ProductName { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Company { get; set; }

        public string ApplicationNo { get; set; }

        public string Investment_Amount { get; set; }
    }

    public class rootGIDetails
    {
        public List<GIDetails> Table { get; set; }
    }
    public class GIDetails
    {
        public string Product { get; set; }
        public string ProductName { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Company { get; set; }
        public string ApplicationNo { get; set; }
        public string Investment_Amount { get; set; }
    }

    //MF


    public class ParentMFPortFolio
    {
        public Table[] Table { get; set; }
        public Table1[] Table1 { get; set; }
        public List<MFPortfolio> Table3 { get; set; }
    }

    public class Table
    {
        public long Client_ID { get; set; }
        public string Name { get; set; }
        public string PAN { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City_Name { get; set; }
    }

    public class Table1
    {
        public int Broker_ID { get; set; }
        public string Broker_Name { get; set; }
        public string ARN { get; set; }
        public string Contact_person { get; set; }
        public object Mobile { get; set; }
        public object Email { get; set; }
        public object Address { get; set; }
    }

    public class MFPortfolio
    {
        public string Client_ID { get; set; }
        public string ISIN { get; set; }
        public string BSECODE { get; set; }
        public string Holding_type { get; set; }
        public string Name { get; set; }
        public string Fund { get; set; }
        public string Asset_Type { get; set; }
        public string Category { get; set; }
        public string Sub_Category { get; set; }
        public string Amc_Code { get; set; }
        public string First_Trxn_Date { get; set; }
        public string Avg_Cost { get; set; }
        public string Cost_Value { get; set; }
        public string Latest_Nav { get; set; }
        public string Folio_No { get; set; }
        public string Scheme_Name { get; set; }
        public string Total_Amount { get; set; }
        public string Current_Invest_Amount { get; set; }
        public string Redeemed_Amount { get; set; }
        public string Profit_Booked { get; set; }
        public string Present_Units { get; set; }
        public string Units { get; set; }
        public string Present_NAV { get; set; }
        public string Present_Value { get; set; }
        public string Dividend_Reinvested { get; set; }
        public string Dividend_Paid_out { get; set; }
        public string Notional_GL { get; set; }
        public string NetGain { get; set; }
        public string Abs_Returns { get; set; }
        public string XIRR_Ann_Returns { get; set; }
        public string Wght_Avg_Days { get; set; }
        public string Scheme_Code { get; set; }
        public string NAV_Date { get; set; }
        public string Weighted_Abs_Amt { get; set; }
        public string srno { get; set; }
        public string RMSLClientID { get; set; }
    }


    //public class ParentMFPortFolio
    //{
    //    public List<MFPortfolio> Table { get; set; }
    //}


    //public class MFPortfolio
    //{
    //    public string Client_ID { get; set; }
    //    public string Name { get; set; }
    //    public string AMFI_CODE { get; set; }
    //    public string Holding_Type { get; set; }
    //    public string SCHEMECODE { get; set; }
    //    public string AMC_CODE { get; set; }
    //    public string Fund { get; set; }
    //    public string S_Name { get; set; }
    //    public string ISIN { get; set; }
    //    public string BSESchemeCode { get; set; }
    //    public string Product_Code { get; set; }
    //    public string category { get; set; }
    //    public string ASSET_TYPE { get; set; }
    //    public string Folio_Number { get; set; }
    //    public string Latest_NAV { get; set; }
    //    public string Latest_Nav_Date { get; set; }
    //    public string Sch_Folio_Unitbal { get; set; }
    //    public string Present_Value { get; set; }
    //    public string Profit_Booked { get; set; }
    //    public string Present_Units { get; set; }
    //    public string INVST_COST { get; set; }
    //    public string Curr_INVST_COST { get; set; }
    //    public string Dividend { get; set; }
    //    public string Dividend_RInvst_AMT { get; set; }
    //    public string Gain_Loss { get; set; }
    //    public string Days { get; set; }
    //    public string WtdDays { get; set; }
    //    public string Absolute_Return { get; set; }
    //    public string SimpleAnnulisedResults { get; set; }
    //    public string CAGR { get; set; }
    //    public string NetGain { get; set; }
    //    public string sw_CurrentValue { get; set; }
    //    public string sw_CostValue { get; set; }
    //    public string sw_Amount { get; set; }
    //    public string sw_Dividend { get; set; }
    //    public string sw_DivReINVST_Amount { get; set; }
    //    public string sw_WedAvgDays { get; set; }
    //    public string sw_Profit_Booked { get; set; }
    //    public string sw_Notional_ProfitLoss { get; set; }
    //    public string sw_AbsReturn { get; set; }
    //    public string sw_AnnulResults { get; set; }
    //    public string sw_CAGR { get; set; }
    //    public string sw_NetGain { get; set; }
    //}


    //LI

    public class ParentLIPortfolio
    {
        public List<LIPortfolio> Table { get; set; }
    }
    public class LIPortfolio
    {
        public string BranchName { get; set; }
        public string EmployeeName { get; set; }
        public string AgentName { get; set; }
        public string ClientName { get; set; }
        public string ClientPAN { get; set; }
        public string CompanyName { get; set; }
        public string Type { get; set; }
        public string PolicyNo { get; set; }
        public string ApplicationDate { get; set; }
        public string Term { get; set; }
        public string PaymentMode { get; set; }
        public float PremiumAmount { get; set; }
        public string INSName { get; set; }
        public string MaturityDate { get; set; }
        public string Status { get; set; }
    }

    //FD
    public class ParentFDPortfolio
    {
        public List<FDPortfolio> Table { get; set; }
        public FDPortfolioTotalRows[] Table1 { get; set; }
    }
    public class FDPortfolio
    {
        public string rowId { get; set; }
        public string Userid { get; set; }
        public string SchemeName { get; set; }
        public string Qtn { get; set; }
        public string MktPrice { get; set; }
        public string gainloss { get; set; }
        public string InvDate { get; set; }
        public string Valuation { get; set; }
        public string Val_Date { get; set; }
        public string Mat_Date { get; set; }
        public string Application_No { get; set; }
        public string InstrName { get; set; }
        public string CostValue { get; set; }
        public string Mkt_Value { get; set; }
        public float AbsPer { get; set; }
        public float Cagr { get; set; }
        public float IntRate { get; set; }
        public string Duration { get; set; }
        public string DepositType { get; set; }
        public float TotalAllocation { get; set; }
        public string MaturityValue { get; set; }
        public float IntPayoutEarn { get; set; }
        public string YTM { get; set; }
    }
    public class FDPortfolioTotalRows
    {
        public int TotalRows { get; set; }
    }

    //Bonds
    public class ParentBondsPortfolio
    {
        public List<BondsPortfolio> Table { get; set; }
    }
    public class BondsPortfolio
    {
        public string BranchName { get; set; }
        public string EmployeeName { get; set; }
        public string AgentName { get; set; }
        public string ClientName { get; set; }
        public string ClientPAN { get; set; }
        public string CompanyName { get; set; }
        public string SchemeName { get; set; }
        public string ApplicationNo { get; set; }
        public string ApplicationType { get; set; }
        public string ChequeNo { get; set; }
        public string NoOfBonds { get; set; }
        public string Amount { get; set; }
        public string Duration { get; set; }
        public float InterestRate { get; set; }
        public string DepositType { get; set; }
        public string InterestFrequency { get; set; }
        public string MaturityDate { get; set; }
        public string FDStatus { get; set; }
    }

    //Others
    public class ParentOtherProductsPortfolio
    {
        public List<OtherProductsPortfolio> Table { get; set; }
    }
    public class OtherProductsPortfolio
    {
        public string ClientName { get; set; }
        public string ClientPAN { get; set; }
        public string CategoryName { get; set; }
        public string SubCategoryName { get; set; }
        public string ProductName { get; set; }
        public string Units { get; set; }
        public string ApplicationNo { get; set; }
        public string Amount { get; set; }
        public string PartnerCode { get; set; }
        public string Status { get; set; }
    }


    public class MFPortfolio_ETF
    {
        public string Client_ID { get; set; }
        public string ISIN { get; set; }
        public string BSECODE { get; set; }
        public string Holding_type { get; set; }
        public string Name { get; set; }
        public string Fund { get; set; }
        public string Asset_Type { get; set; }
        public string Category { get; set; }
        public string Sub_Category { get; set; }
        public string Amc_Code { get; set; }
        public string First_Trxn_Date { get; set; }
        public string Avg_Cost { get; set; }
        public string Cost_Value { get; set; }
        public string Latest_Nav { get; set; }
        public string Folio_No { get; set; }
        public string Scheme_Name { get; set; }
        public string Total_Amount { get; set; }
        public string Current_Invest_Amount { get; set; }
        public string Redeemed_Amount { get; set; }
        public string Profit_Booked { get; set; }
        public string Present_Units { get; set; }
        public string Units { get; set; }
        public string Present_NAV { get; set; }
        public string Present_Value { get; set; }
        public string Dividend_Reinvested { get; set; }
        public string Dividend_Paid_out { get; set; }
        public string Notional_GL { get; set; }
        public string NetGain { get; set; }
        public string Abs_Returns { get; set; }
        public string XIRR_Ann_Returns { get; set; }
        public string Wght_Avg_Days { get; set; }
        public string Scheme_Code { get; set; }
        public string NAV_Date { get; set; }
        public string Weighted_Abs_Amt { get; set; }
        public string srno { get; set; }
        public string RMSLClientID { get; set; }
        public string CODE { get; set; }
        public string SCRIPCODE { get; set; }
        public string NSESYMBOL { get; set; }
        public string Nsetradingsymbol { get; set; }
        public string OmneNSESymbol { get; set; }
        public string Bsetradingsymbol { get; set; }
        public string OmneBSESymbol { get; set; }
        public string NSEToken { get; set; }
        public string BSEToken { get; set; }
        public string Status { get; set; }
        public string isNSE { get; set; }
        public string isBSE { get; set; }
        public string FundName { get; set; }
        public string SchemeCode { get; set; }
        public string NseTicksize { get; set; }
        public string BseTicksize { get; set; }
    }


    #region class portfolio bol start
    public class classportofolioresponce
    {
        public string PARTY_CODE { get; set; }
        public string GROUP_CODE { get; set; }
        public string SUB_GROUP_CODE { get; set; }
        public string OPEN_INVESTMENT_VALUE { get; set; }
        public string OPEN_MARKET_VALUE { get; set; }
        public string UNREALISED_GAIN { get; set; }
        public string UNREALISED_GAINPercent { get; set; }
        public string CLOSE_BUY_VALUE { get; set; }
        public string CLOSE_SELL_VALUE { get; set; }
        public string REALISED_GAIN { get; set; }
        public string REALISED_GAINPercent { get; set; }
        public string ASSET_CATEGORY_WEIGHTAGE { get; set; }
        public string CALLNAME { get; set; }

    }

    public class derivativeclassportfolio
        {


            public string INST_TYPE { get; set; }
            public string SYMBOL { get; set; }
            public string EXPIRYDATE { get; set; }
            public double STRIKE_PRICE { get; set; }
            public string OPTION_TYPE { get; set; }
            public double SPEC_AMT { get; set; }
            public double SHORT_AMT { get; set; }
            public double QTY { get; set; }
            public double VALUE { get; set; }
            public double UNREL_PNL { get; set; }
            public double NETRATE { get; set; }
            public double CL_RATE { get; set; }
            public string PARTY_CODE { get; set; }

        }

        public class commodityclassportfolio
        {
            public string INST_TYPE { get; set; }
            public string SYMBOL { get; set; }
            public string EXPIRYDATE { get; set; }
            public double STRIKE_PRICE { get; set; }
            public string OPTION_TYPE { get; set; }
            public double SPEC_AMT { get; set; }
            public double SHORT_AMT { get; set; }
            public double QTY { get; set; }
            public double VALUE { get; set; }
            public double UNREL_PNL { get; set; }
            public double NETRATE { get; set; }
            public double CL_RATE { get; set; }
            public string PARTY_CODE { get; set; }

        }

        public class transactionportfolio
        {
            public string TRANS_DATE { get; set; }
            public string INST_TYPE { get; set; }
            public string TRANS_TYPE { get; set; }
            public double TRANS_QTY { get; set; }
            public double TRANS_RATE { get; set; }
            public double TRANS_VALUE { get; set; }

            //public string SEM_EXCH_SECURITY_ID { get; set; }
            public string SYMBOL { get; set; }
            public string EXPIRYDATE { get; set; }
            public string STRIKE_PRICE { get; set; }
            public string OPTION_TYPE { get; set; }
            public double BUYQTY { get; set; }
            public double BUYRATE { get; set; }
            public double BUYVALUE { get; set; }
            public double SELLQTY { get; set; }
            public double SELLRATE { get; set; }
            public double SELLVALUE { get; set; }
            public double SPECULATION_GAIN_LOSS { get; set; }
            public double SHORT_TERM_GAIN_LOSS { get; set; }
            public double NETQTY { get; set; }
            public double NETRATE { get; set; }
            public double NETVALUE { get; set; }
            public double CL_RATE { get; set; }
            public double UNREALISED_GAIN_LOSS { get; set; }
            public string LONG_NAME { get; set; }
            public string L_ADDRESS1 { get; set; }
            public string L_ADDRESS2 { get; set; }
            public string L_ADDRESS3 { get; set; }
            public string L_CITY { get; set; }
            public string L_STATE { get; set; }
            public string L_NATION { get; set; }
            public string L_ZIP { get; set; }
            public string REL_MGR { get; set; }
            public string RELMGRNAME { get; set; }
            public string PARTY_CODE { get; set; }
            public string SCRIP_NAME { get; set; }
            public string yy { get; set; }
            public string mm { get; set; }
            public string dd { get; set; }
        }



   
    #endregion

}
