using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AguaLuz1
{
    class PfAgua : PessoaFisica, IAgua
    {
        private double leituraanterior, leituraatual,consumo, consumo1,conta;
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
        public PfAgua()
        { }
        public double CalcularConsumo()
        {
            double cons;
            cons = leituraatual - leituraanterior;
            return cons;
        }
        public void CalcularConta()
        {
            double  agua = 0, esgoto = 0;
            if (consumo < 6)
            {
                conta = (10.08 + 5.05);
            }
            if (consumo >= 10)//faixa 6-10m³
            {
                agua = 2.241 * 10;
                esgoto = 1.122 * 10;
                conta = (agua + esgoto);
                consumo = consumo - 10;
            }
            if (consumo >= 5)//faixa 10-15m³
            {
                agua = 5.447 * 5;
                esgoto = 2.724 * 5;
                conta = conta + agua + esgoto;
                consumo = consumo - 5;
            }
            else if (consumo < 5)//faixa 10-15m³
            {
                agua = 5.447 * consumo;
                esgoto = 2.724 * consumo;
                conta = conta + agua + esgoto;
                consumo = consumo - consumo;
            }
            if (consumo >= 5)//faixa 15-20m³
            {
                agua = 5.461 * 5;
                esgoto = 2.731 * 5;
                conta = conta + agua + esgoto;
                consumo = consumo - 5;
            }
            else if (consumo < 5)//faixa 15-20m³
            {
                agua = 5.461 * consumo;
                esgoto = 2.731 * consumo;
                conta = conta + agua + esgoto;
                consumo = consumo - consumo;
            }
            if (consumo >= 20)//faixa 20-40m³
            {
                agua = 5.487 * 20;
                esgoto = 2.744 * 20;
                conta = conta + agua + esgoto;
                consumo = consumo - 5;
            }
            else if (consumo < 20)//faixa 20-40m³
            {
                agua = 5.487 * consumo;
                esgoto = 2.744 * consumo;
                conta = conta + agua + esgoto;
                consumo = consumo - 20;
            }
            if (consumo > 0)
            {
                agua = 10.066 * consumo;
                esgoto = 5.035 * consumo;
                conta = conta + agua + esgoto;
            }
            conta = Math.Round(conta * 1.03,2);
            
        }
        public  void SalvandoCadastro()
        {
            FileStream arq = new FileStream("CadastroPFAgua.txt", FileMode.Append);
            StreamWriter escreve = new StreamWriter(arq);
            escreve.WriteLine(getNome().ToUpper() + "|" + getCpf().ToUpper() + "|" + getEndereco().ToUpper());
            escreve.Close();
        }
        public void LeituraAnt()
        {
            int a = 0;
            string[] vet = File.ReadAllLines("ContaAgua.txt");
            string[] auxiliar;
            for(int i=0;i<vet.Length;i++)
            {
                auxiliar=vet[i].Split('|');
                if(getCpf()==auxiliar[1])
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
            string[] vet = File.ReadAllLines("CadastroPFAgua.txt");//nome,cpf,endereco
            string[] auxiliar;
            for (int i = 0; i < vet.Length; i++)
            {
                auxiliar = vet[i].Split('|');
                if (cpf == auxiliar[1])
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
            escreve.WriteLine(getNome().ToUpper() + "|" + getCpf().ToUpper() + "|" + getEndereco().ToUpper()+"|"+getleituraanterior()+"|"+getleituraatual()+"|"+getConsumo1()+"|"+getConta()+"|"+getMes()+"|"+getAno());
            escreve.Close();
        }
    }
}
