using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelApp.Models;

namespace HotelApp.Classes
{
    internal class Ihm
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
                        Creer();
                        break;
                    case "2":
                        AfficherClient();
                        break;
                    case "3":
                        
                        break;
                    case "4":
                       
                        break;
                    case "5":
                        
                        break;
                        case "6":

                        break;
                    case "0":
                        Console.WriteLine("vous quittez l'application");
                        return;
                };
            }
        }
        private static void AfficherMenu()
        {
            Console.WriteLine("Menu Principal \n " +
                "1. Ajouter un client\n" +
                "2. Afficher la liste des clients\n" +
                "3. Afficher les réservations d'un client\n" +
                "4. Ajouter une réservation\n" +
                "5. Annuler une réservation\n" +
                "6. afficher les réservations\n" +
                "0. Quitter");
        }
        private static void Creer()
        {
            using var context = new ApplicationDbContext();

            var Client = new Client();

            Console.Write("nom du client :");
            Client.Nom = Console.ReadLine();
            Console.Write("prénom du client:");
            Client.Prenom = Console.ReadLine();
            Console.Write("numéro de téléphone du client");
            Client.NumeroTel = Console.ReadLine();
            context.Clients.Add(Client);
            context.SaveChanges();
        }
        private static void AfficherClient()
        {
            using var context = new ApplicationDbContext();
            context.Clients.ToList().ForEach(c => Console.WriteLine($"{c.Id}---{c.Nom}----{c.Prenom}----{c.NumeroTel}"));
        }
        private static void AfficherRservationClient()
        {
            using var context = new ApplicationDbContext();
        }
        private static void CreerResa()
        {
            using var context = new ApplicationDbContext();
            var Reservation = new Reservation();
            Console.WriteLine("nouvelle réservation");
            Console.Write("votre numero client:");
            Reservation.ClientId = int.Parse(Console.ReadLine());
            Console.WriteLine("numéro de la chambre"); 
            Reservation.Chambres.Numéro = int.Parse( Console.ReadLine());
            //Console.Write("prénom du client:");
            //Client.Prenom = Console.ReadLine();
            //Console.Write("numéro de téléphone du client");
            //Client.NumeroTel = Console.ReadLine();
            //context.Clients.Add(Client);
            //context.SaveChanges();
        }
    }
}
