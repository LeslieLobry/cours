using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Models
{
    internal class Hotel
    {
        public int Id { get; set; }
        public string Nom { get; set; } = null!;
        public List<Client> Clients { get; set; } = new List<Client>();
        public List<Chambre> Chambres { get; set; } = new List<Chambre>();
        public List<Reservation> Reservations { get; set; } = new List<Reservation>();
        public override string ToString()
        {
            return $"";
        }
    }
}
