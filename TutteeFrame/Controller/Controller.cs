using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TutteeFrame.Model;

namespace TutteeFrame
{
    class Controller
    {
        // singleton design-pattern
        private Controller() { }
        readonly static Controller _instance = new Controller();
        public static Controller Instance => _instance;

        public bool Login(string _teacherId, string _pass, ref int _flag)
        {
            foreach (Account account in DataAccess.Instance.accounts)
            {
                if (account.TeacherID == _teacherId)
                    return account.Login(_pass);
            }
            _flag = 0; //unknow username
            return false;
        }


    }
}
