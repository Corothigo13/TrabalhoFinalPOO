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
    public partial class VariacaoConsumoDoisMesAgua : Form
    {
       public int opc=0;
        public VariacaoConsumoDoisMesAgua(int op)
        {
            opc = op;
            InitializeComponent();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)//mes 1
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)//ano 1
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)// mes 2
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)//ano2
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)//cpf
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (opc == 1)
            {
                PfAgua pf = new PfAgua();
                double consumo = pf.VariacaoCons("ContaAgua.txt", textBox1.Text, comboBox4.Text, comboBox3.Text, comboBox1.Text, comboBox2.Text);
                MessageBox.Show("Variação do consumo entre os meses: " + consumo + " m³", "Relatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                PfAgua pf = new PfAgua();
                double valor = pf.VariacaoVal("ContaAgua.txt", textBox1.Text, comboBox4.Text, comboBox3.Text, comboBox1.Text, comboBox2.Text);
                MessageBox.Show("Variação do consumo entre os meses: R$ " + valor, "Relatório", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void VariacaoConsumoDoisMes_Load(object sender, EventArgs e)
        {

        }
    }
}
