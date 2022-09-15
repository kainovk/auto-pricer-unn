using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPricing.Models
{
    internal class Car : Auto
    {
        public Car(string mark, int releaseYear, int initialPrice) : base(mark, releaseYear, initialPrice)
        {
        }

        public override int GetPrice()
        {
            int yearsPassed = DateTime.Now.Year - ReleaseYear;
            return (int)(InitialPrice * Math.Pow(0.9, yearsPassed));
        }

        public override bool Equals(object? obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Car p = (Car)obj;
                return (Mark == p.Mark) && (ReleaseYear == p.ReleaseYear);
            }
        }
    }
}
