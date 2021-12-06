using Interface.Models;
using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Interface

            Student student1 = new Student();
            Teacher teacher1 = new Teacher();
            student1.AmountOfWaterPerDay = 3;
            teacher1.AmountOfWaterPerDay = 2.5;

            teacher1.Drinking();
            student1.Drinking();
            IDrink[] DrinkAmountList = { student1, teacher1 };

            foreach (var item in DrinkAmountList)
            {
                Console.WriteLine($"{"Amount of water per day is: "} { item.AmountOfWaterPerDay}");
            }
            teacher1.DrinkAmount(3, 2.5);

            #endregion

        }
    }
}
