using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubcriptionManagement
{
    public class Calendar
    {
        public int GetTotalDaysInAMonth()
        {
            int totalDays = 0;
            totalDays = DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month);
            return totalDays;
        }

        public int GetTotalNumberOfWeekDays()
        {
            int totalWorkingDays = GetTotalDaysInAMonth() - (GetTotalNumberOfSaturdaysInAMonth() + GetTotalNumberOfSundaysInAMonth());
            return totalWorkingDays;
        }

        public int GetTotalNumberOfSaturdaysInAMonth()
        {
            int totalSaturdayInAMonth = 0;

            totalSaturdayInAMonth = Enumerable.Range(1, GetTotalDaysInAMonth())
                                              .Select(n => new DateTime(DateTime.Today.Year, DateTime.Today.Month, n))
                                              .Where(date => date.DayOfWeek.Equals(DayOfWeek.Saturday)).Count();
            return totalSaturdayInAMonth;
        }

        public int GetTotalNumberOfSundaysInAMonth()
        {
            int totalSundayInAMonth = 0;

            totalSundayInAMonth = Enumerable.Range(1, GetTotalDaysInAMonth())
                                            .Select(n => new DateTime(DateTime.Today.Year, DateTime.Today.Month, n))
                                            .Where(date => date.DayOfWeek.Equals(DayOfWeek.Sunday)).Count();
            return totalSundayInAMonth;
        }

        public int GetTotalBiWeeklyDays()
        {
            int biweeklydays = GetTotalDaysInAMonth();
            int rem = biweeklydays % 14;
            return rem;
        }
    }
}