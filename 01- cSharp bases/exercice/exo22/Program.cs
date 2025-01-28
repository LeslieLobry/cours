//Console.WriteLine("--- Gestion des notes ---");
//Console.WriteLine("--- Veuillez saisir 5 notes ---");

//int note=0;
//int meilleur = 0;
//int bas=0;
//int moyenne = 0;


//for (int chiffre = 1; chiffre <= 5; chiffre++)
//{
//    Console.Write($"Merci de saisir la note {chiffre}\n");
//    note = int.Parse(Console.ReadLine());
   
//    if (meilleur == 0 && bas==0)
//    {
//        meilleur = note;
//        bas = note;

//    } 
//    else if (note < bas)
//    {
//        bas = note;
//    }

//    moyenne = moyenne + note;
//    }
//Console.ForegroundColor = ConsoleColor.Green;
//Console.WriteLine($"La meilleur note est {meilleur}");
//Console.ForegroundColor = ConsoleColor.Red;
//Console.WriteLine($"La moins bonne note est {bas}");
//Console.ForegroundColor = ConsoleColor.Gray;
//Console.WriteLine($"la moyenne est de  {moyenne/5}");
//Console.ForegroundColor = ConsoleColor.White;

double max = 0, min = 20, somme = 0, moyenne, note; 

for (int i = 1; i <= 5; i++)
{
    Console.Write($"veuillez saisir la note n {i} (sur/20)"); 
    
    while(!double.TryParse(Console.ReadLine(), out note) || note < 0 || note > 20)
    {
        Console.WriteLine("saisie invalide, merci de saisir une note entre 0 et 20");
    }
    
        if ( note > max)
        {
            max = note;
        }
        if ( note < min)
        {
            min = note;
        }
        somme += note;
    }
moyenne = somme / 5; 
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"La meilleur note est {max}");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"La moins bonne note est {min}");
Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine($"la moyenne est de  {moyenne}");
Console.ResetColor();