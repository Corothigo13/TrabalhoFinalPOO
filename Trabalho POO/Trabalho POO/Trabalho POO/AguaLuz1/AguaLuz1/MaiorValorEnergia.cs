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
    public partial class MaiorValorEnergia : Form
    {
        public MaiorValorEnergia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PfLuz pf = new PfLuz();
            string[] maiores = pf.Maiores("ContaLuz.txt", textBox1.Text).Split('|');//consumo,valor,mes
            MessageBox.Show("Maior consumo: " + maiores[0] + " KwH \n Maior valor: R$ " + maiores[1] + "\n Mês: " + maiores[2], "Relatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
