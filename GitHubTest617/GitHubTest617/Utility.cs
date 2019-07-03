using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHubTest617
{
    class Utility
    {
        public static bool CompareValue<T01, T02>(T01 Value01, T02 Value02)
        {
            return Value01.Equals(Value02);
        }

        public static bool CompareType<T01, T02>(ref T01 t1,ref T02 t2)
        {
            return typeof(T01).Equals(typeof(T02));
        }
        public static void Swap<T>(ref T t1, ref T t2)
        {
            T temp = t1;
            t1 = t2;
            t2 = temp;
        }


        // #Delegate Testing#

        public static void Display(int i)
        {
            MessageBox.Show(i.ToString());
        }
        public static void M2()
        {
            MessageBox.Show("M2 Changed me");
        }
    }
}
