using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace AguaLuz1
{
    class PjAgua : PessoaJuridica, IAgua
    {
        private double leituraanterior, leituraatual, consumo, conta,consumo1;
        private string mes, ano;
        public void setleituraanterior(double leituraant)
        {
            leituraanterior = leituraant;
        }
        public double getleituraanterior()
        {
            return leituraanterior;
        }
        public void setleituraatual(double leituraat)
        {
            leituraatual = leituraat;
        }
        public double getleituraatual()
        {
            return leituraatual;
        }
        public void setConsumo(double consumo)
        {
            this.consumo = consumo;
        }
        public double getConsumo()
        {
            return this.consumo;
        }
        public void setConsumo1(double consumo)
        {
            consumo1 = consumo;
        }
        public double getConsumo1()
        {
            return this.consumo1;
        }
        public void setMes(string mes)
        {
            this.mes = mes;
        }
        public string getMes()
        {
            return this.mes;
        }
        public void setAno(string ano)
        {
            this.ano = ano;
        }
        public string getAno()
        {
            return this.ano;
        }
        public void setConta(double conta)
        {
            this.conta = conta;
        }
        public double getConta()
        {
            return this.conta;
        }
        public PjAgua()
        { }
        public double CalcularConsumo()
        {
            double cons;
            cons = leituraatual - leituraanterior;
            return cons;
        }
        public void CalcularConta()
        {
            double agua = 0, esgoto = 0;
            if (consumo < 6)
            {
                conta = (25.79 + 12.90);
            }
            if (consumo >= 10)//faixa 6-10m³
            {
                agua = 4.299 * 10;
                esgoto = 2.149 * 10;
                conta = (agua + esgoto);
                consumo = consumo - 10;
            }
            if (consumo >= 30)//faixa 10-40m³
            {
                agua = 8.221 * 30;
                esgoto = 4.111 * 30;
                conta = conta + agua + esgoto;
                consumo = consumo - 30;
            }
            else if (consumo < 30)//faixa 10-40m³
            {
                agua = 8.221 * 30;
                esgoto = 4.111 * 30;
                conta = conta + agua + esgoto;
                consumo = consumo - consumo;
            }
            if (consumo >= 60)//faixa 40-100m³
            {
                agua = 8.288 * 60;
                esgoto = 4.144 * 60;
                conta = conta + agua + esgoto;
                consumo = consumo - 60;
            }
            else if (consumo < 5)//faixa 40-100m³
            {
                agua = 8.288 * 60;
                esgoto = 4.144 * 60;
                conta = conta + agua + esgoto;
                consumo = consumo - consumo;
            }

            if (consumo > 0)
            {
                agua = 8.329 * consumo;
                esgoto = 4.165 * consumo;
                conta = conta + agua + esgoto;
            }
            conta = Math.Round(conta * 1.03, 2);
        }
        public void SalvandoCadastro()
        {
            FileStream arq = new FileStream("CadastroPJAgua.txt", FileMode.Append);
            StreamWriter escreve = new StreamWriter(arq);
            escreve.WriteLine(getNome().ToUpper() + "|" + getCnpj().ToUpper() + "|" + getEndereco().ToUpper());
            escreve.Close();
        }
        public void LeituraAnt()
        {
            int a = 0; 
            string[] vet = File.ReadAllLines("ContaAgua.txt");
            string[] auxiliar;
            for (int i = 0; i < vet.Length; i++)
            {
                auxiliar = vet[i].Split('|');
                if (getCnpj() == auxiliar[1])
                {
                    setleituraanterior(Convert.ToDouble(auxiliar[4]));
                    a++;
                }
                else if(a==0)
                {
                    setleituraanterior(0);
                }
            }
        }
        public void BuscarCliente()
        {
            string[] vet = File.ReadAllLines("CadastroPJAgua.txt");//nome,cpf,endereco
            string[] auxiliar;
            for (int i = 0; i < vet.Length; i++)
            {
                auxiliar = vet[i].Split('|');
                if (cnpj == auxiliar[1])
                {
                    setNome(auxiliar[0]);
                    setEndereco(auxiliar[2]);
                }
            }
        }
        public void SalvandoContaAgua()
        {
            FileStream arq = new FileStream("ContaAgua.txt", FileMode.Append);
            StreamWriter escreve = new StreamWriter(arq);
            escreve.WriteLine(getNome().ToUpper() + "|" + getCnpj().ToUpper() + "|" + getEndereco().ToUpper() + "|" + getleituraanterior() + "|" + getleituraatual() + "|" + getConsumo1() + "|" + getConta() + "|" + getMes() + "|" + getAno());
            escreve.Close();
        }
    }

}
