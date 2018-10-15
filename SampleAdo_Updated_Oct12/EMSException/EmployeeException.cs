using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSException
{
    public class EmployeeException:ApplicationException
    {
        public EmployeeException():base()
        {

        }

        public EmployeeException(string errMessage):base(errMessage)
        {

        }
    }
}
