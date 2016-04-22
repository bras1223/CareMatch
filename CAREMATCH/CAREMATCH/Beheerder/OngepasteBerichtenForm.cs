using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAREMATCH.Hulpvragen;
using CAREMATCH.VrijwilligerSysteem;

namespace CAREMATCH
{
    public partial class OngepasteBerichtenForm : Form
    {
        private Database database;
        private Gebruiker gebruiker;
        private List<Hulpvraag> hulpvragen;
        

        public OngepasteBerichtenForm(Gebruiker gebruiker)
        {
            InitializeComponent();
            cmbKiesBerichten.Items.Add("gemarkeerde hulpvragen");
            cmbKiesBerichten.Items.Add("gemarkeerde beoordelingen");
            //cmbKiesBerichten.Items.Add("verdachte berichten");

            this.gebruiker = gebruiker;
            database = new Database();

            
            lvOngepasteBerichten.View = View.Details;
            lvOngepasteBerichten.CheckBoxes = true;
        }

        private void cmbKiesBerichten_SelectedValueChanged(object sender, EventArgs e)
        {
            string filter = "";
            
            //
            string switchcase = cmbKiesBerichten.Text.ToLower();
            switch (switchcase)
            {
                case "gemarkeerde hulpvragen":
                    //MessageBox.Show("gemarkeerde hulpvragen");
                    filter = "ongepaste hulpvragen";

                    //prepare listview
                    lvOngepasteBerichten.Clear();
                    lvOngepasteBerichten.Columns.Add("Check");
                    lvOngepasteBerichten.Columns.Add("ID");
                    lvOngepasteBerichten.Columns.Add("Titel");
                    lvOngepasteBerichten.Columns.Add("Hulpvraag");
                    lvOngepasteBerichten.Columns.Add("Uitzetter");
                    break;
                case "gemarkeerde beoordeling":
                   // MessageBox.Show("gemarkeerde beoordeling");
                    filter = "ongepaste beoordelingen";

                    //prepare listview
                    lvOngepasteBerichten.Clear();
                    lvOngepasteBerichten.Columns.Add("Check");
                    lvOngepasteBerichten.Columns.Add("Beoordeling van:");
                    lvOngepasteBerichten.Columns.Add("Beoordeling");
                    lvOngepasteBerichten.Columns.Add("Uitzetter");
                    break;
                case "verdachte berichten":
                   // MessageBox.Show("verdachte hulpvragen");
                    filter = "verdachte hulpvragen";


                    break;
                default:
                   // MessageBox.Show("default");
                    break;
            }
            if(filter == "ongepaste hulpvragen" || filter == "ongepaste beoordelingen")
            {
                hulpvragen = database.HulpvragenOverzicht(gebruiker, filter);
            }


            VulListViewMetHulpvragen(hulpvragen);
            //listview vullen met de gekregen list;
        }

        private void VerwijderGemarkeerdeHulpvraag(Hulpvraag hulpvraag)
        {
            database.HulpvraagVerwijderen(hulpvraag);
            hulpvraag = null;

        }

        private void VulListViewMetHulpvragen(List<Hulpvraag> hulpvragen)
        {
            foreach(Hulpvraag hulpvraag in hulpvragen)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(hulpvraag.HulpvraagID.ToString());
                item.SubItems.Add(hulpvraag.Titel);
                item.SubItems.Add(hulpvraag.HulpvraagInhoud);
                item.SubItems.Add(hulpvraag.Hulpbehoevende);

                lvOngepasteBerichten.Items.Add(item);
            }
        }

        private void VulListViewMetBeoordelingen(List<Hulpvraag> hulpvragen)
        {
            foreach(Hulpvraag hulpvraag in hulpvragen)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(hulpvraag.Titel);
                item.SubItems.Add(hulpvraag.Beoordeling);
                item.SubItems.Add(hulpvraag.Hulpbehoevende);
                
            }

        }
        private void btnLaatZien_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hulpvraag hulpvraag;
            //geselecteerde hulpvraag openen.
            hulpvraag = hulpvragen[lvOngepasteBerichten.FocusedItem.Index];
            if(hulpvraag != null)
            {
                HulpvraagForm hulpvraagForm = new HulpvraagForm(hulpvraag, gebruiker, false);
                hulpvraagForm.ShowDialog();
                if (hulpvraagForm.DialogResult == DialogResult.OK || hulpvraagForm.DialogResult == DialogResult.Cancel)
                {
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("selecteer AUB een hulpvraag");
            }


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnDeleteSelection_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OngepasteBerichtenForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
