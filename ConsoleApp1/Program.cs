using Newtonsoft.Json;
using System;
using Humanizer;
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
            string json = JsonConvert.SerializeObject(value1);

            Console.WriteLine($"Serialized JSON: {json}");

            TimeSpan duration = TimeSpan.FromMinutes(125);

            Console.WriteLine($"Duration: {duration}");
            Console.WriteLine($"Humanized duration: {duration.Humanize()}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

