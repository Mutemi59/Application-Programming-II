/*

    Main Components of the .NET Framework: CLR and BCL

    Common Language Runtime (CLR):
    Role: The CLR is the execution engine of the .NET Framework, responsible for managing the 
    execution of .NET programs. It provides key services like memory management, type safety, 
    exception handling, garbage collection, and security.
    How It Works: When you compile your C# code, it gets converted into an Intermediate
    Language (IL) by the compiler. The CLR then takes this IL and compiles it into machine 
    code (Just-In-Time compilation) that can be executed by the CPU. This process ensures that 
    .NET applications can run on any platform that has a compatible CLR, making it platform-independent.

    Base Class Library (BCL):
    Role: The BCL is a comprehensive collection of reusable types that include classes, 
    interfaces, and value types, providing a wide range of functionalities like string manipulation, 
    file handling, database interaction, and more.
    How It Works: The BCL acts as a foundation on which all .NET applications are built. 
    Developers can leverage these pre-built classes and methods to perform common tasks, 
    reducing the need to write code from scratch. The BCL is integrated with the CLR, 
    ensuring that these functionalities are available across all .NET languages, providing consistency and ease of use.

How They Work Together:

    Seamless Development Experience: The CLR and BCL together provide a powerful
     and consistent development environment. The CLR ensures that your code runs 
     efficiently and securely, while the BCL offers a rich set of tools and libraries 
     to simplify coding. This combination allows developers to focus on building applications 
     rather than worrying about low-level details like memory management or basic functionalities.


*/

// a) File Operations in a Library Management System

using System;
using System.IO;

class LibraryManagement
{
    static void Main(string[] args)
    {
        string filePath = "books.txt";

        // Create or overwrite the file with initial list of books
        string[] initialBooks = { "The Great Gatsby", "1984", "To Kill a Mockingbird" };
        File.WriteAllLines(filePath, initialBooks);
        Console.WriteLine("Books have been written to the file.");

        // Read and display the content of the file
        string[] booksFromFile = File.ReadAllLines(filePath);
        Console.WriteLine("\nCurrent books in the file:");
        foreach (string book in booksFromFile)
        {
            Console.WriteLine(book);
        }

        // Append a new book to the file
        string newBook = "Moby Dick";
        File.AppendAllText(filePath, Environment.NewLine + newBook);
        Console.WriteLine("\nNew book has been added to the file.");

        // Read and display the updated content of the file
        booksFromFile = File.ReadAllLines(filePath);
        Console.WriteLine("\nUpdated books in the file:");
        foreach (string book in booksFromFile)
        {
            Console.WriteLine(book);
        }
    }
}
