using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeAttempt
{
    public class Player
    {

        public Player()
        {
            XDefault = 283;
            YDefault = 271;
        }
        // Player's Head
        public PictureBox PlayerHead = new PictureBox();
        // Players Body
        public PictureBox _BodySegment = new PictureBox();
        public List<PictureBox> PlayerBody = new List<PictureBox>(); 

        // Direction the Player is currently going
        public int CurrentDirection { get; set; }

        // Current Player Location
        public int X { get; set; }
        public int Y { get; set; }

        // Default Player Location
        public int XDefault { get; }
        public int YDefault { get; }

        // Min Player Location
        public int XMin { get; set; }
        public int YMin { get; set; }

        // Max Player Location
        public int XMax { get; set; }
        public int YMax { get; set; }

        // Player STATS
        public bool Alive { get; set; }
        public int Length { get; set; }
        public int Speed { get; set; }
        public int Score { get; set; }




        public void Start(Label GameOverLabel, Timer timer) // Reset to defaults
        {
            // RESET ALL VALUES
            X = XDefault;
            Y = YDefault;
            PlayerHead.Location = new System.Drawing.Point(X, Y); // reset body location
            GameOverLabel.Visible = false;
            Alive = true;
            Length = 1;
            Speed = 3;
            CurrentDirection = 0;

            // Start Game
            timer.Start();

            
        }

        public void Eat(Apple AppleAte, PictureBox SegmentAdded) // Grow Body
        {
            Score += AppleAte.Value;
            PlayerBody.Add(SegmentAdded);
        }

        public void Die(Label GameOverLabel)
        {
            GameOverLabel.Visible = true;
            Alive = false;
        }

    }
}
