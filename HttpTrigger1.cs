using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace myfirstfunction;

public class HttpTrigger1
{
    private readonly ILogger<HttpTrigger1> _logger;

    public HttpTrigger1(ILogger<HttpTrigger1> logger)
    {
        _logger = logger;
    }

    [Function("HttpTrigger1")]
    public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");
		
		//var response = req.CreateResponse(HttpStatusCode.OK);
        //response.WriteString("Hello from Azure Functions on .NET 8!");
        return new OkObjectResult("Welcome to Azure Functions!");
    }
}