using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SnakeAttempt
{
    class MoveApple
    {
        static Random RandomNumber = new Random();
        public static void SpawnApple(Apple apple)
        {
            apple.X = RandomNumber.Next(0, Settings.MapMaxWidth);
            apple.Y = RandomNumber.Next(0, Settings.MapMaxHeight);

            apple.AppleBody.Location = new Point(apple.X, apple.Y);
        }
       
    }
}
