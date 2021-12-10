using System;
using System.Collections.Generic;

namespace RSM.BAL.DomainModels.Models
{
    public class MutualFunds
    {
        /*
        public double TOKEN { get; set; }
        public string ISIN { get; set; }
        public string LEGALNAME { get; set; }
        public int SCHEMECODE { get; set; }
        public double NAVRS { get; set; }
        public double NETCHANGE { get; set; }
        public double PERCHANGE { get; set; }
        public double _1DAYRET { get; set; }
        public double _1WEEKRET { get; set; }
        public double _1MONTHRET { get; set; }
        public double _3MONTHRET { get; set; }
        public double _6MONTHRET { get; set; }
        public double _9MNTHRET { get; set; }
        public double _1YRRET { get; set; }
        public double _2YEARRET { get; set; }
        public double _3YEARRET { get; set; }
        public double _4YEARRET { get; set; }
        public double _5YRRET { get; set; }
        public double EXPRATIO { get; set; }
        public double INCRET { get; set; }
        public string FUND_MGR1 { get; set; }
        public string FUND_MGR2 { get; set; }
        public string FUND_MGR3 { get; set; }
        public string FUND_MGR4 { get; set; }
        public string SCHEMETYPE { get; set; }
        public string CATEGORY { get; set; }
        public string AMC { get; set; }
        public string FUND { get; set; }
        public string INCEPTIONDATE { get; set; }
        public int CLASSCODE { get; set; }
        public string S_NAME { get; set; }
        public double MININVT { get; set; }
        public double SUBSEQUENTINVESTMENT { get; set; }
        public int AMFI_CODE { get; set; }
        public int FUND_RATING { get; set; }
        public string RISK_GRADE { get; set; }
        public int RISK_RATING { get; set; }
        public int RANK { get; set; }
        public double AUM { get; set; }
        public string DPCOLUMNS { get; set; }
        public string DPTEXT { get; set; }
        public int RECOMMENDED { get; set; }
        public int ENTRYLOAD { get; set; }
        public int EXITLOAD { get; set; }
        public string RELATEDINFO { get; set; }
        public string STRSCHEMECODE { get; set; }
        public string AMC_CODE { get; set; }
        public string SCHEME_NAME { get; set; }
        public string PURCHASETRANSACTIONMODE { get; set; }
        public double MINPURAMT { get; set; }
        public double ADDPURAMTMUL { get; set; }
        public double MAXPURAMTMUL { get; set; }
        public string PURALLOWED { get; set; }
        public string PURCUTOFFTIME { get; set; }
        public string REDTRANMODE { get; set; }
        public double MINREDQTY { get; set; }
        public double REDQTYMUL { get; set; }
        public double MAXREDQTY { get; set; }
        public string REDALLOWED { get; set; }
        public string REDCUTOFFTIME { get; set; }
        public string RNTAGENTCODE { get; set; }
        public double AMCACTFLAG { get; set; }
        public string ISDIVIDEN { get; set; }
        public string DIVREFLAG { get; set; }
        public string ASSETTYPE { get; set; }
        public string SIPFLAG { get; set; }
        public string STPFLAG { get; set; }
        public string SWPFLAG { get; set; }
        public string SETTLEMENTTYPE { get; set; }
        public double PURAMOUNTMULT { get; set; }
        public double NAVVALUE { get; set; }
        public string NAVDATE { get; set; }
        public double ALLOTEDUNIT { get; set; }
        public double STARRATING { get; set; }
        public double NAVDIFFRENCE { get; set; }
        public double REDEMPTIONAMOUNTMINIMUM { get; set; }
        public double REDEMPTIONAMOUNTMAXIMUM { get; set; }
        public double REDEMPTIONAMOUNTMULTIPLE { get; set; }
        public string BENCHMARK { get; set; }
        public string ASSETALLOCATION { get; set; }
        public double _1MONTHRETMAX { get; set; }
        public double _3MONTHRETMAX { get; set; }
        public double _6MONTHRETMAX { get; set; }
        public double _1YRRETMAX { get; set; }
        public double _3YEARRETMAX { get; set; }
        public double _5YRRETMAX { get; set; }
        public string MOTIFHTML { get; set; }
        public string AMCCODE { get; set; }
        */

        public double _1DAYRET { get; set; }
        public double _1MONTHRET { get; set; }
        public double _1MONTHRETMAX { get; set; }
        public double _1WEEKRET { get; set; }
        public double _1YRRET { get; set; }
        public double _1YRRETMAX { get; set; }
        public double _2YEARRET { get; set; }
        public double _3MONTHRET { get; set; }
        public double _3MONTHRETMAX { get; set; }
        public double _3YEARRET { get; set; }
        public double _3YEARRETMAX { get; set; }
        public double _4YEARRET { get; set; }
        public double _5YRRET { get; set; }
        public double _5YRRETMAX { get; set; }
        public double _6MONTHRET { get; set; }
        public double _6MONTHRETMAX { get; set; }
        public double _9MNTHRET { get; set; }
        public string AMC { get; set; }
        public int AMC_CODE { get; set; }
        public string AMCCODE { get; set; }
        public int AMFI_CODE { get; set; }
        public int ASSETCODE { get; set; }
        public string ASSETTYPE { get; set; }
        public double AUM { get; set; }
        public string CATEGORY { get; set; }
        public string CATEGORY_NAME { get; set; }
        public int CLASSCODE { get; set; }
        public int DIV_FREQ { get; set; }
        public string DIV_TYPE { get; set; }
        public string DPCOLUMNS { get; set; }
        public string DPTEXT { get; set; }
        public string ETF { get; set; }
        public double EXPRATIO { get; set; }
        public string FUND { get; set; }
        public string FUND_MGR1 { get; set; }
        public string FUND_MGR2 { get; set; }
        public string FUND_MGR3 { get; set; }
        public string FUND_MGR4 { get; set; }
        public int FUND_RATING { get; set; }
        public DateTime INCEPTIONDATE { get; set; }
        public double INCRET { get; set; }
        public string LEGALNAME { get; set; }
        public string LOCKIN { get; set; }
        public string LOCKPERIOD { get; set; }
        public double MININVT { get; set; }
        public double SIPMININVEST { get; set; }
        public string MOTIFHTML { get; set; }
        public DateTime NAVDATE { get; set; }
        public double NAVRS { get; set; }
        public double NETCHANGE { get; set; }
        public int OPT_CODE { get; set; }
        public double PERCHANGE { get; set; }
        public int PLAN { get; set; }
        public int PRIMARY_FD_CODE { get; set; }
        public string PRIMARY_FUND { get; set; }
        public int RANK { get; set; }
        public int RECOMMENDED { get; set; }
        public string RELATEDINFO { get; set; }
        public string RISK_GRADE { get; set; }
        public int RISK_RATING { get; set; }
        public string S_NAME { get; set; }
        public string SCHEME_NAME { get; set; }
        public int SCHEMECODE { get; set; }
        public string SCHEMETYPE { get; set; }
        public double SUBSEQUENTINVESTMENT { get; set; }
        public string NFO_OPEN { get; set; }
        public string NFO_CLOSE { get; set; }
        public string DEFAULTPLAN { get; set; }
        public string DEFAULTOPT { get; set; }

        public string OPTION
        {
            get
            {
                return DEFAULTOPT == "Dividend Payout" ? "DP" : "DR";
            }
        }
        public string PURALLOWED { get; set; }
        public string REDALLOWED { get; set; }
        public string SIPFLAG { get; set; }
        public string STPFLAG { get; set; }
        public string SWPFLAG { get; set; }
        public string SwitchFLAG { get; set; }
    }
    public class MFCategoryWiseDP
    {
        public string Categories { get; set; }
    }

    public class MutualFundBasket
    {
        public Guid BasketId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int TotalSchemes { get; set; }
        public decimal MinAmt { get; set; }
        public decimal ReturnPercent { get; set; }
        public string ImageToBind { get; set; }
        public bool isRecommended { get; set; }
        public DateTime AddedDate { get; set; }
        // newly added by arti
        public string PdfToBind { get; set; }
        public string SubDescriptionToBind { get; set; }
        public decimal ReturnValuePercent { get; set; }
        //Added by Arti To sort Maxreturn 
        public decimal MaxReturn { get; set; }
        // public decimal ReturnYears { get; set; }
        public string ReturnYearsText { get; set; }
        //End

    }

    public class MFScreenervalues
    {
        public string MinNav { get; set; }
        public string MinChange { get; set; }
        public string MinPerChange { get; set; }
        public string MinInvestment { get; set; }
        public string MinAUM { get; set; }
        public string MinVRORating { get; set; }
        public string MinExitLoad { get; set; }
        public string Min1MonthReturns { get; set; }
        public string Min3MonthReturns { get; set; }
        public string Min6MonthReturns { get; set; }
        public string Min1YrReturns { get; set; }
        public string Min3YrReturns { get; set; }
        public string Min5YrReturns { get; set; }
        public string MinIncReturns { get; set; }
        public string MinRiskRating { get; set; }
        public string MinExpenseRatio { get; set; }

        public string MaxNav { get; set; }
        public string MaxChange { get; set; }
        public string MaxPerChange { get; set; }
        public string MaxInvestment { get; set; }
        public string MaxAUM { get; set; }
        public string MaxVRORating { get; set; }
        public string MaxExitLoad { get; set; }
        public string Max1MonthReturns { get; set; }
        public string Max3MonthReturns { get; set; }
        public string Max6MonthReturns { get; set; }
        public string Max1YrReturns { get; set; }
        public string Max3YrReturns { get; set; }
        public string Max5YrReturns { get; set; }
        public string MaxIncReturns { get; set; }
        public string MaxRiskRating { get; set; }
        public string MaxExpenseRatio { get; set; }


    }


    public class MutualFundDP
    {
        public static Dictionary<string, string> Columns
        {
            get
            {
                Dictionary<string, string> lst = new Dictionary<string, string>();
                lst.Add(value: "1 Month", key: "_1MONTHRET");
                lst.Add(value: "3 Month", key: "_3MONTHRET");
                lst.Add(value: "6 Month", key: "_6MONTHRET");
                lst.Add(value: "1 Year", key: "_1YRRET");
                lst.Add(value: "3 Years", key: "_3YEARRET");
                lst.Add(value: "5 Years", key: "_5YRRET");
                lst.Add(value: "Risk Profile", key: "RISK_GRADE");
                lst.Add(value: "Open ended / close Ended", key: "SCHEMETYPE");
                lst.Add(value: "AUM", key: "AUM");
                ///
                /// lst.Add(value: "NAV", key: "NAVRS");
                /// lst.Add(value: "Absolute Change", key: "NETCHANGE");
                /// lst.Add(value: "% change", key: "PERCHANGE");
                /// lst.Add(value: "Min investment", key: "MININVT");
                /// lst.Add(value: "Lockin period", key: "");
                /// lst.Add(value: "Growth & Dividend", key: "");
                /// lst.Add(value: "Benchmark Return %", key: "");
                /// lst.Add(value: "Category", key: "Category");
                /// lst.Add(value: "Subcategory", key: "");
                /// lst.Add(value: "Ratings", key: "FUND_RATING");
                /// lst.Add(value: "Entry Load", key: "EntryLoad");
                /// lst.Add(value: "Exit Load", key: "ExitLoad");
                return lst;
            }
        }
    }

    public class MFRuleBasedComponent
    {
        public Guid ComponentId { get; set; }
        public Guid CategoryId { get; set; }
        public Guid SubCategoryId { get; set; }
        public string ComponentName { get; set; }
        public string Description { get; set; }
        public int AMCId { get; set; }
        public Guid FundTypeId { get; set; }
        public Guid GrowthDivedentId { get; set; }
        public bool Status { get; set; }
        public string Nav_Low { get; set; }
        public string Change_Low { get; set; }
        public string PerChange_Low { get; set; }
        public string Investment_Low { get; set; }
        public string AUM_Low { get; set; }
        public string VRORating_Low { get; set; }
        public string ExitLoad_Low { get; set; }
        public string oneMonthReturns_Low { get; set; }
        public string threeMonthReturns_Low { get; set; }
        public string sixMonthReturns_Low { get; set; }
        public string oneYrReturns_Low { get; set; }
        public string threeYrReturns_Low { get; set; }
        public string fiveYrReturns_Low { get; set; }
        public string IncReturns_Low { get; set; }
        public string RiskRating_Low { get; set; }
        public string ExpenseRatio_Low { get; set; }
        public string Nav_High { get; set; }
        public string Change_High { get; set; }
        public string PerChange_High { get; set; }
        public string Investment_High { get; set; }
        public string AUM_High { get; set; }
        public string VRORating_High { get; set; }
        public string ExitLoad_High { get; set; }
        public string oneMonthReturns_High { get; set; }
        public string threeMonthReturns_High { get; set; }
        public string sixMonthReturns_High { get; set; }
        public string oneYrReturns_High { get; set; }
        public string threeYrReturns_High { get; set; }
        public string fiveYrReturns_High { get; set; }
        public string IncReturns_High { get; set; }
        public string RiskRating_High { get; set; }
        public string ExpenseRatio_High { get; set; }
        public string AddedBy { get; set; }
        public int Action { get; set; }
        public int classcode { get; set; }
        public float SECT_CODE { get; set; }
    }
}
