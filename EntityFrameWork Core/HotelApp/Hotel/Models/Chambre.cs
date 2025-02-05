using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelApp.Enums;
using Microsoft.EntityFrameworkCore;

namespace HotelApp.Models
{
   
    public class Chambre
    {
        [Key]
        public int Numero { get; set; }
        [Precision(20,2)]
        public decimal Tarif { get; set; }
        public StatutChambre StatutChambre { get; set; } = StatutChambre.Libre;
        public int NbrLits { get ; set; }
        public List<Reservation> Reservations { get; set; } = [];
    }
}
