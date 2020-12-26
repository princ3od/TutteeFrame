using System;
using TutteeFrame.Model;

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
        public static string GenerateID()
        {
            int result = (new Random()).Next(100000, 999999);
            return result.ToString();
        }
        public static string GenerateSessionID()
        {
            string[] characters = new string[] { "a", "b", "c", "d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z",
                "0","1","2","3","4","5","6","7","8","9" };
            string result = "";
            Random random = new Random();
            for (int i = 0; i < 10; i++)
                result += characters[random.Next(characters.Length)];
            return result;
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
