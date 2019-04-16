using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace sistemaAspCore.Models
{
    public class sistemaAspCoreContext : DbContext
    {
        public sistemaAspCoreContext (DbContextOptions<sistemaAspCoreContext> options)
            : base(options)
        {
        }

        public DbSet<sistemaAspCore.Models.Categoria> Categoria { get; set; }
    }
}
