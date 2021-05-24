using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubcriptionManagement
{
    public class Periodicals : IEssentialItems
    {
        private string name;
        private double weekdayPrice;
        private double saturdayPrice;
        private double sundayPrice;

        public Periodicals(string name, double weekdayPrice, double saturdayPrice, double sundayPrice)
        {
            this.name = name;
            this.weekdayPrice = weekdayPrice;
            this.saturdayPrice = saturdayPrice;
            this.sundayPrice = sundayPrice;
        }

        public string GetName()
        {
            return name;
        }

        public double GetWeekdaysPrice()
        {
            return weekdayPrice;
        }

        public double GetSaturdayPrice()
        {
            return saturdayPrice;
        }

        public double GetSundayPrice()
        {
            return sundayPrice;
        }
    }
}