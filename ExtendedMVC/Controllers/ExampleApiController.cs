using Microsoft.AspNetCore.Mvc;

namespace ExtendedMVC.Controllers;

[ApiController]
public class ExampleApiController : ControllerBase
{
    [HttpGet("~/example/")]
    public IEnumerable<string> Get()
    {
        return new[]
        {
            "Example 1",
            "Example 2",
            "Example 3"
        };
    }
}