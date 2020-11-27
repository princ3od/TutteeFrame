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

    }
}
