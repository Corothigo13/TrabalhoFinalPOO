using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AguaLuz1
{
    public partial class CadastroPF_Energia : Form
    {
        public CadastroPF_Energia()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//nome
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)//cpf
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)//endereco
        {

        }

        private void CONSULTA1_Click(object sender, EventArgs e)
        {
            PfLuz pf = new PfLuz();
            pf.setNome(textBox1.Text);
            pf.setCpf(textBox3.Text);
            pf.setEndereco(textBox4.Text);
            pf.SalvandoCadastro();
            FileStream arq = new FileStream("Cliente.txt", FileMode.Append);
            StreamWriter escreve = new StreamWriter(arq);
            escreve.Write(textBox1.Text + "|" + textBox2.Text + "\n");
            escreve.Close();
            /*FazerOutraOperacao FO = new FazerOutraOperacao();
            FO.ShowDialog();*/
            Close();
        }
    }
}
