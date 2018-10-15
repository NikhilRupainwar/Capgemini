using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSEntity
{
    /// <summary>
    /// Author:CG
    /// DoC:15th Oct
    /// Desc: Entity class defined with properties
    /// </summary>
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Location { get; set; }
        public long PhoneNo { get; set; }
        public int Department { get; set; }
    }
}
