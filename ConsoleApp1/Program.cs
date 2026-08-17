using System;
namespace SampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deployment Activity 1: Pass Task Completed!");
            Console.WriteLine("Hello world! This is a simple console application.");
            Console.WriteLine("Please enter a value:");
            string value1 = Console.ReadLine();
            Console.WriteLine($"You entered: {value1}");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
