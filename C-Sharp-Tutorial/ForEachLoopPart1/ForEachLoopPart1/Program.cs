using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachLoopPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] arrInts = new int[] { 3, 5, 6, 26, 95, 45, 32 };
            foreach(int item in arrInts)
            {
                Console.WriteLine(item);
            }
             * */
            /*
            int sentinel = 0;
            while (sentinel < 10)
            {
                Console.WriteLine(sentinel);
                sentinel++;
            }
             * */
            /*
            int sentinel = 0;
            do
            {
                Console.WriteLine(sentinel);
                sentinel++;
            }
            while (sentinel < 10);
            */

            #region Decision Structures

            //switch statement
            int value = 40;
            switch(value)
            {
                case 0:
                    Console.WriteLine("value is 0");
                    break;
                case 1:
                    Console.WriteLine("value is 1");
                    break;
                case 2:
                    Console.WriteLine("value is 2");
                    break;
                case 3:
                    Console.WriteLine("value is 3");
                    break;
                default:
                    Console.WriteLine("value is something else");
                    break;

            }
            #endregion

        }
    }
}
