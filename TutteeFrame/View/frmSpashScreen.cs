using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TutteeFrame.Model;

namespace TutteeFrame
{
    public partial class frmSpashScreen : Form
    {

        int secondShowing = 0;
        public frmSpashScreen()
        {
            InitializeComponent();
            Helper.SettingCheck();            
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (secondShowing == 0)
            {
                timer1.Stop();
                this.Close();
            }
            else
                secondShowing--;
        }
        private void SplashScreen_Shown(object sender, EventArgs e)
        {
            this.Activate();
            System.IO.Stream stream = Properties.Resources.intro;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(stream);
            player.Play();
            
        }

      
    }
}
