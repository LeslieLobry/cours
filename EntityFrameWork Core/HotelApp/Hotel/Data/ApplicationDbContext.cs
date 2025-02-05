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
    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<Chambre> Chambres { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\HotelEfcore;Integrated Security=True;Encrypt=True");
    }

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.Entity<Chambre>().HasData(
    //        new Chambre() { Numero = 101,  Tarif = 80.50, NbrLits = 1 }
    //        //new Chambre() { Tarif = 120.00m, NbrLits = 2 },
    //        //new Chambre() { Tarif = 95.75m, NbrLits = 1 },
    //        //new Chambre() { Tarif = 150.00m, NbrLits = 3 },
    //        //new Chambre() { Tarif = 110.25m, NbrLits = 2 }
    //        );
    //}

}