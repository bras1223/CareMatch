using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAREMATCH.VrijwilligerSysteem
{
    public partial class HulpvraagOverzichtForm : Form
    {
        private Database database;
        private HulpvraagForm hulpvraagForm;
        
        public HulpvraagOverzichtForm(Gebruiker gebruiker)
        {
            InitializeComponent();
            database = new Database();
            hulpvraagForm = new HulpvraagForm(gebruiker, false);

            if(gebruiker.rol == Enum.rol.hulpbehoevende)
            {
                lblGebruikersnaam.Text = gebruiker.Gebruikersnaam;
                lblGebruikerType.Text = "hulpbehoevende";
            }
            else if(gebruiker.rol == Enum.rol.vrijwilliger)
            {
                lblGebruikersnaam.Text = gebruiker.Gebruikersnaam;
                lblGebruikerType.Text = "vrijwilliger";
            }
            else
            {
                lblGebruikersnaam.Text = gebruiker.Gebruikersnaam;
                lblGebruikerType.Text = "beheerder";
            }

            lvHulpvragenOverzicht.View = View.Details;
            string[] row1 = { database.HulpvragenOverzicht()[0], database.HulpvragenOverzicht()[1], database.HulpvragenOverzicht()[2] };
            lvHulpvragenOverzicht.Items.Add("chHulpvraagID").SubItems.AddRange(row1);
        }
        private void btnBekijkHulpvraag_Click(object sender, EventArgs e)
        {
            //properties van aangeklikte hulpvraag moeten aan HulpvraagForm worden meegegeven, zodat je ze kunt bekijken.
            //selected index van listbox/view item uit list met hulpvragen halen

            this.Hide();
            hulpvraagForm.ShowDialog();
            if(hulpvraagForm.DialogResult == DialogResult.OK)
            {
                this.Show();
            }
        }
        private void btnLogUit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
        private void HulpvraagOverzichtForm_Load(object sender, EventArgs e)
        {

        }

        private void lvHulpvragenOverzicht_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
