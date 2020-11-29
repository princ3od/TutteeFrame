﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MaterialSkin.Controls;
using TutteeFrame.Model;
using System.Data;
using TutteeFrame.DataAccess;

namespace TutteeFrame.Controller
{
    class MainController
    {
        BaseDA mainDA;
        public MainController()
        {
            mainDA = new BaseDA();
        }
       

        public bool ConnectServer()
        {
            string server = InitHelper.Instance.Read("ServerName", "Database");
            string port = InitHelper.Instance.Read("Port", "Database");
            string serverAccount = InitHelper.Instance.Read("ServerAccount", "Database");
            string serverPass = InitHelper.Instance.Read("ServerPassword", "Database");
            return mainDA.Test(server, port, serverAccount, serverPass);
        }

       
        public string GenerateStudentID()
        {
            int result = 0;
            if (mainDA.GetLastStudentID(ref result))
            {
                result += 1;
            }
            return result.ToString();
        }
       

        public bool CreateAdminAccount()
        {
            Teacher teacher = new Teacher();
            teacher.Subject = new Subject("01", "Toán");
            teacher.ID = "AD999999";
            teacher.FirstName = "Admin";
            teacher.SurName = "Admin";
            teacher.Address = "";
            teacher.Phone = "0123456789";
            teacher.Mail = "admin@tutteframe.com";
            teacher.Type = Teacher.TeacherType.Adminstrator;
            return new TeacherController().AddTeacher(teacher);
        }
        

        


        

    }
}