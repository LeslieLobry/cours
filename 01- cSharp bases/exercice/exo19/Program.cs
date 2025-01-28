Console.WriteLine("--- Menus et sous-menus ---");

Console.WriteLine("table des matières:");



for (int chapitre = 1; chapitre <= 3; chapitre++)
{
    Console.WriteLine($"        Chapitre {chapitre}");
    for (int partie = 1;partie <= 3; partie++)
    {
        Console.WriteLine($"            -Partie {chapitre}.{partie}");
    }
}
