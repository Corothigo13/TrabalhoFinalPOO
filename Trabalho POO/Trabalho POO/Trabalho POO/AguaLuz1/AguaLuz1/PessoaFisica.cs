using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AguaLuz1
{
    class PessoaFisica:Cliente
    {
        public PessoaFisica()
        { }

        protected string  cpf, endereco;

        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }
        public string getCpf()
        {
            return cpf;
        }
        public void setEndereco(string endereco)
        {
            this.endereco = endereco;
        }
        public string getEndereco()
        {
            return endereco;
        }
}
}
