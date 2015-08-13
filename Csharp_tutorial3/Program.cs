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

            Console.WriteLine("Type a superhero's name to see his nickname:");
            string userValue = Console.ReadLine();

            SuperHero myValue;

            //In C# a <> is called a generic method.
            //Parameters:
            //1st:string to lookup
            //2nd:boolean to ignore capitalization
            //3rd:output parameter, returned from the TryParse

            if (Enum.TryParse<SuperHero>(userValue, true, out myValue))
            {
                //myValue [enter] [enter] lists all the values in the corresponding
                //enumeration

                switch (myValue)
                {
                    case SuperHero.Batman:
                        Console.WriteLine("Caped Crusader");
                        break;
                    case SuperHero.Superman:
                        Console.WriteLine("Man of Steel");
                        break;
                    case SuperHero.GreenLantern:
                        Console.WriteLine("Emerald Knight");
                        break;
                    default:
                        break;
                }
            }
            else 
            {
                Console.WriteLine("Does not compute");
            }

            Console.ReadLine();

        }
    }

    enum SuperHero
    { 
        Batman,
        Superman,
        GreenLantern
    }
}
