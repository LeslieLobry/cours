using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exo05.Classes;

namespace exo05.Classes
{
    internal class Rectangle : Figure
    {

        public double Longueur { get; set; }
        public double Largeur { get; set; }

        public Point B => new Point(A.X + Longueur, A.Y);
        public Point C => new Point(B.X , B.Y-Largeur);
        public Point D => new Point(C.X - Longueur, C.Y);


        public Rectangle(double longueur, double largeur) : base()
        {
            Longueur = longueur;
            Largeur = largeur;


        }

        public Rectangle(Point origin, double longueur, double largeur) : base(origin)
        {
        }

        public Rectangle(double x, double y, double longueur, double largeur) : base(x, y)
        {
            Longueur = longueur;
            Largeur = largeur;
        }
        public override string ToString()
        {
            return $"Coordonnées Rectangle ABCD (Coté = {cote})" +
            "\nA= " + A +;
            "\nB= " + B +;
            "\nC= " + c +;
            "\nD= " + D +;


        }

    }


}
