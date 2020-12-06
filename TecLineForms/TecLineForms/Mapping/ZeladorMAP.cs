using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using TecLineForms.Model;

namespace TecLineForms.Mapping
{
    public class ZeladorMAP : EntityTypeConfiguration<Zelador>
    {
        public ZeladorMAP()
        {
            ToTable("TB_ZELADOR");

            HasKey(x => x.Codigo);

            Property(x => x.Codigo).HasColumnName("ZLD_CODIGO");
            Property(x => x.Codigo).HasColumnName("ZLD_NOME");
            Property(x => x.Codigo).HasColumnName("ZLD_TELEFONE");
            Property(x => x.Codigo).HasColumnName("ZLD_EMAIL");
        }
    }
}
