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
    public partial class MaiorValorAgua : Form
    {
        public MaiorValorAgua()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PfAgua pf = new PfAgua();
            string[] maiores=pf.Maiores("ContaAgua.txt", textBox1.Text).Split('|');//consumo,valor,mes
           MessageBox.Show("Maior consumo: " + maiores[0]+ " m³ \n Maior valor: R$ "+maiores[1]+"\n Mês: "+maiores[2], "Relatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
