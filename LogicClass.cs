using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class LogicClass
    {
        int Bul = 0;
        int Ch = 2;


        public void ShootBt()
        {
            //Shoot at head, if Bullet is in the barrel else it will just Rotate
            if (Bul == 5)
            {
                MessageBox.Show("You are dead!");
            }
            else
            {
                MessageBox.Show("The revolver just rotated");
                Bul = Bul + 1;
            }
        }

        public void StAwayBt()
        {
            //if i have any Chance            
            if (Ch > 0)
            {
                if (Bul == 5)
                {

                    MessageBox.Show("You survived . \nYour Score : " + Bul + (Bul == 5 ? "\n \n You Gain" : "\n You failure"));

                }
                else
                {
                    MessageBox.Show("The revolver just rotated");
                    Bul = Bul + 1;

                }


            }
            //If I don't get any Possibility last
            else
            {
                MessageBox.Show("You are dead!");

            }

            Ch = Ch - 1;
        }


        public void Spbt()
        //Spin the Gun to get a Random position 
        {
            Random rand = new Random();
            Bul = rand.Next(0, 6);
            MessageBox.Show("Gun Spin");
        }

        public void LdBt()
        //Start Game
        {
            Bul = 0;
            MessageBox.Show("Gun Loaded");
        }
        public void StartAgainBt()
        {
            // if you restart the game 
            Bul = 0;
            Ch = 2;
            MessageBox.Show("Game starts");
        }
    }
}
