﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TutteeFrame.Model
{
    class Person
    {
        private string iD;
        private string surName;
        private string firstName;
        private string address;
        private string mail;
        private string phone;

        public string ID { get => iD; set => iD = value; }
        public string SurName { get => surName; set => surName = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string Address { get => address; set => address = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Phone { get => phone; set => phone = value; }


    }
}
