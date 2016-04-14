using System;
using CAREMATCH.Gebruikers;
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

            if(gebruiker.GetType() == typeof(Hulpbehoevende))
            {
                lblGebruikersnaam.Text = gebruiker.Gebruikersnaam;
            }
            else if(gebruiker.GetType() == typeof(Vrijwilliger))
            {
                lblGebruikersnaam.Text = gebruiker.Gebruikersnaam;
            }
            else
            {
                lblGebruikersnaam.Text = gebruiker.Gebruikersnaam;
            }

            lvHulpvragen.Columns.Add("HulpvraagID");
            lvHulpvragen.Columns.Add("Foto");
            lvHulpvragen.Columns.Add("Hulpbehoevende");
            lvHulpvragen.Columns.Add("Titel");
            lvHulpvragen.Columns.Add("Hulpvraag inhoud");
            lvHulpvragen.Columns.Add("Vrijwilliger");
            lvHulpvragen.Columns.Add("Urgent");

            foreach (Hulpvragen.Hulpvraag hulpvraag in database.HulpvragenOverzicht())
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(hulpvraag.HulpvraagID.ToString());
            }
        }
        private void btnBekijkHulpvraag_Click(object sender, EventArgs e)
        {
            //properties van aangeklikte hulpvraag moeten aan HulpvraagForm worden meegegeven, zodat je ze kunt bekijken.
            //selected index van listbox/view item uit list met hulpvragen halen
            //eventueel nog de hulpvraag aan kunnen passen als hulbbehoevende

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
