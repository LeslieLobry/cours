using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo04
{
    internal class Commercial : Salarie 
    {
        private double _chiffreDAffaire;
        private double _commission;
        public double ChiffreDAffaire { get => _chiffreDAffaire; set => _chiffreDAffaire = value; }
        public double Commission { get => _commission; set => _commission = value; }
        public Commercial(double chiffreDAffaire, double commission)
        {
            ChiffreDAffaire = chiffreDAffaire;
            Commission = commission;
        }
    }
}
