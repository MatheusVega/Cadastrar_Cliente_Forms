using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecLineForms.Mapping;

namespace TecLineForms.DAL
{
    public class TecLineContext : DbContext
    {
        public TecLineContext() : base("Data Source=.;Initial Catalog=TecLine_Local;Integrated Security=True")
        {
            this.Configuration.LazyLoadingEnabled = true;
        }

        public DbSet<CadastrarCliente> TB_CLIENTE { get; set;}
        public DbSet<CadastrarCliente> TB_ENDERECO { get; set; }
        public DbSet<CadastrarCliente> TB_SINDICO { get; set; }
        public DbSet<CadastrarCliente> TB_ZELADOR { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ClienteMAP());

        }
    }


    
}
