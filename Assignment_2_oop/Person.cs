using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_oop
{
    internal struct Person
    {

        #region Attributes
        public string Name { get; set; }
        public int Age { get; set; } 
        #endregion

        // Method to display person details
        public override string ToString()
            {
                return $"Name is : {Name}, Age is : {Age}";
            }
        
    }
}
