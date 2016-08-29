using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a number, any number");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Console.WriteLine("Did you type {0}?", keyInfo.KeyChar.ToString());
 
            Dog spot = new Dog("Spot","Kemar");
            Console.WriteLine("Enter dog's name");
            spot.name = Console.ReadLine();
            Console.WriteLine("Enter owner's name");
            spot.owner = Console.ReadLine();

            Console.WriteLine("Names are:");

            spot.printNames();
            spot.Age = 5;
            spot.move();
            spot.makeNoise();
            Console.ReadLine();
            
        }
    }
}
