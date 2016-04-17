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
using System.IO;

namespace Login
{
    public partial class SignupForm : Form
    {
        private Database database;
        private OpenFileDialog ofd;
        private string vog;
        public SignupForm()
        {
            InitializeComponent();
            database = new Database();

            label4.Visible = false;
            label5.Visible = false;

            btnUploadVOG.Visible = false;
            txtUploadVOG.Visible = false;        
        }
        //Gebruiker toevoegen
        private void button1_Click(object sender, EventArgs e)
        {
            //Controlleer of gebruikersnaam bestaat.
            bool GebruikNaam = database.GebruikerControlleerUsername(txtGebruikersnaam.Text);

            if (GebruikNaam == false)
            {
                MessageBox.Show("Gebruikersnaam bestaat al");
            }
            if (txtWachtwoord.Text != txtHerhWachtwoord.Text)
            {
                MessageBox.Show("Wachtwoorden zijn niet gelijk");
            }
            if (txtGebruikersnaam.Text == "")
            {
                MessageBox.Show("Niet alles is ingevuld");
            }
            if (txtWachtwoord.Text == "")
            {
                MessageBox.Show("Niet alles is ingevuld");
            }
            else if (cbRol.Text == "Hulpbehoevende" && txtWachtwoord.Text == txtHerhWachtwoord.Text && GebruikNaam == true)
            {
                database.GebruikerAccountToevoegen(txtGebruikersnaam.Text, txtWachtwoord.Text, "Y", cbRol.Text, txtUploadVOG.Text);
                MessageBox.Show("Account aangemaakt. U kunt nu inloggen.");
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (cbRol.Text == "Vrijwilliger" && txtWachtwoord.Text == txtHerhWachtwoord.Text && GebruikNaam == true)
            {
                //Vrijwilliger moet een VOG uploaden.
                if (txtUploadVOG.Text == "")
                {
                    MessageBox.Show("Een vrijwilliger is verplicht een VOG bij te voegen.");
                }
                else
                {
                    //VOG uploaden
                    if (ofd != null)
                    {
                        //Als er een afbeelding geopend is.
                        if (ofd.FileName != "")
                        {
                            if (!File.Exists(txtGebruikersnaam.Text))
                            {
                                //Directory aanmaken als deze nog niet bestaat.
                                System.IO.Directory.CreateDirectory(txtGebruikersnaam.Text);
                            }
                            //Gekozen afbeelding kopieren naar pasfoto directory. Foto = Gebruikersnaam\Gebruikersnaam + Bestandsextensie
                            try
                            {
                                vog = txtGebruikersnaam.Text + @"\VOG" + Path.GetExtension(ofd.FileName);
                                File.Copy(ofd.FileName, vog);
                            }
                            catch
                            {
                                MessageBox.Show("Er is iets fout gegaan bij het uploaden van een VOG. Contacteer een beheerder.");
                            }
                        }
                    }
                    database.GebruikerAccountToevoegen(txtGebruikersnaam.Text, txtWachtwoord.Text, "Y", cbRol.Text, vog);
                    MessageBox.Show("Account aangemaakt. U moet wachten tot dat uw account is geactiveerd voordat u kunt inloggen.");
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
        //Wachtwoord controle
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (txtWachtwoord.Text.Length < 5)
            {
                label4.Visible = true;
                label5.Visible = false;
            }
            if (txtWachtwoord.Text.Length >= 5)
            {
                label4.Visible = false;
                label5.Visible = true;
            }
        }
        //Terug naar LoginForm
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
        private void btnUploadVOG_Click(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                txtUploadVOG.Text = ofd.FileName;
            }
        }

        private void SignupForm_Load(object sender, EventArgs e)
        {

        }

        private void cbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbRol.Text.ToLower() == "vrijwilliger")
            {
                btnUploadVOG.Visible = true;
                txtUploadVOG.Visible = true;
            }
            else
            {
                btnUploadVOG.Visible = false;
                txtUploadVOG.Visible = false;
            }
        }
    }
}
