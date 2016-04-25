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
    partial class BeoordelingForm : Form
    {
        Hulpvragen.Hulpvraag hulpvraag;
        Database database;
        public BeoordelingForm(Hulpvragen.Hulpvraag hulpvraag)
        {
            InitializeComponent();
            database = new Database();
            this.hulpvraag = hulpvraag;

            lblUitleg.Text = "Beoordeel de hulp die u gekregen hebt van de vrijwilliger.\n Maak de beoordeling niet persoonlijk.";
        }

        private void btnSlaOp(object sender, EventArgs e)
        {
            hulpvraag.Beoordeling = txtBeoordeling.Text;

            database.HulpvraagBeoordelingToevoegen(hulpvraag);
            MessageBox.Show("Beoordeling opgeslagen.");

            Close();
        }
    }
}
