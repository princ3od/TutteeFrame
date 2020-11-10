using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TutteeFrame
{
    class OverlayForm : Form
    {

        protected override void DefWndProc(ref Message m)
        {
            const int WM_MOUSEACTIVATE = 0x21;
            const int MA_NOACTIVATE = 0x0003;

            switch (m.Msg)
            {
                case WM_MOUSEACTIVATE:
                    m.Result = (IntPtr)MA_NOACTIVATE;
                    return;
            }
            base.DefWndProc(ref m);
        }
        public OverlayForm(Form _parent, Form _child)
        {
            this.ControlBox = false;
            this.StartPosition = FormStartPosition.Manual;
            this.FormBorderStyle = FormBorderStyle.None;
            this.AllowTransparency = true;
            this.ShowInTaskbar = false;
            this.Opacity = 0.65f;
            this.BackColor = Color.Black;
            this.Size = _parent.Size;
            this.Location = _parent.Location;
            this.Enabled = false;
            _child.FormClosed += (s, e) =>
            {
                this.Close();
                _parent.Focus();
            };
            this.Show();
        }
    }
}
