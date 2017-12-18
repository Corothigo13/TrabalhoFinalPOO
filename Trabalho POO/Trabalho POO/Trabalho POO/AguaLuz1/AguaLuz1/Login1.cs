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
    public partial class Login1 : Form
    {
        public Login1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)//senha
        {
            textBox2.PasswordChar = '•';
            textBox2.MaxLength = 6;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//login(nome)
        {
            
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)//tipo de usuario
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login, senha, usuario, arquivo;
            bool verifica1, verifica2;
            login = textBox1.Text;
            senha = textBox2.Text;
            usuario = comboBox1.Text;
            Cliente c = new Cliente();
            if (usuario == "Administrador")
            {
                arquivo = "Administrador.txt";
            }
            else
            { arquivo = "Cliente.txt"; }
            verifica1 = c.VerificarUsuario(login, arquivo);
            verifica2 = c.VerificarSenha(senha, arquivo);
            if (verifica1 == true && verifica2 == true && comboBox2.Text == "Luz" && comboBox1.Text == "Cliente")
            {
                LuzCli l = new LuzCli();
                l.ShowDialog();
            }
            else if (verifica1 == true && verifica2 == true && comboBox2.Text == "Luz" && comboBox1.Text == "Administrador")
            {
                Luz l = new Luz();
                l.ShowDialog();
            }
            else if (verifica1 == true && verifica2 == true && comboBox2.Text == "Água" && comboBox1.Text == "Administrador")
            {
                Agua a = new Agua();
                a.ShowDialog();
            }
            else if (verifica1 == true && verifica2 == true && comboBox2.Text == "Água" && comboBox1.Text == "Cliente")
            {
                AguaCli a = new AguaCli();
                a.ShowDialog();
            }
            else if (verifica1 == false || verifica2 == false)
            {
                MessageBox.Show("Login ou senha Invalido!");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
