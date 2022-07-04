using Xunit;
using Amazon.Lambda.Core;
using Amazon.Lambda.TestUtilities;
using AWSLambda.Models;

namespace AWSLambda.Tests;

public class FunctionTest
{
    [Fact]
    public void TestCountWeekDaysFunction()
    {
        //Arrange
        var function = new Function();
        var context = new TestLambdaContext();
        var dateRequest = new DateRequest
        {
            DateFrom = new DateTime(2022, 6, 1),
            DateTo = new DateTime(2022, 6, 30)
        };

        //Action
        var totalWeekDays = function.FunctionHandler(dateRequest, context);

        //Assert
        Assert.True(totalWeekDays == 20);
    }
}
