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
    public partial class ValorMedioEnergia : Form
    {
        public ValorMedioEnergia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PfLuz pf = new PfLuz();
            double consumo = pf.ConsumoMedio("ContaLuz.txt", textBox1.Text);
            MessageBox.Show("Valor médio: R$ " + consumo, "Relatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
