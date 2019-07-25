using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace SnakeAttempt
{
    class HitDetect
    {
        public static bool DetectWallHit (Player Player)
        {
            // Detect Wall Hit
            if (Player.PlayerHead.Location.X < (Player.XMin - Player.Speed) // Left wall  
                || Player.PlayerHead.Location.X > (Player.XMax + Player.Speed ) // Right Wall  
                || Player.PlayerHead.Location.Y < (Player.YMin - Player.Speed) // Top Wall   
                || Player.PlayerHead.Location.Y > (Player.YMax + Player.Speed)) // Bottom Wall 
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Detects when any of the 4 corners of the player hits any part of the food.
        /// </summary>
        /// <param name="Player"></param>
        /// <param name="Apple"></param>
        /// <returns></returns>
        public static bool DetectFoodHit(Player Player, Apple Apple)
        {
            if (
                // Top left Corner
                Player.X >= Apple.X &&
                Player.X <= Apple.X + 18 &&
                Player.Y >= Apple.Y &&
                Player.Y <= Apple.Y + 18
                 ||
                // Top Right Corner
                Player.X + 18 >= Apple.X &&
                Player.X + 18 < Apple.X + 18 &&
                Player.Y >= Apple.Y &&
                Player.Y <= Apple.Y + 18
                ||
                // Bottom Left Corner
                Player.X >= Apple.X &&
                Player.X < Apple.X + 18 &&
                Player.Y + 18 >= Apple.Y &&
                Player.Y + 18 <= Apple.Y + 18
                ||
                //Bottom Right Corner
                Player.X + 18 >= Apple.X &&
                Player.X + 18 < Apple.X + 18 &&
                Player.Y + 18 >= Apple.Y &&
                Player.Y + 18 <= Apple.Y + 18
                )
            {
                return true;
            }
            return false;
        }
        
    }
}
