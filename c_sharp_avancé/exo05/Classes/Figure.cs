using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exo05.Interface;

namespace exo05.Classes
{
    internal abstract class Figure : IDeplacable

    {
        public Point Origin { get; private set; } = new Point();
        //public Point A => Origin;
        public Point A { get => Origin; private set => Origin = value; }

        protected Figure() { }
        protected Figure(Point origin)
        {
            Origin = origin;
        }

        protected Figure(double x, double y)
        {
            Origin = new Point(x, y);
        }
       public void Deplacement (double x, double y)
        {
            Origin.Deplacement(x, y);
        }
    }
}
