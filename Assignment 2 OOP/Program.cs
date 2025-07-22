using System;

namespace Assignment2_OOP
{
    internal class Program
    {
        #region Q1
        public struct Person
        {
            public string Name;
            public int Age;
        }
        #endregion

        #region
        #endregion

        #region
        #endregion
        #region
        #endregion
        static void Main(string[] args)
        {
            #region 1-Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.

            Person[] people = new Person[3];

            people[0].Name = "Ahmed";
            people[0].Age = 25;

            people[1].Name = "Mona";
            people[1].Age = 30;

            people[2].Name = "Khaled";
            people[2].Age = 22;

            Console.WriteLine("List of People:");
            foreach (Person p in people)
            {
                Console.WriteLine($"Name: {p.Name}, Age: {p.Age}");
            }
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion
        }
    }
}