using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointeuse
{
    public class TimeData
    {
        public TimeData(int EmployeId,string TypeName, DateTime ? Start, DateTime? End)
        {
            this.EmployeeID = EmployeeID;
            this.TypeName = TypeName;
            this.Start = Start;
            this.End = End;
        }
        public int Id { get; set; }
        public int EmployeeID { get; set; }
        public string TypeName { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
    }
}
