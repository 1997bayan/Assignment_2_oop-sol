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

        #region Methods
        // Method to display person details
        public override string ToString()
        {
            return $"Name is : {Name}, Age is : {Age}";
        }

        public static Person FindOldestPerson(Person[] persons)
        {
            Person oldest = persons[0];
            foreach (var person in persons)
            {
                if (person.Age > oldest.Age)
                {
                    oldest = person;
                }
            }
            return oldest;
        }
            #endregion



        }
}
