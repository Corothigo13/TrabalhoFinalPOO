using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AguaLuz1
{
    public partial class ValorMedioAgua : Form
    {
        public ValorMedioAgua()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PfAgua pf = new PfAgua();
            double consumo = pf.ConsumoMedio("ContaAgua.txt", textBox1.Text);
            MessageBox.Show("Valor médio: R$ " + consumo, "Relatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
