using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Models
{
   public class Client
    {
        public int Id { get; set; }
        public string? Nom { get; set; } = null!;
        public string? Prenom { get; set; } = null!;
        public string? NumeroTel { get; set; } = null!;

        public List<Reservation> Reservations { get; set; } = new List<Reservation>();

        public override string ToString()
        {
            return $"{GetType().Name} :nom = {Nom}, Prènom = {Prenom}, tel ={NumeroTel}";
        }
    }
}
