using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login
{
    public partial class Start : Form
    {
        private Loginn login;
        public Start()
        {
            InitializeComponent();
            login = new Loginn();
        }

        //Logincheck
        private void btnLogin_Click(object sender, EventArgs e)
        {
            login.LoginCheck(textBox1.Text, textBox2.Text, this);
        }

        //User check
        public void AdminLogin()
        {
            this.Hide();
            BeheerdersForm twee = new BeheerdersForm();
            twee.Show();
        }
        public void Userright()
        {
            this.Hide();
            GebruikersForm drie = new GebruikersForm();
            drie.Show();
        }
        public void Userwrong()
        {
            MessageBox.Show("Gebruikersnaam en/of wachtwoord verkeerd");
            textBox2.Text = "";
        }

        //Go to register form
        private void lbRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp drie = new SignUp();
            drie.Show();
        }

        //Cursor hand
        private void lbRegister_MouseLeave(object sender, EventArgs e)
        {
            lbRegister.Cursor = Cursors.Default;
        }
        private void lbRegister_MouseEnter(object sender, EventArgs e)
        {
            lbRegister.Cursor = Cursors.Hand;
        }

        //Close application
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
