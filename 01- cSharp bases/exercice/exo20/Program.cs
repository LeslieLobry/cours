Console.WriteLine("--- Les tables de multiplication ---");

for (int nbr1 = 1; nbr1 <= 10; nbr1++)
{
    Console.WriteLine($"\nTable de {nbr1} :");
    for (int nbr2 = 1; nbr2 <= 10; nbr2++)
    {
        
        Console.WriteLine($"            -{nbr1}*{nbr2} = {nbr1 * nbr2}");
    }
}
