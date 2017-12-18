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
    public partial class ConsumoUltimoMesAgua : Form
    {
        public ConsumoUltimoMesAgua()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PfAgua pf = new PfAgua();
            double consumo = pf.ConsumoUltimoMes("ContaAgua.txt", textBox1.Text);
            MessageBox.Show("Consumo do último mês: " + consumo + " m³", "Relatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConsumoUltimoMes_Load(object sender, EventArgs e)
        {

        }
    }
}
