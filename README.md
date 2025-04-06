
# ToDo List Application

A simple and efficient ToDo List application built with C# and WinForms. Features include adding, modifying, deleting, and filtering tasks. Integrates with an SQL Server database for persistent storage.

## Features
- Add new tasks with descriptions, categories, due dates, and status.
- Modify existing tasks.
- Delete tasks individually or in bulk.
- Filter tasks by category and status.
- Highlight tasks based on urgency.
- Undo actions using a stack-based undo feature.

## Installation
1. Clone the repository:
   ```
   git clone [https://github.com/samarpreetxd/ToDoList.git](https://github.com/samarpreetxd/ToDoList.git)
   ```
2. Open the solution file in Visual Studio.
3. Update the SQL Server connection string in `Form1.cs`:
   ```
   string connectionString = @"Server=your_server;Database=your_database;Integrated Security=True;";
   ```
4. Build and run the application.

## SQL Query to Generate the DB Table
```
CREATE TABLE dbo.ToDoList (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Descrizione NVARCHAR(255) NOT NULL,
    Categoria NVARCHAR(50) NOT NULL,
    Data DATETIME NOT NULL,
    Stato NVARCHAR(50) NOT NULL
);
```

## Usage
- Use the main form to view, add, modify, delete, and filter tasks.
- Double-click a task to open the edit form.
- Use the "Undo" button to revert the last action.

## License
This project is licensed under the [MIT](https://choosealicense.com/licenses/mit/) License.
