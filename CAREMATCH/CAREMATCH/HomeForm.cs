using CAREMATCH.VrijwilligerSysteem;
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
    public partial class HomeForm : Form
    {
        private ChatForm chatForm;
        private AgendaForm agendaForm;
        private HulpvraagForm hulpvraagForm;
        private HulpvraagIndienenForm hulpvraagIndienen;
        private HulpvraagOverzichtForm hulpvraagOverzichtForm;
        private ProfielForm profielForm;

        public HomeForm()
        {
            InitializeComponent();
        }

        private void btnHulpvraagIndienen_Click(object sender, EventArgs e)
        {
            this.Hide();
            hulpvraagIndienen.ShowDialog();
            if(hulpvraagIndienen.DialogResult == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void btnHulpvraagAannemen_Click(object sender, EventArgs e)
        {
            this.Hide();
            hulpvraagOverzichtForm.ShowDialog();
            if(hulpvraagOverzichtForm.DialogResult == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void btnMijnHulpvragen_Click(object sender, EventArgs e)
        {
            this.Hide();
            hulpvraagOverzichtForm.ShowDialog();
            if (hulpvraagOverzichtForm.DialogResult == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void btnAangenomenHulpvragen_Click(object sender, EventArgs e)
        {
            this.Hide();
            hulpvraagOverzichtForm.ShowDialog();
            if (hulpvraagOverzichtForm.DialogResult == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            this.Hide();
            agendaForm.ShowDialog();
            if (agendaForm.DialogResult == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void btnBerichten_Click(object sender, EventArgs e)
        {
            this.Hide();
            chatForm.ShowDialog();
            if (chatForm.DialogResult == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void btnProfiel_Click(object sender, EventArgs e)
        {
            this.Hide();
            profielForm.ShowDialog();
            if (profielForm.DialogResult == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void btnUitloggen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
