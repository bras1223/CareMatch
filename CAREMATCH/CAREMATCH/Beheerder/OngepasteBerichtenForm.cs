using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAREMATCH
{
    public partial class OngepasteBerichtenForm : Form
    {
        private Database database;
        private Gebruiker gebruiker;
        

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
            string switchcase = cmbKiesBerichten.SelectedText;
            switch (switchcase)
            {
                case "gemarkeerde hulpvragen":
                    MessageBox.Show("gemarkeerde hulpvragen");
                    filter = "ongepaste hulpvragen";
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
            if(filter != string.Empty)
            {
                database.HulpvragenOverzicht(gebruiker, filter);
            }
            
            //listview vullen met de gekregen list;
        }

        private void VerwijderGemarkeerdeHulpvraag(Hulpvragen.Hulpvraag hulpvraag)
        {
            //Database.RemoveHulpvraagAt(lvOngepasteBerichten.selectedIndex);
            hulpvraag = null;

        }
    }
}
