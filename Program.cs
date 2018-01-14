using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocking_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Welcome to Rock";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("------------------------");
            Console.WriteLine("     ROCK ROCK ROCK     ");
            Console.WriteLine("------------------------");
            Console.BackgroundColor = ConsoleColor.White;

            Console.ReadLine();
        }
    }
}
