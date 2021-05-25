using Microsoft.VisualStudio.TestTools.UnitTesting;
using SubscriptionManagement;

namespace SubscriptionManagementTest
{
    [TestClass]
    public class SubscriptionTest

    {
        private Customer customer;

        [TestInitialize()]
        public void Initialize()
        {
            customer = new Customer("Sandhya");
        }

        [TestMethod]
        public void TestForMultipleSubscription()
        {
            MonthlySubscription monthlySubscription = new MonthlySubscription();
            Periodicals TOI = new Periodicals("TOI", 3, 5, 6);
            monthlySubscription.AddItem(TOI);

            WeeklySubscription weeklySubscription = new WeeklySubscription();
            Periodicals BM = new Periodicals("BM", 1.5, 1.5, 1.5);
            weeklySubscription.AddItem(BM);

            BiWeeklySubscription biWeeklySubscription = new BiWeeklySubscription();
            Periodicals hindu = new Periodicals("Hindu", 2.5, 4, 4);
            biWeeklySubscription.AddItem(hindu);

            customer.AddSubscription(monthlySubscription);
            customer.AddSubscription(weeklySubscription);
            customer.AddSubscription(biWeeklySubscription);

            double overallExpense = customer.GetOverallSubscriptionPrice(monthlySubscription, weeklySubscription, biWeeklySubscription);

            Assert.AreEqual(145, overallExpense);
        }

    }
}