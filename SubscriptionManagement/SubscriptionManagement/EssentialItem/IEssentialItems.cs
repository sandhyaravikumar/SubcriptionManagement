namespace SubscriptionManagement
{
    public interface IEssentialItems
    {
        string GetName();

        double GetWeekdaysPrice();

        double GetSaturdayPrice();

        double GetSundayPrice();
    }
}