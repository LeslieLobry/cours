

using Entity;
using Entity.Data;

using var context = new ApplicationDbContext();

var fleursDuMal = new Livre()
{
    Titre = "Les fleurs du mal",
    Auteur = "charles Baudelaire", 
    DatePublication = new DateTime(1857,06,21), 
    Description = "Un livre qu'il est rempli de poèmes",
};

var tchoupi = new Livre()
{
    Titre = "Tchoupi à l'école",
    Auteur = "auteur pour enfants",
    DatePublication = new DateTime(1950, 12, 21),
    Description = "Passionnante histoire de tchoupi",
};

context.Livres.Add(fleursDuMal);
context.Livres.Add(tchoupi);

context.SaveChanges();