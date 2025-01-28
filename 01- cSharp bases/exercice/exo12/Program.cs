Console.WriteLine("--- Dans quelle catégories mon enfant est-il... ---");
Console.Write("l'age de votre enfant:");
int age = int.Parse(Console.ReadLine());

if (age >= 3 && age < 18)
{
    if (age <= 6 && age >= 3)
    {
        Console.WriteLine("votre enfant est dans la catégorie 'baby' !");
    };
    if (age == 7 || age == 8)
    {
        Console.WriteLine("votre enfant est dans la catégorie 'Poussin' !");
    }
    if (age == 9 || age == 10)
    {
        Console.WriteLine("votre enfant est dans la catégorie 'Pupille' !");
    }
    if (age == 11 || age == 12)
    {
        Console.WriteLine("votre enfant est dans la catégorie 'Minime' !");
    }
    if (age >= 13)
    {
        Console.WriteLine("votre enfant est dans la catégorie 'Cadet' !");
    }
}
else
{
    if (age < 3)
    {
        Console.WriteLine("Votre enfant est trop jeune");
    }
    if (age >= 18)
    {
        Console.WriteLine("Votre enfant n'est plus un enfant");
    }
}
