using Amazon.Lambda.Core;
using AWSLambda.Models;
using AWSLambda.Services;
using AWSLambda.Services.Concrete;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace AWSLambda;

public class Function
{
    private readonly IDateServices dateServices;

    public Function()
    {
        dateServices = new DateServices();
    }
    
    public int FunctionHandler(DateRequest dateRequest, ILambdaContext context)
    {
        return dateServices.CalculateWeekdays(dateRequest);
    }
}
