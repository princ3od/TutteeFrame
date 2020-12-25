using System;
using System.Drawing;

namespace TutteeFrame.Model
{
    public class Person
    {
        protected string iD;
        protected string surName;
        protected string firstName;
        protected string address;
        protected string mail;
        protected string phone;
        protected DateTime dateBorn;
        protected bool sex;
        protected Image avatar;

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
