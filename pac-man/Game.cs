using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pac_man
{
    public partial class Game : Form
    {
        Entity pacMan = new Entity();             //class
        Entity ghost1 = new Entity();             //class
        Entity ghost2 = new Entity();             //class
        Scoreboard scoredata = new Scoreboard();  //class

        public Game()
        {
            InitializeComponent();

            LoadGame();
            LoadScoreboardFile();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            pacMan.ToggleMovement(2, pbPACMAN);       //movement speed and direction for all entities
            ghost1.ToggleMovement(2, pbGhost1);
            ghost2.ToggleMovement(2, pbGhost2);

            ghost1.RandomGhostMove(scoredata.score);  //change direction for ghost
            ghost2.RandomGhostMove(scoredata.score);

            foreach (Control x in this.Controls)     // https://www.youtube.com/watch?v=sCmybR1e_Vo      this link helped me set up collisions without using lots of if staatements using labels. Had Control as parameter
            {
                if (x is PictureBox && (string)x.Tag == "wall")     //collisions between the entities and walls
                {
                    pacMan.AnythingCollisions(pbPACMAN, x);
                    ghost1.AnythingCollisions(pbGhost1, x);
                    ghost2.AnythingCollisions(pbGhost2, x);
                }
            }
            ghost1.AnythingCollisions(pbGhost1, pbGhost2);            //collisions between ghost entities
            ghost2.AnythingCollisions(pbGhost2, pbGhost1);

            pacMan.LivesCollisions(pbPACMAN, pbGhost1, pbGhost2);     //ghost and pacman collisions
            lblLivesDisplay.Text = pacMan.lives.ToString();           //update lives
            lblScoreDisplay.Text = scoredata.score++.ToString();      //update score
            GameOver();
        }
        
        void StartButton()
        {
            btnStart.Visible = false;
            lbScoreboard.Visible = false;
            btnEnterName.Visible = true;
            btnEnterName.Enabled = true;
            txtName.Enabled = true;
            txtName.Visible = true;
            lblInstructions.Visible = true;
        }

        void LoadGame()
        {
            pbPACMAN.Visible = false;
            pbGhost1.Visible = false;
            pbGhost2.Visible = false;

            btnEnterName.Visible = false;
            btnEnterName.Enabled = false;

            txtName.Visible = false;
            lblInstructions.Visible = false;

            timer1.Stop();
        }

        void LoadScoreboardFile()
        {
            lbScoreboard.Items.Clear();                    //clears listbox
            scoredata.ReadFile();                          //converts file to string and adds each name and score to a list
            foreach (string player in scoredata.players)   //adds all data from file to listbox
            {
                lbScoreboard.Items.Add(player);
            }

            //for (int i = 0; i < scoredata.players.Count(); i++)     could use a for loop
            //{
            //    lbScoreboard.Items.Add(scoredata.players[i]);
            //}


            //int i = 0;                                             or a while loop
            //while(i< scoredata.players.Count())
            //{
            //    lbScoreboard.Items.Add(scoredata.players[i]);
            //    i++;
            //}

            //orginally didn't have the readfile function, just had the code in the add to file function,
            //but this caused a score of 0 to add to the scoreboared every time the game loaded so put them seperate.
        } 

        void GameOver()
        {
            if(pacMan.lives == 0)
            {
                pbPACMAN.Visible = false;                      //removing the entitys for the next game
                pbGhost1.Visible = false;
                pbGhost2.Visible = false;

                scoredata.AddToFile();                         //adds current name and score to file
                LoadScoreboardFile();                          //loads and displays the data to the listbox.

                
                btnStart.Visible = true;                       //allowing the user to start another game.


                scoredata.score = 0;
                pacMan.lives = 3;

                lbScoreboard.Visible = true;
                lblScoreDisplay.Text = scoredata.score.ToString();

                timer1.Stop();
            }
        } 

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            pacMan.MovementSetKeys(e.KeyCode);
        }
        
        private void btnStart_Click(object sender, EventArgs e)
        {
            StartButton();
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            EnterName(e.KeyCode);
        }

        private void btnEnterName_Click(object sender, EventArgs e)
        {
            NameHasBeenEntered();
        }

        void EnterName(Keys e)
        {
            if (e == Keys.Enter)
            {
                NameHasBeenEntered();
                //e.SuppressKeyPress = true;
            }

        }

        void NameHasBeenEntered()
        {

            scoredata.name = txtName.Text;

            if (scoredata.name.Count() > 0)   //makes sure a name was entered
            {
                lblNameDisplay.Text = scoredata.name;

                timer1.Start();
                pbPACMAN.Visible = true;
                pbGhost1.Visible = true;
                pbGhost2.Visible = true;

                ghost1.moveDown = true;
                ghost2.moveRight = true;

                btnEnterName.Visible = false;
                btnEnterName.Enabled = false;

                lblInstructions.Visible = false;

                txtName.Enabled = false;
                txtName.Visible = false;
                txtName.Text = "";            //resets textbox
                pacMan.PacManStartRandomMove();
            }
        }





        //if(pbPACMAN.Bounds.IntersectsWith(label1.Bounds) ||   initial method of stopping when hitting walls, but you would get stuck.
        //pbPACMAN.Bounds.IntersectsWith(label2.Bounds) ||
        //pbPACMAN.Bounds.IntersectsWith(label3.Bounds) ||
        //pbPACMAN.Bounds.IntersectsWith(label4.Bounds) ||      
        //pbPACMAN.Bounds.IntersectsWith(label5.Bounds) ||
        //pbPACMAN.Bounds.IntersectsWith(label6.Bounds) ||
        //pbPACMAN.Bounds.IntersectsWith(label7.Bounds) ||
        //pbPACMAN.Bounds.IntersectsWith(label8.Bounds) ||
        //pbPACMAN.Bounds.IntersectsWith(label9.Bounds) ||
        //pbPACMAN.Bounds.IntersectsWith(label10.Bounds) ||
        //pbPACMAN.Bounds.IntersectsWith(label11.Bounds) ||
        //pbPACMAN.Bounds.IntersectsWith(label12.Bounds) ||
        //pbPACMAN.Bounds.IntersectsWith(label13.Bounds) ||
        //pbPACMAN.Bounds.IntersectsWith(label14.Bounds) ||
        //pbPACMAN.Bounds.IntersectsWith(label15.Bounds) ||
        //pbPACMAN.Bounds.IntersectsWith(label16.Bounds))
        //{
        //   moveUp = false;
        //   moveDown = false;
        //   moveLeft = false;
        //   moveRight = false;
        //}



        //if (pbPACMAN.Bounds.IntersectsWith(label6.Bounds) && moveDown == true)              next method for wall collisions,  needed to do this for every label, used up around 700 lines, and would of had to do it again for the ghosts instead of pacman.
        //{
        //    pbPACMAN.Top -= 2;        //for top collision
        //    Random rng = new Random();
        //    int dice = rng.Next(1, 3);
        //    if (dice == 1)
        //    {
        //        moveUp = false; moveDown = false; moveLeft = true; moveRight = false;
        //    }
        //    else
        //    {
        //        moveUp = false; moveDown = false; moveLeft = false; moveRight = true;
        //    }
        //}
        //if (pbPACMAN.Bounds.IntersectsWith(label6.Bounds) && moveUp == true)
        //{
        //    pbPACMAN.Top += 2;        //for bottom collision
        //    Random rng = new Random();
        //    int dice = rng.Next(1, 3);
        //    if (dice == 1)
        //    {
        //        moveUp = false; moveDown = false; moveLeft = true; moveRight = false;
        //    }
        //    else
        //    {
        //        moveUp = false; moveDown = false; moveLeft = false; moveRight = true;
        //    }
        //}
        //if (pbPACMAN.Bounds.IntersectsWith(label6.Bounds) && moveRight == true)
        //{
        //    pbPACMAN.Left -= 2;       //for left collision
        //    Random rng = new Random();
        //    int dice = rng.Next(1, 3);
        //    if (dice == 1)
        //    {
        //        moveUp = true; moveDown = false; moveLeft = false; moveRight = false;
        //    }
        //    else
        //    {
        //        moveUp = false; moveDown = true; moveLeft = false; moveRight = false;
        //    }
        //}
        //if (pbPACMAN.Bounds.IntersectsWith(label6.Bounds) && moveLeft == true)
        //{
        //    pbPACMAN.Left += 2;       //for right collision
        //    Random rng = new Random();
        //    int dice = rng.Next(1, 3);
        //    if (dice == 1)
        //    {
        //        moveUp = true; moveDown = false; moveLeft = false; moveRight = false;
        //    }
        //    else
        //    {
        //        moveUp = false; moveDown = true; moveLeft = false; moveRight = false;
        //    }
        //}



    }
}

