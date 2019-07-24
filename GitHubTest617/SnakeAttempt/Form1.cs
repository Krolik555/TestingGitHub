﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeAttempt
{
    public partial class Display : Form
    {
        // instantiate Objects
        Player P1 = new Player();
        Apple apple = new Apple();

        // instantiate global values
        public int MapMaxWidth;
        public int MapMaxHeight;

        Random RandomNumber = new Random();

        public Display()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MapMaxWidth = this.Size.Width - 35; // This value doesn't change once it is set here. Why 35? I don't know. It just works best.
            MapMaxHeight = this.Size.Height - 56; // This value doesn't change once it is set here. Why 56? I don't know. It just works best.

            // SETUP PLAYER 1
            P1.PlayerBody = Player1Body;
            P1.Speed = 3;
            P1.XMax = MapMaxWidth;
            P1.YMax = MapMaxHeight;

            // SETUP APPLE
            apple.AppleBody = AppleBody; // Second AppleBody is on-screen apple.
            apple.Value = 10;
            MoveApple.SpawnApple(apple, MapMaxWidth, MapMaxHeight);

            // Start Game
            timer1.Start();
        }
        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Determine what key is pressed and assign that direction to player 1.
            if (e.KeyCode == Keys.Up)
            {
                P1.CurrentDirection = (int)PlayerControls.Move.Up;
            }
            if (e.KeyCode == Keys.Down)
            {
                P1.CurrentDirection = (int)PlayerControls.Move.Down;
            }
            if (e.KeyCode == Keys.Left)
            {
                P1.CurrentDirection = (int)PlayerControls.Move.Left;
            }
            if (e.KeyCode == Keys.Right)
            {
                P1.CurrentDirection = (int)PlayerControls.Move.Right;
            }
            if (!P1.Alive && e.KeyCode == Keys.Enter)
            {
                RestartPlayer(P1);
            }
            if (e.KeyCode == Keys.P)
            {
                MoveApple.SpawnApple(apple, MapMaxWidth, MapMaxHeight);
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
            if (HitDetect.DetectWallHit(P1))
            {
                P1.Die(aLabelGameOver);
                timer1.Stop();
            }
            if (HitDetect.DetectAppleHit(P1, apple))
            {
                P1.Eat(apple);
                MoveApple.SpawnApple(apple, MapMaxWidth, MapMaxHeight);
            }
            MovePlayer.Now(P1); // Simply, move the player.
        }

        public void RestartPlayer (Player player)
        {
            player.Start(aLabelGameOver, timer1);
        }
    }
}
