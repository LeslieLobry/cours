Console.WriteLine("--- Gestion des notes avec menu --- ");

Console.WriteLine(@"                    
                    1-- Saisir les notes
                    2-- La plus grande note
                    3-- la plus petite note
                    4-- la moyenne des notes
                    0-- Quitter
");
Console.Write("Faites votre choix :");
int choix, ctr = 1;
double max = 0, min = 20, somme = 0, note ;



do
{
    Console.Write("Faites votre choix :");
    choix = Convert.ToInt32(Console.ReadLine());

    if (choix < 0 || choix > 4)
    { // !!ce que tu ne veux pas en condition 
        Console.Write("vous devez saisir un chiffre entre 0 et 4");
       
    }     
    switch (choix)
        {
        case 0: break;
          
        case 1:
                Console.WriteLine("Saisie des notes : ");
                Console.WriteLine("999 pour stopper les notes ");
            do
            {
                note = 0;
                Console.Write($"veuillez saisir la note {ctr} (sur/20)");
                note = Convert.ToDouble(Console.ReadLine());
                if(note >= 0 && note <= 20)
                {
                    if (note == 1)
                    {
                        min = note; // pour éviter que 0 soit le plus petit nombre 
                        max = note;
                    }
                    if (note >= max)
                    { // on crée une variable pour stocker le chiffre pour avoir le plus grand 
                        max = note;
                    }
                    if (note <= min)
                    {
                        min = note;
                    }
                    somme += note;
                    ctr++;
                }
                
            }
            while (note != 999);
            
            break;
            case 2:
                if (ctr == 1)
                    Console.WriteLine($"pas de note saisie");
                else
                    Console.WriteLine($"la note maximal est {max}");
                break;
            case 3:
                if (ctr == 1)
                    Console.WriteLine($"pas de note saisie");
                else
                    Console.WriteLine($"la note minimal est {min}");
                break;
            case 4:
                if (ctr == 1)
                    Console.WriteLine($"pas de note saisie");
                else
                    Console.WriteLine($"la moyenne est {somme/(ctr-1)}");
            break;
            default:
            break;
        }
}
while (choix != 0);
