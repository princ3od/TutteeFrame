using System;

namespace TutteeFrame.Model
{
    class Reward : ResultObject
    {
        private string name;
        public Reward(string _studentID)
        {
            Random random = new Random();
            iD = _studentID + (random.Next(1000, 9999)).ToString();
        }
        public Reward()
        {

        }
        public string Name { get => name; set => name = value; }
    }
}
