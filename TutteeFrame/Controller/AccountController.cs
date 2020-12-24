using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutteeFrame.DataAccess;
using TutteeFrame.Model;
namespace TutteeFrame.Controller
{
    class AccountController
    {
        public static int AccountID { get; set; }
        public static string SessionID { get; set; }
        AccountDA accountDA;
        public AccountController()
        {
            accountDA = new AccountDA();
        }

        public bool AddAccount(string _teacherID, string _pass)
        {
            List<Account> accounts = new List<Account>();
            accountDA.LoadAccounts(accounts);
            _pass = Encryption.Encrypt(_pass, _pass);
            Account account = new Account(accounts.Count + 1, _teacherID, _pass);
            bool success = accountDA.AddAccount(account);
            return success;
        }
        public bool Login(string _teacherId, string _pass, ref int _flag)
        {
            List<Account> accounts = new List<Account>();
            accountDA.LoadAccounts(accounts);
            bool loggedIn = false;
            foreach (Account account in accounts)
            {
                if (account.TeacherID == _teacherId)
                    loggedIn = account.Login(_pass);
                if (loggedIn)
                {
                    AccountID = account.ID;
                    SessionID = Helper.GenerateSessionID();
                    accountDA.CreateSession(account.ID, SessionID);
                    break;
                }
            }
            _flag = 0; //unknow username
            return loggedIn;
        }
        public bool CheckSession()
        {
            bool isExist = false;
            accountDA.CheckSession(AccountID, SessionID, out isExist);
            return isExist;
        }
        public void DeleteSession()
        {
            accountDA.DeleteSession(AccountID, SessionID);
        }
        public bool ChangePass(string _accountID, string _newPass)
        {
            return accountDA.UpdatePass(_accountID, Encryption.Encrypt(_newPass, _newPass));
        }


    }
}
