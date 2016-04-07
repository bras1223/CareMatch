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
using CAREMATCH;

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
            DateTime vandaag = new DateTime();
            Image piet = CAREMATCH.Properties.Resources.users;
            HomeForm homeForm;
            Gebruiker gebruiker;
            Gebruiker vrijwilliger;
            Gebruiker hulpbehoevende;
            //login.LoginCheck(textBox1.Text, textBox2.Text, this);
            if (textBox1.Text == "beheerder" && textBox2.Text == "beheerder")
            {
                gebruiker = new Gebruiker("henk", "piet", "piet", piet, "piet", vandaag, true, CAREMATCH.Enum.rol.beheerder);
                homeForm = new HomeForm(gebruiker);
                
                homeForm.Show();
                this.Hide();
                
            }
            else if (textBox1.Text == "vrijwilliger" && textBox2.Text == "beheerder")
            {
                vrijwilliger = new Gebruiker("henk", "piet", "piet", piet, "piet", vandaag, true, CAREMATCH.Enum.rol.vrijwilliger);
                homeForm = new HomeForm(vrijwilliger);
                homeForm.Show();
                this.Hide();
                
            }
            else if (textBox1.Text == "hulpbehoevende" && textBox2.Text == "hulpbehoevende")
            {
                hulpbehoevende = new Gebruiker("freek", "piet", "piet", piet, "piet", vandaag, true, CAREMATCH.Enum.rol.hulpbehoevende);
                homeForm = new HomeForm(hulpbehoevende);
                homeForm.Show();
                this.Hide(); 
            }
        }

        //User check
        public void AdminLogin()
        {
            //this.Hide();
            //BeheerdersForm twee = new BeheerdersForm();
            //twee.Show();
        }
        public void Userright()
        {
            //this.Hide();
            //GebruikersForm drie = new GebruikersForm();
            //drie.Show();
        }
        public void Userwrong()
        {
            //MessageBox.Show("Gebruikersnaam en/of wachtwoord verkeerd");
            //textBox2.Text = "";
        }

        //Go to register form
        private void lbRegister_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //SignUp drie = new SignUp();
            //drie.Show();
        }

        //Cursor hand
        private void lbRegister_MouseLeave(object sender, EventArgs e)
        {
            //lbRegister.Cursor = Cursors.Default;
        }
        private void lbRegister_MouseEnter(object sender, EventArgs e)
        {
            //lbRegister.Cursor = Cursors.Hand;
        }
    }
}
