using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace Snake
{
    public partial class Form1 : Form
    {
        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();
        private Circle food2 = new Circle();
        private Circle slowTime = new Circle();
        private Circle fastTime = new Circle();
        private Circle die = new Circle();
        private Circle normalTime = new Circle();
        public Form1()
        {
            InitializeComponent();

            //Set settings to default
            new Settings();

            //Set game speed and start timer
            gameTimer.Interval = 1000 / Settings.Speed;
            gameTimer.Tick += UpdateScreen;
            gameTimer.Start();
            //Start New game
            StartGame();
        }

        private void StartGame()
        {
            lblGameOver.Visible = false;

            //Set settings to default
            new Settings();

            //Create new player object
            Snake.Clear();
            Circle head = new Circle {X = 10, Y = 5};
            Snake.Add(head);


            lblScore.Text = Settings.Score.ToString();
            GenerateFood();
      
            powerUp.Start();
        }

        //Place random food object
        private void GenerateFood()
        {
            int maxXPos = pbCanvas.Size.Width / Settings.Width;
            int maxYPos = pbCanvas.Size.Height / Settings.Height;

            Random random = new Random();
            food = new Circle {X = random.Next(0,random.Next(0, maxXPos)), Y = random.Next(0, maxYPos)};
        }
        
        //Place random fastTime object
        private void GenerateFastTime()
        {
            int maxXPos = pbCanvas.Size.Width / Settings.Width;
            int maxYPos = pbCanvas.Size.Height / Settings.Height;

            Random random1 = new Random();
            fastTime = new Circle { X = random1.Next(0, maxXPos), Y = random1.Next(0, maxYPos) };
        }

        //Place random food2 object
        private void GenerateFood2()
        {
            int maxXPos = pbCanvas.Size.Width / Settings.Width;
            int maxYPos = pbCanvas.Size.Height / Settings.Height;

            Random random = new Random();
            food2 = new Circle { X = random.Next(0, random.Next(0, random.Next(0, maxXPos))), Y = random.Next(0, maxYPos) };
        }

        //Place random die object
        private void GenerateDie()
        {
            int maxXPos = pbCanvas.Size.Width / Settings.Width;
            int maxYPos = pbCanvas.Size.Height / Settings.Height;

            Random random = new Random();
            die = new Circle { X = random.Next(0, maxXPos), Y = random.Next(0, random.Next(0, maxYPos)) };
        }

        //Place random slowTime object
        private void GenerateSlowTime()
        {
            int maxXPos = pbCanvas.Size.Width / Settings.Width;
            int maxYPos = pbCanvas.Size.Height / Settings.Height;

            Random random = new Random();
            slowTime = new Circle { X = random.Next(0, random.Next(0, maxXPos)), Y = random.Next(0, random.Next(0, maxYPos)) };
        }

        //Place random normalTime object
        private void GenerateNormalTime()
        {
            int maxXPos = pbCanvas.Size.Width / Settings.Width;
            int maxYPos = pbCanvas.Size.Height / Settings.Height;

            Random random = new Random();
            normalTime = new Circle { X = random.Next(0, random.Next(0, maxXPos)), Y = random.Next(0, random.Next(0, maxYPos)) };
        }
        private void UpdateScreen(object sender, EventArgs e)
        {
            //Check for Game Over
            if (Settings.GameOver)
            {
                //Check if Enter is pressed
                if (Input.KeyPressed(Keys.Enter))
                {
                    StartGame();
                }
            }
            else
            {
                if (Input.KeyPressed(Keys.Right) && Settings.direction != Direction.Left)
                    Settings.direction = Direction.Right;
                else if (Input.KeyPressed(Keys.Left) && Settings.direction != Direction.Right)
                    Settings.direction = Direction.Left;
                else if (Input.KeyPressed(Keys.Up) && Settings.direction != Direction.Down)
                    Settings.direction = Direction.Up;
                else if (Input.KeyPressed(Keys.Down) && Settings.direction != Direction.Up)
                    Settings.direction = Direction.Down;

                MovePlayer();
            }
            pbCanvas.Invalidate();

        }

        private void pbCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            if (!Settings.GameOver)
            {
                //Set colour of snake

                //Draw snake
                for (int i = 0; i < Snake.Count; i++)
                {
                    Brush snakeColour;
                    if (i == 0)
                        snakeColour = Brushes.Yellow;     //Draw head
                    else
                        snakeColour = Brushes.Green;    //Rest of body

                    //Draw snake
                    canvas.FillEllipse(snakeColour,
                        new Rectangle(Snake[i].X * Settings.Width,
                                      Snake[i].Y * Settings.Height,
                                      Settings.Width, Settings.Height));


                    //Draw Food
                    canvas.FillEllipse(Brushes.Red,
                        new Rectangle(food.X * Settings.Width,
                             food.Y * Settings.Height, Settings.Width, Settings.Height));

                    //Draw Food2
                    canvas.FillEllipse(Brushes.Gold,
                        new Rectangle(food2.X * Settings.Width,
                             food2.Y * Settings.Height, Settings.Width, Settings.Height));
                
                    //Draw FastTime
                    canvas.FillEllipse(Brushes.Blue,
                        new Rectangle(fastTime.X * Settings.Width,
                             fastTime.Y * Settings.Height, Settings.Width, Settings.Height));
                
                    //Draw SlowTime
                    canvas.FillEllipse(Brushes.Violet,
                        new Rectangle(slowTime.X * Settings.Width,
                             slowTime.Y * Settings.Height, Settings.Width, Settings.Height));

                    //Draw Die
                    canvas.FillEllipse(Brushes.Black,
                        new Rectangle(die.X * Settings.Width,
                             die.Y * Settings.Height, Settings.Width, Settings.Height));

                    //Draw NormalTime
                    canvas.FillEllipse(Brushes.Turquoise,
                        new Rectangle(normalTime.X * Settings.Width,
                             normalTime.Y * Settings.Height, Settings.Width, Settings.Height));
                }
            }
            else
            {
                string gameOver = "Game over \nYour final score is: " + Settings.Score + "\nPress Enter to try again";
                lblGameOver.Text = gameOver;
                lblGameOver.Visible = true;
            }
        }


        private void MovePlayer()
        {
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                //Move head
                if (i == 0)
                {
                    switch (Settings.direction)
                    {
                        case Direction.Right:
                            Snake[i].X++;
                            break;
                        case Direction.Left:
                            Snake[i].X--;
                            break;
                        case Direction.Up:
                            Snake[i].Y--;
                            break;
                        case Direction.Down:
                            Snake[i].Y++;
                            break;
                    }


                    //Get maximum X and Y Pos
                    int maxXPos = pbCanvas.Size.Width / Settings.Width;
                    int maxYPos = pbCanvas.Size.Height / Settings.Height;

                    //Detect collission with game borders.
                    if (Snake[i].X < 0 || Snake[i].Y < 0
                        || Snake[i].X >= maxXPos || Snake[i].Y >= maxYPos)
                    {
                        Die();
                    }


                    //Detect collission with body
                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].X == Snake[j].X &&
                           Snake[i].Y == Snake[j].Y)
                        {
                            Die();
                        }
                    }

                    //Detect collision with food piece
                    if (Snake[0].X == food.X && Snake[0].Y == food.Y)
                    {
                        Eat();
                    }

                    //Detect collision with food2 piece
                    if (Snake[0].X == food2.X && Snake[0].Y == food2.Y)
                    {
                        Eat();
                        Eat();
                        food2.X = -1;
                        food2.Y = -1;
                    }

                    //Detect collision with slowTime piece
                    if (Snake[0].X == slowTime.X && Snake[0].Y == slowTime.Y)
                    {
                        gameTimer.Interval = 1100 / Settings.Speed;
                        slowTime.X = -1;
                        slowTime.Y = -1;
                    }

                    //Detect collision with fastTime piece
                    if (Snake[0].X == fastTime.X && Snake[0].Y == fastTime.Y)
                    {
                        gameTimer.Interval = 900 / Settings.Speed;
                        fastTime.X = -1;
                        fastTime.Y = -1;
                    }

                    //Detect collision with die piece
                    if (Snake[0].X == die.X && Snake[0].Y == die.Y)
                    {
                        Die();
                        die.X = -1;
                        die.Y = -1;
                    }

                    //Detect collision with fastTime piece
                    if (Snake[0].X == normalTime.X && Snake[0].Y == normalTime.Y)
                    {
                        gameTimer.Interval = 1000 / Settings.Speed;
                        normalTime.X = -1;
                        normalTime.Y = -1;
                    }
                }
                else
                {
                    //Move body
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }

        private void Eat()
        {
            //Add circle to body
            Circle circle = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };
            Snake.Add(circle);

            //Update Score
            Settings.Score += Settings.Points;
            lblScore.Text = Settings.Score.ToString();

            GenerateFood();
        }

        private void Die()
        {
            Settings.GameOver = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void powerUp_Tick(object sender, EventArgs e)
        {
            food2.X = -1;
            food2.Y = -1;
            slowTime.X = -1;
            slowTime.Y = -1;
            fastTime.X = -1;
            fastTime.Y = -1;
            normalTime.X = -1;
            normalTime.Y = -1;
            die.X = -1;
            die.Y = -1;
            Random a = new Random();
            int b = a.Next(0, 6);
            if (b == 1)
                GenerateFood2();
            else if (b == 2)
                GenerateSlowTime();
            else if (b == 3)
                GenerateFastTime();
            else if (b == 4)
                GenerateDie();
            else if (b == 5)
                GenerateNormalTime();
        }

       
    }
}
