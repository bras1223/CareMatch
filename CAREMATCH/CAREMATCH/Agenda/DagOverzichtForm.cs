using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAREMATCH.Agenda
{
    public partial class DagOverzichtForm : Form
    {
        private Database database;
        private Gebruiker gebruiker;
        private AgendaDagOverzicht dagOverzicht;
        private AgendaPuntToevoegenForm agendaPuntToevoegen;
        
        public DagOverzichtForm(Gebruiker gebruiker)
        {
            InitializeComponent();
            this.gebruiker = gebruiker;

            database = new Database();
            dagOverzicht = new AgendaDagOverzicht(gebruiker);

            //Alle agendapunten ophalen van de geselecteerde vrijwilliger ind e filter. Standaard eigen agenda weergeven.
            database.AgendaOverzicht(gebruiker, cbFilter.Text, dtpTijdPicker.Value.Date.ToString("dd-MMM-yy"));
            foreach (string vrijwilliger in database.AgendaSelecteerVrijwilligers())
            {
                cbFilter.Items.Add(vrijwilliger);
            }
            lblDatumWaarde.Text = dtpTijdPicker.Value.ToString();
            //Waarde van de filter zetten op de gebruikersnaam.
            cbFilter.SelectedItem = gebruiker.Gebruikersnaam;
            if(gebruiker.Rol.ToLower() == "hulpbehoevende")
            {
                //Als een hulpbehoevende de agenda opent; altijd eerste item selecteren.
                cbFilter.SelectedIndex = 0;
            }
        }

        private void btnAgendaPuntToevoegen_Click(object sender, EventArgs e)
        {
            agendaPuntToevoegen = new AgendaPuntToevoegenForm(gebruiker);
            agendaPuntToevoegen.ShowDialog();
            if (agendaPuntToevoegen.DialogResult == DialogResult.OK)
            {
                GetAgendaOverzicht();
            }
        }
        private void pnlWeekrooster_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics g = pnlWeekrooster.CreateGraphics())
            {
                dagOverzicht.DrawAgendaPunten(g, cbFilter.Text);                                
            }
        }
        private void btnSluiten_Click(object sender, EventArgs e)        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
        private void DagOverzichtForm_MouseDown(object sender, MouseEventArgs e)
        {
            
        }
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetAgendaOverzicht();
        }
        private void dtpTijdPicker_ValueChanged(object sender, EventArgs e)
        {
            GetAgendaOverzicht();
        }
        private void pnlWeekrooster_MouseUp(object sender, MouseEventArgs e)
        {
            foreach (Rectangle p in dagOverzicht.GetAgendaRectangleList())
            {
                if (p.X < e.X && p.Y < e.Y &&
                    p.Right > e.X && p.Bottom > e.Y)
                {
                    foreach(AgendaPunt ap in gebruiker.GetAgendaPunten())
                    {
                        
                    }
                }
            }
        }
        public void GetAgendaOverzicht()
        {
            gebruiker.GetAgendaPunten().Clear();
            database.AgendaOverzicht(gebruiker, cbFilter.Text, dtpTijdPicker.Value.Date.ToString("dd-MMM-yy"));
            pnlWeekrooster.Refresh();
        }
    }
}
