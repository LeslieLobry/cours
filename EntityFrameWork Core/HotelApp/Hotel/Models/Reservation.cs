using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelApp.Enums;

namespace HotelApp.Models
{
   public class Reservation
    {
        public int Id { get; set; }
       
        public StatutResa StatutResa { get; set; }
        public int ClientId {  get; set; } 
        public Client Client { get; set; } = null!;
        public List<Chambre> Chambres { get; set; } = new List<Chambre>();
    }
}

