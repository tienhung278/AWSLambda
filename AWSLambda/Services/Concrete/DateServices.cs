using AWSLambda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWSLambda.Services.Concrete
{
    internal class DateServices : IDateServices
    {
        public int CalculateWeekdays(DateRequest dateRequest)
        {
            int dayDiff = (int)dateRequest.DateTo.Subtract(dateRequest.DateFrom).TotalDays;
            int totalWeekDays = 0;
            for (int i = 1; i < dayDiff; i++)
            {
                var date = dateRequest.DateFrom.AddDays(i);
                if (date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday)
                {
                    ++totalWeekDays;
                }
            }
            return totalWeekDays;
        }
    }
}
