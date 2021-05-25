using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriptionManagement
{
    public class Customer
    {
        private string name;
        private List<Subscription> subscriptions;

        public Customer(string name)
        {
            this.name = name;
            subscriptions = new List<Subscription>();
        }

        public void AddSubscription(Subscription subscription)
        {
            this.subscriptions.Add(subscription);
        }

        public double GetOverallSubscriptionPrice(MonthlySubscription monthlySubscription, WeeklySubscription weeklySubscription, BiWeeklySubscription biweeklySubscription)
        {
            double overallPrice = 0;

            overallPrice = subscriptions.Select(s => s.GetOverallSubscriptionPrice(monthlySubscription, weeklySubscription, biweeklySubscription))
                                        .FirstOrDefault();
            return overallPrice;
        }
    }
}