using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace TutteeFrame.Model
{
    public class StudentInfomation
    {
        public string StudentID {get;set;}
        public string SurName { get; set; }
        public string FistName { get; set; }
        public Image StudentImage { get; set; }
        public DateTime BornDate { get; set; }
        public bool Sex { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Class { get; set; }
        public bool Status { get; set; }
        public string PunishmentID { get; set; }

        public StudentInfomation()
        {
            BornDate = DateTime.Now;
            Sex = true;
        }
	}
}
