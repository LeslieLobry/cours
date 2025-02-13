using System.Collections.Generic;
using Exercice4.Models;
using Microsoft.EntityFrameworkCore;

namespace Exercice4.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Marmoset> Marmosets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Data Source=(Localdb)\AspMarmosets;Integrated Security=True");
        }
    }
}
