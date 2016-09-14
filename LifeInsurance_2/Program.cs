using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeInsurance_2
{
    class Program
    {

        static void Main(string[] args)
        {
            DisplayWelcomeMessage();
            CustomerDetails customerDetails = new CustomerDetails();
            DataCollection captureData = new DataCollection();

            customerDetails.DateOfBirth = captureData.DateOfBirth();
            customerDetails.Gender = captureData.WhatIsYourGender();
            customerDetails.Country = captureData.Country();
            customerDetails.Children = captureData.Children();
            customerDetails.Smoker = captureData.Smoker();
            customerDetails.HoursOfExercise = captureData.Exercise();

            decimal price = 0;
            Calculations calculatePremium = new Calculations();
            try
            {
                price = calculatePremium.CalculatePremium(customerDetails);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                return;
            }

            DisplayPrice(price);

        }

        private static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Thank you for choosing \"So You Think You'll Live Forever\" Life Insurance");
            Console.WriteLine("Please answer the questions truthfully. Failure to do so could invalidate ");
            Console.WriteLine("your claim and leave your family finacially destitute upon your death.");
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
            Console.Clear();
        }


        public static int CalculateAge(DateTime dateOfBirth)
        {
            DateTime now = DateTime.Now;
            int age = now.Year - dateOfBirth.Year;
            if (now.Month < dateOfBirth.Month || (now.Month == dateOfBirth.Month && now.Day < dateOfBirth.Day)) age--;

            return age;
        }


        private static void DisplayPrice(decimal price)
        {
            Console.WriteLine("Thank you for your application for Life Insurance.");
            Console.WriteLine("with \"So You Think You'll Live Forever\" the number one life insurance company.");
            Console.WriteLine("We have serached our panel to find the best price available for you today.");
            Console.WriteLine("Your fantasic price is {0:C}", price);
            Console.ReadLine();

        }
    }
}
