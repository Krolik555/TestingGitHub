using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {

            int x = 5;
            int y = ++x;
            int z = x++;
            x += y;
            Console.Write(x);

            Console.Write(" ");
            int i = 1;
            int f = 1;
            Console.Write(i++);
            Console.Write(++f);

            Console.ReadKey();
        }
    }


}
