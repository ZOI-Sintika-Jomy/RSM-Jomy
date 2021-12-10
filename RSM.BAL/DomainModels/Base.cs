using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RSM.BAL.Models
{
    [Serializable]
    public class Base
    {
        public Base()
        {
            this.CreatedOn = DateTime.Now;
        }

        [DefaultValue(1)]
        public bool IsActive { get; set; }

        [Column(TypeName = "int")]
        public int CreatedBy { get; set; }

        //[DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}", ApplyFormatInEditMode = true)]
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }

        [Column(TypeName = "int")]
        public int? ModifiedBy { get; set; }

        //[DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}", ApplyFormatInEditMode = true)]
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedOn { get; set; }

    }
}
