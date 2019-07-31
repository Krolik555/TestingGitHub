using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SnakeAttempt
{
    static class MovePlayer
    {
        //private static int _Direction;
        //public static int Direction { set { _Direction = value < 4 ? value : 0; } }

        public static void Now(List<Circle> snake)
        {
            for (int i = snake.Count - 1; i >= 0; i--)
            {
                if (i == 0) // 0 = head
                {
                    switch (Settings.direction)
                    {
                        case Direction.Up:
                            snake[i].X = snake[i].X;
                            snake[i].Y = snake[i].Y - Settings.Speed;
                            break;
                        case Direction.Down:
                            snake[i].X = snake[i].X;
                            snake[i].Y = snake[i].Y + Settings.Speed;
                            break;
                        case Direction.Left:
                            snake[i].X = snake[i].X - Settings.Speed;
                            snake[i].Y = snake[i].Y;
                            break;
                        case Direction.Right:
                            snake[i].X = snake[i].X + Settings.Speed;
                            snake[i].Y = snake[i].Y;
                            break;
                    }
                }
                else
                {
                    snake[i].X = snake[i - 1].X;
                    snake[i].Y = snake[i - 1].Y;
                    //_player.PlayerBody[i].Location = new Point(_player.PlayerBody[i - 1].Location.X, _player.PlayerBody[i - 1].Location.Y);
                }

                //for (int i = _player.PlayerBody.Count - 1; i >= 0; i--)
                //{
                //    if (i == 0) // 0 = head
                //    {
                //        switch (Settings.direction)
                //        {
                //            case Direction.Up:
                //                Settings.HeadHistoryX = _player.PlayerBody[i].Location.X;
                //                Settings.HeadHistoryY = _player.PlayerBody[i].Location.Y;
                //                _player.PlayerBody[i].Location = new Point(_player.PlayerBody[i].Location.X, _player.PlayerBody[i].Location.Y - Settings.Speed);
                //                break;
                //            case Direction.Down:
                //                Settings.HeadHistoryX = _player.PlayerBody[i].Location.X;
                //                Settings.HeadHistoryY = _player.PlayerBody[i].Location.Y;
                //                _player.PlayerBody[i].Location = new Point(_player.PlayerBody[i].Location.X, _player.PlayerBody[i].Location.Y + Settings.Speed);
                //                break;
                //            case Direction.Left:
                //                Settings.HeadHistoryX = _player.PlayerBody[i].Location.X;
                //                Settings.HeadHistoryY = _player.PlayerBody[i].Location.Y;
                //                _player.PlayerBody[i].Location = new Point(_player.PlayerBody[i].Location.X - Settings.Speed, _player.PlayerBody[i].Location.Y);
                //                break;
                //            case Direction.Right:
                //                Settings.HeadHistoryX = _player.PlayerBody[i].Location.X;
                //                Settings.HeadHistoryY = _player.PlayerBody[i].Location.Y;
                //                _player.PlayerBody[i].Location = new Point(_player.PlayerBody[i].Location.X + Settings.Speed, _player.PlayerBody[i].Location.Y);
                //                break;
                //        }
                //    }
                //    else if(i == _player.PlayerBody.Count - 1)
                //    {
                //        _player.PlayerBody[_player.PlayerBody.Count - 1].Location = new Point(Settings.HeadHistoryX, Settings.HeadHistoryY);
                //        //_player.PlayerBody[i].Location = new Point(_player.PlayerBody[i - 1].Location.X, _player.PlayerBody[i - 1].Location.Y);
                //    }
                //    else
                //    {

                //    }
                //}



            }
        }
    }
}
