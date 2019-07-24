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
            X = 283;
            XDefault = 283;
            Y = 271;
            YDefault = 271;

            Speed = 1;
        }
        // Other stuff
        public PictureBox PlayerBody = new PictureBox();
        public int CurrentDirection { get; set; }

        // Player Location
        public int X { get; set; }
        public int Y { get; set; }

        public int XDefault { get; }
        public int YDefault { get; }

        // Min Player Location
        public int XMin { get; set; }
        public int YMin { get; set; }

        // Max Player Location
        public int XMax { get; set; }
        public int YMax { get; set; }

        // STATS
        public bool Alive { get; set; }
        public int Length { get; set; }
        public int Speed { get; set; }
        public int Score { get; set; }




        public void Start(Label GameOverLabel, Timer timer) // Reset to defaults
        {
            // RESET ALL VALUES
            X = XDefault;
            Y = YDefault;
            PlayerBody.Location = new System.Drawing.Point(X, Y); // reset body location
            GameOverLabel.Visible = false;
            Alive = true;
            Length = 1;
            Speed = 3;
            CurrentDirection = 0;

            // Start Game
            timer.Start();

            
        }

        public void Eat(Apple Apple) // Grow Body
        {
            Score += Apple.Value;
            Length++;
        }

        public void Die(Label GameOverLabel)
        {
            GameOverLabel.Visible = true;
            Alive = false;
        }
    }
}
