﻿using Material_Design_for_Winform;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TutteeFrame
{
    public partial class frmChooseServer : Form
    {
        public bool connected = false;
        public frmChooseServer()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
            this.DoubleBuffered = true;
        }
        #region Win32 Form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        #endregion
        private void frmChooseServer_Load(object sender, EventArgs e)
        {
            txtServerName.Text = InitHelper.Instance.Read("ServerName", "Database");
            txtPort.Text = InitHelper.Instance.Read("Port", "Database");
            txtAccount.Text = InitHelper.Instance.Read("ServerAccount", "Database");
            txtPassword.Text = InitHelper.Instance.Read("ServerPassword", "Database");
        }
        //only digit textbox
        private void txtPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void ResetTextboxColor(object sender, EventArgs e)
        {
            MaterialTextField textField = sender as MaterialTextField;
            if (textField.FocusColor == Color.Red)
                textField.FocusColor = Color.FromArgb(47, 144, 176);
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtServerName.Text))
            {
                txtServerName.FocusColor = Color.Red;
                txtServerName.Focus();

            }
            else if (string.IsNullOrEmpty(txtPort.Text))
            {
                txtPort.FocusColor = Color.Red;
                txtPort.Focus();
            }
            else if (string.IsNullOrEmpty(txtAccount.Text))
            {
                txtAccount.FocusColor = Color.Red;
                txtAccount.Focus();
            }
            else
            {
                InitHelper.Instance.Write("ServerName", txtServerName.Text, "Database");
                InitHelper.Instance.Write("Port", txtPort.Text, "Database");
                InitHelper.Instance.Write("ServerAccount", txtAccount.Text, "Database");
                InitHelper.Instance.Write("ServerPassword", txtPassword.Text, "Database");
                this.Close();
            }
        }

        private void btnAcept_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtServerName.Text))
                txtServerName.Focus();
            else if (string.IsNullOrEmpty(txtPort.Text))
                txtPort.Focus();
            else if (string.IsNullOrEmpty(txtAccount.Text))
                txtAccount.Focus();
            else if (string.IsNullOrEmpty(txtPassword.Text))
                txtPassword.Focus();
            else
                btnConfirm.PerformClick();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}