using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAREMATCH.VrijwilligerSysteem
{
    public partial class ProfielForm : Form
    {
        private Gebruiker gebruiker;
        private Database database;
        private OpenFileDialog zoekFotoDialog;

        private string FotoPath;
        public ProfielForm(Gebruiker gebruiker)
        {
            InitializeComponent();
            this.gebruiker = gebruiker;
            database = new Database();

            //afbeelding in de picturebox zetten als een gebruiker deze heeft.
            if (gebruiker.Pasfoto != "")
            {
                pbProfielFoto.Image = Image.FromFile(gebruiker.Pasfoto);
            }
            //checkbox checken als de gebruiker een auto heeft
            if(gebruiker.Auto)
            {
                cbAuto.Checked = true;
            }
            //info van de gebruiker in de textvelden zetten.
            rtxtGebruikerInfo.Text = gebruiker.GebruikerInfo;
            txtAchternaam.Text = gebruiker.Achternaam;
            txtVoornaam.Text = gebruiker.Voornaam;
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            //dubbele IF anders foutmelding.
            if(zoekFotoDialog != null)
            {
                //Als er een afbeelding geselecteerd is.
                if (zoekFotoDialog.FileName != "")
                {
                    FotoPath = gebruiker.Gebruikersnaam + @"\" + gebruiker.Gebruikersnaam + Path.GetExtension(zoekFotoDialog.FileName);
                    if (!File.Exists(gebruiker.Gebruikersnaam))
                    {
                        //Directory aanmaken als deze nog niet bestaat.
                        System.IO.Directory.CreateDirectory(gebruiker.Gebruikersnaam);
                    }
                    //Gekozen afbeelding kopieren naar pasfoto directory. Foto = Gebruikersnaam\Gebruikersnaam + Bestandsextensie
                    try
                    {
                        //passfoto property krijgt de string van de afbeeldingnaam.
                        gebruiker.Pasfoto = FotoPath;
                        //Als er all een profielfoto is. De afbeelding verwijderen en nieuwe afbeelding kopieren.
                        if(!File.Exists(FotoPath))
                        {
                            File.Copy(zoekFotoDialog.FileName, FotoPath);
                        }
                        else
                        {
                            using (FileStream fs = File.Open(FotoPath, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
                            {
                                fs.Close();
                            }
                            File.Delete(FotoPath);
                            File.Copy(zoekFotoDialog.FileName, FotoPath);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Probleem bij het instellen van de profiel afbeelding.");
                    }
                }
            }

            gebruiker.GebruikerInfo = rtxtGebruikerInfo.Text;
            gebruiker.Voornaam = txtVoornaam.Text;
            gebruiker.Achternaam = txtAchternaam.Text;
            //Verschil maken tussen welke info veranderd is. Anders wordt er een encryptie 
            //over encryptie van het wachtwoord gedaan elke keer dat je iets aan het profiel aanpast
            if (txtHerhaalWachtwoord.Text != "")
            {
                gebruiker.Wachtwoord = txtNieuwWachtwoord.Text;
                database.ProfielAanpassen(gebruiker,true,false);
            }
            else if(gebruiker.Pasfoto != @"\")
            {
                database.ProfielAanpassen(gebruiker, false, true);
            }
            else
            {
                database.ProfielAanpassen(gebruiker, false, false);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnWijzig_Click(object sender, EventArgs e)
        {
            zoekFotoDialog = new OpenFileDialog();
            zoekFotoDialog.ShowDialog();
        }
        private void cbAuto_CheckedChanged(object sender, EventArgs e)
        {
            if(cbAuto.Checked)
            {
                gebruiker.Auto = true;
            }
            else
            {
                gebruiker.Auto = false;
            }
        }
    }
}
