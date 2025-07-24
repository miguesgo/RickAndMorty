# Rick & Morty - API Coding Test
Hi! this is my try for the coding test. In this project, I used the ASP.NET Core Web API template to fetch and retrieve data (characters data) from the Rick & Morty Api.

## Considerations:
- I only use the Swagger UI because I didn't have time to make the frontend using a Razor page.
- Due to time again, I retrieve the first or default of the list of characters fecthed from the api.
- This first character found was automatically saved in the Database.
- I didn't build the "Favoritos" part :"(

## Technologies Used
- ASP.NET MVC.
- C# & Entity Framework Core
- SQL Server

## Documentation

You'll need Visual Studio (in my case I used the 2022 version), .NET 8.0 installed and clone the repo. To run and test the application, For testing purposes, I relied on Swagger UI, which provides a user-friendly interface to explore and test the API endpoints.

### Folder Structure
Data
  - ApplicationDbContext (DbContext)
Model
  - Character (Entity - Model - DTO)
  - Chracter Controller (Controller)
  - ChracterService (Service)

## Database

For Entity Framework I use the following packages: 
- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.SqlServer 
- Microsoft.EntityFrameworkCore.Tools 

For Database Creation I use the following command:
- CREATE DATABASE Character;

For migrations I use the Nuget package manager console, using the following commands:
- add-migration AddCharacterToDB
- update-database

## Images
Result in Swagger UI

<img width="632" height="215" alt="image" src="https://github.com/user-attachments/assets/a7d9ba69-4f34-4487-b16d-382fa6f2ce49" />

Result in SQL Server Management Studio

<img width="903" height="182" alt="image" src="https://github.com/user-attachments/assets/254bf03c-1a5a-4de0-91a8-cf4ced42fbc9" />

Gif of the execution of the project

![gif4](https://github.com/user-attachments/assets/1ed5174f-36bd-485a-8747-6c3517f10d1c)
