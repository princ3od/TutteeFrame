using System;
using System.Windows.Forms;

namespace TutteeFrame
{
    public partial class frmSpashScreen : Form
    {

        int secondShowing = 1;
        public frmSpashScreen()
        {
            InitializeComponent();
            Helper.SettingCheck();
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
            timer1.Start();
            this.Activate();
            if (!Properties.Settings.Default.StartupSound)
                return;
            System.IO.Stream stream = Properties.Resources.intro;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(stream);
            player.Play();
            
        }


    }
}
