using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ResturantFinal.Models;

namespace ResturantFinal.Data
{
    public class ResturantFinalContext : DbContext
    {
        public ResturantFinalContext (DbContextOptions<ResturantFinalContext> options)
            : base(options)
        {
        }

        public DbSet<ResturantFinal.Models.Admin> Admin { get; set; } = default!;

        public DbSet<ResturantFinal.Models.consumption_report>? consumption_report { get; set; }

        public DbSet<ResturantFinal.Models.Invoice>? Invoice { get; set; }

        public DbSet<ResturantFinal.Models.Item>? Item { get; set; }

        public DbSet<ResturantFinal.Models.supplier>? supplier { get; set; }
    }
}
