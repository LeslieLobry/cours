using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo04
{
    internal class Salarie
    {

        private static int _nombreDeSalarie = 0;
        private string? _matricule = "";
        private string? _nom = "Salarié";
        private string? _service = "";
        private string? _categorie = "";
        private static int _totalSalaire = 0;
        private int _salaire;


        public string? Matricule { get => _matricule; set => _matricule = value; }
        public string? Service { get => _service; set => _service = value; }
        public string? Categorie { get => _categorie; set => _categorie = value; }
        public string? Nom { get => _nom; set => _nom = value; }
        public int Salaire
        {
            get => _salaire;
            set
            {
                TotalSalaire -= _salaire;
                _salaire = value;
                TotalSalaire += _salaire;
            }
        }
        public static int NombreDeSalarie { get => _nombreDeSalarie; set => _nombreDeSalarie = value; }
        public static int TotalSalaire { get => _totalSalaire; set => _totalSalaire = value; }

        public Salarie()
        {
            Salaire = 16236;
            _nombreDeSalarie++;
        }


        public Salarie(string? nom, string? categorie, int salaire) : this()
        {
           
            Nom = nom;
            Categorie = categorie;
            Salaire = salaire;


        }
        internal void AfficherSalaire()
        {

            Console.WriteLine($"Le salaire de {Nom} est de  {Salaire} ");

        }
        internal static void NombreSalaries()
        {
            Console.WriteLine("Il y a " + NombreDeSalarie + "salarié");
        }
        
        internal static void TotalSalaires()
        {
            Console.WriteLine("le total des salaire est de " + TotalSalaire);
        }
        public void RemiseAZero()
        {
            NombreDeSalarie = 0;
            Salaire = 0;
        }
    }
}
