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

namespace CAREMATCH
{
    public partial class OngepasteBerichtenForm : Form
    {
        private string filter;
        private Database database;
        private Gebruiker gebruiker;
        private List<Hulpvraag> hulpvragen;
        

        public OngepasteBerichtenForm(Gebruiker gebruiker)
        {
            InitializeComponent();
            cmbKiesBerichten.Items.Add("gemarkeerde hulpvragen");
            cmbKiesBerichten.Items.Add("gemarkeerde beoordelingen");
            cmbKiesBerichten.Items.Add("verdachte berichten");

            this.gebruiker = gebruiker;
            database = new Database();
        }

        private void cmbKiesBerichten_SelectedValueChanged(object sender, EventArgs e)
        {
            string filter = "";
            
            //
            string switchcase = cmbKiesBerichten.Text.ToLower();
            switch (switchcase)
            {
                case "gemarkeerde hulpvragen":
                    MessageBox.Show("gemarkeerde hulpvragen");
                    filter = "ongepaste hulpvragen";
                    VulListViewMetHulpvragen();
                    break;
                case "gemarkeerde beoordeling":
                    MessageBox.Show("gemarkeerde beoordeling");
                    filter = "ongepaste beoordelingen";
                    break;
                case "verdachte berichten":
                    MessageBox.Show("verdachte hulpvragen");
                    filter = "verdachte hulpvragen";
                    break;
                default:
                    MessageBox.Show("default");
                    break;
            }
            if(filter != "")
            {
                hulpvragen = database.HulpvragenOverzicht(gebruiker, filter);
            }
            
            //listview vullen met de gekregen list;
        }

        private void VerwijderGemarkeerdeHulpvraag(Hulpvraag hulpvraag)
        {
            database.HulpvraagVerwijderen(hulpvraag);
            hulpvraag = null;

        }

        private void VulListViewMetHulpvragen()
        {
            
            hulpvragen = database.HulpvragenOverzicht(gebruiker, filter);

            lvOngepasteBerichten.Columns.Add("ID");
            lvOngepasteBerichten.Columns.Add("Titel");
            lvOngepasteBerichten.Columns.Add("Hulpvraag");

            foreach(Hulpvraag hulpvraag in hulpvragen)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(hulpvraag.Titel);
                item.SubItems.Add(hulpvraag.HulpvraagInhoud);
                lvOngepasteBerichten.Items.Add(item);
            }
                


        }
    }
}
