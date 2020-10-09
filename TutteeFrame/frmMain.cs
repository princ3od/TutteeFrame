using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using TutteeFrame.Modal;
namespace TutteeFrame
{
    public partial class frmMain : MetroForm
    {
        public frmMain()
        {
            InitializeComponent();
            DataAccess.Instance.Test("PRINC3-LAPTOP", 49172, "princ3od", "");
        }
    }
}
