using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDEMO
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal newAnimal = new Animal();
            newAnimal.move();
            newAnimal.makeNoise();
        }
    }
}
