

Console.WriteLine("---Gestion des Contacts---");
Console.Write("Merci de saisir le nombre de contact:");
int nbrcontact = int.Parse(Console.ReadLine());
int choix = 1;
string[] tab = new string[nbrcontact];
string nom;
int ctr = 0;


Console.WriteLine("Ma liste de Contacts");
Console.Clear();
do
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Faites votre choix :");
    Console.ResetColor();
    Console.Write(@"1--- Saisir des contacts
                    2--- Afficher mes contacts
                    0--- Quitter
        Faites votre choix : ");
    choix = Convert.ToInt32(Console.ReadLine());
      if (choix < 0 || choix > 2)
    { // !!ce que tu ne veux pas en condition 
        Console.WriteLine("vous devez saisir un chiffre entre 0 et 4");

    }
    switch (choix)
    {
                case 1:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Saisir des contacts : ");
            Console.ResetColor();
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write($"Nom et prénom du contact n°{i+1} : ");
                nom = Console.ReadLine();
                tab[i] = nom;
                ctr ++;
                
            }
            Console.Clear();
                 break;
        case 2:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Affichage des contacts : ");
            Console.ResetColor ();
           
            if (ctr == 0)
            {
                Console.WriteLine($"pas de contact saisi");
            }

            else
            {
                for (int i = 0; i < tab.Length; i++)
                {
                    Console.WriteLine($"Nom et prénom du contact n°{i+1} {tab[i]}");
                }
            }
            Console.WriteLine("appuyer sur une touche pour retourner au menu");
            Console.ReadKey();
            Console.Clear ();
            break;
            case 0:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine($"erreur ");
            break;
        }
    }
while (true);

