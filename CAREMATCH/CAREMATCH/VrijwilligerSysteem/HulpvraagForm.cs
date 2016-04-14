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
    public partial class HulpvraagForm : Form
    {
        private Gebruiker gebruiker;
        public HulpvraagForm(Gebruiker gebruiker, bool hulpvraagIndienen)
        {
            InitializeComponent();
            this.gebruiker = gebruiker;

            if (gebruiker.GetType() == typeof(Hulpbehoevende) && hulpvraagIndienen == true)
            {
                rtxtReactieInhoud.Enabled = false;
                btnReactieOpslaan.Visible = false;
            }
            else if (gebruiker.GetType() == typeof(Vrijwilliger))
            {
                btnHulpvraagOpslaan.Visible = false;

                cbUrgent.Enabled = false;
                rtxtHulpvraag.Enabled = false;

                txtDuur.Enabled = false;
                txtFrequentie.Enabled = false;
                txtHulpvrager.Enabled = false;
                txtTitel.Enabled = false;
            }
        }

        private void btnSluit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnSlaOp_Click(object sender, EventArgs e)
        {
            rtxtReactieInhoud.Enabled = false;
        }

        private void HulpvraagForm_Load(object sender, EventArgs e)
        {

        }

        private void cbUrgent_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rtxtReactieInhoud_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
