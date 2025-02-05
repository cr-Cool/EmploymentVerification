# Employment Verification System

This is a **Full Stack Application** built with **ASP.NET Core (Backend)** and **JavaScript (Frontend)**. The system verifies employee details using an API.

## Features

- ASP.NET Core Backend: API endpoints for verifying employee information based on the company name, verification code, and employee ID.
- Database Integration: Uses **Entity Framework Core** to handle database operations.
- Frontend: Simple HTML, CSS, and JavaScript interface to interact with the API.
  
## Technologies Used

- Backend: ASP.NET Core, Entity Framework Core
- Frontend: HTML, JavaScript
- Database: SQLite
- Tools: Visual Studio, Postman, .NET CLI

## Setup Instructions

### Prerequisites

- Install **.NET SDK**: [Download .NET SDK](https://dotnet.microsoft.com/download/dotnet)
- Install **Visual Studio**: [Download Visual Studio](https://visualstudio.microsoft.com/downloads/)
- Install **SQLite**: [Download SQLite](https://www.sqlite.org/download.html)

### Clone the Repository

	git clone https://github.com/cr-Cool/EmploymentVerification.git
	cd EmploymentVerification


## Backend Setup (ASP.NET Core)
Install Dependencies: In Visual Studio, right-click on the solution and select Restore NuGet Packages or use the following command in your terminal:

	dotnet restore
 
## Run Database Migrations: To create the necessary tables in your SQLite database:


	dotnet tool install --global dotnet-ef --version 5.0.17
	dotnet ef migrations add InitialCreate
	dotnet ef database update
 
## Run the Backend: 

Press F5 in Visual Studio or run the following command in your terminal:

	dotnet run


## Frontend Setup (JavaScript)
	
	The frontend files are located in the wwwroot folder. You can modify the HTML and JavaScript files as needed to enhance the user interface.

	Access the frontend by navigating to:

	http://localhost:38526/index.html


## Testing the Application
	You can test the API endpoints using Postman or any API testing tool.
	Example POST request to verify employee:
	URL: http://localhost:38526/api/verify-employment
	Body (JSON):

		{
			"id": 101,
			"companyName": "Infosys",
			"verificationCode": "Infy123"
		}



## Troubleshooting

	Internal Server Error (500):
	This may occur due to a null database context or if migrations are not applied. Ensure you run the correct EF Core commands:

		dotnet ef migrations add InitialCreate
		dotnet ef database update

	**dotnet-ef Version Mismatch:
	If using .NET 5, ensure you install the correct version:

	dotnet tool install --global dotnet-ef --version 5.0.17
