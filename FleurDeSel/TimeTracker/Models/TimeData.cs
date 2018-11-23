using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pointeuse.Models
{
    public class TimeData
    {
        public int id { get; set; }
        public int EmployeeID { get; set; }        
        public DateTime ? Start { get; set; }
        public DateTime? End { get; set; }
        
    }
}