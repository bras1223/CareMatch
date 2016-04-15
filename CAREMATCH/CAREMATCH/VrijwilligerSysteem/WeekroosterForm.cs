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
    public partial class WeekroosterForm : Form
    {
        private Gebruiker gebruiker;
        private AgendaPuntForm agendaForm;

        public WeekroosterForm(Gebruiker gebruiker)
        {
            InitializeComponent();
            this.gebruiker = gebruiker;
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void pnlAgenda_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
        }

        private void btnNieuwAgendaPunt_Click(object sender, EventArgs e)
        {
            agendaForm = new AgendaPuntForm(gebruiker);
            agendaForm.Show();
        }
    }
}
