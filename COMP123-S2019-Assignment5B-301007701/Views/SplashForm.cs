using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * APP NAME: Dollar Computers
 * AUTHOR NAME: Reena Mangubat
 * STUDENT ID: 301007701
 * APP CREATION DATE: July 31, 2019
 * DESCRIPTION: This is the Splash Form and it is the first form to appear on the screen to introduce the app.
 **/
namespace COMP123_S2019_Assignment5B_301007701.Views
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            SplashTimer.Enabled = true;
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashTimer.Enabled = false;
            this.Hide();
            Program.startForm.Show();
        }
    }
}
