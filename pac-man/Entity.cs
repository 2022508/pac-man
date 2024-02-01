using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pac_man
{
    internal class Entity
    {
        public bool moveUp, moveDown, moveLeft, moveRight;
        public int lives = 3;

        public void AnythingCollisions(Control pb1, Control pb2)
        {
            //Collisions between everything

            //for top collision
            if (pb1.Bounds.IntersectsWith(pb2.Bounds) && moveDown == true)
            {
                pb1.Top -= 2;
                Random rng = new Random();
                int dice = rng.Next(1, 4);
                if (dice == 1)
                {
                    moveUp = false; moveDown = false; moveLeft = true; moveRight = false;
                }
                if (dice == 2)
                {
                    moveUp = false; moveDown = false; moveLeft = false; moveRight = true;
                }
                if (dice == 3)
                {
                    moveUp = true; moveDown = false; moveLeft = false; moveRight = false;
                }
            }


            //for bottom collision
            if (pb1.Bounds.IntersectsWith(pb2.Bounds) && moveUp == true)
            {
                pb1.Top += 2;
                Random rng = new Random();
                int dice = rng.Next(1, 4);
                if (dice == 1)
                {
                    moveUp = false; moveDown = false; moveLeft = true; moveRight = false;
                }
                if (dice == 2)
                {
                    moveUp = false; moveDown = false; moveLeft = false; moveRight = true;
                }
                if (dice == 3)
                {
                    moveUp = false; moveDown = true; moveLeft = false; moveRight = false;
                }
            }


            //for right collision
            if (pb1.Bounds.IntersectsWith(pb2.Bounds) && moveLeft == true)
            {
                pb1.Left += 2;
                Random rng = new Random();
                int dice = rng.Next(1, 4);
                if (dice == 1)
                {
                    moveUp = true; moveDown = false; moveLeft = false; moveRight = false;
                }
                if (dice == 2)
                {
                    moveUp = false; moveDown = true; moveLeft = false; moveRight = false;
                }
                if (dice == 3)
                {
                    moveUp = false; moveDown = false; moveLeft = false; moveRight = true;
                }
            }

            //for left collision
            if (pb1.Bounds.IntersectsWith(pb2.Bounds) && moveRight == true)
            {
                pb1.Left -= 2;
                Random rng = new Random();
                int dice = rng.Next(1, 3);
                if (dice == 1)
                {
                    moveUp = true; moveDown = false; moveLeft = false; moveRight = false;
                }
                if (dice == 2)
                {
                    moveUp = false; moveDown = true; moveLeft = false; moveRight = false;
                }
                if (dice == 3)
                {
                    moveUp = false; moveDown = false; moveLeft = true; moveRight = false;
                }
            }


        }

        public void LivesCollisions(Control pbPACMAN, Control pbGhost1, Control pbGhost2)
        {
            if (pbPACMAN.Bounds.IntersectsWith(pbGhost1.Bounds) || pbPACMAN.Bounds.IntersectsWith(pbGhost2.Bounds))
            {
                pbPACMAN.Left = 634;
                pbPACMAN.Top = 324;
                moveUp = false;
                moveDown = false;
                moveLeft = false;
                moveRight = false;

                pbGhost1.Left = 448;
                pbGhost1.Top = 170;
                moveUp = false;
                moveDown = false;
                moveLeft = false;
                moveRight = false;

                pbGhost2.Left = 803;
                pbGhost2.Top = 170;
                moveUp = false;
                moveDown = false;
                moveLeft = false;
                moveRight = false;

                PacManStartRandomMove();
                lives--;
            }
        }

        public void MovementSetKeys(Keys k)
        {
            if (k == Keys.Up || k == Keys.W)
            {
                moveUp = true;
                moveDown = false;
                moveLeft = false;
                moveRight = false;
            }
            if (k == Keys.Down || k == Keys.S)
            {
                moveUp = false;
                moveDown = true;
                moveLeft = false;
                moveRight = false;
            }
            if (k == Keys.Left || k == Keys.A)
            {
                moveUp = false;
                moveDown = false;
                moveLeft = true;
                moveRight = false;
            }
            if (k == Keys.Right || k == Keys.D)
            {
                moveUp = false;
                moveDown = false;
                moveLeft = false;
                moveRight = true;
            }
        }

        public void ToggleMovement(int speed, Control p)
        {
            if (moveUp == true)
            {
                p.Top -= speed;
            }
            if (moveDown == true)
            {
                p.Top += speed;
            }
            if (moveLeft == true)
            {
                p.Left -= speed;
            }
            if (moveRight == true)
            {
                p.Left += speed;
            }
        }

        public void RandomGhostMove(int scoreTimer)
        {

            if (scoreTimer % 150 == 1)
            {
                RandomDirection();
            }
        }

        public void PacManStartRandomMove()
        {
            RandomDirection();
        }

        void RandomDirection()
        {
            Random rng = new Random();
            int dice = rng.Next(1, 5);
            if (dice == 1)
            {
                moveUp = false; moveDown = false; moveLeft = true; moveRight = false;
            }
            if (dice == 2)
            {
                moveUp = false; moveDown = false; moveLeft = false; moveRight = true;
            }
            if (dice == 3)
            {
                moveUp = true; moveDown = false; moveLeft = false; moveRight = false;
            }
            if (dice == 4)
            {
                moveUp = true; moveDown = false; moveLeft = false; moveRight = false;
            }
        }
    }
}
