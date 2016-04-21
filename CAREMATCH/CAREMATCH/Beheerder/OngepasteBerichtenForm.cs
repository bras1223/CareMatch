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
    public partial class OngepasteBerichtenForm : Form
    {
        private Database database;

        public OngepasteBerichtenForm()
        {
            InitializeComponent();
            cmbKiesBerichten.Items.Add("gemarkeerde hulpvragen");
            cmbKiesBerichten.Items.Add("gemarkeerde beoordelingen");
            cmbKiesBerichten.Items.Add("verdachte berichten");

            database = new Database();
        }

        private void cmbKiesBerichten_SelectedValueChanged(object sender, EventArgs e)
        {
            string switchcase = cmbKiesBerichten.SelectedText;
            switch (switchcase)
            {
                case "gemarkeerde hulpvragen":
                    MessageBox.Show("gemarkeerde hulpvragen");

                    break;
                case "gemarkeerde beoordeling":
                    MessageBox.Show("gemarkeerde beoordeling");

                    break;
                case "verdachte berichten":
                    MessageBox.Show("verdachte berichten");

                    break;
                default:
                    MessageBox.Show("default");
                    break;
            }
        }
    }
}
