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

/*
Coforge block memory created. EID and salary will go here.

*/