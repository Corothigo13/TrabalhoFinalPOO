using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AguaLuz1
{
    class PessoaJuridica:Cliente
    {
        public PessoaJuridica()
        { }
        protected string  cnpj, endereco;
        public void setCnpj(string cnpj)
        {
            this.cnpj = cnpj;
        }
        public string getCnpj()
        {
            return cnpj;
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
