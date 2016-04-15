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
    public partial class AgendaPuntForm : Form
    {
        private Gebruiker gebruiker;
        private AgendaPunt agendaPunt;

        public AgendaPuntForm(Gebruiker gebruiker)
        {
            InitializeComponent();
            this.gebruiker = gebruiker;
            agendaPunt = new AgendaPunt();
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            agendaPunt.AfspraakBeschrijving = rtxtBeschrijving.Text;
            gebruiker.AgendaPuntToevoegen(agendaPunt);
            DialogResult = DialogResult.OK;
        }
    }
}
