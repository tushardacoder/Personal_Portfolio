using Microsoft.AspNetCore.Mvc;
using Personal_Portfolio.Services;

namespace Personal_Portfolio.Controllers;

public sealed class HomeController(IPortfolioService portfolioService) : Controller
{
    [HttpGet]
    public IActionResult Index() => View(portfolioService.GetHome());

    [HttpGet("/Home/Error")]
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() => View(new Models.ErrorViewModel { RequestId = HttpContext.TraceIdentifier });
}
