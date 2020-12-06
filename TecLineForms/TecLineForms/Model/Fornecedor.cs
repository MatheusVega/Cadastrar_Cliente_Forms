using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecLineForms.Model
{
    public class Fornecedor
    {
        public int Codigo { get; set; }
        public string CNPJ { get; set; }
        public string Nome { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Setor { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}
