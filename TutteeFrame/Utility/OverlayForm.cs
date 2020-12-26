using System.Drawing;
using System.Windows.Forms;

namespace TutteeFrame
{
    class OverlayForm : Form
    {
        public OverlayForm() { this.Close(); }
        public OverlayForm(Form _parent, Form _child, float _opacity = 0.6f, int _offSet = 5, bool setChild = true)
        {
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
            this.DoubleBuffered = true;
            if (setChild)
                ((frmMain)_parent).isChildShowing = true;
            this.ControlBox = false;
            this.StartPosition = FormStartPosition.Manual;
            this.FormBorderStyle = FormBorderStyle.None;
            this.AllowTransparency = true;
            this.ShowInTaskbar = false;
            this.Opacity = _opacity;
            this.BackColor = Color.Black;
            this.Size = _parent.Size;
            this.Location = _parent.Location;
            this.Enabled = false;
            this.Owner = _parent;
            this.Activated += (s, e) =>
            {
                _child.Activate();
            };
            _child.StartPosition = FormStartPosition.Manual;
            _child.Owner = _parent;
            _child.ShowInTaskbar = false;
            _child.Location = new Point(this.Location.X + this.Width / 2 - _child.Width / 2, this.Location.Y + this.Height / 2 - _child.Height / 2 - _offSet);
            _child.FormClosed += (s, e) =>
            {
                if (setChild)
                    ((frmMain)_parent).isChildShowing = false;
                this.Close();
                //_parent.Focus();
            };
            this.Show();
        }
    }
}
