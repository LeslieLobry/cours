using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelApp.Enums;
using HotelApp.Models;
using Microsoft.EntityFrameworkCore;

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
                        AfficherReservationsClient();
                        break;
                    case "4":
                        CreerResa();

                        break;
                    case "5":
                        SupprimerResa();

                        break;
                    case "6":
                        ReservationT();

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
            Console.Write("numéro de téléphone du client:");
            Client.NumeroTel = Console.ReadLine();
            context.Clients.Add(Client);
            context.SaveChanges();
            Console.WriteLine("vous êtes parmi nous :)");
        }
        private static void AfficherClient()
        {
            using var context = new ApplicationDbContext();
            context.Clients.ToList().ForEach(c => Console.WriteLine($"{c.Id}---{c.Nom}----{c.Prenom}----{c.NumeroTel}"));
        }

        private static void AfficherReservationsClient()
        {
            using var context = new ApplicationDbContext();
            Console.Write("Entrez l'ID du client : ");
            int clientId = int.Parse(Console.ReadLine());
            var reservations = context.Reservations
                            .Where(r => r.ClientId == clientId)
                            .ToList();
            if (reservations.Count == 0)
            {
                Console.WriteLine("Aucune réservation trouvée pour ce client.");
            }
            foreach (var res in reservations)
            {
                Console.WriteLine($"Réservation {res.Id} - Statut : {res.StatutResa}");
                foreach (var chambre in res.Chambres)
                { Console.WriteLine($" Chambre {chambre.Numero} - {chambre.NbrLits} lits - {chambre.Tarif}€"); }
            }
        }
        private static void CreerResa()
        {
            using var context = new ApplicationDbContext();
            var reservation = new Reservation();
            Console.WriteLine("nouvelle réservation");
            Console.Write("votre numero client:");
            reservation.ClientId = int.Parse(Console.ReadLine());
            var client = context.Clients.Find(reservation.ClientId);
            if (client == null)
            {
                Console.WriteLine("vous n'êtes pas client");
                return;
            }
            Console.WriteLine("numéro de la chambre");
            int numeroChambre = int.Parse(Console.ReadLine());
            var chambre = context.Chambres.Find(numeroChambre);
            reservation.Client = client;
            reservation.StatutResa = StatutResa.Prevu;
            reservation.Chambres.Add(chambre);
            if (chambre == null)
            {
                Console.WriteLine("nous n'avons pas cette chambre");
            }
            if (chambre.StatutChambre != StatutChambre.Libre)
            {
                Console.WriteLine("la chambre est déjà réservée");
            }
            chambre.StatutChambre = StatutChambre.Occupe;
            context.Reservations.Add(reservation); context.SaveChanges();
            Console.WriteLine(" Réservation effectuée avec succès !");

        }
        private static void SupprimerResa()
        {
            using var context = new ApplicationDbContext();
            Console.WriteLine("supprimer une réservation");
            Console.WriteLine("Quelle réservation voulez-vous supprimer?");
            int choix = int.Parse(Console.ReadLine());
            var reservation = context.Reservations.Find(choix);
            if (reservation == null)
            {
                Console.WriteLine(" Réservation introuvable.");
            }
            reservation.StatutResa = StatutResa.Annule;
            foreach (var chambre in reservation.Chambres)
            {
                chambre.StatutChambre = StatutChambre.Libre;
            }
            context.SaveChanges(); Console.WriteLine(" Réservation annulée avec succès !");


        }
        private static void ReservationT()
        {
            using var context = new ApplicationDbContext();
        }
    }
}