namespace RSM.BAL.DomainModels.Models
{
    public enum AssetCategory
    {
        Stock = 1,
        Mutual_Fund = 2,
        Basket = 3,

    }
    public enum Carts
    {
        stockcart,
        mfcart,
        stockbasketcart,
        mfbasketcart
    }

    public enum CacheKeys
    {
        None = 0,
        Stocks,
        MutualFunds,
        StocksDataPointConfiguration,
        MutualFundsDataPointsConfiguration,
        MostBoughtStocks,
        StockManualComponent,
        StockList,
        RulebasedComponent,
        MFList,
        Blog,
        TM,
        FAQ,
        PredefinedComponent,
        stocksforsip,
        buzzingstocks,
        bluechipstocks,
        lastyearcenturion,
        NFO,
        MF_ISIN_SCHEMECODE_MAPPING,
        Stockbasket,
        Mfbasket,
        ResearchReport,
        StocksBroad,
        StockListBroad,
        StocksBroadDelay,
        StockListBroadDelay

    }

    public enum ComponentType
    {
        Manual = 1,
        RuleBased = 2,
        PreDefined = 3,
        Profile = 4
    }

    public enum ConnectionStringKeys
    {
        RsecConfig,
        BranchLocatorNew, // new branch locator
        SQLErrorLog,
        RsecAccord,
        VRORating,
        BlinkEndpoint,
        OmnesysEndpoint,
        Excel2003,
        Excel2007,
        BSEStarMFEndpoint,
        UatRsecAccord,
        LeadSource,
        RELMONEY,
        ResearchReportsURL,
        CoachScreenExpiry,
        RelianceETF,
        BackOfficeReport,
        ConsentReport,
        SignupPopuprepeatSeq,
        SignupPopuprepeatTime,
        PNLReports,
        CasheEndPoint,
        MktPms2014,
        Analytical,
        OmnesysLimit,
        cuttofftime,
        ClassPortfolio,
        islogprint,
  
        CreateLeadUrlThirdPartyProject, // Added by Arti For lead push in Third party project Menipal & liberty general 20201111
        UpdateLeadUrlThirdPartyProject // Added by Arti For lead push in Third party project Menipal & liberty general 20201111

        
    }
    public enum NetcoreSMSAPI
    {
        NetcoreSMSAPIEndpoint,
        NetcoreFeedId,
        NetcoreUsername,
        NetcorePassword
    }
    public enum NetcoreEmailAPI
    {
        NetcoreEmailAPIUrl,
        NetcoreEmailAPIKey
    }

    public enum TrendingProducts
    {
        TrendProductFileContent,
        TrendProductLimitBlock
    }

    public enum BuyBackConnectionURL
    {
        BuyBackAlterURL,
        BuyBackQtyURL,
        BuyBackReduceURL,
        BuyBackIncreaseURL,
        BuyBackDecreaseURL

    }

    public enum ETFConnectionURL
    {
        ETFBLOCKURL,
        ETFUNBLOCKURL

    }



}
