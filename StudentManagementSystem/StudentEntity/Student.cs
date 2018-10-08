using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEntity
{
    /// <summary>
    /// Employee ID : Developers Employee ID
    /// Employee Name : Developers Employee Name
    /// Description : This is an Entity Class for Employee
    /// Date of Modification : 4th Oct 2018
    /// </summary>

    [Serializable]
    public class Student
    {
        public int StudentId { get; set; }

        public string StudentName {get; set; }

        public string CourseName { get; set; }

        public static char Grade { get; set; }
    }
}
