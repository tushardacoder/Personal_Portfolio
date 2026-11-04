using Personal_Portfolio.Models;

namespace Personal_Portfolio.Services;

public interface IPortfolioService
{
    HomeViewModel GetHome();
    IReadOnlyList<Project> GetProjects();
    ProjectDetailsViewModel? GetProject(string slug);
}
