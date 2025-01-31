using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.classes
{
    internal class Etudiant
    {
        private int _id ; 
        private string _nom="john";
        private string _prenom="smith";
        private int _classe;
        private DateTime _datediplome;
        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public int Classe { get => _classe; set => _classe = value; }
        public DateTime Datediplome { get => _datediplome; set => _datediplome = value; }

        public Etudiant(int id, string nom, string prenom, int classe, DateTime datediplome)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Classe = classe;
            Datediplome = datediplome;
        }
        public override string ToString()
        {
            return $"id:{Id:D3}, prenom{Prenom}, nom {Nom}, classe {Classe}, date du diplome {Datediplome}";
        }

        public bool Save()
        {

        }
        public bool Delete()
        {

        }
    }
}
