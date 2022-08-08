using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesMvcEntityFramework.Models
{
    public class SalesMvcEntityFrameworkContext : DbContext
    {
        public SalesMvcEntityFrameworkContext (DbContextOptions<SalesMvcEntityFrameworkContext> options)
            : base(options)
        {
        }

        public DbSet<Departament> Departament { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
