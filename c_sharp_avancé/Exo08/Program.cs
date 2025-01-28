using System;
using System.Linq;
using Exo08;

List<Personne> mesPersonnes = new()
{
 new() { Id =1, Nom = "Alice", Age = 25, Ville ="Paris" },
 new() { Id =2, Nom = "Bob", Age = 30, Ville ="Lyon" },
 new() { Id =3, Nom = "Charlie", Age = 35, Ville ="Marseille"},
 new() { Id =4, Nom = "Diana", Age = 40, Ville ="Paris"},
 new() { Id =5, Nom = "Eve", Age = 28, Ville ="Lyon"},
 new() { Id =6, Nom = "Frank", Age = 33, Ville ="Paris"}
};


//exo1 Trouver toutes les personnes de Paris.
Console.WriteLine("-----------------exo1");
mesPersonnes.Where(x => x.Ville == "Paris")
            .ToList()
            .ForEach(Console.WriteLine);

//exo 2 Trouver les noms des personnes ayant plus de 30 ans.
Console.WriteLine("-----------------exo2");
mesPersonnes.Where(x => x.Age > 30)
            .Select(x => x.Nom)
            .ToList()
            .ForEach(Console.Write);
//ex3Trier les personnes par âge croissant
Console.WriteLine("-----------------exo3");
mesPersonnes.OrderBy(x => x.Age)
            .ToList()
            .ForEach(Console.WriteLine);

//ex4 Compter le nombre de personnes vivant à Lyon.
Console.WriteLine("-----------------exo4");
Console.WriteLine(mesPersonnes.Count(x => x.Ville == "Lyon"));    ;
           

//ex5 Trouver la personne la plus âgée
Console.WriteLine("-----------------exo5");
Console.WriteLine(mesPersonnes.OrderByDescending(p => p.Age).FirstOrDefault()); ;

//ex6 Obtenir une liste des villes distinctes.
Console.WriteLine("-----------------exo6");
mesPersonnes.Select(x => x.Ville).Distinct().ToList().ForEach(Console.Write);

//ex7 Vérifier si toutes les personnes ont plus de 20 ans
Console.WriteLine("-----------------exo7");
bool plusDe20 = mesPersonnes.All(x => x.Age > 20);
Console.WriteLine(plusDe20);

//ex8 Projeter une nouvelle liste contenant uniquement les noms et âges.
Console.WriteLine("-----------------exo8");
mesPersonnes.Select(p =>(p.Nom, p.Age));

//ex9 Trouver le nom de la personne la plus jeune vivant à Paris.
Console.WriteLine("-----------------ex9");
var jeuneParis = 
mesPersonnes.Where(x => x.Ville == "Paris")
            .OrderBy(x => x.Age)
            .Select(x => x.Nom)
            .FirstOrDefault();
        
Console.WriteLine(jeuneParis);

//ex10 Grouper les personnes par ville et afficher le nombre de personnes dans chaque ville.
Console.WriteLine("-----------------exo10");
mesPersonnes.GroupBy(x => x.Ville).Select(g => new {ville =g.Key, Count = g.Count()}).ToList().ForEach(Console.Write);
            

//ex11 Créer une séquence infinie de nombres pairs et récupérer les 10 premiers.
Console.WriteLine("-----------------exo11");
Enumerable.Range(0, int.MaxValue).Take(10).ToList().ForEach(Console.WriteLine);
//exo12 Paginer une liste de nombres de 1 à 100 pour obtenir le 3ème bloc de 10 nombres (21 à 30).
Console.WriteLine("-----------------12");
int noPage = 3 - 1;
int nbElem = 10;
Enumerable.Range(1, 100).Skip(nbElem * noPage).Take(nbElem);
//exo13 Trouver le nombre maximum dans une liste d'entiers.** `[4, 8, 15, 16, 23, 42]
Console.WriteLine("-----------------exo13");
new List<int>() { 4, 8, 15, 16, 23, 42 }.Max();

//exo14 Filtrer les mots d'une liste contenant plus de 5 lettres.** `["chat", "ordinateur", "table", "lampe", "programme"]
Console.WriteLine("-----------------");
new List<string>() { "chat", "ordinateur", "table", "lampe", "programme" }.Where(s => s.Length >= 5);