using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RSM.BAL.Models;

namespace RSM.BAL.DomainModels.Models
{
    [Table("tbl_Users")]
    public class User : Base
    {
        public User()
        {
            CreatedOn = DateTime.Now;
            DesignationList = new List<SelectListItem>();
            BusinessSegmentList = new List<SelectListItem>();
            BusinessSubSegmentList = new List<SelectListItem>();
            LDAPList = new List<SelectListItem>();
            ReportingList = new List<SelectListItem>();
            AdminReportingList = new List<SelectListItem>();

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }

        [NotMapped]
        public string UserHash { get; set; }

        [Display(Name = "First Name")]
        [RegularExpression("[A-Za-z0-9 ]*", ErrorMessage = "Invalid Firstname "), Required(ErrorMessage = "Enter First Name"), StringLength(500)]
        [Column(name: "FirstName", TypeName = "varchar(150)")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [RegularExpression("[A-Za-z0-9 ]*", ErrorMessage = "Invalid Lastname "), Required(ErrorMessage = "Enter Last Name"), StringLength(500)]
        [Column(name: "LastName", TypeName = "varchar(150)")]
        public string LastName { get; set; }

        [Display(Name = "Middle Name")]
        [RegularExpression("[A-Za-z0-9 ]*", ErrorMessage = "Invalid MiddleName "), StringLength(500)]
        [Column(name: "MiddleName", TypeName = "varchar(150)")]
        public string MiddleName { get; set; }


        [Display(Name = "User Name")]
        [RegularExpression("[A-Za-z0-9]*", ErrorMessage = "Invalid Username "), Required(ErrorMessage = "Enter User Name"), StringLength(150)]
        [Column(TypeName = "varchar(150)")]
        public string UserName { get; set; }

        [Display(Name = "")]
        [Column(TypeName = "varchar(150)")]
        //[AllowExtensions(Extensions = "png,jpg,jpeg", ErrorMessage = "Please select only Supported Files .png | .jpg")]
        public string UserImage { get; set; }

        [Display(Name = "Email ID")]
        [Required(ErrorMessage = "Enter Email ID")]
        [Column(TypeName = "varchar(150)")]
        [RegularExpression("^[A-Za-z0-9_\\+-]+(\\.[A-Za-z0-9_\\+-]+)*@[A-Za-z0-9-]+(\\.[A-Za-z0-9]+)*\\.([A-Za-z]{2,4})$", ErrorMessage = "Invalid Email ID format.")]
        public string Email { get; set; }

        [Display(Name = "User ID")]
        [RegularExpression("[A-Za-z0-9]*", ErrorMessage = "Invalid UserID "), Required(ErrorMessage = "Enter User ID"), StringLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string UserCode { get; set; }

        [Display(Name = "User Role")]
        [DefaultValue(4)]
        public int? UserRoleId { get; set; }

        [Display(Name = "Business Sub-Unit")]
        [Column("BusinessSubSegment")]
        [DefaultValue(1)]
        public int? BusinessSubSegment { get; set; }
        public List<SelectListItem> BusinessSubSegmentList { get; set; }

        [Display(Name = "Business Unit")]
        [Required(ErrorMessage = "Select Business Unit")]
        [Column("BusinessSegment")]
        public int? BusinessSegment { get; set; }
        public List<SelectListItem> BusinessSegmentList { get; set; }

        [Display(Name = "LDAP User Name")]
        [Column(TypeName = "varchar(50)")]
        public string LDAPName { get; set; }

        [RegularExpression("[A-Za-z0-9]*", ErrorMessage = "Invalid MIRI-ID "), StringLength(50)]
        [Column(TypeName = "varchar(50)")]
        [NotMapped]
        public string MiriAccountNumber { get; set; }

        public int? DomainID { get; set; }
        public List<SelectListItem> LDAPList { get; set; }

        [Required(ErrorMessage = "Select Designation")]
        public int? DesignationID { get; set; }
        public List<SelectListItem> DesignationList { get; set; }


        [Required(ErrorMessage = "Select Reporting Manager")]
        public int ReportingTo { get; set; }
        public List<SelectListItem> ReportingList { get; set; }

        [Required(ErrorMessage = "Select Admin Manager")]
        public int AdminReportingTo { get; set; }
        public List<SelectListItem> AdminReportingList { get; set; }

        [Display(Name = "Mobile No")]
        [Column(TypeName = "varchar(30)")]
        [MaxLength(10)]
        [RegularExpression("[0-9]*", ErrorMessage = "Mobile No should be in numbers"), Required(ErrorMessage = "Enter Mobile No"), StringLength(10)]
        public string Mobile { get; set; }

        [Display(Name = "Map MIRI-ID")]
        [DefaultValue(1)]
        public bool CreateMiriId { get; set; }

        [Display(Name = "Activation Date")]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}", ApplyFormatInEditMode = true)]
        [Column(TypeName = "datetime")]
        [Required(ErrorMessage = "Select Activation Date")]
        public DateTime? EffectiveFromDate { get; set; }

        [Display(Name = "Valid Till")]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}", ApplyFormatInEditMode = true)]
        [Column(TypeName = "datetime")]
        [Required(ErrorMessage = "Select Valid Till Date")]
        public DateTime? EffectiveToDate { get; set; }

        [DefaultValue(0)]
        public bool IsAdministrator { get; set; }

        public object AsNoTracking()
        {
            throw new NotImplementedException();
        }
    }
}
