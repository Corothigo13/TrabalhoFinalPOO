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
    public partial class CadastroPJ_Energia : Form
    {
        public CadastroPJ_Energia()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//nome
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)//cnpj
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)//endereco
        {

        }

        private void CONSULTA1_Click(object sender, EventArgs e)
        {
            PjLuz pj = new PjLuz();
            pj.setNome(textBox1.Text);
            pj.setCnpj(textBox3.Text);
            pj.setEndereco(textBox4.Text);
            pj.SalvandoCadastro();
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
