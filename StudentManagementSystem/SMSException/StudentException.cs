using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSException
{
    /// <summary>
    /// Exception Class to catch the Exceptions occuring in Student Mngt System
    /// Author:CG
    /// DOC:23rd Jan 2017
    /// </summary>
    public class StudentException:ApplicationException 
    {
     //Default Constructor , that inherits the base constructor
        public StudentException() : base() { }

// Parameterized constructor for passing the Error/Exception Message
        public StudentException(string errormsg) :
            base(errormsg) { }

    }
}
