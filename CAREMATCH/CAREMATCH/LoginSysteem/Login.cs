using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CAREMATCH;

namespace Login
{
    class Login
    {
        public Database database;
        public Login()
        {
            database = new Database();
        }
        //LoginCheck
        public void LoginCheck(string naam, string wachtwoord, LoginForm form1)
        {

            SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ferry\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Login where username='" + naam + "' and password='" + wachtwoord + "'", sql);
            SqlDataAdapter sdaa = new SqlDataAdapter("Select Count(*) From LoginAdmin where username='" + naam + "' and password='" + wachtwoord + "'", sql);
            DataTable dt = new DataTable();
            DataTable dat = new DataTable();
            sda.Fill(dt);
            sdaa.Fill(dat);

            if (dt.Rows[0][0].ToString() == "1")
            {
                form1.Userright();
            }
            else if (dat.Rows[0][0].ToString() == "1")
            {
                form1.AdminLogin();
            }
            else
            {
                form1.Userwrong();
            }
        }
    }
}

