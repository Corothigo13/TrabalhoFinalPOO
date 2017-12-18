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
    public partial class CadastroPJ_Agua : Form
    {
        public CadastroPJ_Agua()
        {
            InitializeComponent();
        }

        private void CONSULTA1_Click(object sender, EventArgs e)
        {
            PjAgua pj = new PjAgua();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
