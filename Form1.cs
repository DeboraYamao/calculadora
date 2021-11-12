using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tds
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            lblmostra.Text = txtfrase.Text;
            txtfrase.Text = "";
        }

        private void btncalculadora_Click(object sender, EventArgs e)
        {
            Form2 calc = new Form2();
            calc.Show();
        }
    }
}
