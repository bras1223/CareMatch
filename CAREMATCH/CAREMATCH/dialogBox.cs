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
    public partial class dialogBox : Form
    {
        public dialogBox(string message)
        {
            InitializeComponent();
            lblMessage.Text = message;
        }

        private void btnOKE_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void dialogBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
