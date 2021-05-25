using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriptionManagement
{
    public class MonthlySubscription : Subscription
    {
        Calendar calender = new Calendar();

        public override double GetSubscriptionPrice()
        {
            int numberOfWeekDaysInMonth = calender.GetTotalNumberOfWeekDays();
            int numberOfSaturdaysInMonth = calender.GetTotalNumberOfSaturdaysInAMonth();
            int numberOfSundaysInMonth = calender.GetTotalNumberOfSundaysInAMonth();

            double weekdayPrice = GetTotalWeekdayPrice() * numberOfWeekDaysInMonth;
            double saturdayPrice = GetSaturdayPrice() * numberOfSaturdaysInMonth;
            double sundayPrice = GetSundayPrice() * numberOfSundaysInMonth;

            double monthlySubscriptionPrice = weekdayPrice + saturdayPrice + sundayPrice;

            return monthlySubscriptionPrice;
        }
    }
}