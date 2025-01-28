using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Exo08
{
    internal class Personne
    {
        public int Id { get; set; }
        public string? Nom { get; set; }
        public int Age { get; set; }
        public string? Ville { get; set; }
        public override string ToString() => $"Personne : {Id} {Nom} {Age} {Ville}";
    }
}
