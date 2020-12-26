namespace TutteeFrame.Model
{
    public class Subject
    {
        string iD;
        string name;

        public string ID { get => iD ?? ""; set => iD = value; }
        public string Name { get => name ?? ""; set => name = value; }

        public Subject(string _id, string _name)
        {
            iD = _id;
            name = _name;
        }
        public Subject()
        {
            iD = "";
            name = "";
        }

    }
}
