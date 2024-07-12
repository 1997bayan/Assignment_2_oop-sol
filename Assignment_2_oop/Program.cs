using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;

namespace Assignment_2_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Q1-Part02
            //1 Define a struct "Person" with properties "Name" and "Age".
            //Create an array of three "Person" objects and populate it with data.Then, write a C# program to display the details of all the persons in the array.

            Person[] persons = new Person[3];

            // Input details for 3 persons
            for (int i = 0; i < persons.Length; i++)
            {
                Console.WriteLine($"Please enter details for person {i + 1}:");

                Console.Write("Name: ");
                persons[i].Name = Console.ReadLine();

                Console.Write("Age: ");
                persons[i].Age = int.Parse(Console.ReadLine());
            }

            // Display details of all persons
            for (int i = 0; i < persons.Length; i++)
            {
                Console.WriteLine(persons[i].ToString());
            } 
            #endregion
        }
    }
 }

