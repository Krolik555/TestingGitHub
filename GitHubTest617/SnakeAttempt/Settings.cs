using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAttempt
{
    public enum Direction
    {
        Up, Down, Left, Right, Stop
    };
    class Settings
    {
        public static int PlayerWidth { get; set; }
        public static int PlayerHeight { get; set; }
        public static int FoodWidth { get; set; }
        public static int FoodHeight { get; set; }
        public static int MapMaxWidth { get; set; }
        public static int MapMaxHeight { get; set; }
        public static int MapMinWidth { get; set; }
        public static int MapMinHeight { get; set; }
        public static int XDefault { get; set; }
        public static int YDefault {get;set;}
        public static int Speed { get; set; }
        public static int Score { get; set; }
        public static int Points { get; set; }
        public static int BodySize { get; set; }
        public static bool GameOver { get; set; }
        public static Direction direction { get; set; }


        public static int HeadHistoryX { get; set; }
        public static int HeadHistoryY { get; set; }

        public Settings()
        {
            PlayerWidth = 18;
            PlayerHeight = 18;
            FoodWidth = 18;
            FoodHeight = 18;
            XDefault = 283;
            YDefault = 271;
            MapMaxWidth = GlobalObjects.GameDisplay.Size.Width - PlayerWidth;
            MapMaxHeight = GlobalObjects.GameDisplay.Size.Height - PlayerHeight;
            MapMinWidth = 0;
            MapMinHeight = 0;
            Speed = 18;
            Score = 0;
            Points = 10;
            BodySize = 0;
            GameOver = false;
            direction = Direction.Stop;
        }
    }
}
