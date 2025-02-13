namespace Exercice4.Models
{
    public class Marmoset
    {

        public int Id { get; set; }
        public string Nom { get; set; }

        public decimal Poids { get; set; }

        public  decimal Taille { get; set; }
        public Marmoset(int id, string nom, decimal poids, decimal taille)
        {
            Id = id;
            Nom = nom;
            Poids = poids;
            this.Taille = taille;
        }
        public Marmoset() { }
    } 
}


   