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

            cbRol.SelectedIndex = 0;

            btnUploadVOG.Visible = false;
            lblVOGPath.Visible = false;
            lblVOG.Visible = false;     
        }
        //Gebruiker toevoegen
        private void btnRegistreer_Click(object sender, EventArgs e)
        {
            //Controlleer of gebruikersnaam bestaat.
            bool GebruikNaam = database.GebruikerControlleerUsername(tbGebruikersnaam.Text);

            if (GebruikNaam == false)
            {
                MessageBox.Show("Gebruikersnaam bestaat al");
            }
            if (tbWachtwoord.Text != tbHerhWachtwoord.Text)
            {
                MessageBox.Show("Wachtwoorden zijn niet gelijk");
            }
            if (tbGebruikersnaam.Text == "")
            {
                MessageBox.Show("Geen gebruikersnaam ingevuld");
            }
            if (tbWachtwoord.Text == "")
            {
                MessageBox.Show("Geen wachtwoord ingevuld");
            }
            else if (cbRol.Text == "Hulpbehoevende" && tbWachtwoord.Text == tbHerhWachtwoord.Text && GebruikNaam == true)
            {
                database.GebruikerAccountToevoegen(tbGebruikersnaam.Text, tbWachtwoord.Text,  "Y", cbRol.Text, lblPasFotoPath.Text, lblVOGPath.Text, tbVoornaam.Text, tbAchternaam.Text, cbGeslacht.Text, dtpGeboortedatum.Value);
                MessageBox.Show("Account aangemaakt. U kunt nu inloggen.");
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (cbRol.Text == "Vrijwilliger" && tbWachtwoord.Text == tbHerhWachtwoord.Text && GebruikNaam == true)
            {
                //Vrijwilliger moet een VOG uploaden.
                if (lblVOGPath.Text == "")
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
                            if (!File.Exists(tbGebruikersnaam.Text))
                            {
                                //Directory aanmaken als deze nog niet bestaat.
                                System.IO.Directory.CreateDirectory(tbGebruikersnaam.Text);
                            }
                            //Gekozen afbeelding kopieren naar pasfoto directory. Foto = Gebruikersnaam\Gebruikersnaam + Bestandsextensie
                            try
                            {
                                vog = tbGebruikersnaam.Text + @"\VOG" + Path.GetExtension(ofd.FileName);
                                File.Copy(ofd.FileName, vog);
                            }
                            catch
                            {
                                MessageBox.Show("Er is iets fout gegaan bij het uploaden van een VOG. Contacteer een beheerder.");
                            }
                        }
                    }
                    database.GebruikerAccountToevoegen(tbGebruikersnaam.Text, tbWachtwoord.Text, "Y", cbRol.Text, lblPasFotoPath.Text, lblVOGPath.Text, tbVoornaam.Text, tbAchternaam.Text, cbGeslacht.Text, dtpGeboortedatum.Value);
                    MessageBox.Show("Account aangemaakt. U moet wachten tot dat uw account is geactiveerd voordat u kunt inloggen.");
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
        //Wachtwoord controle
        private void txtHerhWachtwoord_TextChanged(object sender, EventArgs e)
        {
            if (tbWachtwoord.Text.Length < 5)
            {
                label4.Visible = true;
                label5.Visible = false;
            }
            if (tbWachtwoord.Text.Length >= 5)
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
                lblVOGPath.Text = ofd.FileName;
            }
        }
        private void cbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbRol.Text.ToLower() == "vrijwilliger")
            {
                btnUploadVOG.Visible = true;
                lblVOG.Visible = true;


            }
            else
            {
               
                btnUploadVOG.Visible = false;
                lblVOG.Visible = false;

            }
        }

        private void btnPasfotoToevoegen_Click(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                lblPasFotoPath.Text = ofd.FileName;
            }
        }
    }
}
