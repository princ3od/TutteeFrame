using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace TutteeFrame
{
    class InitHelper
    {
        string PATH = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "setting.ini");

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

        static readonly InitHelper instance = new InitHelper();
        public static InitHelper Instance => instance;
        private InitHelper(string IniPath = null)
        {
        }

        public string Read(string Key, string Section)
        {
            var RetVal = new StringBuilder(255);
            GetPrivateProfileString(Section, Key, "", RetVal, 255, PATH);
            return RetVal.ToString();
        }

        public void Write(string Key, string Value, string Section)
        {
            WritePrivateProfileString(Section, Key, Value, PATH);
        }

        public void DeleteKey(string Key, string Section)
        {
            Write(Key, null, Section);
        }

        public void DeleteSection(string Section)
        {
            Write(null, null, Section);
        }

        public bool KeyExists(string Key, string Section)
        {
            return Read(Key, Section).Length > 0;
        }

        public bool IsSettingExist()
        {
            return File.Exists(PATH);
        }
        public void CreateDefaultSetting()
        {
            File.Delete(PATH);
            Write("ServerName", "PRINC3-LAPTOP", "Database");
            Write("Port", "49172", "Database");
            Write("ServerAccount", "princ3od", "Database");
            Write("ServerPassword", "", "Database");
            Write("RememberMe", "FALSE", "Application");
            Write("LastID", "", "Application");
            Write("LastPass", "", "Application");
            Write("ConnectionType", "Server", "Application");
        }
    }
}
