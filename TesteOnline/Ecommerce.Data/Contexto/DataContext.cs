using Ecommerce.core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Data.Contexto
{
    public class DataContext : DbContext

    {
        public DataContext() : base("ConnectionString")
        {

        }
        public DbSet<Mercadoria> Mercadoria { get; set; }
        public DbSet<Login> Login { get; set; }
    }
}
