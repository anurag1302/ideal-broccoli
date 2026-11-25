using Microsoft.AspNetCore.Mvc;

namespace Idea.Brocolli.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrderController : ControllerBase
{
    // GET
    public IActionResult Index()
    {
        return Ok("I am OrderController");
    }
}