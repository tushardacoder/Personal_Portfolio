Software Architecture Document (SAD)
1. Introduction
Project Name
Tushar Basak – Developer Portfolio
Architecture Style
ASP.NET Core MVC with a layered application structure.
Architectural Goal
Build a maintainable, lightweight, responsive, and professional developer portfolio website using ASP.NET Core MVC.

The architecture separates request handling, application logic, data management, and presentation to ensure maintainability, reusability, and future scalability.
Portfolio Owner
- Name: Tushar Basak
- Profile Photo: View Profile Photo
- GitHub: https://github.com/tushardacoder
- LinkedIn: https://www.linkedin.com/in/tusharbasak/

2. High-Level Architecture
The application follows the MVC pattern with a lightweight service layer.
Architecture Diagram

Flow explanation:
1. Visitor sends an HTTP request.
2. ASP.NET Core Middleware processes the request.
3. MVC Routing identifies the appropriate controller.
4. Controller calls the required service.
5. Service retrieves information from the static data source.
6. Models and ViewModels transfer data to Razor Views.
7. Razor generates HTML.
8. Browser displays the portfolio website.





3. Application Layers
3.1 Presentation Layer
Responsibilities:
- Display portfolio content.
- Handle user navigation.
- Render personal and professional information.
- Display validation messages.
- Manage responsive UI and theme interactions.
Technologies:
- Razor Views
- Bootstrap 5
- CSS3
- JavaScript
3.2 Controller Layer
Controllers receive HTTP requests and coordinate application operations.

Controllers:
- HomeController
- ProjectsController
- ContactController
Responsibilities:
- Handle incoming HTTP requests.
- Call appropriate services.
- Pass data to views.
- Return appropriate HTTP responses.
3.3 Service Layer
Services contain reusable application logic.

Services:
- IPortfolioService
- PortfolioService
Responsibilities:
- Retrieve portfolio information.
- Retrieve project information.
- Retrieve skills and experience.
- Keep controllers lightweight.
3.4 Model and ViewModel Layer
Models represent portfolio data.

Models:
- Project
- Skill
- Experience
- Education
- Achievement
ViewModels represent data required by individual views.

ViewModels:
- HomeViewModel
- ProjectDetailsViewModel
The contact page uses native browser validation and a JavaScript mailto action; no contact POST model is required.
3.5 Data Layer
The initial implementation uses static C# data.

Example: PortfolioData.cs

This class provides:
- Personal information.
- Profile photo URL.
- Project information.
- Technical skills.
- Work experience.
- Education.
- Achievements.
- Social and professional links.
No database is required for the MVP.

4. Portfolio Content and Projects
The portfolio will showcase personal information, technical skills, education, achievements, and selected development projects.
4.1 Profile Information
- Name: Tushar Basak
- Degree: B.Sc. in Computer Science and Engineering
- University: Independent University, Bangladesh (IUB) (2020-2025 Aug)
- CGPA: 3.57
- Primary Interest: Backend Development
- Backend Technology: C#, ASP.NET Core
- Frontend Technologies: React.js, Next.js, Angular
- Programming Languages: C#, C++, Java
Profile Photo URL:
https://i.postimg.cc/z3ZQWVMy/Tushar-Basak.jpg


4.2 Featured Projects
The portfolio will initially showcase four projects.
Project 1: MaleFashion – E-Commerce Web Application
Description:

MaleFashion is a multi-role e-commerce web application built using ASP.NET Core MVC. It includes product management, shopping cart, checkout, order management, authentication, and admin functionalities.

Technologies:
- ASP.NET Core MVC
- C#
- Entity Framework Core
- SQL Server
- Clean Architecture
- DDD
- CQRS
- Docker
GitHub Repository:
https://github.com/tushardacoder/MaleFashion-E-Commerce-Web-Application

Live Demo:
https://malefashion-001-site1.jtempurl.com/
Project 2: StackOverflow Lite API
Description:

StackOverflow Lite is a backend API project inspired by Stack Overflow. It focuses on building a structured, scalable API using modern backend development practices.

Technologies:
- ASP.NET Core Web API
- C#
- Clean Architecture
- CQRS
- JWT Authentication
- Redis
- Docker Compose
- PostgreSQL
- Cortex.Mediator
GitHub Repository:
https://github.com/tushardacoder/StackOverFlow_Lite

Live Demo:
Not available.
Project 3: Green Gladiators – Cycling Community Platform
Description:

Green Gladiators is a modern cycling community platform that connects riders with routes, events, gear, and fellow cyclists. It helps riders explore more, ride together, and support local cycling culture.

Technologies:
- React.js
- JavaScript
- HTML5
- CSS3
GitHub Repository:
https://github.com/tushardacoder/Green-Gladitors

Live Demo:
https://green-gladitors-ksb4.vercel.app/
Project 4: Stories – Personal Travel Blog
Description:

Stories is a personal travel blog website designed to share travel experiences, stories, and tips in a clean and modern layout. The platform focuses on storytelling, destinations, and useful travel insights.

Technologies:
- Frontend Development
- HTML5
- CSS3
- JavaScript
GitHub Repository:
https://github.com/tushardacoder/Stories-Personal-Blog

Live Demo:
https://stories-personal-blog-b9kcv3vpe-tushardacoders-projects.vercel.app/

5. Proposed Folder Structure
TusharPortfolio/
│
├── Controllers/
│   ├── HomeController.cs
│   ├── ProjectsController.cs
│   └── ContactController.cs
│
├── Models/
│   ├── Project.cs
│   ├── Skill.cs
│   ├── Experience.cs
│   ├── Education.cs
│   └── ErrorViewModel.cs
│
├── ViewModels/
│   ├── HomeViewModel.cs
│   └── ProjectDetailsViewModel.cs
│
├── Services/
│   ├── Interfaces/
│   │   ├── IPortfolioService.cs
│   │
│   ├── PortfolioService.cs
│
├── Data/
│   └── PortfolioData.cs
│
├── Views/
│   ├── Home/
│   │   └── Index.cshtml
│   │
│   ├── Projects/
│   │   ├── Index.cshtml
│   │   └── Details.cshtml
│   │
│   ├── Contact/
│   │   └── Index.cshtml
│   │
│   └── Shared/
│       ├── _Layout.cshtml
│       ├── _Navbar.cshtml
│       ├── _Footer.cshtml
│       └── Error.cshtml
│
├── wwwroot/
│   ├── css/
│   │   ├── site.css
│   │   ├── theme.css
│   │   └── responsive.css
│   │
│   ├── js/
│   │   ├── site.js
│   │   └── theme.js
│   │
│   ├── images/
│   │   ├── profile/
│   │   └── projects/
│   │
│   ├── documents/
│   │   └── tushar-basak-cv.pdf
│   │
│   └── lib/
│
├── Properties/
├── Program.cs
├── appsettings.json
└── TusharPortfolio.csproj



6. Request Processing Flow
Homepage Request Flow
1. Browser sends GET /.
2. ASP.NET Core middleware processes the request.
3. MVC routing identifies HomeController.
4. HomeController.Index() executes.
5. Controller requests portfolio information from IPortfolioService.
6. PortfolioService retrieves information from PortfolioData.
7. Controller passes the data to Views/Home/Index.cshtml.
8. Razor renders HTML.
9. Browser displays the homepage.
Contact Link Flow
1. Visitor opens /contact.
2. Contact view displays GitHub, LinkedIn, and email links with recognizable icons.
3. GitHub and LinkedIn open the portfolio owner's profiles in a new tab.
4. Email opens a draft addressed to the portfolio owner in the visitor's email app.

7. Routing Design
HTTP Method	Route	Controller Action
GET	/	HomeController.Index
GET	/projects	ProjectsController.Index
GET	/projects/{slug}	ProjectsController.Details
GET	/contact	ContactController.Index

A fallback route will handle unknown pages.

8. Dependency Injection
Services will be registered in Program.cs.

Example:
builder.Services.AddScoped<
    IPortfolioService,
    PortfolioService>();

Controllers will receive their dependencies through constructor injection.

9. UI Architecture
The shared layout will contain:
- Navigation bar.
- Hero section.
- Main content area.
- Footer.
- Theme toggle.
- Bootstrap and custom CSS references.
- JavaScript references.
Reusable Razor partial views:
- _Navbar.cshtml
- _Footer.cshtml
This avoids duplicating common UI elements.
Main Website Sections
1. Home / Hero
2. About Me
3. Technical Skills
4. Education
5. Experience
6. Projects
7. Achievements
8. Contact

10. Design Architecture
Theme System
The website will primarily use a clean, modern light theme.

CSS custom properties will define:
Theme System – Light Theme
The website will use a modern, clean, and professional Light Theme as its default appearance.

CSS custom properties (CSS variables) will be used to maintain consistent colors throughout the application and make future theme customization easier.
1. Light Theme Color Palette
Element	Color	Hex Code
Main Background	Soft Off-White	#F8FAFC
Section Background	Light Gray	#F1F5F9
Primary Text	Dark Navy	#0F172A
Secondary Text	Slate Gray	#64748B
Card Background	Pure White	#FFFFFF
Border Color	Light Slate	#E2E8F0
Primary Accent	Blue	#2563EB
Accent Hover	Dark Blue	#1D4ED8
Muted Accent	Light Blue	#DBEAFE
Footer Background	Dark Navy	#0F172A
Footer Text	Soft Off-White	#F8FAFC

2. CSS Custom Properties
:root {
    /* Background Colors */
    --bg-primary: #F8FAFC;
    --bg-secondary: #F1F5F9;

    /* Text Colors */
    --text-primary: #0F172A;
    --text-secondary: #64748B;

    /* Card Colors */
    --card-bg: #FFFFFF;

    /* Border Colors */
    --border-color: #E2E8F0;

    /* Accent Colors */
    --accent-color: #2563EB;
    --accent-hover: #1D4ED8;
    --accent-light: #DBEAFE;

    /* Footer Colors */
    --footer-bg: #0F172A;
    --footer-text: #F8FAFC;
}


3. Design Guidelines
- Use soft off-white (#F8FAFC) as the main website background.
- Use light gray (#F1F5F9) for alternate sections.
- Use white cards with subtle borders and shadows.
- Use dark navy (#0F172A) for headings and important content.
- Use slate gray (#64748B) for descriptions and secondary text.
- Use blue (#2563EB) for buttons, links, and important highlights.
- Use dark blue (#1D4ED8) for button and link hover states.
- Use light blue (#DBEAFE) for badges, tags, and selected elements.
- Maintain sufficient color contrast for readability and accessibility.
- Use subtle shadows, smooth transitions, and rounded corners instead of heavy visual effects.
- Maintain consistent spacing, typography, and color usage across all pages.
4. Theme Preference
Setting	Description
Default Theme	System preference on first visit (light when unavailable)
Dark Theme	Included in the first release
Theme Management	CSS Custom Properties
Theme Switching	Toggle persisted with localStorage

JavaScript applies the system color preference on a first visit and persists the visitor's explicit theme selection using localStorage.
Responsive Layout
Use Bootstrap 5 breakpoints and grid utilities to support:
- Mobile.
- Tablet.
- Desktop.
Visual Style
- Minimal and professional layout.
- Light theme as the default.
- Optional dark theme.
- Responsive project cards.
- Professional profile presentation.
- Subtle transitions and animations.
- Consistent spacing and typography.
- Clear calls to action.
- Separate GitHub and Live Demo links for each project.

11. Security Architecture
- HTTPS enabled.
- No secrets committed to GitHub.
- External services configured through environment variables or secure configuration.
- Safe output rendering.

12. Deployment Architecture


Flow explanation:
1. Developer develops the portfolio using Visual Studio Code
2. Application is tested locally.
3. Source code is committed to Git.
4. Changes are pushed to GitHub.
5. ASP.NET Core application is published.
6. Published application is deployed to MonsterASP.NET.
7. Visitors access the live portfolio through a web browser.
Deployment details:
Component	Technology
IDE	Visual Studio Code
Framework	ASP.NET Core MVC
Version Control	Git
Source Code Hosting	GitHub
Hosting Provider	MonsterASP.NET
Application	Developer Portfolio




Deployment Target: MonsterASP.NET free hosting, subject to its current plan restrictions.

Deployment Workflow:
1. Develop the application locally using Visual Studio code
2. Commit and push changes to GitHub.
3. Publish the ASP.NET Core application.
4. Deploy the published application to MonsterASP.NET.
5. Test the deployed website.

13. Future Scalability
Possible future improvements:
- Database-backed portfolio content.
- Admin dashboard.
- Blog module.
- GitHub API integration.
- Analytics integration.
- Automated deployment using GitHub Actions.
- Dedicated email service integration.
- Dynamic project management.
These features are not required for the initial MVP.

14. Architecture Decisions
Decision	Reason
ASP.NET Core MVC	Familiar and suitable for the project
Bootstrap 5	Responsive UI development
Razor Views	Server-side rendering
Static C# data	Simple content management for MVP
Service layer	Reusable and testable application logic
No database initially	Avoid unnecessary complexity
No Clean Architecture initially	Project scope does not justify additional layers
Light theme	Clean and professional presentation
External profile image URL	Easy profile image management
Separate GitHub and Live Demo links	Better project accessibility


15. Conclusion
The proposed architecture provides a simple, maintainable foundation for a professional developer portfolio.

ASP.NET Core MVC handles request processing and server-side rendering, while Bootstrap 5 and custom CSS provide a responsive and modern user interface.

The portfolio will highlight Tushar Basak's professional background, technical skills, education, achievements, and four selected development projects.

The architecture avoids unnecessary complexity in the MVP while allowing future improvements such as database integration, an admin dashboard, blog functionality, and automated deployment.

Implementation note: The portfolio photo is configured as an external image URL, so you do not need to store another copy in wwwroot/images/profile/ unless you later decide to host it locally.
