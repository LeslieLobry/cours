using System.ComponentModel.DataAnnotations;

namespace ASP.NET_Core.Models
{
    
        public class Contact
        {
            [Key]
            public int Id { get; set; }
            public string Nom { get; set; }
            public string Prenom { get; set; }
            public string Age { get; set; }

        public Contact(int id, string nom, string prenom, string age)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Age = age;
        }
    }
    }


