﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecLineForms.Model
{
    public class Cliente
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public string DataCadastro { get; set; }
        public string Telefone { get; set; }
        public string Comentario { get; set; }
        public string DataComentario { get; set; }
    }
}
