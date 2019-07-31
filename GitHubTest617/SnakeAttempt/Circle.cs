using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAttempt
{
    class Circle
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Rectangle Bounds { get; set; }

        public Circle()
        {
            X = 0;
            Y = 0;
        }

    }
}
