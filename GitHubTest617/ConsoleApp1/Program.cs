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

            MyClass mc = new MyClass();

            mc.Task(Call);

        }
        static void Call(int num)
        {
            Console.WriteLine(num);
        }
    }

    

    public class MyClass
    {
        public delegate void Callback(int count);
        public void Task(Callback count)
        {
            for (int i = 0; i < 1000; i++)
            {
                // do something
                count(i);
            }
        }

        
    }


}
