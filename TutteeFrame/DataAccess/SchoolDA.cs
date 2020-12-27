using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Windows;
using TutteeFrame.Model;

namespace TutteeFrame.DataAccess
{
    class SchoolDA:BaseDA
    {
       public bool GetSchoolInfoPrepareToPrint(DataSet input)
        {
            base.CreateLocalConnect();
            bool success = Connect();
            if (!success) return false;
            try
            {
                using (SqlCommand cmd =  new SqlCommand())
                {
                    strQuery = "SELECT * FROM SCHOOLINFO WHERE STT = '00001'";
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = strQuery;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(input,"SCHOOLINFO");
                }
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State == ConnectionState.Open) Disconnect();
                return false;
            }
        }
        public bool GetSchoolInfo(School school)
        {
            base.CreateLocalConnect();
            bool success = Connect();
            if (!success) return false;
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    strQuery = "SELECT * FROM SCHOOLINFO WHERE STT = '00001'";
                    cmd.Connection = connection;
                    cmd.CommandText = strQuery;
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader reader = cmd.ExecuteReader();
                    if(reader.Read())
                    {
                        if (!reader.IsDBNull(1)) school.Logo = ImageHelper.BytesToImage((byte[])reader["Logo"]);
                        if (!reader.IsDBNull(2)) school.Slogan = (string)reader["Slogan"];
                        if (!reader.IsDBNull(3)) school.FullName = (string)reader["FullName"];
                    }
                    Disconnect();
                    return true;
                }
            }
            catch(Exception ex)
            {
                if (connection.State == ConnectionState.Open) Disconnect();
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        ////
        ///
        public bool UpdateSchoolInfo(School school)
        {
            bool success = Connect();
            if (!success) return false;
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    strQuery = "UPDATE SCHOOLINFO " +
                        "SET Logo = @Logo,FullName=@FullName,Slogan=@Slogan " +
                        "WHERE STT = '00001'";
                    cmd.Connection = connection;
                    cmd.CommandText = strQuery;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Logo", ImageHelper.ImageToBytes(school.Logo));
                    cmd.Parameters.AddWithValue("@FullName",school.FullName);
                    cmd.Parameters.AddWithValue("@Slogan", school.Slogan);
                    cmd.ExecuteNonQuery();
                    Disconnect();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


    }
}
