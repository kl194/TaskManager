#TaskManager: Task Management Application#
A simple desktop application for managing personal tasks, built with C# and Windows Forms (WinForms), utilizing an embedded SQLite database for local data storage.

##Technologies##
C#: Primary programming language.

Windows Forms (WinForms): Framework used for the graphical user interface (GUI).

SQLite: Lightweight, file-based database used for all data persistence.

##Key Features##
Task Creation: Easily add new tasks, set names, descriptions, and assign categories (subjects).

Task Management: Modify and update existing task details.

Scheduling: Set a due date for critical tasks.

Status Tracking: Mark tasks as completed by changing their status.

##Installation and Setup##
To get the application running, you must build the project and correctly place the necessary database template file.

##Prerequisites##
The required version of the .NET Framework installed on your system.

##Step-by-Step Guide##
Build the Project:

Open the TaskManager solution in Visual Studio.

Build the solution in either Debug or Release mode.

The executable file (TaskManager.exe) and all dependencies will be generated in the output directory (e.g., bin/Debug/).

Database Template Placement:

Locate the database template file: database_template (it has no file extension).

Place the database_template file into the same folder as the executable file (TaskManager.exe).

First Run (Database Initialization):

On the first launch, the application automatically checks for the working database file (database).

If the file is not found, it is automatically created by copying the contents of the database_template.

Launch:

Execute TaskManager.exe to start the application.
