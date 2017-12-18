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
    public partial class VariacaoConsumoDoisMesEnergia : Form
    {
        public int opc = 0;
        public VariacaoConsumoDoisMesEnergia(int op)
        {
            opc = op;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (opc == 1)
            {
                PfLuz pf = new PfLuz();
                double consumo = pf.VariacaoCons("ContaLuz.txt", textBox1.Text, comboBox4.Text, comboBox3.Text, comboBox1.Text, comboBox2.Text);
                MessageBox.Show("Variação do consumo entre os meses: " + consumo + " KwH", "Relatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                PfLuz pf = new PfLuz();
                double valor = pf.VariacaoVal("ContaLuz.txt", textBox1.Text, comboBox4.Text, comboBox3.Text, comboBox1.Text, comboBox2.Text);
                MessageBox.Show("Variação do consumo entre os meses: R$ " + valor, "Relatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }//valor medio energia , valor conta ultimo mes energia, maior valor energia, consumo ultimo mes energia.falta
    }
}
