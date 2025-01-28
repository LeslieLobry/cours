Console.WriteLine("--- Calcul du périmètre et de l'aire d'un carré ---");

Console.Write("Entrez la longueur d'un coté du carré (en cm): ");
int longueur = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"le périmètre du carré est : {longueur*4} cm");
Console.WriteLine($"l'aire du carré est : {longueur * longueur} cm²");


Console.WriteLine("--- Calcul du périmètre et de l'aire d'un rectangle ---");

Console.Write("Entrez la longueur du rectangle (en cm): ");
int longueurR = Convert.ToInt32(Console.ReadLine());
Console.Write("Entrez la largueur du rectangle (en cm): ");
int largeurR = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"le périmètre du carré est : {(longueurR+largeurR)*2} cm");
Console.WriteLine($"l'aire du carré est : {longueurR * largeurR} cm²");

