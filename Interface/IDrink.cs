using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public interface IDrink : IWalk
    {
        double AmountOfWaterPerDay { get; set; }
        void Drinking();
        void DrinkAmount(params double[] arr);
    }
}
