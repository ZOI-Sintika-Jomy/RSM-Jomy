using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSM.BAL.DomainModels.Models
{
    public class HolidayList
    {
        public string exchange { get; set; }
        public string segment { get; set; }
        public DateTime holidaydate { get; set; }
        public string holidayname { get; set; }
    }
}
