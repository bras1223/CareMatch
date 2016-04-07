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
    public partial class HulpvraagForm : Form
    {
        private Gebruiker gebruiker;
        public HulpvraagForm(Gebruiker gebruiker)
        {
            InitializeComponent();
            this.gebruiker = gebruiker;
        }

        private void btnSluit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnReageer_Click(object sender, EventArgs e)
        {
            rtxtReactieInhoud.Enabled = true;
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
    }
}
