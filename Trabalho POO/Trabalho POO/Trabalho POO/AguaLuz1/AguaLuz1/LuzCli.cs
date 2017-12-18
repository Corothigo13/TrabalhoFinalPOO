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
    public partial class LuzCli : Form
    {
        public LuzCli()
        {
            InitializeComponent();
        }

        private void LuzCli_Load(object sender, EventArgs e)
        {

        }

        private void CONSULTA1_Click(object sender, EventArgs e) //Consultar consumo ultimo mês
        {
            ConsumoUltimoMesEnergia CUME = new ConsumoUltimoMesEnergia();
            CUME.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ValorContaUltimoMesEnergia VCUME = new ValorContaUltimoMesEnergia();
            VCUME.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VariacaoConsumoDoisMesEnergia VCDME = new VariacaoConsumoDoisMesEnergia(2);
            VCDME.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VariacaoConsumoDoisMesEnergia VCDME = new VariacaoConsumoDoisMesEnergia(1);
            VCDME.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ValorMedioEnergia VME = new ValorMedioEnergia();
            VME.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MaiorValorEnergia MVE = new MaiorValorEnergia();
            MVE.ShowDialog();
        }
    }
}
