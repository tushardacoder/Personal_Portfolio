using Microsoft.AspNetCore.Mvc;
using Personal_Portfolio.Services;

namespace Personal_Portfolio.Controllers;

[Route("projects")]
public sealed class ProjectsController(IPortfolioService portfolioService) : Controller
{
    [HttpGet("")]
    public IActionResult Index() => View(portfolioService.GetProjects());

    [HttpGet("{slug}")]
    public IActionResult Details(string slug)
    {
        var project = portfolioService.GetProject(slug);
        return project is null ? NotFound() : View(project);
    }
}
