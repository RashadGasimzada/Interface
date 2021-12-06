using System;
using System.Collections.Generic;
using System.Text;

namespace Interface.Models
{
    public class Student : IDrink
    {
        public double AmountOfWaterPerDay { get; set; }
        
        public void DrinkAmount(params double[] arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        public void Drinking()
        {
            Console.WriteLine("Student drink cofee");
        }

        public void Walking()
        {
            Console.WriteLine("Student walking");
        }
    }
}
