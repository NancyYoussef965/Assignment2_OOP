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

        #region Q2
        //public struct Point
        //{
        //    public double X;
        //    public double Y;
        //}

        #endregion



        #region

        #endregion
        static void Main(string[] args)
        {
            #region 1-Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.

            //Person[] people = new Person[3];

            //people[0].Name = "Ahmed";
            //people[0].Age = 25;

            //people[1].Name = "Mona";
            //people[1].Age = 30;

            //people[2].Name = "Khaled";
            //people[2].Age = 22;

            //Console.WriteLine("List of People:");
            //foreach (Person p in people)
            //{
            //    Console.WriteLine($"Name: {p.Name}, Age: {p.Age}");
            //}
            #endregion

            #region 2-Create a struct called "Point" to represent a 2D point with properties "X" and   "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
            //Point P1;
            //Console.Write("Enter the X coordinate of Point 1: ");
            //P1.X=double.Parse(Console.ReadLine());

            //Console.Write("Enter the Y coordinate of Point 1: ");
            //P1.Y = double.Parse(Console.ReadLine());
            //Point P2;
            //Console.Write("Enter the X coordinate of Point 2: ");
            //P2.X = double.Parse(Console.ReadLine());
            //Console.Write("Enter the Y coordinate of Point 2: ");
            //P2.Y = double.Parse(Console.ReadLine());
            //double distance = Math.Sqrt(Math.Pow(P2.X - P1.X, 2) + Math.Pow(P2.Y - P1.Y, 2));
            //Console.WriteLine($"The distance between the two points is: {distance:F2}");

            //Console.ReadLine();
            #endregion

            #region 3-Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.

            Person[] people = new Person[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter name of person {i + 1}: ");
                people[i].Name = Console.ReadLine();
                Console.Write($"Enter age of person {i + 1}: ");
                people[i].Age = int.Parse(Console.ReadLine());
            }

            Person oldest = people[0];
            for (int i = 1; i < 3; i++)
            {
                if (people[i].Age > oldest.Age)
                {
                    oldest = people[i];
                }
            }
            Console.WriteLine($"\nThe oldest person is: {oldest.Name}, Age: {oldest.Age}");
            Console.ReadLine();
            #endregion

            #region
            #endregion
        }
    }
}