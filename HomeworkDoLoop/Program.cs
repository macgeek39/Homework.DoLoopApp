
/*
 * Create a console application that asks the user 
 * for their name. Welcome Tim as professor or
 * anyone else as student. Do this until the user
 * types "exit".
 */

string firstName;
string lowerName;

// Until user type "exit" to exit the app
do
{
    // Ask the User for their name
    Console.WriteLine("Enter your first name: ");
    firstName = Console.ReadLine();
    lowerName = firstName.ToLower();
    // If name is tim
    if (lowerName == "tim")
    {
        // Print "Welcome professor"
        Console.WriteLine("Welcome Professor");
    }
    else
    {
        // Or else "Welcome Student"
        Console.WriteLine("Welcome Student");
    } 
} while (lowerName != "exit");
