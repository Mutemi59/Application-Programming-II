using System;

class Calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Choose an operation: +, -, *, /");
        string operation = Console.ReadLine();

        double result = 0;

        switch (operation)
        {
            case "+":
                result = Add(num1, num2);
                break;
            case "-":
                result = Subtract(num1, num2);
                break;
            case "*":
                result = Multiply(num1, num2);
                break;
            case "/":
                result = Divide(num1, num2);
                break;
            default:
                Console.WriteLine("Invalid operation.");
                return;
        }

        Console.WriteLine($"The result is: {result}");
    }

    static double Add(double a, double b)
    {
        return a + b;
    }

    static double Subtract(double a, double b)
    {
        return a - b;
    }

    static double Multiply(double a, double b)
    {
        return a * b;
    }

    static double Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Cannot divide by zero.");
            return 0;
        }
        return a / b;
    }


    // a)
    public static double CalculateAverage(int[] numbers)
    {
        if (numbers.Length == 0)
            return 0;

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return (double)sum / numbers.Length;
    }


}

// B)
/*Constructors are special methods in a class that are automatically invoked
 when an object of that class is created. They initialize the object's properties
  and ensure that the object is in a valid state when it is created. Unlike other methods, 
  constructors don't have a return type and share the name with the class.
*/
using System;
class Product
{
    public string Name { get; set; }
    public double Price { get; set; }

    // Default constructor
    public Product()
    {
        Name = "Unknown";
        Price = 0.0;
    }

    // Overloaded constructor
    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Product Name: {Name}, Price: {Price}");
    }

    static void Main(string[] args)
    {
        // Using default constructor
        Product product1 = new Product();
        product1.DisplayInfo();

        // Using overloaded constructor
        Product product2 = new Product("Laptop", 999.99);
        product2.DisplayInfo();
    }
}


// C)
using System;

class Employee
{
    public string Name { get; set; }
    public int ID { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }

    // Constructor with required parameters
    public Employee(string name, int id)
    {
        Name = name;
        ID = id;
    }

    // Secondary constructor with optional parameters
    public Employee(string name, int id, string department = "General", double salary = 50000)
    {
        Name = name;
        ID = id;
        Department = department;
        Salary = salary;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, ID: {ID}, Department: {Department}, Salary: {Salary}");
    }

    static void Main(string[] args)
    {
        // Creating an instance using the primary constructor
        Employee emp1 = new Employee("Alice", 101);
        emp1.DisplayInfo();

        // Creating an instance using the secondary constructor
        Employee emp2 = new Employee("Bob", 102, "IT", 75000);
        emp2.DisplayInfo();
    }
}


