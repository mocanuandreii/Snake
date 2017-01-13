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
        private Circle MancareDubla = new Circle();
        private Circle TimpIncet = new Circle();
        private Circle timpRapid = new Circle();
        private Circle die = new Circle();
        private Circle TimpNormal = new Circle();
        private int Maxim;

        public bool X { get; private set; }

        public Form1()
        {
            InitializeComponent();

            //Seteaza setarile Default
            new Settings();
            lblHighScore2.Text = System.IO.File.ReadAllText(@"D:\Snake\HighScore.txt"); 
            Maxim = int.Parse(System.IO.File.ReadAllText(@"D:\Snake\HighScore.txt"));
            playerName.Text = System.IO.File.ReadAllText(@"D:\Snake\playerName.txt");
            //Seteaza viteza jocului si timerul
            gameTimer.Interval = 1000 / Settings.Viteza;
            gameTimer.Tick += UpdateScreen;
            gameTimer.Start();
            //Incepe Joc Nou
            IncepeJocul();
        }

        private void IncepeJocul()
        {
            timer1.Stop();
            lblBestPlayer.Visible = false;
            textBox.Visible = false;
            textBox.Enabled = false;
            button1.Visible = false;
            button1.Enabled = false;
            lblTimpIncet1.Visible = false;
            lblTimpRapid1.Visible = false;
            lblTimpNormal1.Visible = true;
            lblPause.Visible = false;
            lblGameOver.Visible = false;

            //Seteaza setarile Default
            new Settings();

            //Adauga capul sarpelui
            Snake.Clear();
            Circle head = new Circle { X = 10, Y = 10 };
            Snake.Add(head);


            lblScore.Text = Settings.Scor.ToString();
            GenereazaMancare();

            powerUp.Start();
        }

        //Plaseaza mancare random
        private void GenereazaMancare()
        {
            int maxXPos = pbCanvas.Size.Width / Settings.Width;
            int maxYPos = pbCanvas.Size.Height / Settings.Height;

            Random random = new Random();
            food = new Circle { X = random.Next(0, random.Next(0, maxXPos)), Y = random.Next(0, maxYPos) };
        }

        //Plaseaza mancare timpRapid
        private void GenereazaTimpRapid()
        {
            int maxXPos = pbCanvas.Size.Width / Settings.Width;
            int maxYPos = pbCanvas.Size.Height / Settings.Height;

            Random random1 = new Random();
            timpRapid = new Circle { X = random1.Next(0, maxXPos), Y = random1.Next(0, maxYPos) };
        }

        //Plaseaza Mancare Dubla 
        private void GenereazaMancareDubla()
        {
            int maxXPos = pbCanvas.Size.Width / Settings.Width;
            int maxYPos = pbCanvas.Size.Height / Settings.Height;

            Random random = new Random();
            MancareDubla = new Circle { X = random.Next(0, random.Next(0, random.Next(0, maxXPos))), Y = random.Next(0, maxYPos) };
        }

        //Plaseaza mancare moarte
        private void GenereazaMoarte()
        {
            int maxXPos = pbCanvas.Size.Width / Settings.Width;
            int maxYPos = pbCanvas.Size.Height / Settings.Height;

            Random random = new Random();
            die = new Circle { X = random.Next(0, maxXPos), Y = random.Next(0, random.Next(0, maxYPos)) };
        }

        //Plaseaza mancare Timp Incet
        private void GenereazaTimpIncet()
        {
            int maxXPos = pbCanvas.Size.Width / Settings.Width;
            int maxYPos = pbCanvas.Size.Height / Settings.Height;

            Random random = new Random();
            TimpIncet = new Circle { X = random.Next(0, random.Next(0, maxXPos)), Y = random.Next(0, random.Next(0, maxYPos)) };
        }

        //Plaseaza mancare Timp Normal
        private void GenereazaTimpNormal()
        {
            int maxXPos = pbCanvas.Size.Width / Settings.Width;
            int maxYPos = pbCanvas.Size.Height / Settings.Height;

            Random random = new Random();
            TimpNormal = new Circle { X = random.Next(0, random.Next(0, maxXPos)), Y = random.Next(0, random.Next(0, maxYPos)) };
        }
        private void UpdateScreen(object sender, EventArgs e)
        {
            //Verifica Joc Terminat
            if (Settings.JocTerminat)
            {
                //Verifica daca s-a apasat tasta S
                if (Input.KeyPressed(Keys.S))
                {
                    IncepeJocul();
                }
            }
            else
            {
                if (Input.KeyPressed(Keys.Right) && Settings.direction != Direction.Left)
                {
                    Settings.direction = Direction.Right;
                    lblPause.Visible = false;
                }
                else if (Input.KeyPressed(Keys.Left) && Settings.direction != Direction.Right)
                {
                    Settings.direction = Direction.Left;
                    lblPause.Visible = false;
                }
                else if (Input.KeyPressed(Keys.Up) && Settings.direction != Direction.Down)
                {
                    Settings.direction = Direction.Up;
                    lblPause.Visible = false;
                }
                else if (Input.KeyPressed(Keys.Down) && Settings.direction != Direction.Up)
                {
                    Settings.direction = Direction.Down;
                    lblPause.Visible = false;
                }
                else if (Input.KeyPressed(Keys.P) && Settings.direction != Direction.Stay)
                {
                    Settings.direction = Direction.Stay;
                    lblPause.Visible = true;
                }
                MiscaJucator();
            }
            pbCanvas.Invalidate();

        }

        private void pbCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            if (!Settings.JocTerminat)
            {
                //Seteaza culoarea sarpelui

                //Deseneaza sarpele
                for (int i = 0; i < Snake.Count; i++)
                {
                    Brush snakeColour;
                    if (i == 0)
                        snakeColour = Brushes.Purple;     //Deseneaza capul sarpelui
                    else
                        snakeColour = Brushes.MediumPurple;    //Deseneaza restul corpului

                    //Deseneaza sarpe
                    canvas.FillEllipse(snakeColour,
                        new Rectangle(Snake[i].X * Settings.Width,
                                      Snake[i].Y * Settings.Height,
                                      Settings.Width, Settings.Height));


                    //Deseneaza Mancare
                    canvas.FillEllipse(Brushes.Red,
                        new Rectangle(food.X * Settings.Width,
                             food.Y * Settings.Height, Settings.Width, Settings.Height));

                    //Deseneaza Mancare Dubla
                    canvas.FillEllipse(Brushes.Gold,
                        new Rectangle(MancareDubla.X * Settings.Width,
                             MancareDubla.Y * Settings.Height, Settings.Width, Settings.Height));

                    //Deseneaza Timp Rapid
                    canvas.FillEllipse(Brushes.Blue,
                        new Rectangle(timpRapid.X * Settings.Width,
                             timpRapid.Y * Settings.Height, Settings.Width, Settings.Height));

                    //Deseneaza Timp Incet
                    canvas.FillEllipse(Brushes.Chocolate,
                        new Rectangle(TimpIncet.X * Settings.Width,
                             TimpIncet.Y * Settings.Height, Settings.Width, Settings.Height));

                    //Deseneaza Moarte
                    canvas.FillEllipse(Brushes.Black,
                        new Rectangle(die.X * Settings.Width,
                             die.Y * Settings.Height, Settings.Width, Settings.Height));

                    //Deseneaza Timp Normal
                    canvas.FillEllipse(Brushes.Turquoise,
                        new Rectangle(TimpNormal.X * Settings.Width,
                             TimpNormal.Y * Settings.Height, Settings.Width, Settings.Height));
                }
            }
            else
            {
                string JocTerminat = "          Game over \nScorul tau final este: " + Settings.Scor + "\nApasa S \npentru a reincerca";
                if (Settings.Scor > Maxim)
                {
                    Maxim = Settings.Scor;
                    lblHighScore2.Text = Settings.Scor.ToString();
                    System.IO.File.WriteAllText(@"D:\Snake\HighScore.txt", string.Empty);
                    using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter(@"D:\Snake\HighScore.txt", true))
                    {
                        file.WriteLine(Maxim);
                    }
                    lblBestPlayer.Visible = true;
                    textBox.Visible = true;
                    button1.Visible = true;
                    button1.Enabled = true;
                    textBox.Enabled = true;
                    lblGameOver.Text = JocTerminat;
                    lblGameOver.Visible = true;
                }
                else
                {
                    button1.Enabled = true;
                    textBox.Enabled = true;
                    lblGameOver.Text = JocTerminat;
                    lblGameOver.Visible = true;
                }
           }
        }


        private void MiscaJucator()
        {
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                //Muta Sarpele
                if (i == 0)
                {
                    switch (Settings.direction)
                    {
                        case Direction.Right:
                            Snake[i].X++;
                            X = false;
                            break;
                        case Direction.Left:
                            Snake[i].X--;
                            X = false;
                            break;
                        case Direction.Up:
                            Snake[i].Y--;
                            X = false;
                            break;
                        case Direction.Down:
                            Snake[i].Y++;
                            break;
                        case Direction.Stay:
                            for (int j = 0; j <= Snake.Count - 1; j++)
                            {
                                Snake[j].X += 0;
                                Snake[j].Y += 0;
                                X = true;
                            }
                            break;
                    }


                    //Pozitiile maxime de X si Y
                    int maxXPos = pbCanvas.Size.Width / Settings.Width;
                    int maxYPos = pbCanvas.Size.Height / Settings.Height;

                    //Detecteaza coliziunea cu limitele jocului
                    if (Snake[i].X < 0)
                        Snake[i].X = maxXPos-1;
                    if (Snake[i].Y < 0)
                        Snake[i].Y = maxYPos-1;
                    if (Snake[i].X >= maxXPos)
                        Snake[i].X = 0;
                    if (Snake[i].Y >= maxYPos)
                        Snake[i].Y = 0;
                    //{
                    //   Die();
                    //}


                    //Detecteaza coliziunea cu corpul
                    if (X == true)
                    {
                        for (int j = 1; j < Snake.Count; j++)
                        {
                            if (Snake[i].X == Snake[j].X &&
                               Snake[i].Y == Snake[j].Y)
                            {
                                //Die();
                            }
                        }
                    }
                    else
                    {
                        for (int j = 1; j < Snake.Count; j++)
                        {
                            if (Snake[i].X == Snake[j].X &&
                               Snake[i].Y == Snake[j].Y)
                            {
                                Die();
                            }
                        }
                    }

                    //Detecteaza coliziunea cu Mancarea Normala
                    if (Snake[0].X == food.X && Snake[0].Y == food.Y)
                    {
                        Mananca();
                    }

                    //Detecteaza coliziunea cu Mancarea Dubla
                    if (Snake[0].X == MancareDubla.X && Snake[0].Y == MancareDubla.Y)
                    {                        
                        Mananca();
                        Mananca();
                        MancareDubla.X = -1;
                        MancareDubla.Y = -1;
                    }

                    //Detecteaza coliziunea cu Mancarea Timp Incet
                    if (Snake[0].X == TimpIncet.X && Snake[0].Y == TimpIncet.Y)
                    {
                        lblTimpIncet1.Visible = true;
                        lblTimpRapid1.Visible = false;
                        lblTimpNormal1.Visible = false;
                        gameTimer.Interval = 1000 / Settings.Viteza1;
                        TimpIncet.X = -1;
                        TimpIncet.Y = -1;
                        timer1.Start();
                    }

                    //Detecteaza coliziunea cu Mancarea Timp Rapid
                    if (Snake[0].X == timpRapid.X && Snake[0].Y == timpRapid.Y)
                    {
                        lblTimpRapid1.Visible = true;
                        lblTimpNormal1.Visible = false;
                        lblTimpIncet1.Visible = false;
                        gameTimer.Interval = 1000 / Settings.Viteza2;
                        timpRapid.X = -1;
                        timpRapid.Y = -1;
                        timer1.Start();
                    }

                    //Detecteaza coliziunea cu Mancarea Moarte
                    if (Snake[0].X == die.X && Snake[0].Y == die.Y)
                    {
                        Die();
                        die.X = -1;
                        die.Y = -1;
                    }

                    //Detecteaza coliziunea cu Mancarea Timp Normal
                    if (Snake[0].X == TimpNormal.X && Snake[0].Y == TimpNormal.Y)
                    {
                        lblTimpNormal1.Visible = true;
                        lblTimpIncet1.Visible = false;
                        lblTimpRapid1.Visible = false;
                        gameTimer.Interval = 1000 / Settings.Viteza;
                        TimpNormal.X = -1;
                        TimpNormal.Y = -1;
                    }
                }
                else
                {
                    //Misca Corpul
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

        private void Mananca()
        {
            //Adauga o bucata de corp
            Circle circle = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };
            Snake.Add(circle);

            //Schimba scor
            Settings.Scor += Settings.Puncte;
            lblScore.Text = Settings.Scor.ToString();

            GenereazaMancare();
        }

        private void Die()
        {
            gameTimer.Interval = 1000 / Settings.Viteza;
            Settings.JocTerminat = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void powerUp_Tick(object sender, EventArgs e)
        {
            MancareDubla.X = -1;
            MancareDubla.Y = -1;
            TimpIncet.X = -1;
            TimpIncet.Y = -1;
            timpRapid.X = -1;
            timpRapid.Y = -1;
            TimpNormal.X = -1;
            TimpNormal.Y = -1;
            die.X = -1;
            die.Y = -1;
            Random a = new Random();
            int b = a.Next(0, 6);
            if (b == 1)
                GenereazaMancareDubla();
            else if (b == 2)
                GenereazaTimpIncet();
            else if (b == 3)
                GenereazaTimpRapid();
            else if (b == 4)
                GenereazaMoarte();
            else if (b == 5)
                GenereazaTimpNormal();
        }

        private void pbCanvas_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            playerName.Text = textBox.Text;
            lblBestPlayer.Visible = false;
            textBox.Visible = false;
            button1.Visible = false;
            button1.Enabled = false;
            textBox.Enabled = false;
            textBox.Clear();
            System.IO.File.WriteAllText(@"D:\Snake\playerName.txt", string.Empty);
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"D:\Snake\playerName.txt", true))
            {
                file.WriteLine(playerName.Text);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gameTimer.Interval = 1000 / Settings.Viteza;
            timer1.Stop();
            lblTimpIncet1.Visible = false;
            lblTimpNormal1.Visible = true;
            lblTimpRapid1.Visible = false;
        }

        private void lblTimpNormal1_Click(object sender, EventArgs e)
        {

        }
    }
}