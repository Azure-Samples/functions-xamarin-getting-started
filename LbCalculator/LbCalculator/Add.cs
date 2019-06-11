using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Calculator.Data;
using System;
using Microsoft.Extensions.Logging;

namespace LbCalculator
{
    public static class Add
    {
        [FunctionName("Add")]
        public static IActionResult Run(
            [HttpTrigger(
                AuthorizationLevel.Function, 
                "get",
                Route = "add/num1/{num1}/num2/{num2}")]
            HttpRequest req, 
            int num1,
            int num2,
            ILogger log)
        {
            log.LogInformation($"C# HTTP trigger function processed a request with {num1} and {num2}");

            var result = new AdditionResult
            {
                Result = num1 + num2,
                TimeOnServer = DateTime.Now
            };

            return new OkObjectResult(result);
        }
    }
}
