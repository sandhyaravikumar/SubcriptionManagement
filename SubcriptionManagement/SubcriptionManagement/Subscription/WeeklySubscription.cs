using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubcriptionManagement
{
    public class WeeklySubscription : Subscription
    {
        Calendar calender = new Calendar();

        public override double GetSubscriptionPrice()
        {
            int numberOfSaturdaysInMonth = calender.GetTotalNumberOfSaturdaysInAMonth();
            int numberOfSundaysInMonth = calender.GetTotalNumberOfSundaysInAMonth();

            double saturdayPrice = GetSaturdayPrice() * numberOfSaturdaysInMonth;
            double sundayPrice = GetSundayPrice() * numberOfSundaysInMonth;

            double weeklySubscriptionPrice = saturdayPrice + sundayPrice;

            return weeklySubscriptionPrice;
        }
    }
}