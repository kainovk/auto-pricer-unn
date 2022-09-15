using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPricing.Models
{
    abstract internal class Auto
    {
        public string Mark { get; set; }
        public int ReleaseYear { get; set; }
        public int InitialPrice { get; set; }

        protected Auto(string mark, int releaseYear, int initialPrice)
        {
            Mark = mark;
            ReleaseYear = releaseYear;
            InitialPrice = initialPrice;
        }

        public abstract int GetPrice();
    }
}
