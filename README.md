# Account Management System

## Overview
This project is a simple account management system built in C#. It allows users to:
- Login with their credentials
- View account details
- Deposit funds
- Withdraw funds (subject to a limit)
- Change their password
- Exit the system

## Features
### 1. User Authentication
- Users must enter a username and password to access the system.
- Credentials are stored in a text file (`account.txt`).

### 2. Account Details
- Users can check their current account balance.

### 3. Deposit Funds
- Users can add money to their account.
- The new balance is saved to `account.txt`.

### 4. Withdraw Funds
- Users can withdraw money, provided they do not exceed the withdrawal limit.
- The system ensures that the account does not go negative.

### 5. Change Password
- Users can change their password.
- The new password must be different from the old one.

### 6. Exit Option
- Users can exit the application safely.

## File Structure
- **`Program.cs`**: The entry point of the program where the console UI is managed.
- **`Account.cs`**: Contains the logic for user authentication and account operations.
- **`account.txt`**: Stores user account information in a structured format.

## Setup Instructions
1. Ensure you have **.NET SDK** installed on your system.
2. Create a text file named `account.txt` with the following format:
   ```plaintext
   username
   unused_field1
   unused_field2
   password
   unused_field3
   balance
   ```
   Example:
   ```plaintext
   JohnDoe
   -
   -
   password123
   -
   5000
   ```
3. Compile and run the program:
   ```sh
   dotnet run
   ```
4. Follow the on-screen instructions to log in and manage the account.

## Future Improvements
- Store user data in a **CSV file** for better data organization.
- Implement a graphical user interface (GUI).
- Enhance security by using **hashing** for password storage.
- Add multi-user support with different account types.

## Author
This project was developed as part of a class assignment.

