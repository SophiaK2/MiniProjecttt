#MiniProjecttt
The MiniProjecttt is a Windows Forms application developed in C# for managing user registrations, activities, and space reservations. It provides a user-friendly interface for users to register, search for activities, view available spaces, and reserve spaces for their events.

Features
User Registration: Users can register by providing their email, password, phone number, and username. The application checks for duplicate usernames and validates user input for email format, password length, and phone number format.
Activity Search: Users can search for activities based on quantity, number of people, and things required. The application dynamically generates SQL queries based on the selected search criteria and displays the results in a DataGridView.
Space Reservation: Users can view available spaces and reserve a space for their events. The application updates the space status to "occupied" upon successful reservation.
Data Validation: The application validates user input for username, password, email, and phone number to ensure data integrity and security.
Getting Started
To run the MiniProjecttt locally on your machine, follow these steps:

Clone the Repository:
Clone this repository to your local machine using Git. Open a terminal or command prompt and run the following command:

Set Up the Database:
Ensure that you have a SQL Server instance running locally or accessible from your machine. Update the connection string in the code files (Form2.cs, Form4.cs, Form5.cs) to point to your SQL Server instance.

Build and Run:
Build the solution in Visual Studio and run the project (F5 or Ctrl + F5).

Explore the Application:
Once the application is running, you can register as a user, search for activities, and reserve spaces for your events.

Technologies Used
C# (.NET Framework)
Windows Forms (WinForms)
SQL Server
Git
Contributing
Contributions to the MiniProjecttt are welcome! If you have any ideas for improvements, bug fixes, or new features, feel free to open an issue or submit a pull request.
