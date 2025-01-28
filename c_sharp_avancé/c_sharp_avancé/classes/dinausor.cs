using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_avancé.classes
{
    internal class Dinosaur
    {
        // Attribut
        private int _age; // _ pour priver
        private string? _espece;
        private int _nbPattes;
        private double _poids;
        private bool _peutVoler = false;

        public int Age { get => _age; set => _age = value; }
        public string? Espece { get => _espece; set => _espece = value; }
        public int NbPattes { get => _nbPattes; set => _nbPattes = value; }
        public double Poids { get => _poids; set => _poids = value; }
        public bool PeutVoler { get => _peutVoler; set => _peutVoler = value; }

        private string? _nom;

        public string? NomMajuscule
        {
            get { return _nom; }
            set { _nom = value; }
        }
        public Dinosaur()
        {
            
        }

    }
    




        // propriétés
        //(pour accéder et modifier les attributs, principe de l'encapsulation

//        public int Age { 
//            get 
//            {
//                Console.WriteLine("recup age");
//                return _age;
//            } 
//            set
//            {
//                Console.WriteLine("set age à" + value);
//                _age = value;
//                Console.WriteLine("fin set age");
//            } 
//        }
//    }
}

