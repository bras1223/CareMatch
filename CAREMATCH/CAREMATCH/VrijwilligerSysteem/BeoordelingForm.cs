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
        private Hulpvragen.Hulpvraag hulpvraag;
        private Database database;
        public BeoordelingForm(Hulpvragen.Hulpvraag hulpvraag)
        {
            InitializeComponent();
            database = new Database();
            this.hulpvraag = hulpvraag;
            lblUitleg.Text = "Beoordeel de hulp die u gekregen hebt van de vrijwilliger.\n Maak de beoordeling niet persoonlijk.";
        }

        #region Mouseleave
        private void pbStar4_MouseLeave(object sender, EventArgs e)
        {
            pbStar3_MouseLeave(sender, e);
            pbStar4.Image = Properties.Resources.EmptyStar;
        }

        private void pbStar3_MouseLeave(object sender, EventArgs e)
        {
            pbStar2_MouseLeave(sender, e);
            pbStar3.Image = Properties.Resources.EmptyStar;
        }

        private void pbStar2_MouseLeave(object sender, EventArgs e)
        {
            pbStar1_MouseLeave(sender, e);
            pbStar2.Image = Properties.Resources.EmptyStar;
        }

        private void pbStar1_MouseLeave(object sender, EventArgs e)
        {
            pbStar1.Image = Properties.Resources.EmptyStar;
        }

        private void pbStar5_MouseLeave(object sender, EventArgs e)
        {
            pbStar4_MouseLeave(sender, e);
            pbStar5.Image = Properties.Resources.EmptyStar;
        }
        #endregion
        #region MouseEnter
        private void pbStar1_MouseEnter(object sender, EventArgs e)
        {
            pbStar1.Image = Properties.Resources.FilledStar;
        }

        private void pbStar2_MouseEnter(object sender, EventArgs e)
        {
            pbStar1_MouseEnter(sender, e);
            pbStar2.Image = Properties.Resources.FilledStar;
        }

        private void pbStar3_MouseEnter(object sender, EventArgs e)
        {
            pbStar2_MouseEnter(sender, e);
            pbStar3.Image = Properties.Resources.FilledStar;
        }

        private void pbStar4_MouseEnter(object sender, EventArgs e)
        {
            pbStar3_MouseEnter(sender, e);
            pbStar4.Image = Properties.Resources.FilledStar;
        }

        private void pbStar5_MouseEnter(object sender, EventArgs e)
        {
            pbStar4_MouseEnter(sender, e);
            pbStar5.Image = Properties.Resources.FilledStar;
        }
        #endregion
        #region MouseClick
        private void pbStar1_Click(object sender, EventArgs e)
        {
            pbStar1.Image = Properties.Resources.FilledStar;
            hulpvraag.Cijfer = 1;
            RemoveMouseLeave(hulpvraag.Cijfer);
        }

        private void pbStar2_Click(object sender, EventArgs e)
        {
            pbStar1_Click(sender, e);
            pbStar2.Image = Properties.Resources.FilledStar;
            hulpvraag.Cijfer = 2;
            RemoveMouseLeave(hulpvraag.Cijfer);
        }

        private void pbStar3_Click(object sender, EventArgs e)
        {
            pbStar2_Click(sender, e);
            pbStar3.Image = Properties.Resources.FilledStar;
            hulpvraag.Cijfer = 3;
            RemoveMouseLeave(hulpvraag.Cijfer);
        }

        private void pbStar4_Click(object sender, EventArgs e)
        {
            pbStar3_Click(sender, e);
            pbStar4.Image = Properties.Resources.FilledStar;
            hulpvraag.Cijfer = 4;
            RemoveMouseLeave(hulpvraag.Cijfer);
        }

        private void pbStar5_Click(object sender, EventArgs e)
        {
            pbStar4_Click(sender, e);
            pbStar5.Image = Properties.Resources.FilledStar;
            hulpvraag.Cijfer = 5;
            RemoveMouseLeave(hulpvraag.Cijfer);
        }
        #endregion
        private void RemoveMouseLeave(int i)
        {
            switch(i)
            {
                case 1:
                    this.pbStar1.MouseLeave -= new System.EventHandler(this.pbStar1_MouseLeave);
                    break;
                case 2:
                    this.pbStar1.MouseLeave -= new System.EventHandler(this.pbStar1_MouseLeave);
                    this.pbStar2.MouseLeave -= new System.EventHandler(this.pbStar2_MouseLeave);
                    break;
                case 3:
                    this.pbStar1.MouseLeave -= new System.EventHandler(this.pbStar1_MouseLeave);
                    this.pbStar2.MouseLeave -= new System.EventHandler(this.pbStar2_MouseLeave);
                    this.pbStar3.MouseLeave -= new System.EventHandler(this.pbStar3_MouseLeave);
                    break;
                case 4:
                    this.pbStar1.MouseLeave -= new System.EventHandler(this.pbStar1_MouseLeave);
                    this.pbStar2.MouseLeave -= new System.EventHandler(this.pbStar2_MouseLeave);
                    this.pbStar3.MouseLeave -= new System.EventHandler(this.pbStar3_MouseLeave);
                    this.pbStar4.MouseLeave -= new System.EventHandler(this.pbStar4_MouseLeave);
                    break;
                case 5:
                    this.pbStar1.MouseLeave -= new System.EventHandler(this.pbStar1_MouseLeave);
                    this.pbStar2.MouseLeave -= new System.EventHandler(this.pbStar2_MouseLeave);
                    this.pbStar3.MouseLeave -= new System.EventHandler(this.pbStar3_MouseLeave);
                    this.pbStar4.MouseLeave -= new System.EventHandler(this.pbStar4_MouseLeave);
                    this.pbStar5.MouseLeave -= new System.EventHandler(this.pbStar5_MouseLeave);
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hulpvraag.Beoordeling = txtBeoordeling.Text;

            database.HulpvraagBeoordelingToevoegen(hulpvraag);
            MessageBox.Show("U heeft een " + hulpvraag.Cijfer + "/5 gegeven voor de gekregen hulp.\n Beoordeling opgeslagen.");
            Close();
        }
    }
}
