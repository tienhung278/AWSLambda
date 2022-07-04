using AWSLambda.Models;

namespace AWSLambda.Services
{
    internal interface IDateServices
    {
        int CalculateWeekdays(DateRequest dateRequest);
    }
}