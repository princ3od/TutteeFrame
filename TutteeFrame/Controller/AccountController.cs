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
            foreach (Account account in accounts)
            {
                if (account.TeacherID == _teacherId)
                    return account.Login(_pass);
            }
            _flag = 0; //unknow username
            return false;
        }
        public bool ChangePass(string _accountID, string _newPass)
        {
            return accountDA.UpdatePass(_accountID, Encryption.Encrypt(_newPass, _newPass));
        }


    }
}
