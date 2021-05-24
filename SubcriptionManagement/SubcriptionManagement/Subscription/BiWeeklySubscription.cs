using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubcriptionManagement
{
    public class BiWeeklySubscription : Subscription
    {
        Calendar calender = new Calendar();

        public override double GetSubscriptionPrice()
        {
            int numberOfBiWeeklyInMonth = calender.GetTotalBiWeeklyDays();

            double weeklySubscriptionPrice = GetSaturdayPrice() * numberOfBiWeeklyInMonth;

            return weeklySubscriptionPrice;
        }
    }
}