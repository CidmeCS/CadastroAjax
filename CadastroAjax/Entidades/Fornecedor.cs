using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroAjax.Entidades
{
    class Fornecedor
    {
        public string Empresa { get; set; }
        public string Nome { get; set; }
        public string CPF_CNPJ { get; set; }
        public string RG { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataHora { get; set; }
        public StringBuilder Telefone { get; set; }
    }
}
