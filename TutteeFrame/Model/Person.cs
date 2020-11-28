using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace TutteeFrame.Model
{
    public class Person
    {
        private string iD;
        private string surName;
        private string firstName;
        private string address;
        private string mail;
        private string phone;
        private DateTime dateBorn;
        private bool sex;
        private Image avatar;

        public Person()
        {
            dateBorn = DateTime.Now;
            sex = true;
        }
        public string ID { get => iD; set => iD = value; }
        public string SurName { get => surName; set => surName = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string Address { get => address; set => address = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Phone { get => phone; set => phone = value; }
        public bool Sex { get => sex; set => sex = value; }
        public DateTime DateBorn { get => dateBorn; set => dateBorn = value; }
        public Image Avatar { get => avatar ?? Properties.Resources.default_avatar; set => avatar = value; }
        public string GetSex
        {
            get => (sex) ? "Nam" : "Nữ";
        }
        public string GetName()
        {
            return SurName + " " + FirstName;
        }
    }
}
