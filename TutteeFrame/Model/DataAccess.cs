using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TutteeFrame.Modal
{
    class DataAccess
    {
        // singleton design-pattern
        private DataAccess() { }
        readonly static DataAccess _instance = new DataAccess();
        public static DataAccess Instance => _instance;

        public bool Connect()
        {
            string strConnect = @"Server=tcp:PrInc3-Laptop,49172;Initial Catalog=TutteeFrame;User ID=princ3od;password=;Integrated Security=False;Connect Timeout=5;";
            SqlConnection connection = new SqlConnection(strConnect);
            try
            {
                connection.Open();
                MessageBox.Show("Successs");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }
    }
}
