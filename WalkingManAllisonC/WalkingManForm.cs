/*
 * Created by: Allison Cook
 * Created on: 21 March, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #20 - Walking Man
 * This program animates and man walking when a button is clicked
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WalkingManAllisonC
{
    public partial class frmWalkingMan : Form
    {
        public frmWalkingMan()
        {
            InitializeComponent();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            //close the program when clicked
            this.Close();
        }

        private void btnWalk_Click(object sender, EventArgs e)
        {
            //variables and constants
            const int MAX_FRAMES = 10;
            int picCounter = 1;

            //loop to animate the man walking
            while (picCounter < MAX_FRAMES)
            {
                if (picCounter == 1)
                {
                    picMan.Image = Properties.Resources.walk1;
                }
                else if (picCounter == 2)
                {
                    picMan.Image = Properties.Resources.walk2;
                }
                else if (picCounter == 3)
                {
                    picMan.Image = Properties.Resources.walk3;
                }
                else if (picCounter == 4)
                {
                    picMan.Image = Properties.Resources.walk4;
                }
                else if (picCounter == 5)
                {
                    picMan.Image = Properties.Resources.walk5;
                }
                else if (picCounter == 6)
                {
                    picMan.Image = Properties.Resources.walk6;
                }
                else if (picCounter == 7)
                {
                    picMan.Image = Properties.Resources.walk7;
                }
                else if (picCounter == 8)
                {
                    picMan.Image = Properties.Resources.walk8;
                }
                else if (picCounter == 9)
                {
                    picMan.Image = Properties.Resources.walk9;
                }
                else if (picCounter == 10)
                {
                    picMan.Image = Properties.Resources.walk10;
                }

                //increment the counter
                picCounter = picCounter + 1;

                //refresh the form
                this.Refresh();

                //pause the loop for 100 miliseconds
                Thread.Sleep(100);
            }
        }
    }
}
