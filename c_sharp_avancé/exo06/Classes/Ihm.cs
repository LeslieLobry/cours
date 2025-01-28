using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using exo06.Classes;

namespace exo06.Classes
{
    internal static class IHM
    {
        private static Pile<string> pile = new ();
        public static void Start()


        {
            string? choix;
            Console.Write("Menu Principal:");
            Console.WriteLine(@"
                                1. String
                                2. Decimal
                                3. Personne
                                0. Quitter");
            do
            {
                Console.Write("Faites votre choix :");
                choix = Console.ReadLine();



                switch (choix)
                {
                    case "0": break;

                    case "1":
                        IHM.String();
                        break;
                    case "2":
                        Console.WriteLine("decimal");
                        IHM.Decimal();
                        break;
                    case "3":
                        Console.WriteLine("Personne");
                        break;
                    default:
                        break;
                }
            }
            while (default);
        }

        public static void String()
        {
            string? choix2;
            Console.Write("Menu Principal:");
            Console.WriteLine(@"
                                1. Empiler
                                2. dépiler
                                3. Récupérer à X
                                0. Quitter");
            do
            {
                Console.Write("Faites votre choix :");
                choix2 = Console.ReadLine();
                switch (choix2)
                {
                    case "0": break;

                    case "1":
                        Console.WriteLine("empiler");
                        IHM.Empiler();
                        break;
                    case "2":
                        Console.WriteLine("decimal");
                        IHM.Depiler();
                        break;
                    case "3":
                        Console.WriteLine("Personne");
                        break;
                    default:
                        break;
                }
            }
            while (default);
        }

        
        public static void Decimal() 
        {
            string? choix2;
            Console.Write("Menu Principal:");
            Console.WriteLine(@"
                                1. Empiler
                                2. dépiler
                                3. Récupérer à X
                                0. Quitter");
            do
            {
                Console.Write("Faites votre choix :");
                choix2 = Console.ReadLine();
                switch (choix2)
                {
                    case "0": break;

                    case "1":
                        Console.WriteLine("empiler");
                        IHM.Empiler();
                        break;
                    case "2":
                        Console.WriteLine("decimal");
                        IHM.Decimal();
                        break;
                    case "3":
                        Console.WriteLine("Personne");
                        break;
                    default:
                        break;
                }
            }
            while (default);

        }
        public static void Personne()
        {

        }

        public static void Empiler()
        {
            Console.Write("Valeur à empiler:");
            string? element = Console.ReadLine();
            Console.WriteLine($"{element} a été ajoutée à la pile");
            pile.Empiler(element);
        }
        public static void Depiler()
        {
            Console.Write("Valeur à dépiler:");
            string element = Console.ReadLine();
            Console.WriteLine($"{element} a été supprimé à la pile");
            pile.Depiler();
        }

        public static void RecupererAX()
        {
            //Console.Write("Valeur à dépiler:");
            //int element = Console.ReadLine();
            //Console.WriteLine($"{element} a été ajoutée à la pile");
            //pile.Depiler(element);
        }
    }      
}


