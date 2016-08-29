using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDEMO
{
    class Animal
    {
        private string type;
        private string color;
        private string weight;
        private string height;
        private int age;
        private int numOfLegs;

        public void move()
        {
            Console.WriteLine("move");
        }

        public void makeNoise()
        {
            Console.WriteLine("Make noise");
        }
    }
}
