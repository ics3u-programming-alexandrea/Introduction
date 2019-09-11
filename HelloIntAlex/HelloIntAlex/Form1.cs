/*
 * Created by: Alexandera Udechukwu
 * Created on: 10-Sep-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #6 - Hello World Ineternational
 * This program displays the greeting in different languages depending on which radio button is clicked.
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

namespace HelloIntAlex
{
    public partial class frmHelloWorldInt : Form
    {
        public frmHelloWorldInt()
        {
            InitializeComponent();
        }

        private void GrbGreetings_Enter(object sender, EventArgs e)
        {

        }

        private void RadFrench_CheckedChanged(object sender, EventArgs e)
        {
            //change the greeting to french
            this.lblHelloWorld.Text = "Bonjour le monde!";
        }

        private void RadSpanish_CheckedChanged(object sender, EventArgs e)
        {
            //change greeting to spanish
            this.lblHelloWorld.Text = "¡Hola Mundo!";
        }

        private void Radarabic_CheckedChanged(object sender, EventArgs e)
        {
            //change greeting to arabic
            this.lblHelloWorld.Text = "مرحبا بالعالم!";

        }

        private void RadEnglish_CheckedChanged(object sender, EventArgs e)
        {
            //changr greeting to english
            this.lblHelloWorld.Text = "Hello, World!";

        }
    }
}
