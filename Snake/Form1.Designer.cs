namespace Snake
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblGameOver = new System.Windows.Forms.Label();
            this.powerUp = new System.Windows.Forms.Timer(this.components);
            this.playerName = new System.Windows.Forms.Label();
            this.lblBestPlayer1 = new System.Windows.Forms.Label();
            this.lblHighScore2 = new System.Windows.Forms.Label();
            this.lblHighScore1 = new System.Windows.Forms.Label();
            this.lblPause = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTimpIncet1 = new System.Windows.Forms.Label();
            this.lblTimpRapid1 = new System.Windows.Forms.Label();
            this.lblMancareNormala1 = new System.Windows.Forms.Label();
            this.lblMancareDubla1 = new System.Windows.Forms.Label();
            this.lblTimpNormal1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.lblBestPlayer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCanvas
            // 
            this.pbCanvas.BackColor = System.Drawing.Color.LightGreen;
            this.pbCanvas.Location = new System.Drawing.Point(13, 13);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(432, 424);
            this.pbCanvas.TabIndex = 0;
            this.pbCanvas.TabStop = false;
            this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCanvas_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(500, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score :";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(583, 7);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(21, 24);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "0";
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.BackColor = System.Drawing.Color.LightGreen;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.Location = new System.Drawing.Point(67, 45);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(102, 37);
            this.lblGameOver.TabIndex = 3;
            this.lblGameOver.Text = "label2";
            this.lblGameOver.Visible = false;
            // 
            // powerUp
            // 
            this.powerUp.Interval = 15000;
            this.powerUp.Tick += new System.EventHandler(this.powerUp_Tick);
            // 
            // playerName
            // 
            this.playerName.AutoSize = true;
            this.playerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerName.Location = new System.Drawing.Point(582, 58);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(83, 24);
            this.playerName.TabIndex = 5;
            this.playerName.Text = "Nobody";
            // 
            // lblBestPlayer1
            // 
            this.lblBestPlayer1.AutoSize = true;
            this.lblBestPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBestPlayer1.Location = new System.Drawing.Point(450, 58);
            this.lblBestPlayer1.Name = "lblBestPlayer1";
            this.lblBestPlayer1.Size = new System.Drawing.Size(126, 24);
            this.lblBestPlayer1.TabIndex = 6;
            this.lblBestPlayer1.Text = "Best Player :";
            this.lblBestPlayer1.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblHighScore2
            // 
            this.lblHighScore2.AutoSize = true;
            this.lblHighScore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore2.Location = new System.Drawing.Point(582, 31);
            this.lblHighScore2.Name = "lblHighScore2";
            this.lblHighScore2.Size = new System.Drawing.Size(142, 24);
            this.lblHighScore2.TabIndex = 7;
            this.lblHighScore2.Text = "lblHighScore2";
            this.lblHighScore2.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblHighScore1
            // 
            this.lblHighScore1.AutoSize = true;
            this.lblHighScore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore1.Location = new System.Drawing.Point(455, 31);
            this.lblHighScore1.Name = "lblHighScore1";
            this.lblHighScore1.Size = new System.Drawing.Size(121, 24);
            this.lblHighScore1.TabIndex = 8;
            this.lblHighScore1.Text = "HighScore :";
            this.lblHighScore1.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblPause
            // 
            this.lblPause.AutoSize = true;
            this.lblPause.BackColor = System.Drawing.Color.Aqua;
            this.lblPause.Font = new System.Drawing.Font("MS Reference Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPause.Location = new System.Drawing.Point(141, 174);
            this.lblPause.Name = "lblPause";
            this.lblPause.Size = new System.Drawing.Size(177, 46);
            this.lblPause.TabIndex = 9;
            this.lblPause.Text = "PAUSED";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Press \"P\" to pause.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(451, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Black Circle = Death";
            // 
            // lblTimpIncet1
            // 
            this.lblTimpIncet1.AutoSize = true;
            this.lblTimpIncet1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimpIncet1.ForeColor = System.Drawing.Color.Chocolate;
            this.lblTimpIncet1.Location = new System.Drawing.Point(446, 234);
            this.lblTimpIncet1.Name = "lblTimpIncet1";
            this.lblTimpIncet1.Size = new System.Drawing.Size(227, 25);
            this.lblTimpIncet1.TabIndex = 13;
            this.lblTimpIncet1.Text = "SLOW TIME ACTIVE";
            // 
            // lblTimpRapid1
            // 
            this.lblTimpRapid1.AutoSize = true;
            this.lblTimpRapid1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimpRapid1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTimpRapid1.Location = new System.Drawing.Point(446, 234);
            this.lblTimpRapid1.Name = "lblTimpRapid1";
            this.lblTimpRapid1.Size = new System.Drawing.Size(219, 25);
            this.lblTimpRapid1.TabIndex = 14;
            this.lblTimpRapid1.Text = "FAST TIME ACTIVE";
            // 
            // lblMancareNormala1
            // 
            this.lblMancareNormala1.AutoSize = true;
            this.lblMancareNormala1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMancareNormala1.ForeColor = System.Drawing.Color.Red;
            this.lblMancareNormala1.Location = new System.Drawing.Point(451, 153);
            this.lblMancareNormala1.Name = "lblMancareNormala1";
            this.lblMancareNormala1.Size = new System.Drawing.Size(266, 24);
            this.lblMancareNormala1.TabIndex = 15;
            this.lblMancareNormala1.Text = "Red Circle   = Normal Food";
            this.lblMancareNormala1.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblMancareDubla1
            // 
            this.lblMancareDubla1.AutoSize = true;
            this.lblMancareDubla1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMancareDubla1.ForeColor = System.Drawing.Color.Gold;
            this.lblMancareDubla1.Location = new System.Drawing.Point(450, 129);
            this.lblMancareDubla1.Name = "lblMancareDubla1";
            this.lblMancareDubla1.Size = new System.Drawing.Size(266, 24);
            this.lblMancareDubla1.TabIndex = 16;
            this.lblMancareDubla1.Text = "Gold Circle  = Double Food";
            // 
            // lblTimpNormal1
            // 
            this.lblTimpNormal1.AutoSize = true;
            this.lblTimpNormal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimpNormal1.ForeColor = System.Drawing.Color.Turquoise;
            this.lblTimpNormal1.Location = new System.Drawing.Point(446, 195);
            this.lblTimpNormal1.Name = "lblTimpNormal1";
            this.lblTimpNormal1.Size = new System.Drawing.Size(257, 25);
            this.lblTimpNormal1.TabIndex = 17;
            this.lblTimpNormal1.Text = "NORMAL TIME ACTIVE";
            this.lblTimpNormal1.Click += new System.EventHandler(this.lblTimpNormal1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(565, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(509, 319);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(201, 20);
            this.textBox.TabIndex = 20;
            // 
            // lblBestPlayer
            // 
            this.lblBestPlayer.AutoSize = true;
            this.lblBestPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBestPlayer.Location = new System.Drawing.Point(490, 268);
            this.lblBestPlayer.Name = "lblBestPlayer";
            this.lblBestPlayer.Size = new System.Drawing.Size(234, 48);
            this.lblBestPlayer.TabIndex = 21;
            this.lblBestPlayer.Text = "You Achived HighScore\r\nEnter your name :\r\n";
            // 
            // timer1
            // 
            this.timer1.Interval = 8000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(765, 467);
            this.Controls.Add(this.lblBestPlayer);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTimpNormal1);
            this.Controls.Add(this.lblMancareDubla1);
            this.Controls.Add(this.lblMancareNormala1);
            this.Controls.Add(this.lblTimpRapid1);
            this.Controls.Add(this.lblTimpIncet1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPause);
            this.Controls.Add(this.lblHighScore1);
            this.Controls.Add(this.lblHighScore2);
            this.Controls.Add(this.lblBestPlayer1);
            this.Controls.Add(this.playerName);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbCanvas);
            this.Name = "Form1";
            this.Text = "Snake";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Timer powerUp;
        private System.Windows.Forms.Label playerName;
        private System.Windows.Forms.Label lblBestPlayer1;
        private System.Windows.Forms.Label lblHighScore2;
        private System.Windows.Forms.Label lblHighScore1;
        private System.Windows.Forms.Label lblPause;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTimpIncet1;
        private System.Windows.Forms.Label lblTimpRapid1;
        private System.Windows.Forms.Label lblMancareNormala1;
        private System.Windows.Forms.Label lblMancareDubla1;
        private System.Windows.Forms.Label lblTimpNormal1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label lblBestPlayer;
        private System.Windows.Forms.Timer timer1;
    }
}

