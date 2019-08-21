using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SistemaWebMvcVendedores.Models
{
    public class SistemaWebMvcVendedoresContext : DbContext
    {
        public SistemaWebMvcVendedoresContext (DbContextOptions<SistemaWebMvcVendedoresContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SallesRecord> SallesRecord { get; set; }
        public object SalesRecord { get; internal set; }
    }
}
