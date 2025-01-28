Console.WriteLine("--- Calcul des intérêts ---");
Console.Write("Entrez Capital de départ (en Euros) :");
double capital = double.Parse(Console.ReadLine());
Console.Write("Entrez le taux d'inérêt (en %):");
double taux = double.Parse(Console.ReadLine());
Console.Write("Entrez la durée de l'épargne (en année):");
int annee = int.Parse(Console.ReadLine());

double calcul = Math.Round(capital * Math.Pow((1 + taux / 100), annee),2);

double montantinteret = Math.Round((calcul - capital),2);

Console.WriteLine($"le montant des intérets sera de {montantinteret} Euros après {annee}");
Console.WriteLine($"le capital final sera de {calcul} euros ");

