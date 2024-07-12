using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_oop
{
    internal class Employee
    {
        //Employee is identified by an ID, Name, security level, salary, hire date and Gender.
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public securityPrivileges SecurityLevel { get; set; }
        public double Salary { get; set; }

        public DateTime Hire_date { get; set; }

        public Gender Gender { get; set; }
        #endregion

        #region Constructor
        public Employee(int _id, string _Name, securityPrivileges _SecurityLevel, double _Salary, DateTime _Hire_date, Gender _Gender)
        {

            Id = _id;
            Name = _Name;
            SecurityLevel = _SecurityLevel;
            Salary = _Salary;
            Hire_date = _Hire_date;
            Gender = _Gender;


        }
        #endregion


        //We want to provide the Employee Class to represent Employee data in a string Form (override ToString ()),
        //display employee salary in a currency format. [ use String.Format Function]

        public override string ToString()
        {
            return $"Employee Data are : > Employee id : {Id} ,\nName : {Name} ,\n SecurityLevel:{SecurityLevel} \n Salary :{Salary:c} , \n Hire_date : {Hire_date:dd-MM-YYYY} ,\nGender:{Gender}";
        }


    }


}
