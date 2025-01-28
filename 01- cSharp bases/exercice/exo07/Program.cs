Console.WriteLine("--- Calcul de la longueur de l'hypothénuse ---");

Console.Write("Entrez la longueur du premier coté (en cm): ");
double longueur1 = double.Parse(Console.ReadLine());
Console.Write("Entrez la longueur du deuxième coté (en cm): ");
double longueur2 = double.Parse(Console.ReadLine());
double hyp = Math.Sqrt(Math.Pow(longueur1,1)+Math.Pow(longueur2,1));


Console.WriteLine($"La longueur de l'hypothénuse est :{Math.Round(hyp),2}");

// théoreme = hpo² = Premiercoté² + deuxiemecoté²

