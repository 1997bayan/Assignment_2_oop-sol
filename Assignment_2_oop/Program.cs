using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Reflection;
using System.Diagnostics;
using System;

namespace Assignment_2_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Q1-Part02
            //1 Define a struct "Person" with properties "Name" and "Age".
            //Create an array of three "Person" objects and populate it with data.Then, write a C# program to display the details of all the persons in the array.

            //Person[] persons = new Person[3];

            // Input details for 3 persons
            //for (int i = 0; i < persons.Length; i++)
            //{
            //    Console.WriteLine($"Please enter details for person {i + 1}:");

            //    Console.Write("Name: ");
            //    persons[i].Name = Console.ReadLine();

            //    Console.Write("Age: ");
            //    persons[i].Age = int.Parse(Console.ReadLine());
            //}

            // Display details of all persons
            //for (int i = 0; i < persons.Length; i++)
            //{
            //    Console.WriteLine(persons[i].ToString());
            //}
            #endregion
            #region Q2-Part02
            // Find the oldest person
            //Person oldestPerson = Person.FindOldestPerson(persons);

            // Display the oldest person's details
            //Console.WriteLine($"\nThe oldest person is {oldestPerson.Name} with age {oldestPerson.Age}.");
            #endregion

            #region Part03
            //Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee [] EmpArr;)

            Employee[] employees = new Employee[3];
            employees[0] = new Employee(1, "Bayan", securityPrivileges.guest, 8000, new DateTime(2024, 1, 5), Gender.Female);


            employees[0].SecurityLevel = employees[0].SecurityLevel | securityPrivileges.DBA | securityPrivileges.secretary | securityPrivileges.Developer;
            employees[1] = new Employee(2, "omar", securityPrivileges.DBA, 9000, new DateTime(2024, 5, 5), Gender.Male);
            employees[2] = new Employee(3, "Rayan", securityPrivileges.guest, 7800, new DateTime(2020, 1, 5), Gender.Male);

            #endregion
            //
            //Sort the employees based on their hire date then Print the sorted array.
            // While sorting(how many times Boxing and Unboxing process has occurred)









        }





    }
    }
 


