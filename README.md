# Task Tracker

The **Team Task Tracker** is a web-based application that allows multiple users to manage and assign tasks efficiently. Users can assign tasks by typing their or their coworkers' names, adding the task to a shared list stored in an SQL Server database. The backend is implemented using C# and .NET, designed to handle multiple users simultaneously without conflicts. 

The architecture follows a simple web API design, where users interact with the system through any web browser. Users send requests (insert, update, delete, view) to the backend, which communicates with the SQL Server database to process these requests and returns responses to the user.

This project highlights the power of modern frameworks like .NET in reducing development time and complexity compared to older, more manual setups like Java SE/Servlets.

## Technology Stack
- **Backend**: C#, .NET Framework, ASP.NET Core, SQL Server
- **Frontend**: JavaScript, HTML, CSS
- **Development Environment**: Visual Studio Community, GitHub
- **Design Concepts**: Object-Oriented Programming, API, Encapsulation, Polymorphism

## Getting Started
Follow these steps to set up the project for development and testing.

### Prerequisites
- **Visual Studio**: Ensure Visual Studio is installed, which is essential for development.
- **.NET Framework**: Confirm that the .NET SDK and runtime are installed, typically included with Visual Studio.

### Installation
1. Install Visual Studio and C# development tools.
2. Download the latest version of the .NET framework.
3. Follow the steps to set up the backend using Entity Framework for SQL Server.

### Running the Application
1. Clone the repository from GitHub.
2. Open the project in Visual Studio.
3. Press `Ctrl + F5` to start the application.
4. A web browser will launch, displaying the task tracker interface.
5. Users can add tasks, assign them to others, and manage the task list in real time.

## Testing
To run tests:
1. Start the application in Visual Studio.
2. Interact with the task tracker through the browser to test features like adding, editing, or deleting tasks.
3. The system synchronizes across multiple clients in real-time.

## Reflection on Frameworks
Seven years ago, I built an automotive system using Java SE/Servlets, which required writing much more code and lacked the streamlined tools provided by modern frameworks. With .NET and Visual Studio, I completed this task tracker in two days compared to 25 days for the Java project. While both languages have their strengths, this project demonstrates the time-saving advantages of platform support and frameworks.
