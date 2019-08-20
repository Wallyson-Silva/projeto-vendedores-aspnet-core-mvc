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

        public DbSet<SistemaWebMvcVendedores.Models.Department> Department { get; set; }
    }
}
