using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
           // Concatinate("Kemar ", "Galloway");
            string word;
            word = Concatinate("Kemar ", "Galloway");
            Console.WriteLine(word);
            
        }


        //static void Concatinate(string first, string last)
        //{
        //    string whole = first + last;
        //}

        static string Concatinate(string first, string last)
        {
            string whole = first + last;
            return whole;
        }
    }
}
