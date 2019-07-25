using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeAttempt
{
    public class BodySegment
    {
        public int X { get; set; }
        public int Y { get; set; }

        public PictureBox SegmentBox = new PictureBox();

    }
}
