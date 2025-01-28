

Console.WriteLine("--- le nombre est-il divisible par...? ---");
Console.Write("Entrez un chiffre/ nombre entier:");
int entier = int.Parse(Console.ReadLine());
Console.Write("Entrez un chiffre/ nombre diviseur:");
int diviseur = int.Parse(Console.ReadLine());

if (entier % diviseur == 0)
{
    if (entier < 10)
    {
        Console.WriteLine($"le chiffre est divisble par {diviseur}");

    }
    else
    {
        Console.WriteLine($"le nombre est divisble par {diviseur}");
    }
}
else
{

    if (entier < 10)
    {
        Console.WriteLine($"le chiffre n'est pas divisble par {diviseur}");

    }
    else
    {
        Console.WriteLine($"le nombre n'est pas divisble par {diviseur}");
    }
}
