﻿using System;
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
            this.Owner = _parent;
            this.Activated += (s, e) =>
            {
                _child.Activate();
            };
            _child.Owner = _parent;
            _child.ShowInTaskbar = false;
            _child.Location = new Point(this.Location.X + this.Width / 2 - _child.Width / 2, this.Location.Y + this.Height / 2 - _child.Height / 2);
            _child.FormClosed += (s, e) =>
            {
                this.Close();
                //_parent.Focus();
            };
            this.Show();
        }
    }
}
