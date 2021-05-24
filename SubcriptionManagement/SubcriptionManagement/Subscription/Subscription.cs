using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubcriptionManagement
{
    public abstract class Subscription
    {
        private List<IEssentialItems> essentialItems;

        public Subscription()
        {
            essentialItems = new List<IEssentialItems>();
        }

        public void AddItem(IEssentialItems item)
        {
            this.essentialItems.Add(item);
        }

        public abstract double GetSubscriptionPrice();

        public double GetTotalWeekdayPrice()
        {
            double totalWeekdayPrice = 0;
            essentialItems.ForEach(i => totalWeekdayPrice += i.GetWeekdaysPrice());
            return totalWeekdayPrice;
        }

        public double GetSaturdayPrice()
        {
            double totalSaturdayPrice = 0;
            essentialItems.ForEach(i => totalSaturdayPrice += i.GetSaturdayPrice());
            return totalSaturdayPrice;
        }

        public double GetSundayPrice()
        {
            double totalSundayPrice = 0;
            essentialItems.ForEach(i => totalSundayPrice += i.GetSundayPrice());
            return totalSundayPrice;
        }

        public double GetOverallSubscriptionPrice(MonthlySubscription monthlySubscription, WeeklySubscription weeklySubscription, BiWeeklySubscription biweeklySubscription)
        {
            double monthlySubscriptionPrice = monthlySubscription.GetSubscriptionPrice();
            double weeklySubscriptionPrice = weeklySubscription.GetSubscriptionPrice();
            double biweeklySubscriptionPrice = biweeklySubscription.GetSubscriptionPrice();

            double OverallSubscriptionPrice = monthlySubscriptionPrice + weeklySubscriptionPrice + biweeklySubscriptionPrice;
            return OverallSubscriptionPrice;
        }
    }
}
