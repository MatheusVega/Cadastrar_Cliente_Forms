using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecLineForms.Model
{
    public class Endereco
    {
        public int Codigo { get; set; }
        public String Rua { get; set; }
        public int Numero { get; set; }
        public String Bairro { get; set; }
        public int Cep { get; set; }
        public String Zona { get; set; }
        public String Cidade { get; set; }


        /// </Construtor>
        public Endereco()
        {

        }
        public Endereco(int codigo, string rua, int numero, string bairro, int cep, string zona, String cidade)
        {
            Codigo = codigo;
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cep = cep;
            Zona = zona;
            Cidade = cidade;
        }
    }
}
