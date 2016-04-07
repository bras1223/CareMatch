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
    public partial class AgendaForm : Form
    {
        private Gebruiker gebruiker;

        public AgendaForm(Gebruiker gebruiker)
        {
            InitializeComponent();
            this.gebruiker = gebruiker;
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
