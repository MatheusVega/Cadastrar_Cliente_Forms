using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecLineForms.Model
{
    public class Sindico
    {
        public int Codigo { get; set; }
        public String Nome { get; set; }
        public int Telefone { get; set; }
        public String Email { get; set; }



        /// </Construtor>
        public Sindico()
        {
        }
        public Sindico(int id, String nome)
        {
            Codigo = id;
            Nome = nome;
        }
        public Sindico(int id, String nome, int telefone, String email) : this(id, nome)
        {
            Telefone = telefone;
            Email = email;
        }
    }
}
