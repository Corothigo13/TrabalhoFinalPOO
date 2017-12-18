using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AguaLuz1
{
    class Cliente
    {
        private string nome, senha;
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return nome;
        }
        public void setSenha(string senha)
        {
            this.senha = senha;
        }
        public string getSenha()
        {
            return senha;
        }

        public Cliente()
        { }
        public bool VerificarUsuario(string usuario, string arquivo)
        {
            bool verificar = false;
            string usuarioArq;
            string[] linhas = File.ReadAllLines(arquivo);
            for (int i = 0; i < linhas.Length; i++)
            {
                string[] auxiliar;
                auxiliar = linhas[i].Split('|');
                usuarioArq = auxiliar[0];
                if (usuarioArq == usuario)
                {
                    verificar = true;
                }
            }
            return verificar;
        }
        public bool VerificarSenha(string senha, string arquivo)
        {
            bool verificar = false;
            string senhaArq;
            string[] linhas = File.ReadAllLines(arquivo);
            for (int i = 0; i < linhas.Length; i++)
            {
                string[] auxiliar;
                auxiliar = linhas[i].Split('|');
                senhaArq = auxiliar[1];
                if (senhaArq == senha)
                {
                    verificar = true;
                }
            }
            return verificar;
        }
        public double ConsumoUltimoMes(string arquivo, string cpf)
        {
            double cons = 0;
            int mes, ano;
            mes = DateTime.Now.Month - 1;
            ano = DateTime.Now.Year;
            if (mes == 0)
            {
                mes = 12;
                ano = ano - 1;
            }
            string[] array = File.ReadAllLines(arquivo);
            string[] vet;
            for (int i = 0; i < array.Length; i++)//NOME|CPF|ENDERECO|LEITURAANTERIOR|LEITURAATUAL|CONSUMO|VALOR|MES|ANO
            {
                vet = array[i].Split('|');
                if (vet[1] == cpf && Convert.ToInt32(vet[7]) == mes && Convert.ToInt32(vet[8]) == ano)
                {
                    cons = Convert.ToDouble(vet[5]);
                }
            }
            return cons;
        }
        public double ValorUltimoMes(string arquivo, string cpf)
        {
            double cons = 0;
            int mes, ano;
            mes = DateTime.Now.Month - 1;
            ano = DateTime.Now.Year;
            if (mes == 0)
            {
                mes = 12;
                ano = ano - 1;
            }
            string[] array = File.ReadAllLines(arquivo);
            string[] vet;
            for (int i = 0; i < array.Length; i++)//NOME|CPF|ENDERECO|LEITURAANTERIOR|LEITURAATUAL|CONSUMO|VALOR|MES|ANO
            {
                vet = array[i].Split('|');
                if (vet[1] == cpf && Convert.ToInt32(vet[7]) == mes && Convert.ToInt32(vet[8]) == ano)
                {
                    cons = Convert.ToDouble(vet[6]);
                }
            }
            return cons;
        }
        public double VariacaoCons(string arquivo, string cpf, string mes, string ano, string mes1, string ano1)
        {
            double cons = 0, cons1 = 0, cons2 = 0;
            string[] array = File.ReadAllLines(arquivo);
            string[] vet;
            for (int i = 0; i < array.Length; i++)//NOME|CPF|ENDERECO|LEITURAANTERIOR|LEITURAATUAL|CONSUMO|VALOR|MES|ANO
            {
                vet = array[i].Split('|');
                if (vet[1] == cpf && (vet[7]) == mes && (vet[8]) == ano)
                {
                    cons1 = Convert.ToDouble(vet[5]);
                }
                if (vet[1] == cpf && (vet[7]) == mes1 && (vet[8]) == ano1)
                {
                    cons2 = Convert.ToDouble(vet[5]);
                }
            }
            if (cons1 > cons2)
            {
                cons = cons1 - cons2;
            }
            else
            {
                cons = cons2 - cons1;
            }
            return cons;
        }
        public double VariacaoVal(string arquivo, string cpf, string mes, string ano, string mes1, string ano1)
        {
            double cons = 0, cons1 = 0, cons2 = 0;
            string[] array = File.ReadAllLines(arquivo);
            string[] vet;
            for (int i = 0; i < array.Length; i++)//NOME|CPF|ENDERECO|LEITURAANTERIOR|LEITURAATUAL|CONSUMO|VALOR|MES|ANO
            {
                vet = array[i].Split('|');
                if (vet[1] == cpf && (vet[7]) == mes && (vet[8]) == ano)
                {
                    cons1 = Convert.ToDouble(vet[6]);
                }
                if (vet[1] == cpf && (vet[7]) == mes1 && (vet[8]) == ano1)
                {
                    cons2 = Convert.ToDouble(vet[6]);
                }
            }
            if (cons1 > cons2)
            {
                cons = cons1 - cons2;
            }
            else
            {
                cons = cons2 - cons1;
            }
            return cons;
        }
        public double ConsumoMedio(string arquivo, string cpf)
        {
            double cons = 0, a = 0;
            string[] array = File.ReadAllLines(arquivo);
            string[] vet;
            for (int i = 0; i < array.Length; i++)//NOME|CPF|ENDERECO|LEITURAANTERIOR|LEITURAATUAL|CONSUMO|VALOR|MES|ANO
            {
                vet = array[i].Split('|');
                if (vet[1] == cpf)
                {
                    cons = cons + Convert.ToDouble(vet[5]);
                    a++;
                }

            }
            cons = cons / a;
            return cons;
        }
        public string Maiores(string arquivo, string cpf)
        {
            double cons = 0, valor = 0, mes = 0;
            string[] array = File.ReadAllLines(arquivo);
            string[] vet;
            for (int i = 0; i < array.Length; i++)//NOME|CPF|ENDERECO|LEITURAANTERIOR|LEITURAATUAL|CONSUMO|VALOR|MES|ANO
            {
                vet = array[i].Split('|');
                if (vet[1] == cpf)
                {
                    if (cons < Convert.ToDouble(vet[5]))
                    {
                        cons = Convert.ToDouble(vet[5]);
                        valor = Convert.ToDouble(vet[6]);
                        mes = Convert.ToDouble(vet[7]);
                    }
                }

            }
            return cons+"|"+valor+"|"+mes;
        }
    }
}
