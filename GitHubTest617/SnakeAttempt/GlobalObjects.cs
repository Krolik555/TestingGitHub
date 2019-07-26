using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeAttempt
{
    class GlobalObjects
    {
        public static Label aLabelScoreLabel { get; set; }
        public static PictureBox GameDisplay { get; set; }

        public GlobalObjects(Label ScoreLabel)
        {
            aLabelScoreLabel = ScoreLabel;
        }
        public GlobalObjects(PictureBox DisplayBox)
        {
            GameDisplay = DisplayBox;
        }
    }

}
