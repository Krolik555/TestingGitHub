using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeAttempt
{
    public class Apple
    {
        public PictureBox AppleBody = new PictureBox();
        public int Value { get; set; }

        public int X { get; set; }
        public int Y { get; set; }
    }
}
