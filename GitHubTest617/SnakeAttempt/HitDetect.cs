using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeAttempt
{
    class HitDetect
    {
        public static bool DetectWallHit (Player Player)
        {
            // Detect Wall Hit
            if (Player.PlayerBody.Location.X < (Player.XMin - Player.Speed) // Left wall  
                || Player.PlayerBody.Location.X > (Player.XMax + Player.Speed ) // Right Wall  
                || Player.PlayerBody.Location.Y < (Player.YMin - Player.Speed) // Top Wall   
                || Player.PlayerBody.Location.Y > (Player.YMax + Player.Speed)) // Bottom Wall 
            {
                return true;
            }
            return false;
        }

        public static bool DetectAppleHit(Player Player, Apple Apple)
        {
            if (Player.X >= Apple.X && Player.X <= Apple.X+18)
            {
                return true;
            }
            return false;
        }
        
    }
}
