using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointeuse
{
    public class TimeData
    {
        public int Id { get; set; }
        public int EmployeId { get; set; }
        public DateTime StartWork { get; set; }
        public DateTime EndWork { get; set; }
        public List<DateTime> ListOfStartPause { get; set; }
        public List<DateTime> ListOfEndPause { get; set; }     
        public string status { get; set; }
        public bool repas { get; set; }
    }
}
