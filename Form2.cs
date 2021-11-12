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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnsomar_Click(object sender, EventArgs e)
        {
            int valora = Convert.ToInt32(txtvalora.Text);
            int valorb = Convert.ToInt32(txtvalorb.Text);
            int soma = valora + valorb;
            lblResultado.Text = Convert.ToString(soma);
            txtvalora.Text = "";
            txtvalorb.Text = "";
        }

        private void btnsubtrair_Click(object sender, EventArgs e)
        {
            int valora = Convert.ToInt32(txtvalora.Text);
            int valorb = Convert.ToInt32(txtvalorb.Text);
            int subtrair = valora - valorb;
            lblResultado.Text = Convert.ToString(subtrair);
            txtvalora.Text = "";
            txtvalorb.Text = "";
        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            int valora = Convert.ToInt32(txtvalora.Text);
            int valorb = Convert.ToInt32(txtvalorb.Text);
            int multiplicar = valora * valorb;
            lblResultado.Text = Convert.ToString(multiplicar);
            txtvalora.Text = "";
            txtvalorb.Text = "";
        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            int valora = Convert.ToInt32(txtvalora.Text);
            int valorb = Convert.ToInt32(txtvalorb.Text);
            int dividir = valora / valorb;
            lblResultado.Text = Convert.ToString(dividir);
            txtvalora.Text = "";
            txtvalorb.Text = "";
        }
    }
}
