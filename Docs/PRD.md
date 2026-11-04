# Product Requirements Document (PRD)

## 1. Project Overview

**Project Name:** Tushar Basak – Developer Portfolio  
**Product Type:** Personal Developer Portfolio Website  
**Primary Goal:** Build a professional, creative, responsive portfolio website to showcase my skills, projects, experience, education, and achievements to recruiters and potential employers.

The website will be developed using ASP.NET Core MVC with Bootstrap 5 and custom CSS.

## 2. Product Objectives

- Establish a professional online presence.
- Showcase technical skills and development experience.
- Present personal and academic projects with detailed descriptions.
- Provide recruiters with easy access to my CV and contact information.
- Demonstrate practical knowledge of ASP.NET Core MVC and frontend development.
- Deploy the portfolio using a free hosting platform initially.

## 3. Target Audience

- Technical recruiters
- HR professionals
- Software engineering managers
- Hiring managers
- Development teams
- Potential collaborators

## 4. User Requirements

Visitors should be able to:

1. Learn about me and my professional background.
2. Explore my technical skills.
3. View my projects and their technologies.
4. Read detailed project descriptions.
5. Download my CV.
6. Access my GitHub and LinkedIn profiles.
7. Contact me through the website or provided contact information.
8. Switch between light and dark themes.
9. Navigate the website easily on desktop, tablet, and mobile devices.

## 5. Functional Requirements

### FR-01: Home Page
- Display name, professional title, and short introduction.
- Display profile image.
- Provide CV download functionality.
- Include GitHub, LinkedIn, and Contact links.
- Include a clear call-to-action.

### FR-02: About Section
- Display professional introduction.
- Show educational background.
- Highlight career interests and professional goals.

### FR-03: Skills Section
Organize skills into categories:

- Frontend Development
- Backend Development
- Database
- Tools and Technologies
- Software Engineering Concepts

Skills should be displayed using badges, icons, or cards. Avoid misleading skill percentage indicators.

### FR-04: Projects Section
Display projects using responsive cards.

Each project should contain:
- Project name
- Short description
- Technologies used
- Project image or screenshot
- GitHub repository link
- Live demo link, if available
- Project details link

### FR-05: Project Details
Provide a dedicated details page for each major project.

Include:
- Project overview
- Problem statement
- Key features
- Technology stack
- Architecture overview
- Implementation details
- Challenges and solutions
- Screenshots
- GitHub and live demo links

### FR-06: Experience Section
Display professional experience and training.

Initial entries:
- Goinnovior Limited – 4-month internship.
- CodeCamp ServerCamp – Backend development training.

### FR-07: Education and Achievements
Display:
- B.Sc. in Computer Science and Engineering – Independent University, Bangladesh.(2020-2025 Aug)
- DBMS TechFest Champion.
- Relevant certifications and workshops.
- Leetcode achievements, including 500+ solved problems.

### FR-08: Contact Section
- Display email and social profile links.
- Provide a contact form.
- Validate user input using ASP.NET Core MVC model validation.
- Include spam protection where appropriate.
- Show success and error feedback.

### FR-09: Theme Management
- Support light and dark themes.
- Provide a theme toggle.
- Use the system preference on the first visit.
- Save the visitor's selected theme using localStorage.

### FR-10: Responsive Design
- Support desktop, tablet, and mobile screens.
- Use Bootstrap 5 responsive utilities and grid system.
- Ensure navigation and content remain accessible on smaller screens.

## 6. Non-Functional Requirements

### Performance
- Optimize images.
- Minimize unnecessary JavaScript and CSS.
- Keep page loading fast.

### Security
- Use HTTPS.
- Use anti-forgery validation for POST forms.
- Avoid exposing sensitive configuration.
- Protect contact functionality from spam.

### Maintainability
- Follow ASP.NET Core MVC conventions.
- Separate controllers, models, views, and services.
- Keep portfolio content organized.
- Use reusable Razor partial views.

### Usability
- Simple navigation.
- Consistent typography and spacing.
- Clear project information.
- Accessible colors and controls.

## 7. Main Website Pages

| Page | Route | Purpose |
|---|---|---|
| Home | `/` | Introduction and overview |
| Projects | `/projects` | Project collection |
| Project Details | `/projects/{slug}` | Individual project information |
| Contact | `/contact` | Contact information and form |

The Home page will also contain About, Skills, Experience, Education, and Achievements sections.

## 8. Initial Project Content

### Featured Projects

**MaleFashion**
- ASP.NET Core MVC
- Clean Architecture and DDD
- CQRS
- Entity Framework Core
- SQL Server
- Docker

**StackOverflow Lite API**
- ASP.NET Core Web API
- Clean Architecture
- CQRS
- JWT Authentication
- Redis
- PostgreSQL
- Docker Compose

**Stories – Personal Travel Blog**
- Frontend-only project.

**Green Gladiators**
- Frontend-only project.

### Professional Experience
- Goinnovior Limited – Internship.
- CodeCamp ServerCamp – Backend development training.

## 9. Out of Scope for MVP

The initial release will not include:

- Admin dashboard.
- Database-driven content management.
- User registration and login.
- Blog management system.
- Complex analytics dashboard.
- GitHub API integration.

These features may be considered in future versions.

## 10. Success Criteria

The project will be considered successful when:

- All primary sections are implemented.
- Projects display correct information and working links.
- CV download works.
- Contact information is accessible.
- Light and dark themes work.
- The website is responsive.
- No major navigation or validation errors remain.
- The website is successfully deployed using a public URL.

## 11. Development Phases

| Phase | Activities |
|---|---|
| Phase 1 | Project setup and configuration |
| Phase 2 | Layout, navigation, and design system |
| Phase 3 | Home page and About section |
| Phase 4 | Skills and Experience sections |
| Phase 5 | Projects and project details |
| Phase 6 | Education, achievements, and Contact |
| Phase 7 | Responsive design and testing |
| Phase 8 | Deployment and documentation |
