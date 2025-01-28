using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exo05.Classes;

namespace exo05.Classes
{
    internal class Carre : Figure
    {

        /*         +cote
         *        A    B
         *  -cote
         *        D    c
         */

        public double Cote { get; set; }

        public Point B => new (A.X + Cote, A.Y);
        public Point C => new (B.X, B.Y - Cote);
        public Point D => new(C.X - Cote, C.Y);
        

        public Carre(double cote) : base()
        {
            Cote = cote;
        }

        public Carre(Point origin, double cote) : base(origin)
        {
        }

        public Carre(double x, double y, double cote) : base(x, y)
        {
        }
        public override string ToString()
        {
            return $"Coordonnées du Carré ABCD (Coté = {cote})"+
                "\nA= " +A+;
                "\nB= " + B +;
                "\nC= " + c +;
                "\nD= " + D +;


        }

    }
}

