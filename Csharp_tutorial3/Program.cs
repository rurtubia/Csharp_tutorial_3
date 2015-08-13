using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_tutorial3
{
    //Understanding enumerations
    class Program
    {
        static void Main(string[] args)
        {
            //Using the ConsoleColor enumeration:
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Hello World");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("GoodBye World");
            Console.ReadLine();

        }
    }
}
