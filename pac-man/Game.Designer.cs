namespace pac_man
{
    partial class Game
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.pbPACMAN = new System.Windows.Forms.PictureBox();
            this.lblLives = new System.Windows.Forms.Label();
            this.lblNameDisplay = new System.Windows.Forms.Label();
            this.lblScoreDisplay = new System.Windows.Forms.Label();
            this.lblLivesDisplay = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbGhost1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pbGhost2 = new System.Windows.Forms.PictureBox();
            this.lbScoreboard = new System.Windows.Forms.ListBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnEnterName = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPACMAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGhost1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGhost2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(12, 14);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(68, 25);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name: ";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(288, 14);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(65, 25);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Score: ";
            // 
            // pbPACMAN
            // 
            this.pbPACMAN.Image = global::pac_man.Properties.Resources.pacman;
            this.pbPACMAN.Location = new System.Drawing.Point(624, 321);
            this.pbPACMAN.Name = "pbPACMAN";
            this.pbPACMAN.Size = new System.Drawing.Size(45, 45);
            this.pbPACMAN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPACMAN.TabIndex = 3;
            this.pbPACMAN.TabStop = false;
            // 
            // lblLives
            // 
            this.lblLives.AutoSize = true;
            this.lblLives.ForeColor = System.Drawing.Color.White;
            this.lblLives.Location = new System.Drawing.Point(920, 14);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(54, 25);
            this.lblLives.TabIndex = 4;
            this.lblLives.Text = "Lives:";
            // 
            // lblNameDisplay
            // 
            this.lblNameDisplay.ForeColor = System.Drawing.Color.White;
            this.lblNameDisplay.Location = new System.Drawing.Point(71, 14);
            this.lblNameDisplay.Name = "lblNameDisplay";
            this.lblNameDisplay.Size = new System.Drawing.Size(200, 25);
            this.lblNameDisplay.TabIndex = 5;
            // 
            // lblScoreDisplay
            // 
            this.lblScoreDisplay.ForeColor = System.Drawing.Color.White;
            this.lblScoreDisplay.Location = new System.Drawing.Point(349, 16);
            this.lblScoreDisplay.Name = "lblScoreDisplay";
            this.lblScoreDisplay.Size = new System.Drawing.Size(100, 25);
            this.lblScoreDisplay.TabIndex = 6;
            // 
            // lblLivesDisplay
            // 
            this.lblLivesDisplay.ForeColor = System.Drawing.Color.White;
            this.lblLivesDisplay.Location = new System.Drawing.Point(985, 14);
            this.lblLivesDisplay.Name = "lblLivesDisplay";
            this.lblLivesDisplay.Size = new System.Drawing.Size(50, 25);
            this.lblLivesDisplay.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pac_man.Properties.Resources.background3;
            this.pictureBox1.Location = new System.Drawing.Point(349, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(603, 523);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pbGhost1
            // 
            this.pbGhost1.Image = global::pac_man.Properties.Resources.ghost1;
            this.pbGhost1.Location = new System.Drawing.Point(448, 168);
            this.pbGhost1.Name = "pbGhost1";
            this.pbGhost1.Size = new System.Drawing.Size(45, 45);
            this.pbGhost1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGhost1.TabIndex = 25;
            this.pbGhost1.TabStop = false;
            this.pbGhost1.Tag = "";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(406, 142);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 409);
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "wall";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(873, 142);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 409);
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "wall";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(406, 126);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(492, 27);
            this.pictureBox4.TabIndex = 28;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "wall";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(406, 541);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(492, 27);
            this.pictureBox5.TabIndex = 29;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "wall";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(604, 305);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(98, 10);
            this.pictureBox6.TabIndex = 30;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "wall";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(604, 381);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(98, 10);
            this.pictureBox7.TabIndex = 31;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "wall";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Location = new System.Drawing.Point(516, 225);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(47, 10);
            this.pictureBox8.TabIndex = 32;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "wall";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Location = new System.Drawing.Point(743, 225);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(47, 10);
            this.pictureBox9.TabIndex = 33;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "wall";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Location = new System.Drawing.Point(516, 461);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(47, 10);
            this.pictureBox10.TabIndex = 34;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "wall";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Location = new System.Drawing.Point(743, 461);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(47, 10);
            this.pictureBox11.TabIndex = 35;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Tag = "wall";
            // 
            // pictureBox12
            // 
            this.pictureBox12.Location = new System.Drawing.Point(783, 225);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(10, 90);
            this.pictureBox12.TabIndex = 36;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Tag = "wall";
            // 
            // pictureBox13
            // 
            this.pictureBox13.Location = new System.Drawing.Point(511, 225);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(10, 90);
            this.pictureBox13.TabIndex = 37;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Tag = "wall";
            // 
            // pictureBox14
            // 
            this.pictureBox14.Location = new System.Drawing.Point(511, 381);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(10, 90);
            this.pictureBox14.TabIndex = 38;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Tag = "wall";
            // 
            // pictureBox15
            // 
            this.pictureBox15.Location = new System.Drawing.Point(783, 381);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(10, 90);
            this.pictureBox15.TabIndex = 39;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.Tag = "wall";
            // 
            // pictureBox16
            // 
            this.pictureBox16.Location = new System.Drawing.Point(645, 461);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(10, 90);
            this.pictureBox16.TabIndex = 40;
            this.pictureBox16.TabStop = false;
            this.pictureBox16.Tag = "wall";
            // 
            // pictureBox17
            // 
            this.pictureBox17.Location = new System.Drawing.Point(645, 142);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(10, 90);
            this.pictureBox17.TabIndex = 41;
            this.pictureBox17.TabStop = false;
            this.pictureBox17.Tag = "wall";
            // 
            // pbGhost2
            // 
            this.pbGhost2.Image = global::pac_man.Properties.Resources.ghost2;
            this.pbGhost2.Location = new System.Drawing.Point(807, 168);
            this.pbGhost2.Name = "pbGhost2";
            this.pbGhost2.Size = new System.Drawing.Size(45, 45);
            this.pbGhost2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGhost2.TabIndex = 42;
            this.pbGhost2.TabStop = false;
            this.pbGhost2.Tag = "";
            // 
            // lbScoreboard
            // 
            this.lbScoreboard.BackColor = System.Drawing.Color.White;
            this.lbScoreboard.ForeColor = System.Drawing.Color.Black;
            this.lbScoreboard.FormattingEnabled = true;
            this.lbScoreboard.ItemHeight = 25;
            this.lbScoreboard.Location = new System.Drawing.Point(59, 87);
            this.lbScoreboard.Name = "lbScoreboard";
            this.lbScoreboard.Size = new System.Drawing.Size(249, 504);
            this.lbScoreboard.TabIndex = 43;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Black;
            this.btnStart.ForeColor = System.Drawing.Color.Transparent;
            this.btnStart.Location = new System.Drawing.Point(1012, 305);
            this.btnStart.Name = "btnStart";
            this.btnStart.Padding = new System.Windows.Forms.Padding(10);
            this.btnStart.Size = new System.Drawing.Size(153, 70);
            this.btnStart.TabIndex = 44;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(1012, 450);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(225, 31);
            this.txtName.TabIndex = 45;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // btnEnterName
            // 
            this.btnEnterName.Location = new System.Drawing.Point(1012, 410);
            this.btnEnterName.Name = "btnEnterName";
            this.btnEnterName.Size = new System.Drawing.Size(112, 34);
            this.btnEnterName.TabIndex = 47;
            this.btnEnterName.Text = "Enter Name";
            this.btnEnterName.UseVisualStyleBackColor = true;
            this.btnEnterName.Click += new System.EventHandler(this.btnEnterName_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.BackColor = System.Drawing.Color.White;
            this.lblInstructions.Location = new System.Drawing.Point(1012, 508);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(296, 102);
            this.lblInstructions.TabIndex = 48;
            this.lblInstructions.Text = "To move, use the up, down, left and right arrows, or wasd. The objective is to mo" +
    "ve your yellow character away from the blue and red ghosts.\r\n\r\n";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1388, 833);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.btnEnterName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbScoreboard);
            this.Controls.Add(this.pbGhost2);
            this.Controls.Add(this.pictureBox17);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pbGhost1);
            this.Controls.Add(this.pbPACMAN);
            this.Controls.Add(this.lblLivesDisplay);
            this.Controls.Add(this.lblScoreDisplay);
            this.Controls.Add(this.lblNameDisplay);
            this.Controls.Add(this.lblLives);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Game";
            this.Text = "PAC-MAN: Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbPACMAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGhost1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGhost2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblName;
        private Label lblScore;
        private PictureBox pbPACMAN;
        private Label lblLives;
        private Label lblNameDisplay;
        private Label lblScoreDisplay;
        private Label lblLivesDisplay;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private PictureBox pbGhost1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private PictureBox pictureBox15;
        private PictureBox pictureBox16;
        private PictureBox pictureBox17;
        private PictureBox pbGhost2;
        private ListBox lbScoreboard;
        private Button btnStart;
        private TextBox txtName;
        private Button btnEnterName;
        private Label lblInstructions;
    }
}