/*
 * Created by: Alexandrea Udechukwu
 * Created on: 16-September-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #8 - Name of Program
 * This program exits the program when the exit menu item is clicked and displays cartoon characters depending on what menu item is clicked.
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

namespace MovingCat
{
    public partial class frmMovingGirls : Form
    {
        public frmMovingGirls()
        {
            InitializeComponent();
        }

        private void MniExit_Click(object sender, EventArgs e)
        {
            //this.will close the program
            this.Close();
        }

        private void FrmMovingGirls_Load(object sender, EventArgs e)
        {

        }

        private void MniGirls1_Click(object sender, EventArgs e)
        {
            this.picGirls.Image = Properties.Resources.ppg;
        }

        private void MniGirls2_Click(object sender, EventArgs e)
        {
            this.picGirls.Image = Properties.Resources.ppg2;
        }
    }
}
