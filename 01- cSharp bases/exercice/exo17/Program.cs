Console.WriteLine("--- Dans quelle catégorie mon enfant est -il...? ---");

Console.Write("Entrez l'âge de votre enfant :");
int age = int.Parse(Console.ReadLine());

switch (age)
{

    case < 3  :
        Console.WriteLine("votre enfant n'a pas l'âge");
        break;
    case >= 3 and <= 6:
        Console.WriteLine("votre enfant est dans la catégorie \"baby\"");
        break;
    case  >=7 and <= 8:
        Console.WriteLine("votre enfant est dans la catégorie 'Poussin'");
        break;
    case >= 9 and <= 10:
        Console.WriteLine("votre enfant est dans la catégorie 'Pupille'");
        break;
    case >= 11 and <=12 :
        Console.WriteLine("votre enfant est dans la catégorie 'Minime'");
        break;
    case >= 13 and <= 17:
        Console.WriteLine("votre enfant est dans la catégorie 'cadet'");
        break;
    default:
        Console.WriteLine("votre enfant est trop vieux");
        break;
}

