VisualTaskList-Evolution
A personal task management evolution showcasing my transition from basic scripts to a structured, professional software architecture.

Project Overview
Originally created to replace disorganized text files, this repository contains two versions of my task manager. It serves as a visual timeline of my growth as a developer, comparing my early logic to the professional standards I apply today.

The Evolution

[Description](Assets/legacy-v1.png)
1. Legacy Version (VisualOrganisationTool)
The "Why": Built to solve a personal need to stay organized during my early studies.
Tech: .NET Framework 4.7.2, Windows Forms.
Focus: Core functionality and UI basics.

[Description](Assets/dashboard-v2.png)  
2. Current Version (VisualTaskList)
The "Why": A complete rewrite to implement industry-standard design patterns and modern frameworks.
Tech: .NET 8.0, SQLite.

Improvements:
-Architecture: Implemented the Model-View-Presenter (MVP) pattern for better separation of concerns.
-Data Integrity: Moved from local memory/files to a structured SQLite database using the Repository pattern.
-Scalability: Extensive use of Interfaces to allow for easier testing and future-proofing.
-Custom UI: Developed custom calendar controls and modular views.

Tech Stack
-Language: C#
-Framework: .NET 8.0 (Windows Forms)
-Database: SQLite
-Patterns: MVP, Dependency Inversion (Interfaces), Repository Pattern.

Structure
-/VisualTaskList: The modern, refactored implementation.
-/VisualOrganisationTool_Legacy: The original project files for comparison.

How to Run
-Clone the repository.
-Open VisualTaskList.sln in Visual Studio 2022.
-Build and Run.
