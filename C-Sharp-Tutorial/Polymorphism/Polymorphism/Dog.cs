using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Dog:Animal
    {
        public string name { get; set; }
        public string owner
        {
            get; set;
        }

        public Dog(string nm, string ownr)
        {
            name = nm;
            owner = ownr;
        }

        public override void move()
        {
            //base.move();
            Console.WriteLine("Running");
        }

        public override void makeNoise()
        {
            Console.WriteLine("Bark");
        }

        public void printNames()
        {
            Console.WriteLine(name);
            Console.WriteLine(owner);
        }
    }
}
