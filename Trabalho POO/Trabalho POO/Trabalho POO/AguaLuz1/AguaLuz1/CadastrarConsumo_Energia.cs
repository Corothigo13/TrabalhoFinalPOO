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
    public partial class CadastrarConsumo_Energia : Form
    {
        public CadastrarConsumo_Energia()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)//tipo de cliente
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)// cpf cnpj
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)// leitura
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)// mes
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)//ano
        {

        }

        private void CONSULTA1_Click(object sender, EventArgs e)
        {
            string tipoCli;
            tipoCli = comboBox3.Text;
            if (tipoCli == "PESSOA FÍSICA")
            {
                PfLuz pf = new PfLuz();
                pf.setCpf(textBox3.Text);
                pf.BuscarCliente();
                pf.setleituraatual(Convert.ToDouble(textBox1.Text));
                pf.setMes(comboBox1.Text);
                pf.setAno(comboBox2.Text);
                pf.LeituraAnt();
                pf.setConsumo(pf.CalcularConsumo());
                pf.setConsumo1(pf.getConsumo());
                pf.setConta(pf.CalcularConta());
                pf.SalvandoContaLuz();
                /*FazerOutraOperacao FO = new FazerOutraOperacao();
                FO.ShowDialog();*/
                Close();
            }
            else
            {
                PjLuz pj = new PjLuz();
                pj.setCnpj(textBox3.Text);
                pj.BuscarCliente();
                pj.setleituraatual(Convert.ToDouble(textBox1.Text));
                pj.setMes(comboBox1.Text);
                pj.setAno(comboBox2.Text);
                pj.LeituraAnt();
                pj.setConsumo(pj.CalcularConsumo());
                pj.setConsumo1(pj.getConsumo());
                pj.setConta(pj.CalcularConta());
                pj.SalvandoContaLuz();
                /*FazerOutraOperacao FO = new FazerOutraOperacao();
                FO.ShowDialog();*/
                Close();
            }
        }
    }
}
