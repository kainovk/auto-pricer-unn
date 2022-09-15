using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPricing.Models
{
    internal class Truck : Auto
    {
        public Truck(string mark, int releaseYear, int initialPrice) : base(mark, releaseYear, initialPrice)
        {
        }

        public override bool Equals(object? obj)
        {
            return obj is Truck truck &&
                   Mark == truck.Mark &&
                   ReleaseYear == truck.ReleaseYear &&
                   InitialPrice == truck.InitialPrice;
        }

        public override int GetPrice()
        {
            int yearsPassed = DateTime.Now.Year - ReleaseYear;
            double coefficient = CaltulateCoefficient(yearsPassed);
            return (int)(InitialPrice * Math.Pow(coefficient, yearsPassed));
        }

        private double CaltulateCoefficient(int yearsPassed)
        {
            double coefficient = 1;
            if (yearsPassed >= 1 && yearsPassed <= 3)
            {
                coefficient = 0.9;
            }
            else if (yearsPassed >= 4 && yearsPassed <= 10)
            {
                coefficient = 0.8;
            }
            else if (yearsPassed >= 11)
            {
                coefficient = 0.7;
            }
            return coefficient;
        }


    }
}
