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

            var a = 2;
            var b = "1";
            var c = 0;
            var d = int.Parse(b);
            var e = int.Parse(b + c);
            var ee = e / 21;
            var f = int.Parse(a + b + c) / 21;
            Console.Write(f);

            Console.ReadKey();
        }
    }


}
