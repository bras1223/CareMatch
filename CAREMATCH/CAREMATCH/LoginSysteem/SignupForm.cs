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
    public partial class SignupForm : Form
    {
        private Database dbQuery;
        
        public SignupForm()
        {
            InitializeComponent();
            label4.Visible = false;
            label5.Visible = false;
            dbQuery = new Database();
            
        }
        //SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ferry\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30");

        private void button1_Click(object sender, EventArgs e)
        {
            //int GebruikerIDNUM = dbQuery.ControlleerMaxGebruikerID;

            if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Wachtwoorden zijn niet gelijk");
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("Niet alles is ingevuld");
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Niet alles is ingevuld");
            }
            else if (comboBox1.Text == "Hulpbehoevende")
            {
                dbQuery.AccountToevoegen("6", textBox1.Text, textBox2.Text, "Y", comboBox1.Text);
                MessageBox.Show("Account toegevoed");
            }
            else if (comboBox1.Text == "Vrijwilliger")
            {
                dbQuery.AccountToevoegen("6", textBox1.Text, textBox2.Text, "N", comboBox1.Text);
                MessageBox.Show("Account toegevoed");
            }


            //if (textBox2.Text == textBox3.Text && textBox2.Text != "" && textBox1.Text != "")
            // {
            ///  sql.Open();
            //   SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO Login (Username, Password) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "')", sql);
            //  sda.SelectCommand.ExecuteNonQuery();
            //   sql.Close();
            //   MessageBox.Show("Gebruiker succesvol toegevoed!");
            // }



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 5)
            {
                label4.Visible = true;
                label5.Visible = false;
            }
            if (textBox2.Text.Length >= 5)
            {
                label4.Visible = false;
                label5.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // this.Hide();
           // Start een = new Start();
            //een.Show();
        }
    }
}
