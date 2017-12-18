using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace AguaLuz1
{
    class PfLuz : PessoaFisica, ILuz
    {
        private double leituraanterior, leituraatual, consumo, consumo1, conta;
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
        public PfLuz()
        { }
        public double CalcularConsumo()
        {
            double consumo = 0;
            consumo = leituraatual - leituraanterior;
            return consumo;
        }
        public double CalcularConta()
        {
            double conta = 0;
            conta = 0.46 * consumo;
            conta = conta + 13.25;
            if (consumo > 90)
            {
                conta = Math.Round(conta * 1.4285,2);
            }
            return conta;
        }
        public void LeituraAnt()
        {
            int a = 0;
            string[] vet = File.ReadAllLines("ContaLuz.txt");
            string[] auxiliar;
            for (int i = 0; i < vet.Length; i++)
            {
                
                auxiliar = vet[i].Split('|');
                try
                {
                    if (getCpf() == auxiliar[1])
                    {
                        setleituraanterior(Convert.ToDouble(auxiliar[4]));
                        a++;
                    }
                }
                catch
                {
                    setleituraanterior(0);

                }
               if(a==0)
                {
                    setleituraanterior(0);
                }
            }
        }
        public void SalvandoCadastro()
        {
            FileStream arq = new FileStream("CadastroPFLuz.txt", FileMode.Append);
            StreamWriter escreve = new StreamWriter(arq);
            escreve.WriteLine(getNome().ToUpper() + "|" + getCpf().ToUpper() + "|" + getEndereco().ToUpper());
            escreve.Close();
        }
        public void BuscarCliente()
        {
            string[] vet = File.ReadAllLines("CadastroPFLuz.txt");
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
        public void SalvandoContaLuz()
        {
            FileStream arq = new FileStream("ContaLuz.txt", FileMode.Append);
            StreamWriter escreve = new StreamWriter(arq);
            escreve.WriteLine(getNome().ToUpper() + "|" + getCpf().ToUpper() + "|" + getEndereco().ToUpper() + "|" + getleituraanterior() + "|" + getleituraatual() + "|" + getConsumo1() + "|" + getConta() + "|" + getMes() + "|" + getAno());
            escreve.Close();
        }
    }

}
