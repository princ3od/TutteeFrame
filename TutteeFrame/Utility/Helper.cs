using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutteeFrame.Model;
using TutteeFrame.Controller;
using TutteeFrame.DataAccess;

namespace TutteeFrame
{
    class Helper
    {
        public static void SettingCheck()
        {
            if (!InitHelper.Instance.IsSettingExist())
                InitHelper.Instance.CreateDefaultSetting();
        }
        public static bool IsDigitsOnly(string str)
        {
            if (str == null) return false;
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
        public static string GenerateTeacherID()
        {
            int result = (new Random()).Next(100000, 999999);
            return result.ToString();
        }
        public static bool IsInformationOfClassCorrected(Class item)
        {
            if (item.ID.Length > 5)
                return false;
            if (item.ID.Substring(0, 2) != "10" && item.ID.Substring(0, 2) != "11" && item.ID.Substring(0, 2) != "12")
                return false;
            if (item.StudentNum < 0)
                return false;
            if (item.FormerTeacherID != null)
            {
                if (item.FormerTeacherID.Length != 8)
                    return false;
            }
            return true;
        }
    }
}
