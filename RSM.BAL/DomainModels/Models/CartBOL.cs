using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RSM.BAL.DomainModels.Models
{
    public class CartBOL
    {
        public Guid Id { get; set; }
        public int AssetCat { get; set; }
        public Int32 Scripcode { get; set; }
        public Int16 Quantity { get; set; }
        public Guid Username { get; set; }
        public DateTime AddedDate { get; set; }
    }
    public class StockCart
    {
        public string Id { get; set; }
        public string Code { get; set; }

        public int AssetCategory { get; set; }
        public int Fincode { get; set; }
        public string Exchange { get; set; }
        public string ScripName { get; set; }
        public int Quantity { get; set; }
        public double LTP { get; set; }
        public double ChangePrice { get; set; }
        public double PercentChange { get; set; }
        public double Amount { get; set; }
        public DateTime AddedDate { get; set; }
        public double OrderValue { get; set; }
        public int DisclosedQty { get; set; }
        public string OrderType { get; set; }
        public string ProductType { get; set; }
        public string Validity { get; set; }
        public double LimitPrice { get; set; }
        public double TriggerPrice { get; set; }
        public string Nsetradingsymbol { get; set; }
        public string OmneNSESymbol { get; set; }
        public string Bsetradingsymbol { get; set; }
        public string OmneBSESymbol { get; set; }
        public double NseTicksize { get; set; }
        public double BseTicksize { get; set; }
        public string NSEToken { get; set; }
        public string BSEToken { get; set; }
        public string PriceType { get; set; }
    }
    public class StockBasketCart
    {
        public string id { get; set; }
        public int quantity { get; set; }
        public decimal Total { get; set; }
        public string Title { get; set; }
        public string exchange { get; set; }
        public int fincode { get; set; }
    }
    public class MFBasketCart
    {
        public string id { get; set; }
        public int Funds { get; set; }
        public decimal Total { get; set; }
        public string Title { get; set; }
    }
    public class MFCart
    {
        public string Id { get; set; }
        public int SchemeCode { get; set; }
        public string SchemeName { get; set; }
        public decimal Nav { get; set; }
        public int MinInv { get; set; }
        public int VRO { get; set; }
        public decimal change { get; set; }
        public decimal perchange { get; set; }
        public string NAVDATE { get; set; }
        public string amccode { get; set; }
        public int SchemeType { get; set; }
        public string DividendOption { get; set; }
        public string MfUnit { get; set; }
        public string FolioNumber { get; set; }
        public string Amount { get; set; }
        public string PURALLOWED { get; set; }
        public string SIPFLAG { get; set; }
        public int FUND_RATING { get; set; }
    }
  
    public class GetCartCount
    {
        public int Count { get; set; }
    }
}
