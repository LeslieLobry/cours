using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp.Classes;


internal class IHM
{

    public static void Start()
    {
        using var context = new ApplicationDbContext();
        while (true)
        {
            AfficherMenu();
            Console.Write("votre choix:");
            string? choix = Console.ReadLine();
            switch (choix)
            {
                case "1":
                    CreerPerso();
                    break;
                case "2":
                    MettreAjour();
                    break;
                case "3":
                    Afficher();
                    break;
                case "4":
                    AfficherPersonnagesAvecPVSuperieurs();
                    break;
                case "5":
                    Taper();
                    break;
                case "0":
                    Console.WriteLine("vous quittez l'application");
                    return;
            };
        }
    }
    private static void AfficherMenu()
    {
        Console.WriteLine("Que voulez faire ?\n " +
            "1. Créer un personnage\n" +
            "2. Mettre à jour un personnage\n" +
            "3. Afficher tous les personnages\n" +
            "4. Afficher les personnages ayant des PVS\n" +
            "5. Taper\n" +
            "0. Quitter");
    }
    private static void CreerPerso()
    {
        using var context = new ApplicationDbContext();

        var Personnage = new Personnage();

        Console.Write("votre pseudo:");
        Personnage.Pseudo = Console.ReadLine();
        Console.Write("PointdsDeVie:");
        Personnage.PointdsDeVie = int.Parse(Console.ReadLine());
        Console.Write("Dégats");
        Personnage.Degats = int.Parse(Console.ReadLine());
        Console.Write("armure");
        Personnage.Armure = int.Parse(Console.ReadLine());
        Console.Write("nbr de kill");
        Personnage.NombrePersonnesTues = int.Parse(Console.ReadLine());
        context.Personnages.Add(Personnage);
        context.SaveChanges();
    }
    private static void Afficher()
    {
        using var context = new ApplicationDbContext();
        context.Personnages.ToList().ForEach(p => Console.WriteLine(p.Pseudo, p.Id, p.NombrePersonnesTues, p.DateCreation, p.PointdsDeVie, p.Armure));
    }
    private static void MettreAjour()
    {
        using var context = new ApplicationDbContext();
        Console.Write("Entrez le pseudo du personnage à mettre à jour: ");
        string? pseudo = Console.ReadLine();
        var personnage = context.Personnages.FirstOrDefault(p => p.Pseudo == pseudo);
        if (personnage == null) { Console.WriteLine("Personnage introuvable."); return; }
        Console.Write("Nouveau pseudo : ");
        string? nouveauPseudo = Console.ReadLine();
        Console.Write("Nouveaux points de vie : ");
        if (int.TryParse(Console.ReadLine(), out int newPV))
        { personnage.PointdsDeVie = newPV; }
        Console.Write("Nouvelle armure : ");
        if (int.TryParse(Console.ReadLine(), out int newArmure))
        { personnage.Armure = newArmure; }
        Console.Write("Nouveaux dégâts : ");
        if (int.TryParse(Console.ReadLine(), out int newDegats))
        { personnage.Degats = newDegats; }
        context.SaveChanges(); Console.WriteLine("Personnage mis à jour avec succès !");
    }

    private static void AfficherPersonnagesAvecPVSuperieurs()
    {
        using var context = new ApplicationDbContext();
        var moyenne = context.Personnages.Average(p => p.PointdsDeVie + p.Armure);
        var personnages = context.Personnages.Where(p => (p.PointdsDeVie + p.Armure) > moyenne).ToList();
        if (personnages.Count == 0) { Console.WriteLine("Aucun personnage n'a des PV + Armure supérieurs à la moyenne."); return; }
        foreach (var p in personnages) { Console.WriteLine($"Pseudo: {p.Pseudo} | PV + Armure: {p.PointdsDeVie + p.Armure}"); }
    }

    private static void Taper()
    {
        using var context = new ApplicationDbContext();
        string? combatant1;
        string? combatant2;
        Personnage? attaquant1 = null;
        Personnage? attaquant2 = null;
        while (attaquant1 == null)
        {
            Console.Write("Entrez le pseudo du 1er personnage à faire combattre: ");
            combatant1 = Console.ReadLine();
            attaquant1 = context.Personnages.FirstOrDefault(p => p.Pseudo == combatant1);

            if (attaquant1 == null)
            {
                Console.WriteLine("Personnage introuvable, veuillez réessayer.");
            }
        }
        while (attaquant2 == null)
        {
            Console.Write("Entrez le pseudo du 2eme personnage à faire combattre: ");
            combatant2 = Console.ReadLine();
            attaquant2 = context.Personnages.FirstOrDefault(p => p.Pseudo == combatant2);

            if (attaquant1 == null)
            {
                Console.WriteLine("Personnage introuvable, veuillez réessayer.");
            }
            if (attaquant2 == attaquant1)
            {
                Console.WriteLine("vous ne pouvez pas le faire combattre contre lui même");
                Console.Write("Entrez le pseudo du 2eme personnage à faire combattre: ");
                combatant2 = Console.ReadLine();
                attaquant2 = context.Personnages.FirstOrDefault(p => p.Pseudo == combatant2);
            }
        }
        Console.WriteLine($"combat entre {attaquant1.Pseudo} et {attaquant2.Pseudo}");
    }
}

