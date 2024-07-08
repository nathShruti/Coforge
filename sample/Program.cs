using System;
using System.Xml.Serialization;

public class MyClass
{
    private static int instanceCount;
    private static readonly DateTime creationTime;
    //static constructor
    static MyClass()
    {
        instanceCount = 0; //initialize static field
        creationTime = DateTime.Now; //Initialize readonly static field
        Console.WriteLine("Static constructor called.");
    }
    //Method to print instance count
    public static void PrintInstanceCount()
    {
        Console.WriteLine($"Number of instances created: {instanceCount}");
    }
    //Method to print creation time
    public static void PrintCreationTime()
    {
        Console.WriteLine($"Class Creation time: {creationTime}");
    }
}

public class Program
{
    public static void Main()
    {
        //Accessing static members triggers static constructor
        MyClass.PrintInstanceCount();
        MyClass.PrintCreationTime();
    }
}