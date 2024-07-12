using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_oop
{
    [Flags]
    internal enum securityPrivileges
    //Assign the following security privileges to the employee (guest, Developer, secretary and DBA) in a form of Enum
    {
        guest=1, 
        Developer=2, 
        secretary =4,
        DBA= 8
    }
}
