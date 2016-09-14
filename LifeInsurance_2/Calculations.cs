using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeInsurance_2
{
    public class Calculations
    {

        public decimal CalculatePremium(CustomerDetails customerDetails)
        {
            if (customerDetails == null)
            {
                throw new ArgumentNullException("Customer details are invalid");
            }

            int age = CalculateAge(customerDetails.DateOfBirth);
            decimal price = CalculateAgeGenderPrice(age, customerDetails.Gender);
            price = Country(customerDetails.Country, price);
            price = Children(customerDetails.Children, price);
            price = Smoker(customerDetails.Smoker, price);
            price = Exercise(customerDetails.HoursOfExercise, price);

            return price;
        }


        private int CalculateAge(DateTime dateOfBirth)
        {
            DateTime now = DateTime.Now;
            int age = now.Year - dateOfBirth.Year;
            if (now.Month < dateOfBirth.Month || (now.Month == dateOfBirth.Month && now.Day < dateOfBirth.Day)) age--;

            return age;
        }

        public static decimal CalculateAgeGenderPrice(int age, string gender)
        {
            decimal price = 0;
            int[] ages = new int[] { 18, 24, 35, 45, 60, 120 };
            int[] malePrices = new int[] { 150, 180, 200, 250, 320, 500 };
            int[] femalePrices = new int[] { 100, 165, 180, 225, 315, 485 };

            string male = "M";
            string female = "F";

            if (gender == male)
            {
                for (int i = 0; i < ages.Length; i++)
                {
                    if ((age <= ages[i]) && (price == 0))
                    {
                        price = malePrices[i];
                    }
                }
            }

            else if (gender == female)
            {
                for (int i = 0; i < ages.Length; i++)
                {
                    if ((age <= ages[i]) && (price == 0))
                    {
                        price = femalePrices[i];
                    }
                }
            }

            return price;
        }

        private static decimal Country(string country, decimal price)
        {
            if (country == "England")
            {
            }
            else if (country == "Wales")
            {
                price = price - 100;
            }
            else if (country == "Scotland")
            {
                price = price + 200;
            }
            else if (country == "Ireland")
            {
                price = price + 500;
            }
            else if (country == "Northern Ireland")
            {
                price = price + 75;
            }
            else if (country == "Other")
            {
                price = price + 75;
            }

            if (price < 50)
            {
                price = 50;
            }

            return price;
        }

        private static decimal Children(string children, decimal price)
        {

            if (children == "Yes")
            {
                price = (price * 50 / 100) + price;
            }

            if (price < 50)
            {
                price = 50;
            }

            return price;
        }
        private static decimal Smoker(string smoker, decimal price)
        {
            if (smoker == "Yes")
            {
                price = (price * 300 / 100) + price;
            }

            if (price < 50)
            {
                price = 50;
            }

            return price;
        }
        private static decimal Exercise(int hoursOfExercise, decimal price)
        {
            if (hoursOfExercise == 0)
            {
                price = (price * 20 / 100) + price;
            }
            else if (hoursOfExercise <= 2)
            {
            }
            else if (hoursOfExercise <= 5)
            {
                price = price - (price * 30 / 100);
            }
            else if (hoursOfExercise <= 8)
            {
                price = price - (price * 50 / 100);
            }
            else
            {
                price = (price * 50 / 100) + price;
            }

            if (price < 50)
            {
                price = 50;
            }

            return price;
        }

    }
}
