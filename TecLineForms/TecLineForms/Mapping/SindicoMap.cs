using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using TecLineForms.Model;

namespace TecLineForms.Mapping
{
    public class SindicoMAP : EntityTypeConfiguration<Sindico>
    {
        public SindicoMAP()
        {
            ToTable("TB_SINDICO");

            HasKey(x => x.Codigo);

            Property(x => x.Codigo).HasColumnName("SIN_CODIGO");
            Property(x => x.Codigo).HasColumnName("SIN_NOME");
            Property(x => x.Codigo).HasColumnName("SIN_TELEFONE");
            Property(x => x.Codigo).HasColumnName("SIN_EMAIL");

        }
    }
}
