using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecLineForms.Model;

namespace TecLineForms.Mapping 
{
    public class ClienteMAP : EntityTypeConfiguration<Cliente>
    {
        public ClienteMAP()
        {
            ToTable("TB_CLIENTE");

            HasKey(x => x.Codigo);

            Property(x => x.Codigo).HasColumnName("CLI_CODIGO");
            Property(x => x.CNPJ).HasColumnName("CLI_CNPJ");
            Property(x => x.Nome).HasColumnName("CLI_NOME");
            Property(x => x.DataCadastro).HasColumnName("CLI_DATACADASTRO");
            Property(x => x.Telefone).HasColumnName("CLI_TELEFONE");
            Property(x => x.Comentario).HasColumnName("CLI_COMENTARIO");
            Property(x => x.DataComentario).HasColumnName("CLI_DATACOMENTARIO");


        }
    }
}
