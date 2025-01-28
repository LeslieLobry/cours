Console.WriteLine("--- Est Pair...? Est impair...?");
Console.Write("combien de nombre contiendra le tableau ?:");
int choix = int.Parse(Console.ReadLine());
int[] tab = new int[choix];


for (int ligne = 0; ligne < tab.Length; ligne++)
{
    Random aleatoire = new Random();
    int val = aleatoire.Next(0, 100);
    tab[ligne] = val;

    if (val % 2 == 0)
    {
        Console.WriteLine($"le nombre {val} est pair.");
    }
    else
        Console.WriteLine($"le nombre {val} est impair.");
}

