namespace Personal_Portfolio.Models;

public sealed record Project(
    string Slug,
    string Name,
    string Summary,
    string Description,
    string[] Technologies,
    string RepositoryUrl,
    string? DemoUrl,
    string Number,
    string Category,
    string Problem,
    string[] Features,
    string Architecture,
    string Challenges,
    string? ImagePath = null);

public sealed record SkillGroup(string Name, string[] Skills);
public sealed record Experience(string Organization, string Role, string Period, string Description);
public sealed record Education(string Institution, string Degree, string Period, string Result);
public sealed record Achievement(string Title, string Detail, string? Url = null, string? LinkText = null);

public sealed class HomeViewModel
{
    public required IReadOnlyList<Project> FeaturedProjects { get; init; }
    public required IReadOnlyList<SkillGroup> SkillGroups { get; init; }
    public required IReadOnlyList<Experience> Experience { get; init; }
    public required Education Education { get; init; }
    public required IReadOnlyList<Achievement> Achievements { get; init; }
}

public sealed class ProjectDetailsViewModel
{
    public required Project Project { get; init; }
    public required Project? Previous { get; init; }
    public required Project? Next { get; init; }
}

