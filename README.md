# Tushar Basak — Developer Portfolio

An ASP.NET Core MVC portfolio built with .NET 10, Razor views, Bootstrap 5, and custom CSS. Portfolio content is static C# data. The contact page links directly to GitHub, LinkedIn, and email.

## Run locally

```powershell
dotnet run
```

## Contact

The contact page provides direct links to GitHub, LinkedIn, and `tusharbasak041@gmail.com`. Social links open in a new tab; the email link opens the visitor's email app.

## Content and assets

- Projects, skills, education, achievements, and experience live in `Services/PortfolioService.cs`.
- The CV link points to the Google Drive file supplied by the portfolio owner.
- The homepage portrait uses the image URL recorded in the SAD. For long-term reliability, consider adding an optimized local copy under `wwwroot/images/profile/`.
- Project detail copy is based on the SAD and should be expanded with confirmed implementation specifics and screenshots as they become available.

## Structure

- `Controllers/`: route handling for home, projects, and contact.
- `Models/`: portfolio content types and page view models.
- `Services/`: static portfolio content provider.
- `Views/`: Razor pages and shared layout.
- `wwwroot/`: Bootstrap assets, custom stylesheet, and theme behavior.

The theme starts with the visitor's system preference and stores an explicit selection in `localStorage`.
