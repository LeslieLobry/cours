using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Entity.Data
{
    internal class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(): base()
        {

        }
        public DbSet<Livre>Livres{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\EFCore;Integrated Security=True");
        }

    }
}
