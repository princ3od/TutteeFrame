using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TutteeFrame.Model
{
   public class School
    {
        private Image logo;
        public string Slogan { get; set; }
        public string FullName { get; set; }
        public Image Logo { get => logo ?? Properties.Resources.WaitCurser; set => logo = value; }
    }
}
