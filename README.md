A fullstack application for managing a personal book library.

## What the application does

You can add, view, update and delete books.
Each book has a title, author, year and a status for whether it has been read or not.
The frontend is built with HTML, CSS and JavaScript and communicates with a .NET Web API connected to a SQL Server database.

## How to run the project

1. Clone the repository
2. Open `BookLibraryAPI.sln` in Visual Studio 2022
3. Make sure SQL Server LocalDB is installed
4. Open Package Manager Console and run:
5. Press F5 to start the application
6. The browser will open automatically at `http://localhost:5009`

## API Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | /api/books | Get all books |
| GET | /api/books/{id} | Get one book by id |
| POST | /api/books | Create a new book |
| PUT | /api/books/{id} | Update a book |
| DELETE | /api/books/{id} | Delete a book |

## How the frontend talks to the API

The frontend uses `fetch()` in JavaScript to send HTTP requests to the API.
When the page loads, it fetches all books and displays them using DOM manipulation.
When a user adds, edits or deletes a book, a new fetch request is sent to the API and the list updates automatically.

## Reflection

What went well: Setting up the API structure with controllers, services and DTOs felt clear once I understood how they connect. Getting the frontend to communicate with the API using fetch was also satisfying when it finally worked.

What was difficult: Figuring out the correct port and HTTP vs HTTPS took some time. Installing the right NuGet package versions for .NET 9 was also a bit tricky at first.

What I would improve: I would add a loading indicator while books are being fetched, and maybe a search or filter function.
