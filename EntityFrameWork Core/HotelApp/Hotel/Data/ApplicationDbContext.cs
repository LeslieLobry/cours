using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelApp.Models;
using Microsoft.EntityFrameworkCore;

internal class ApplicationDbContext : DbContext
{
 
    public ApplicationDbContext() : base()
    {
    }
  
    public DbSet<Client> Clients { get; set; }
    public DbSet<Hotel> Hotels { get; set; }
    public DbSet<Reservation> Réservations { get; set; }
    public DbSet<Chambre> Chambres { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\HotelEfcore;Integrated Security=True;Encrypt=True");
    }

}