using System;
using Microsoft.EntityFrameworkCore;

internal class ApplicationDbContext : DbContext
{
    // Dans une app qui n'utilise pas d'injection de dépendances, on utilisera ce constructeur
    public ApplicationDbContext() : base()
    {
    }

    // les propriétés de types DbSet<Entité> permettent de définir les tables que nous allons utiliser
    public DbSet<Personnage> Personnages { get; set; }

    // Méthode appelée lors de la configuration d'EFCore à notre application
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Ici on utilise une méthode de optionsBuilder pour lui spécifier que nous allons utiliser une base de données SqlServer avec la chaine de connexion
        optionsBuilder.UseSqlServer(@"Data Source=(localdb)\TpEntity;Integrated Security=True");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Personnage>().HasData(new Personnage() { Id = 1, Pseudo = "the boss", PointdsDeVie = 120, Armure = 150, Degats = 15, DateCreation = DateTime.Now, NombrePersonnesTues = 0 });

    }
}
