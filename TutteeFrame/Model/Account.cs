namespace TutteeFrame.Model
{
    class Account
    {
        private string iD;
        private string teacherID;
        private string password;

        public string ID { get => iD; set => iD = value; }
        public string TeacherID { get => teacherID; set => teacherID = value; }
        public string Password { get => password; set => password = value; }

        public Account(string _id, string _teacherId, string _password)
        {
            iD = _id;
            teacherID = _teacherId;
            password = _password;
        }

        public bool Login(string _password)
        {
            if (_password == Encryption.Decrypt(password, _password))
                return true;
            return false;
        }
    }
}
