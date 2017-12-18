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
    public partial class Agua : Form
    {
        public Agua()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroPJ_Agua cpjA = new CadastroPJ_Agua();
            cpjA.ShowDialog();
        }

        private void CONSULTA1_Click(object sender, EventArgs e)
        {
            //Consultar_Agua ca = new Consultar_Agua();
            //ca.ShowDialog();
        }

        private void CADAST_CON1_Click(object sender, EventArgs e)
        {
            CadastroConsumo_Agua ccA = new CadastroConsumo_Agua();
            ccA.ShowDialog();
        }

        private void CADAST_USU1_Click(object sender, EventArgs e)
        {
            CadastroPF_Agua cpfA = new CadastroPF_Agua();
            cpfA.ShowDialog();
        }

        private void CONSULTA_Click(object sender, EventArgs e)
        {

        }

        private void CADAST_CON_Click(object sender, EventArgs e)
        {

        }

        private void CADAST_USU_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
