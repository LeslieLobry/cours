using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exo05.Interface;

namespace exo05.Classes
{

    internal class Triangle : Figure
    {
        public double Base { get; set; }
        public double Hauteur { get; set; }

        public Point B => new Point(A.X + base/2, A.Y -Hauteur);
        public Point C => new Point(A.X -base, A.Y - Hauteur);
        


        public Triangle(double baseTr, double hauteur) : base()
        {
            Base = baseTr;
        }

        public Triangle(Point origin, double baseTr, double hauteur) : base(origin)
        {
            Base = baseTr;
            Hauteur = hauteur;
        }

        public Triangle(double x, double y, double baseTr, double hauteur) : base(x, y)
        {
            Base = baseTr; 
            Hauteur = hauteur;
        }
        public override string ToString()
        {
            return $"Coordonnées du Triangle ABCD (Coté = {cote})" +
                "\nA= " + A +;
            "\nB= " + B +;
            "\nC= " + c +;
            "\nD= " + D +;


        }

    }

}

