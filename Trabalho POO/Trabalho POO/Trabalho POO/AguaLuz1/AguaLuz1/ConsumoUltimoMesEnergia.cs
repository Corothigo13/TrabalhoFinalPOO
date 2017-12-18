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
    public partial class ConsumoUltimoMesEnergia : Form
    {
        public ConsumoUltimoMesEnergia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PfLuz pf = new PfLuz();
            double consumo = pf.ConsumoUltimoMes("ContaLuz.txt", textBox1.Text);
            MessageBox.Show("Consumo do último mês: " + consumo + " KWh", "Relatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
