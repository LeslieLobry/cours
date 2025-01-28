int[] valeur = new int[10];
string espace=""; // ppur gérer les espaces
for (int ligne = 0; ligne < valeur.Length; ligne++)
{
    Console.Write($"Saisir la valeur de {ligne + 1} :");
    int val = Convert.ToInt32(Console.ReadLine());

    valeur[ligne] = val;

}

foreach (int item in valeur)
{
    Console.WriteLine($"{espace}{item}"); // au début pas d'affichage
    espace += "\t"; // et apres on rajoute une tabulation à chaque passage
}

// pour saisie automatique des nombre dans le tableau.

for (int ligne = 0; ligne < valeur.Length; ligne++)
{
    Random aleatoire = new Random();
    int val = aleatoire.Next(0,100);
    valeur[ligne] = val;
}
foreach (int item in valeur)
{
    Console.WriteLine($"{espace}{item}");
    espace += "\t";
}
