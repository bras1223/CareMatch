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
        // private AgendaForm agendaForm = new AgendaForm();
        private HulpvraagForm hulpvraagForm;
       // private ProfielForm profielForm = new ProfielForm();
        public HulpvraagOverzichtForm(Gebruiker gebruiker)
        {
            InitializeComponent();
            hulpvraagForm = new HulpvraagForm(gebruiker);
        }

        private void lbHulpvragen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBekijkHulpvraag_Click(object sender, EventArgs e)
        {
            this.Hide();
            hulpvraagForm.ShowDialog();
            if(hulpvraagForm.DialogResult == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void btnProfiel_Click(object sender, EventArgs e)
        {

        }

        private void btnLogUit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {

        }

        private void HulpvraagOverzichtForm_Load(object sender, EventArgs e)
        {

        }
    }
}
