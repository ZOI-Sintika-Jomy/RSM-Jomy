using System;
using System.Collections.Generic;

namespace RSM.BAL.DomainModels.Models
{
    public class Documents
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
        public string Extension { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }


    public class TrainingMaterial
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string PublishedOn { get { return PublicationDate.ToString("dd MMM, yyyy"); } }
        public string Description { get; set; }
        public List<string> Tags { get; set; }
        public string PMAudio { get; set; }
        public string PMVideo { get; set; }
        public string PMPdf { get; set; }
        public string Thumbnail { get; set; }
        public List<Documents> Media { get; set; }
        public string Owner { get; set; }
        public DateTime PublicationDate { get; set; }
        public string UrlName { get; set; }
        public int listcount { get; set; }
        public DateTime CreationDate { get; set; }
        public string strCreationDate { get { return CreationDate.ToString("dd MMM, yyyy"); } }

    }

    public class NewsLetter {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string DownloadPDF { get; set; }
        public DateTime PublicationDate { get; set; }
        public string PublishedOn { get { return PublicationDate.ToString("dd MMM, yyyy"); } }

        public DateTime DateCreated { get; set; }
        public string Date { get { return DateCreated.ToString("dd MMM, yyyy"); } }
    }

    // og working
    //public class ResearchReports
    //{
    //    public Guid ID { get; set; }
    //    public string ReportType { get; set; }
    //    public string DocumentName { get; set; }
    //    public string Synopsis { get; set; }
    //    public string Symbol { get; set; }
    //    public string Sector { get; set; }
    //    public string PublishedOn { get { return PublishedDate.ToString("dd MMM yyyy"); } }
    //    public DateTime PublishedDate { get; set; }
    //    public string UrlName { get; set; }

    //    public List<string> Tags { get; set; }
    //    public Documents DownloadableItem { get; set; }
    //    public string Owner { get; set; }
    //    public DateTime PublicationDate { get; set; }
    //}


    // new arti
    public class ResearchReports
    {
        public Guid ID { get; set; }
        public string ReportType { get; set; }
        public string DocumentName { get; set; }
        public string Synopsis { get; set; }
        public string Symbol { get; set; }
        public string Sector { get; set; }
        public string PublishedOn { get { return PublishedDate.ToString("dd MMM yyyy"); } }
        public DateTime PublishedDate { get; set; }
        public string UrlName { get; set; }

        public List<string> Tags { get; set; }
        public Documents DownloadableItem { get; set; }
        public string Owner { get; set; }
        public DateTime PublicationDate { get; set; }
        public string UploadContent { get; set; }
    }

    public class Archivemedia  // Added by Baburav 20201218 For Archive Media
    {

        public string ArticleName { get; set; }
        public string ActiveCheck { get; set; }
        public DateTime PublishedOn { get; set; }
        public string UploadContent { get; set; }
        public string Title { get; set; }
    }



    public class CustomerQueries
    {
        public string ClientID { get; set; }
        public string Subject { get; set; }
        public string ClientName { get; set; }
        public string MobileNumber { get; set; }
        public string EmailID { get; set; }
        public string Comments { get; set; }
        public string UrlName { get; set; }
        public DateTime PublicationDate { get; set; }
    }


    public class CustomerSuggestions
    {
        public string ImproveService { get; set; }
        public string QRCNumber { get; set; }
        public string ReplyDated { get; set; }
        public string ClientID { get; set; }
        public string EmailID { get; set; }
        public string MobileNumber { get; set; }
        public string AdequateResolutionTime { get; set; }
        public string ResolutionProvided { get; set; }
        public string HelpfulExecutive { get; set; }
        public string Comments { get; set; }
        public string UrlName { get; set; }
        public DateTime PublicationDate { get; set; }
    }

    public class BlogPosts
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public string DateAdded { get { return PublicationDate.ToString("MMM dd yyyy"); } }
        public DateTime PublicationDate { get; set; }
        public string ListImage { get; set; }

        public string DetailImage { get; set; }
        public string Audio { get; set; }
        public string Video { get; set; }
        public string Documents { get; set; }
        public string Owner { get; set; }
        public List<string> Tags { get; set; }


    }

    public class MasterBlogInfo
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Summary { get; set; }

        public string ListPageImage { get; set; }

        public string DetailImage { get; set; }

        public string Tags { get; set; }

        public string blogAudio { get; set; }

        public string blogVideo { get; set; }

        public string blogPDF { get; set; }

        public DateTime PublicationDate { get; set; }

        public string strPublicationDate { get { return PublicationDate.ToString("dd MMM, yyyy"); } }

        public string Author { get; set; }

        public string Content { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime LastModified { get; set; }
        public Guid LastModifiedBy { get; set; }

        public string SystemUrl { get; set; }
        public string UrlName { get; set; }

        public string ProductCategory { get; set; }

        public List<string> lstTags { get; set; }
    }

    public class MasterAwardsInfo
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Summary { get; set; }

        public string ListPageImage { get; set; }

        public string DetailImage { get; set; }

        public string Tags { get; set; }

        

        public DateTime PublicationDate { get; set; }

        public string strPublicationDate { get { return PublicationDate.ToString("dd MMM, yyyy"); } }

        

        public string Content { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime LastModified { get; set; }
        public Guid LastModifiedBy { get; set; }

        public string SystemUrl { get; set; }
        public string UrlName { get; set; }

        
    }

    public class MasterPressInfo
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Summary { get; set; }

        public string ListPageImage { get; set; }

        public string DetailImage { get; set; }

        public string Tags { get; set; }


        public string pressAudio { get; set; }

        public string pressVideo { get; set; }

        public string pressPDF { get; set; }

        public DateTime PublicationDate { get; set; }

        public string strPublicationDate { get { return PublicationDate.ToString("dd MMM, yyyy"); } }



        public string Content { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime LastModified { get; set; }
        public Guid LastModifiedBy { get; set; }

        public string SystemUrl { get; set; }
        public string UrlName { get; set; }


    }

    public class MasterVideoInfo
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Summary { get; set; }

        public string ListPageImage { get; set; }

        public string DetailImage { get; set; }

        public string Tags { get; set; }


        public string Audio { get; set; }

        public string Video { get; set; }

        public string PDF { get; set; }

        public DateTime PublicationDate { get; set; }

        public string strPublicationDate { get { return PublicationDate.ToString("dd MMM, yyyy"); } }



        public string Content { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime LastModified { get; set; }
        public Guid LastModifiedBy { get; set; }

        public string SystemUrl { get; set; }
        public string UrlName { get; set; }
        public List<string> Category { get; set; }


    }

    public class MasterGalleryInfo
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Summary { get; set; }

        public string ListPageImage { get; set; }

        public string DetailImage { get; set; }

        public string Tags { get; set; }



        public DateTime PublicationDate { get; set; }

        public string strPublicationDate { get { return PublicationDate.ToString("dd MMM, yyyy"); } }



        public string Content { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime LastModified { get; set; }
        public Guid LastModifiedBy { get; set; }

        public string SystemUrl { get; set; }
        public string UrlName { get; set; }


    }

    public class FAQBlog
    {
        public string Title { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }

        public string Tags { get; set; }

        public List<string> lstTags { get; set; }

        public string Category { get; set; }


    }

    public class CustomerCareBlogInfo
    {
        public string Title { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }

        public string Tags { get; set; }

        public DateTime PublishedDate { get; set; }
        public string Category { get; set; }
        public DateTime LastModified { get; set; }

    }

    public class MoreProducts
    {
        public string Title { get; set; }
        public string Tags { get; set; }
        public string SelectCategory { get; set; }
        public string ProductName { get; set; }
        public string Productcode { get; set; }
        public string ManaufacturerName { get; set; }
        public string Creationdate { get; set; }
        public string ActiveDeactiveflag { get; set; }
        public string TransactionType { get; set; }
        public string RedirectURL { get; set; }
        public string LogoImage { get; set; }
    }


    public class InsuranceTypes
    {
        public string InsuranceID { get; set; }
        public string Title { get; set; }
        public string ManufacturerName { get; set; }

        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public string CreationDate { get; set; }

        public string PublishedDate { get; set; }
        public string Flag { get; set; }

        public string TransactionType { get; set; }
        public string RedirectURL { get; set; }
        public string LogoImage { get; set; }

        public string Premium { get; set; }
        public int Tenure { get; set; }
        public string ClaimsSettlement { get; set; }
        public string Benefits { get; set; }
        public string InsuranceType { get; set; }

        public string ZeroDepreciation{get;set;}
        public string RoadSideAssistance { get; set; }
        public string NoClaimBonusProtection { get; set; }
        public int InsuredDeclaredValue { get; set; }
        public string Features { get; set; }
    
        public string DetailURL { get; set; }
        public string InfoText { get; set; }

    }

    public class BondList
    {
        public Int32 Type { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public Int32 Category { get; set; }
        public string Scheme { get; set; }
        public Int32 FaceValue { get; set; }
        public string ISIN { get; set; }
        public Int32 DepositeType { get; set; }
        public Int32 YieldOnMaturity { get; set; }
        public Int32 InterestDetails_Type { get; set; }
        public Int32 InterestRate { get; set; }
        public Int32 InterestFrequency { get; set; }
        public string Tags { get; set; }
    }


    public class Webinar
    {
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string EventType { get; set; }
        public string ScheduleFromDate { get; set; }
        public string ScheduleToDate { get; set; }
        public string Duration { get; set; }
        public string Location { get; set; }

        public string ShortImage { get; set; }
        public string BigImage { get; set; }

        public string Url { get; set; }
    }



    public class CDFList
    {
        public string ViewDetailURL { get; set; }
        public string TransactionType { get; set; }
        public string Title { get; set; }
        public string Tenure { get; set; }
        public string SROI { get; set; }
        public string RelatedInfo { get; set; }
        public string RedirectURL { get; set; }
        public string Ratingtooltip { get; set; }
        public string Ratingby { get; set; }
        public string Rating { get; set; }
        public string ROI { get; set; }
        public string ProductCode { get; set; }
        public string Priority { get; set; }
        public string MinInvestmentAmt { get; set; }
        public string MaxInvestmentAmt { get; set; }
        public string ManufacurerCode { get; set; }
        public string ManufacturerLogo { get; set; }
        public string IsCumulative { get; set; }
        public string IsActive { get; set; }
        public string InterestFrequency { get; set; }
        public string Grouping { get; set; }
        public string CreationDate { get; set; }
        public string Isrecommended { get; set; }
        public string Manufacturer { get; set; }
        public string Maturity_Amt_Cal { get; set; }
    }


    public class ConsentList
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Date { get; set; }
        public string formatdesc { get; set; }

    }


    public class LocateUs
    {
        public string Title { get; set; }

        public string BranchName { get; set; }

        public string Region { get; set; }

        public string BranchCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public string Address { get; set; }
        public string IsDealing { get; set; }


        public string Active { get; set; }
        public string EntryOn { get; set; }
        public string EntryBy { get; set; }
        public string ModifyOn { get; set; }

        public string ModifyBy { get; set; }
        public string LOB { get; set; }

        public string Latitude { get; set; }
        public string Longitude { get; set; }

    }

    public class GetSGB
    {
        public string base_id { get; set; }

        public string TransactionType { get; set; }

        public string Title { get; set; }

        public string SBGStatus { get; set; }
        public string RedirectURL { get; set; }
        public string ROI { get; set; }

        public string ProductCode { get; set; }
        public string Priority { get; set; }


        public string Price { get; set; }
        public string MinQty { get; set; }
        public string MaxQty { get; set; }
        public string ManufacrurerName { get; set; }

        public string MKTComment { get; set; }
        public string IsActive { get; set; }

        public string Discount { get; set; }
        public string CreationDateTime { get; set; }



        public string ClosingDateTime { get; set; }
        public string ChequeNo { get; set; }
        public string Benifits { get; set; }
        public string ApplicationNo { get; set; }
        public string QtyMultiple { get; set; }
        public string RN { get; set; }
        public string cutoffFlag { get; set; }
        public string BankName { get; set; }
        public string Motif { get; set; }
        






    }

    public class GetBuyBack
    {
        public string Title { get; set; }
        public string ProductCode { get; set; }
        public string ManufacrurerName { get; set; }
        public string OpeningDateTime { get; set; }
        public string ClosingDateTime { get; set; }
        public string ListingDateTime { get; set; }
        public string IsActive { get; set; }
        public string Priority { get; set; }
        public string TransactionType { get; set; }
        public string DetailPageURL { get; set; }
        public string Recommended { get; set; }
        public string MKTComment { get; set; }
        public string LogoImgName { get; set; }
        public string minimumQty { get; set; }
        public string MaximumQty { get; set; }
        public string LotSize { get; set; }
        public string ClientCategory { get; set; }
        public string InvestmentAmt { get; set; }
        public string Price { get; set; }
        public string Exchange { get; set; }
        public string ISIN { get; set; }

    }











    public class JobDescriptionBOL
    {
        public string Title { get; set; }

        public string Designation { get; set; }
        public string Experience { get; set; }

        public string Business { get; set; }
        public string ReportingAuthority { get; set; }
        public string Spanofcontrol { get; set; }

        public string Qualification { get; set; }

        public string SkillsandCompetencies { get; set; }

        public string Duties { get; set; }

        public DateTime CreationDate { get; set; }

        public string Region { get; set; }
        public string City { get; set; }
    }

    public class MediaCenterVideos
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public string Image1 { get; set; }
        public string Description { get; set; }
        public string CreationDate { get; set; }
        public string Video { get; set; }
    }

    public class MediaCenterGallery
    {
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Content { get; set; }
        public string CreationDate { get; set; }
        public string ListPageImage { get; set; }
        public string DetailPageImage { get; set; }
        public string SlideShowImage { get; set; }
    }

    public class LogQuery
    {
        public string CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string FeedbackType { get; set; }
        public string SubjectValue { get; set; }
        public string SubjectTitle { get; set; }
        public string Comments { get; set; }
    }


    public class PageList
    {
        public string pageTitle { get; set; }
        public string pageURL { get; set; }
        public bool isGroupPage { get; set; }
        public bool isSiteMap { get; set; }
        public List<PageList> pageList { get; set; } 
    }

    public class LoanTypes
    {
        public string LoanName { get; set; }
        public string RedirectUrl { get; set; }
        public List<LoanInfo> LoanInfo { get; set; }
    }

    public class LoanInfo
    {

        public string LoanType { get; set; }

        public string Title { get; set; }
        public string InterestRateMinimum { get; set; }
        public string InterestRateMaximum { get; set; }
        public string ProcessingFees { get; set; }
        public string LoanTermMax { get; set; }
        public string LoanAmountMax { get; set; }
        public string ForeclosureCharge { get; set; }
        public string EMI { get; set; }
        public string TermsAndConditions { get; set; }

        public string MPID { get; set; }
        public string DetailPageUrl { get; set; }

        public string RedirectURL { get; set; }

        public string SEOTitle {get;set;}
        public string SEODescription { get; set; }
        public string SEOKeywords { get; set; }
        public string SEOH1 { get; set; }

        public string InterestPlan { get; set; }
        public string InterestRateText { get; set; }
        public string Column1Header { get; set; }
        public string Column1Text { get; set; }
        public string Column2Header { get; set; }
        public string Column2Text { get; set; }
        public string IsCashe { get; set; }

    }

    public class FundTransferDetails
    {
        public string bankaccountid { get; set; }
        public string accountId { get; set; }
        public string status { get; set; }
        public string bankname { get; set; }
        public string segment { get; set; }
        public double transactionamount { get; set; }
        public string remarks { get; set; }
        public string bankrefnumber { get; set; }
        public string customerReference { get; set; }
        public string product { get; set; }
        public string bankbranch { get; set; }
        public string instructiondatetime { get; set; }
        public double instructionnumber { get; set; }
        public string user { get; set; }
        public string requesttype { get; set; }
        public string modifycancel { get; set; }
    }

}
