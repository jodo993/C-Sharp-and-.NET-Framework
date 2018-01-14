using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvironmentDetails
{
    class Program
    {
        static void ShowEnvironmentDetails()
        {
            // get drives and info about computer
            foreach (string drive in Environment.GetLogicalDrives())
                Console.WriteLine("Drive: {0}", drive);

            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("Processor: {0}", Environment.ProcessorCount);
            Console.WriteLine("NET Version: {0}", Environment.Version);

            Console.ReadLine();
        }

        static void getNameAndAge()
        {
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Age: ");
            string age = Console.ReadLine();

            ConsoleColor oneColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Hi {0}, you're {1} years old??", name,age);

            Console.ForegroundColor = oneColor;
        }

        static int Main(string[] args)
        {
            // Get computer data
            ShowEnvironmentDetails();

            // get name and age
            getNameAndAge();

            Console.ReadLine();
            return -1;
        }
    }
}