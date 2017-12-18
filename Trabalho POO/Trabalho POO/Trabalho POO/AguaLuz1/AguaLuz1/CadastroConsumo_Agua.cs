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
    public partial class CadastroConsumo_Agua : Form
    {
        public CadastroConsumo_Agua()
        {
            InitializeComponent();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)//mes
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)//cpf
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)//leitura
        {

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)//ano
        {

        }

        private void CONSULTA1_Click(object sender, EventArgs e)//botão
        {

            string tipoCli;
            tipoCli = comboBox3.Text;
            if(tipoCli== "PESSOA FÍSICA") 
            {
                PfAgua pf = new PfAgua();
                pf.setCpf(textBox3.Text);
                pf.BuscarCliente();
                pf.setleituraatual(Convert.ToDouble(textBox1.Text));
                pf.setMes(comboBox1.Text);
                pf.setAno(comboBox2.Text);
                pf.LeituraAnt();
                pf.setConsumo(pf.CalcularConsumo());
                pf.setConsumo1(pf.getConsumo());
                pf.CalcularConta();
                pf.SalvandoContaAgua();
                /*FazerOutraOperacao FO = new FazerOutraOperacao();
                FO.ShowDialog();*/
                Close();
            }
            else
            {
                PjAgua pj = new PjAgua();
                pj.setCnpj(textBox3.Text);
                pj.BuscarCliente();
                pj.setleituraatual(Convert.ToDouble(textBox1.Text));
                pj.setMes(comboBox1.Text);
                pj.setAno(comboBox2.Text);
                pj.LeituraAnt();
                pj.setConsumo(pj.CalcularConsumo());
                pj.setConsumo1(pj.getConsumo());
                pj.CalcularConta();
                pj.SalvandoContaAgua();
                /*FazerOutraOperacao FO = new FazerOutraOperacao();
                FO.ShowDialog();*/
                Close();
            }

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)// tipo de cliente
        {

        }
    }
}
