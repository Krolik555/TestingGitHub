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
        public static bool DetectWallHit(Rectangle head, PictureBox Display)
        {
            // Detect Wall Hit
            if (
                !head.IntersectsWith(Display.Bounds))
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
        public static bool DetectFoodHit(Rectangle head, Apple Apple)
        {
            if (head.IntersectsWith(Apple.AppleBody.Bounds))
            {
                return true;
            }
            return false;
        }
        
    }
}
