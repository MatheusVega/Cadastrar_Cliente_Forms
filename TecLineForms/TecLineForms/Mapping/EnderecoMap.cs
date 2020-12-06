using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecLineForms.Model;

namespace TecLineForms.Mapping
{
    public class EnderecoMAP : EntityTypeConfiguration<Endereco>
    {
        public EnderecoMAP()
        {
            ToTable("TB_ENDERECO");

            HasKey(x => x.Codigo);

            Property(x => x.Codigo).HasColumnName("END_CODIGO");
            Property(x => x.Rua).HasColumnName("END_RUA");
            Property(x => x.Numero).HasColumnName("END_NUMERO");
            Property(x => x.Bairro).HasColumnName("END_BAIRRO");
            Property(x => x.Cep).HasColumnName("END_CEP");
            Property(x => x.Zona).HasColumnName("END_ZONA");
        }
    }
}
