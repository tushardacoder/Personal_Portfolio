using Microsoft.AspNetCore.Mvc;
namespace Personal_Portfolio.Controllers;

[Route("contact")]
public sealed class ContactController : Controller
{
    [HttpGet("")]
    public IActionResult Index() => View();
}
