using System;
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
        //Player P1 = new Player();
        Apple apple = new Apple();

        List<Circle> Snake = new List<Circle>();
        Circle Food = new Circle();


        Random RandomNumber = new Random();

        public Display()
        {
            InitializeComponent();
            new GlobalObjects(aLabelScoreLabel);
            new GlobalObjects(aPictureBoxDisplay);
            new Settings();



            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // SETUP PLAYER 1
            //P1.Segment_PictureBox = aPictureBoxBodySegmant;
            //P1.Segment_PictureBox.Size = new Size(Settings.PlayerWidth, Settings.PlayerHeight);
            //P1.Start(aLabelGameOver, timer1);

            // SETUP APPLE
            apple.AppleBody = AppleBody; // Second AppleBody is on-screen apple.
            apple.AppleBody.Size = new Size(Settings.FoodWidth, Settings.FoodHeight);
            apple.Value = 10;
            MoveApple.SpawnApple(apple);




            // Start Game
            timer1.Start();
            StartGame();
        }
        
        public void StartGame()
        {
            new Settings();

            Snake.Clear();
            Circle head = new Circle();
            head.X = Settings.XDefault;
            head.Y = Settings.YDefault;
            Snake.Add(head);
            Settings.GameOver = false;
            aLabelGameOver.Visible = false;
            timer1.Start();
            
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Determine what key is pressed and assign that direction to player 1.
            if (e.KeyCode == Keys.Up)
            {
                Settings.direction = Direction.Up;
            }
            if (e.KeyCode == Keys.Down)
            {
                Settings.direction = Direction.Down;
            }
            if (e.KeyCode == Keys.Left)
            {
                Settings.direction = Direction.Left;
            }
            if (e.KeyCode == Keys.Right)
            {
                Settings.direction = Direction.Right;
            }
            if (Settings.GameOver && e.KeyCode == Keys.Enter)
            {
                StartGame();
            }
            if (e.KeyCode == Keys.P)
            {
                MoveApple.SpawnApple(apple);

            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            aPictureBoxDisplay.Invalidate();
            Rectangle Head = new Rectangle(Snake[0].X, Snake[0].Y,
                                  Settings.PlayerWidth, Settings.PlayerHeight);

            // Detect if player hits wall
            if (HitDetect.DetectWallHit(Head, aPictureBoxDisplay))
            {
                Die(aLabelGameOver);
                timer1.Stop();
            }
            // Detect if player hits food
            if (HitDetect.DetectFoodHit(Head, apple))
            {
                Eat(apple);
                MoveApple.SpawnApple(apple);
            }
            // Move player every tick
            MovePlayer.Now(Snake);

            // Update score and body size labels
            aLabelScore.Text = Settings.Score.ToString();
            aLabelBodySize.Text = Settings.BodySize.ToString();

        }



        public void Eat(Apple AppleAte) // Grow Body
        {
            Circle segment = new Circle();
            segment.X = Snake[Snake.Count - 1].X;
            segment.Y = Snake[Snake.Count - 1].Y;
            Settings.Score += AppleAte.Value;
            Settings.BodySize += 1;
            Snake.Add(segment);
        }

        public void Die(Label GameOverLabel)
        {
            GameOverLabel.Visible = true;
            Settings.GameOver = true;
        }

        private void APictureBoxDisplay_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            Brush snakeColor;
            for (int i = 0; i <= Snake.Count - 1; i++)
            {
                if (i == 0) 
                {
                    snakeColor = Brushes.White; // Draw Head
                }
                else 
                {
                    snakeColor = Brushes.Gold; // Draw Body
                }

                // Draw Snake
                canvas.FillRectangle(snakeColor,
                    new Rectangle(Snake[i].X,
                                  Snake[i].Y,
                                  Settings.PlayerWidth, Settings.PlayerHeight));


                
            }
        }
    }
}
