using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    internal class Livre
    {
        public int Id { get; set; }
        public String? Titre { get; set; }
        public string? Description { get; set; }
        public string? Auteur { get; set; }
        public DateTime DatePublication { get; set; }
    }
}
