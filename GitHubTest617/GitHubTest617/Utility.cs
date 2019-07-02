using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubTest617
{
    class Utility
    {
        public static bool CompareValue<T01, T02>(T01 Value01, T02 Value02)
        {
            return Value01.Equals(Value02);
        }

        public static bool CompareType<T01, T02>(T01 t1, T02 t2)
        {
            return typeof(T01).Equals(typeof(T02));
        }

    }
}
