using System;

class Program
{
    static void Main()
    {
        // Hardcoded username and password for demonstration purposes
        string validUsername = "admin";
        string validPassword = "password";

        Console.WriteLine("Welcome to Ås Kommune Login");

        // Ask user to enter username
        Console.Write("Enter your username: ");
        string username = Console.ReadLine();

        // Ask user to enter password (mask input)
        Console.Write("Enter your password: ");
        string password = ReadPassword();

        // Check if the entered username and password are valid
        if (username == validUsername && password == validPassword)
        {
            Console.WriteLine("Login successful!");
            // Add code here to redirect user to the appropriate page or perform other actions after successful login
        }
        else
        {
            Console.WriteLine("Invalid username or password. Please try again.");
        }
    }

    // Method to read password without displaying input characters
    static string ReadPassword()
    {
        string password = "";
        ConsoleKeyInfo key;

        do
        {
            key = Console.ReadKey(true);

            // Ignore any key that is not a number, letter, or special character
            if (!char.IsControl(key.KeyChar))
            {
                password += key.KeyChar;
                Console.Write("*"); // Display asterisk instead of the actual character
            }
            else if (key.Key == ConsoleKey.Backspace && password.Length > 0)
            {
                password = password.Substring(0, password.Length - 1);
                Console.Write("\b \b"); // Move the cursor back and erase the character
            }
        }
        while (key.Key != ConsoleKey.Enter);

        Console.WriteLine(); // Move to the next line after input

        return password;
    }
}
