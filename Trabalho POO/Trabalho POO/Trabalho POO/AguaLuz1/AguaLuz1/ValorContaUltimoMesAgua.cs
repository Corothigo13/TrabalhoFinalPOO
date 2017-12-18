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
    public partial class ValorContaUltimoMesAgua : Form
    {
        public ValorContaUltimoMesAgua()
        {
            InitializeComponent();
        }

        private void ValorContaUltimoMes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PfAgua pf = new PfAgua();
            double consumo = pf.ValorUltimoMes("ContaAgua.txt", textBox1.Text);
            MessageBox.Show("Valor do último mês: R$ " + consumo , "Relatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
