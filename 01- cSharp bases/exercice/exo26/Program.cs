Random aleatoire = new Random();
int nbrMystere = aleatoire.Next(1, 51);
int nombre=0;
int coup = 0;



while (nombre != nbrMystere)
{
    coup++;
Console.Write("Veuillez saisir un nombre : ");
 nombre = Convert.ToInt32(Console.ReadLine());
     if (nombre > nbrMystere)
        {

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("c'est moins");
        Console.ResetColor();
    }
     else if(nombre < nbrMystere)
    {

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("c'est plus");
        Console.ResetColor();
    }

    
};

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"bravo, vous avez trouvez en : {coup}");
Console.ResetColor();


