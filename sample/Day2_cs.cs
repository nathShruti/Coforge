//1st Example
class Coforge
{
    public readonly int EID; //Instance readonly (Makes separate copy for each object and ensure that one time initialization)
    public double salary; //Instance variably (Makes separate copy for each object and we can change the value)
    public static int officePhNo; //Global variable (makes single copy for all objects)
    public readonly static int LeavePolicy; //Global variable (makes single copy for all objects)
    public const int EstYear = 2001; //Global variable (makes single copy but initialization takes place at the point of declaration)

    static Coforge()
    {
        Console.WriteLine("static constructor");
    }
}

class Controller
{
    public static void Main()
    {
        Coforge deepa = new Coforge();
        Console.WriteLine("Inside main");
        Console.WriteLine(deepa.EID);
    }
}

//2nd Example - Static variable
public class Logger
{
    private static int logCount = 0;
    public static void Log(string message)
    {
        logCount++;
        Console.WriteLine($"[{DateTime.Now}] {message}");
    }
    public static int GetLogCount()
    {
        return logCount;
    }
}

// Usage
class Start
{
    public static void Main()
    {
        Logger.Log("Application started.");
        Logger.Log("Error: File not found.");
        int count = Logger.GetLogCount();
        Console.WriteLine($"Total logs: {count}");
    }
}

//3rd Example - Static constructor
public class DatabaseConnection
{
    private static string connectionString;

    // Static constructor to initialize the static variable
    static DatabaseConnection()
    {
        connectionString = "YourDatabaseConnectionString";
        // Additional setup tasks can be performed here
        Console.WriteLine("Static constructor called.");
    }

    public static void Connect()
    {
        Console.WriteLine($"Connecting to database with connection string: {connectionString}");
        // Logic to establish database connection
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Call the static method without creating an instance
        DatabaseConnection.Connect();
    }
}

//4th Example - Type conversion
public class Program
{
    static void Main(string[] args)
    {
        // Implicit conversion
        int num = 10;
        double numDouble = num; // Implicit conversion from int to double

        Console.WriteLine($"Implicit conversion: int to double -> {numDouble}");

        // Explicit conversion (casting)
        double pi = 3.14159;
        int piInt = (int)pi; // Explicit cast from double to int

        Console.WriteLine($"Explicit conversion (casting): double to int -> {piInt}");

        // Using Convert class for type conversion
        string numberString = "123";
        int parsedNumber = Convert.ToInt32(numberString);

        Console.WriteLine($"Convert.ToInt32 example: {parsedNumber}");

        // Using as operator for reference type conversion
        object obj = "Hello";
        string str = obj as string;

        if (str != null)
        {
            Console.WriteLine($"Using 'as' operator: {str}");
        }
        else
        {
            Console.WriteLine("Conversion using 'as' failed.");
        }
    }
}
