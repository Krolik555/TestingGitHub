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
                _player.PlayerBody.Location = new Point(_player.X, _player.Y);
            }
            else if(_player.CurrentDirection == 2) // Down
            {
                _player.Y += _player.Speed;
                _player.PlayerBody.Location = new Point(_player.X, _player.Y);
            }
            else if (_player.CurrentDirection == 3) // Left
            {
                _player.X -= _player.Speed;
                _player.PlayerBody.Location = new Point(_player.X, _player.Y);
            }
            else if (_player.CurrentDirection == 4) // Right
            {
                _player.X += _player.Speed;
                _player.PlayerBody.Location = new Point(_player.X, _player.Y);
            }
        }
    }
}
