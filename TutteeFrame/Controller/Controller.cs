using System;
using System.Collections.Generic;
using System.IO;
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


        #region Data List
        public List<Account> accounts = new List<Account>();
        #endregion

        public bool Login(string _teacherId, string _pass, ref int _flag)
        {
            foreach (Account account in accounts)
            {
                if (account.TeacherID == _teacherId)
                    return account.Login(_pass);
            }
            _flag = 0; //unknow username
            return false;
        }

        public bool LoadAccount()
        {
            accounts = DataAccess.Instance.LoadAccount();
            if (accounts == null)
                return false;
            return true;
        }

        public bool ConnectServer()
        {
            string server = InitHelper.Instance.Read("ServerName", "Database");
            string port = InitHelper.Instance.Read("Port", "Database");
            string serverAccount = InitHelper.Instance.Read("ServerAccount", "Database");
            string serverPass = InitHelper.Instance.Read("ServerPassword", "Database");
            return DataAccess.Instance.Test(server, port, serverAccount, serverPass);
        }

        public void SettingCheck()
        {
            if (!InitHelper.Instance.IsSettingExist() || !InitHelper.Instance.IsSettingCorrupt())
                InitHelper.Instance.CreateDefaultSetting();
        }

    }
}
