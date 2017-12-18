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
    public partial class Luz : Form
    {
        public Luz()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void CADAST_USU1_Click(object sender, EventArgs e)
        {
            CadastroPF_Energia cpfE = new CadastroPF_Energia();
            cpfE.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroPJ_Energia cpjE = new CadastroPJ_Energia();
            cpjE.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void CADAST_CON_Click(object sender, EventArgs e)
        {

        }

        private void CADAST_CON1_Click(object sender, EventArgs e)
        {
            CadastrarConsumo_Energia ccE = new CadastrarConsumo_Energia();
            ccE.ShowDialog();
        }

        private void CONSULTA_Click(object sender, EventArgs e)
        {

        }

        private void CONSULTA1_Click(object sender, EventArgs e)
        {
            //Consulta_Energia cE = new Consulta_Energia();
           // cE.ShowDialog();
        }

        private void CADAST_USU_Click(object sender, EventArgs e)
        {

        }
    }
}
