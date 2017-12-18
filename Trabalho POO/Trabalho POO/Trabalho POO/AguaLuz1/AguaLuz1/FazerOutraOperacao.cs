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
    public partial class FazerOutraOperacao : Form
    {
        public FazerOutraOperacao()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int intIndex = Application.OpenForms.Count - 1; intIndex >= 0; intIndex--)
            {
                if (Application.OpenForms[intIndex] != this)
                    Application.OpenForms[intIndex].Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login1 F1 = new Login1();
            F1.ShowDialog();
        }
    }
}
