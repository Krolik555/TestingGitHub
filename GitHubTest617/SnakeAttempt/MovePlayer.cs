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
        
        public static void Now(Player _player)
        {
            if (_player.CurrentDirection == 1) // Up
            {
                _player.Y -= _player.Speed;
                _player.PlayerHead.Location = new Point(_player.X, _player.Y);
                // Draw Snake Body
                if (_player.PlayerBody.Count > 0)
                {
                    for (int i = 0; i < _player.PlayerBody.Count; i++)
                    {
                        if (i == 0) // If this is first segment
                        {
                            _player.PlayerBody[i].Location = new Point(_player.X, _player.Y + 20);
                        }
                        else
                        {
                            _player.PlayerBody[i].Location = new Point(_player.PlayerBody[i-1].Location.X , _player.PlayerBody[i-1].Location.Y + 20);
                        }
                    }
                    //foreach (PictureBox Segment in _player.PlayerBody)
                    //{
                    //    Segment.Location = new Point(_player.X, _player.Y + 20);
                    //}
                }
            }
            else if(_player.CurrentDirection == 2) // Down
            {
                _player.Y += _player.Speed;
                _player.PlayerHead.Location = new Point(_player.X, _player.Y);
                // Draw Snake Body
                if (_player.PlayerBody.Count > 0)
                {
                    for (int i = 0; i < _player.PlayerBody.Count; i++)
                    {
                        if (i == 0) // If this is first segment
                        {
                            _player.PlayerBody[i].Location = new Point(_player.X, _player.Y - 20);
                        }
                        else
                        {
                            _player.PlayerBody[i].Location = new Point(_player.PlayerBody[i - 1].Location.X, _player.PlayerBody[i - 1].Location.Y - 20);
                        }
                    }
                }
            }
            else if (_player.CurrentDirection == 3) // Left
            {
                _player.X -= _player.Speed;
                _player.PlayerHead.Location = new Point(_player.X, _player.Y);
                // Draw Snake Body
                for (int i = 0; i < _player.PlayerBody.Count; i++)
                {
                    if (i == 0) // If this is first segment
                    {
                        _player.PlayerBody[i].Location = new Point(_player.X + 20, _player.Y);
                    }
                    else
                    {
                        _player.PlayerBody[i].Location = new Point(_player.PlayerBody[i - 1].Location.X + 20, _player.PlayerBody[i - 1].Location.Y);
                    }
                }
            }
            else if (_player.CurrentDirection == 4) // Right
            {
                _player.X += _player.Speed;
                _player.PlayerHead.Location = new Point(_player.X, _player.Y);
                // Draw Snake Body
                if (_player.PlayerBody.Count > 0)
                {
                    for (int i = 0; i < _player.PlayerBody.Count; i++)
                    {
                        if (i == 0) // If this is first segment
                        {
                            _player.PlayerBody[i].Location = new Point(_player.X - 20, _player.Y);
                        }
                        else
                        {
                            _player.PlayerBody[i].Location = new Point(_player.PlayerBody[i - 1].Location.X -20, _player.PlayerBody[i - 1].Location.Y);
                        }
                    }
                }
            }
        }
    }
}
