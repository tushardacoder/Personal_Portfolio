using Personal_Portfolio.Models;

namespace Personal_Portfolio.Services;

public sealed class PortfolioService : IPortfolioService
{
    private static readonly Project[] Projects =
    [
        new("malefashion", "MaleFashion", "A multi-role commerce platform built around catalog, cart, checkout, and order workflows.",
            "An ASP.NET Core MVC e-commerce application with customer and administration workflows, designed with clear domain boundaries.",
            ["ASP.NET Core MVC", "C#", "EF Core", "SQL Server", "DDD", "CQRS", "Docker"],
            "https://github.com/tushardacoder/MaleFashion-E-Commerce-Web-Application", "https://malefashion-001-site1.jtempurl.com/", "01", "E-commerce",
            "Build a full shopping journey with separate customer and administration needs.",
            ["Product management", "Shopping cart and checkout", "Order management", "Authentication and admin tools"],
            "ASP.NET Core MVC with Clean Architecture, domain-driven design, CQRS, and Entity Framework Core.",
            "Keeping the customer journey and administrative workflows cohesive while maintaining clear separation of concerns."),
        new("stackoverflow-lite", "StackOverflow Lite API", "A structured Q&A API focused on backend boundaries, authentication, and reliable data access.",
            "A backend API inspired by Stack Overflow, built to practice modern API architecture and service integration.",
            ["ASP.NET Core Web API", "C#", "CQRS", "JWT", "Redis", "PostgreSQL", "Docker Compose"],
            "https://github.com/tushardacoder/StackOverFlow_Lite", null, "02", "Backend API",
            "Provide a dependable API foundation for asking questions and sharing answers.",
            ["JWT authentication", "Question and answer workflows", "PostgreSQL persistence", "Redis integration"],
            "Clean Architecture with CQRS and Cortex.Mediator, backed by PostgreSQL and Redis.",
            "Coordinating API concerns, persistence, and cross-cutting behavior across a layered backend."),
        new("green-gladiators", "Green Gladiators", "A cycling community concept connecting riders with routes, events, gear, and one another.",
            "A frontend platform centered on local cycling culture and practical ways for riders to discover and participate.",
            ["React", "JavaScript", "HTML5", "CSS3"], "https://github.com/tushardacoder/Green-Gladitors",
            "https://green-gladitors-ksb4.vercel.app/", "03", "Community",
            "Help cyclists discover places to ride and find a welcoming community.",
            ["Cycling community landing page", "Route and event discovery", "Responsive frontend experience"],
            "A component-driven React frontend with responsive HTML and CSS.",
            "Presenting several community needs clearly while keeping the interface approachable."),
        new("stories", "Stories", "A personal travel blog concept for sharing journeys, destination notes, and useful tips.",
            "A frontend-only travel blog experience focused on readable stories and destination discovery.",
            ["HTML5", "CSS3", "JavaScript"], "https://github.com/tushardacoder/Stories-Personal-Blog",
            "https://stories-personal-blog-b9kcv3vpe-tushardacoders-projects.vercel.app/", "04", "Editorial",
            "Make travel memories and practical destination advice easy to explore.",
            ["Travel story presentation", "Destination-focused content", "Responsive reading layout"],
            "A lightweight static frontend using semantic HTML, CSS, and JavaScript.",
            "Balancing expressive travel content with a comfortable reading experience.")
    ];

    private static readonly SkillGroup[] SkillGroups =
    [
        new("Backend Development", ["ASP.NET Core Web API", "ASP.NET Core MVC", "Clean Architecture", "SOLID Principles", "Design Patterns", "ASP.NET Core Identity", "Logging", "Redis", "Docker", "Git", "GitHub", "Postman", "NUnit", "Moq", "FluentAssertions"]),
        new("Databases & ORMs", ["SQL Server", "PostgreSQL", "MySQL", "MongoDB", "Entity Framework Core"]),
        new("Programming Languages", ["C#", "C++", "JavaScript"]),
        new("Frontend Development", ["HTML5", "CSS3", "Bootstrap", "Tailwind CSS", "React.js", "Next.js"])
    ];

    private static readonly Experience[] ExperienceEntries =
    [
        new("Goinnovior Limited", "Software Engineering Intern", "October 2025 – January 2026", "Contributed to a software team and gained practical experience working on development tasks."),
        new("CodeCamp ServerCamp", "Backend Development Trainee", "January 2026 – June 2026", "Built backend development skills through structured training and hands-on practice.")
    ];

    private static readonly Education EducationEntry = new("Independent University, Bangladesh", "B.Sc. in Computer Science and Engineering", "2020 – August 2025", "CGPA 3.57");

    private static readonly Achievement[] AchievementsList =
    [
        new("DBMS TechFest Champion 2023", "Champion at the DBMS TechFest in 2023."),
        new("LeetCode", "Explore my profile and problem-solving practice.", "https://leetcode.com/u/tushardacoder/", "View LeetCode profile"),
        new("Astha IT Certificate", "Certificate awarded by Astha IT.", "https://drive.google.com/file/d/1ZtMsIChMawfKnzBwYBsVT3b-Ch2--Iab/view", "View certificate")
    ];

    public HomeViewModel GetHome() => new()
    {
        FeaturedProjects = Projects,
        SkillGroups = SkillGroups,
        Experience = ExperienceEntries,
        Education = EducationEntry,
        Achievements = AchievementsList
    };

    public IReadOnlyList<Project> GetProjects() => Projects;

    public ProjectDetailsViewModel? GetProject(string slug)
    {
        var index = Array.FindIndex(Projects, p => string.Equals(p.Slug, slug, StringComparison.OrdinalIgnoreCase));
        return index < 0 ? null : new()
        {
            Project = Projects[index],
            Previous = index > 0 ? Projects[index - 1] : null,
            Next = index < Projects.Length - 1 ? Projects[index + 1] : null
        };
    }
}
