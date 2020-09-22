using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TutteeFrame.Modal
{
    class Person
    {
        private string iD;
        private string surName;
        private string firstName;
        private string address;
        private string mail;

        protected string ID { get => iD; set => iD = value; }
        protected string SurName { get => surName; set => surName = value; }
        protected string FirstName { get => firstName; set => firstName = value; }
        protected string Address { get => address; set => address = value; }
        protected string Mail { get => mail; set => mail = value; }
    }
}
