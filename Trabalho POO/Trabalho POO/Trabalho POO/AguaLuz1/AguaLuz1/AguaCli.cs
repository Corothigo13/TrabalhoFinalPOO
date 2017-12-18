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
    public partial class AguaCli : Form
    {
        public AguaCli()
        {
            InitializeComponent();
        }

        private void CONSULTA1_Click(object sender, EventArgs e)//consulta
        {
            ConsumoUltimoMesAgua c = new ConsumoUltimoMesAgua();
            c.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ValorContaUltimoMesAgua v = new ValorContaUltimoMesAgua();
            v.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)//variação consumo
        {
            VariacaoConsumoDoisMesAgua v = new VariacaoConsumoDoisMesAgua(1);
            v.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)//variação valor
        {
            VariacaoConsumoDoisMesAgua v = new VariacaoConsumoDoisMesAgua(2);
            v.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)//valor médio
        {
            ValorMedioAgua v = new ValorMedioAgua();
            v.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MaiorValorAgua m = new MaiorValorAgua();
            m.ShowDialog();

        }
    }
}
