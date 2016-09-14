using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeInsurance_2
{
    class DataCollection
    {
        public DateTime DateOfBirth()
        {
            Console.WriteLine("Please enter your Date of Birth?");
            Console.Write("dd/mm/yyyy: ");
            string dob = Console.ReadLine();
            DateTime dateOfBirth;

            while (!DateTime.TryParse(dob, out dateOfBirth))
            {
                Console.WriteLine("Invalid Date of Birth, please try again");
                dob = Console.ReadLine();
            }
            Console.Clear();

            return dateOfBirth;
        }

        public string WhatIsYourGender()
        {
            Console.WriteLine("What is your gender?");
            Console.Write("Male or Female: ");
            string gender = Console.ReadLine();

            while (gender != "Male" && gender != "Female")
            {
                Console.WriteLine("Invalid Gender, please try again");

                gender = Console.ReadLine();
            }

            gender = gender.Substring(0, 1);
            Console.Clear();
            return gender;
        }

        public string Country()
        {
            Console.WriteLine("Which country do you live in?");
            Console.WriteLine("England, Wales, Scotland, Ireland, Northen Irealand, Other");
            string country = Console.ReadLine();
            while (country != "England" && country != "Wales" &&
                   country != "Scotland" && country != "Ireland" &&
                   country != "Northern Ireland" && country != "Other")
            {
                Console.WriteLine("Invalid country, please try again");

                country = Console.ReadLine();
            }

            Console.Clear();

            return country;
        }

        public string Smoker()
        {
            Console.WriteLine("Are you a smoker?");
            Console.Write("Yes or No: ");
            string smoker = Console.ReadLine();

            while (smoker != "Yes" && smoker != "No")
            {
                Console.WriteLine("Invalid response, please try again");

                smoker = Console.ReadLine();
            }

            Console.Clear();

            return smoker;
        }

        public int Exercise()
        {
            Console.WriteLine("How many hours of exercise do you do per week?");
            //int hoursOfExercise = int.Parse(Console.ReadLine());
            string Exercise = Console.ReadLine();
            int hoursOfExercise;


            while (!int.TryParse(Exercise, out hoursOfExercise))
            {
                Console.WriteLine("Invalid response, please try again");

                Exercise = Console.ReadLine();
            }

            Console.Clear();

            return hoursOfExercise;

        }

        public string Children()
        {
            Console.WriteLine("Do you have any children?");
            Console.Write("Yes or No: ");
            string children = Console.ReadLine();

            while (children != "Yes" && children != "No")
            {
                Console.WriteLine("Invalid response, please try again");

                children = Console.ReadLine();
            }
            Console.Clear();

            return children;
        }
    }
}
