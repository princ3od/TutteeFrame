using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TutteeFrame
{
    public partial class frmSpashScreen : Form
    {
        int second = 1;

        public frmSpashScreen()
        {
            InitializeComponent();
            Controller.Instance.SettingCheck();
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (second == 0)
            {
                timer1.Stop();
                this.Close();

            }
            else
                second--;

                

        }

        private void SplashScreen_Shown(object sender, EventArgs e)
        {
            this.Activate();
        }

    }
}
