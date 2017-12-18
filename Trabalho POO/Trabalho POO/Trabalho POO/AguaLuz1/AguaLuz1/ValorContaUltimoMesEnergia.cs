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
    public partial class ValorContaUltimoMesEnergia : Form
    {
        public ValorContaUltimoMesEnergia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PfLuz pf = new PfLuz();
            double consumo = pf.ValorUltimoMes("ContaLuz.txt", textBox1.Text);
            MessageBox.Show("Valor do último mês: R$ " + consumo, "Relatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
