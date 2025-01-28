using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo01
{
    internal class Chaise
    {
            private static int _nombreDeSalarie = 0;
            private int _nbrDePied=10;
            private string? _matériaux ="marbre";
            private string? _couleur= "Rose";


        // pour pouvoir récupérer et modifier les elmts
        public static int NombreDeSalarie { get => _nombreDeSalarie; set => _nombreDeSalarie=value; }   
        public int NbrDePied1 { get => _nbrDePied; set => _nbrDePied = value; }
        public string? Matériaux1 { get => _matériaux; set => _matériaux = value; }
        public string? Couleur1 { get => _couleur; set => _couleur = value; }

        public Chaise() // par defaut ! 
        {
            _nombreDeSalarie++;
        }

        public Chaise(int nbrDePied, string materiaux, string couleur)
        {
            NbrDePied1 = nbrDePied; 
            Matériaux1 = materiaux; 
            Couleur1 = couleur; 
        }

        public void Afficher()
        {
            Console.WriteLine($"Je suis une chaise, avec {this.NbrDePied1} pieds en {Matériaux1}et de couleur {Couleur1}");
        }
        public static void AfficherNbrSalarie()
        {
            Console.WriteLine("le nombree de salarié est de : " + NombreDeSalarie);
        }
    }
}

