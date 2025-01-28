using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Exo04
{
    internal static class IHM
    {
        private static int _tailleEntreprise = 20;
        private static List<Salarie> _salaries = new List<Salarie>()
     {
         new Salarie(),
         new Commercial(0, 0),
     };

        public static void Start()


        {
            string? choix;
            Console.Write("Gestion des employés:");
            Console.WriteLine(@"
                                1. Ajouter un employé
                                2. Afficher le salaire des employés
                                3. Rechercher un employé
                                0. Quitter");
            do
            {
                Console.Write("Faites votre choix :");
                choix = Console.ReadLine();


               
                switch (choix)
                {
                    case "0": break;

                    case "1":
                        {
                            if (_salaries.Count == 20)
                            {
                                Console.WriteLine("L'entreprise est complète !");
                                break;
                            }
                            IHM.AjouterEmployé();
                        }


                        break;
                    case "2":
                        Console.WriteLine("Afficher le salaire des salarié");

                        break;
                    case "3":
                        Console.WriteLine("rechercher un employé");
                        IHM.RechercherEmploye();
                        break;
                        default:
                        break;
                }
            }
            while (default);
        }

        public static void AjouterEmployé()
        {

            string? choix2;
            do
            {
                Console.Write("--- Ajouter un employé ---- :");
                Console.WriteLine(@"
                                                1-- Salarié
                                                2-- Commerciale
                                                0-- Retour");
                Console.Write("Entrez votre choix : ");
                choix2 = Console.ReadLine();
                switch (choix2)
                {
                    case "0": return;
                    case "1":IHM.AjoutSalarie();
                        break;
                    case" 2": IHM.AjoutCommercial();
                        break;
                }
            }
            while (default);
        }
        public static void RechercherEmploye()
        {
            Console.Write("--- Recherhcer un employé ---- :");
            Console.Write("Merci de saisir le nom:");
            string? name = Console.ReadLine();

        }
        public static void AjoutCommercial()
        {
            Console.Write("Merci de saisir le nom:");
            string? name = Console.ReadLine();
            Console.Write("Merci de saisir le matricule:");
            string? matricule = Console.ReadLine();
            Console.Write("Merci de saisir la catégorie:");
            string? categorie = Console.ReadLine();
            Console.Write("Merci de saisir le service:");
            string? service = Console.ReadLine();
            Console.Write("Merci de saisir le salaire:");
            int salaire = Convert.ToInt16(Console.ReadLine());
            Console.Write("Merci de saisir le chiffre d'affaire du commerciale:");
            int chiffreAffaire = Convert.ToInt16(Console.ReadLine());
            Console.Write("Merci de saisir la commission:");
            int commission = Convert.ToInt16(Console.ReadLine());
            Commercial commercial = new Commercial(chiffreAffaire, commission)
            {
                Nom = name,
                Matricule = matricule,
                Categorie = categorie,
                Service = service,
                Salaire = salaire
            };

            // Ajout dans la liste
            _salaries.Add(commercial);
            Console.WriteLine("Commercial ajouté avec succès !");
        }
        public static void AjoutSalarie()
        {
            Console.Write("Merci de saisir le nom:");
            string? name = Console.ReadLine();
            Console.Write("Merci de saisir le matricule:");
            string? matricule = Console.ReadLine();
            Console.Write("Merci de saisir la catégorie:");
            string? categorie = Console.ReadLine();
            Console.Write("Merci de saisir le service:");
            string? service = Console.ReadLine();
            Console.Write("Merci de saisir le salaire:");
            int salaire = Convert.ToInt16(Console.ReadLine());
            Salarie salarie = new Salarie
            {
                Nom = name,
                Matricule = matricule,
                Categorie = categorie,
                Service = service,
                Salaire = salaire
            };

            // Ajout dans la liste
            _salaries.Add(salarie);
            Console.WriteLine("Salarie ajouté avec succès !");
        }
        public static void AfficherSalaries()
        {
            Console.WriteLine("--- Liste des employés ---");
            foreach (var salarie in _salaries)
            {
                Console.WriteLine(salarie.ToString()); 
            }
        }
    }
}