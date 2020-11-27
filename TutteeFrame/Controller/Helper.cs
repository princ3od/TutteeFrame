using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
