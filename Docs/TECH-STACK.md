# Technology Stack Specification

## 1. Overview

The portfolio will use ASP.NET Core MVC as its primary web framework. Bootstrap 5 and custom CSS will handle the frontend design.

The initial implementation will use static C# data rather than a database because portfolio content changes infrequently.

## 2. Backend Technologies

| Technology | Purpose |
|---|---|
| C# | Primary programming language |
| .NET 10 | Application platform |
| ASP.NET Core MVC | Backend web framework |
| MVC Pattern | Separation of application responsibilities |
| Razor Views | Dynamic HTML rendering |
| Dependency Injection | Managing service dependencies |

## 3. Frontend Technologies

| Technology | Purpose |
|---|---|
| HTML5 | Website structure |
| CSS3 | Custom styling |
| Bootstrap 5 | Responsive layout and components |
| JavaScript | Client-side interactions |
| Razor | Server-side HTML rendering |
| Lucide / Bootstrap Icons | Icons |

### Frontend Design Approach

- Bootstrap 5 grid system.
- Custom CSS for creative styling.
- CSS variables for theme colors.
- Responsive navigation.
- Reusable UI components.
- Subtle hover effects and animations.
- Light and dark theme support.

## 4. Theme Management

Theme switching will use:

- CSS custom properties.
- JavaScript.
- Browser localStorage.
- System color preference detection.

The selected theme will persist across page reloads.

## 5. Data Management

**Initial approach: Static C# data**

Portfolio information will be stored in organized C# classes.

Example:
- `PortfolioData.cs`
- `Project.cs`
- `Skill.cs`
- `Experience.cs`

No database is required for the initial version.

A database can be introduced later if dynamic content management becomes necessary.

## 6. Contact Links

The contact page provides direct GitHub, LinkedIn, and email links. Social profiles open in a new tab; the email link opens a draft addressed to tusharbasak041@gmail.com. No contact form, server-side email service, or SMTP configuration is used.

## 7. Testing

| Technology | Purpose |
|---|---|
| NUnit | Unit testing |
| Shouldly | Readable test assertions |

Testing will focus on important application logic, especially project data services.

## 8. Development Tools

| Tool | Purpose |
|---|---|
| Visual Studio Code | Development IDE |
| Git | Version control |
| GitHub | Source code hosting |
| Browser DevTools | Frontend debugging |
| Postman | API testing if required |

## 9. Hosting and Deployment

**Initial hosting target:** MonsterASP.NET free ASP.NET hosting, subject to current plan availability and limitations.



Deployment requirements:
- Publish ASP.NET Core application.
- Configure production environment settings.
- Verify HTTPS.
- Test all routes and contact links.
- Verify CV and project image paths.
- Verify the GitHub, LinkedIn, and email links.
- Verify mobile responsiveness.

## 10. Final Technology Stack

| Layer | Selected Technology |
|---|---|
| Language | C# |
| Framework | .NET 10 |
| Backend | ASP.NET Core MVC |
| Frontend | HTML5, CSS3, JavaScript |
| UI Framework | Bootstrap 5 |
| Styling | Custom CSS |
| Icons | Lucide / Bootstrap Icons |
| Rendering | Razor Views |
| Data Storage | Static C# data |
| Validation | MVC Model Validation |
| Testing | NUnit + Shouldly |
| Version Control | Git |
| Repository | GitHub |
| Hosting | MonsterASP.NET (initial target) |

## 11. Architectural Decision

The portfolio is primarily a content-driven website.

Therefore, the MVP will use a simple MVC architecture with a small service layer.

The following technologies are intentionally excluded from the initial implementation:

- Entity Framework Core
- SQL Server
- Repository Pattern
- Unit of Work
- CQRS
- MediatR
- Redis
- Microservices

These technologies are unnecessary for the initial requirements and would increase complexity without providing meaningful benefits.
