
Console.WriteLine("---Le grand tirage au sort ---");
string[] tab = ["jerome", "alain", "gaëlle","leslie", "mathieu"];
string[] tab2 = new string[tab.Length];
int tiragecompteur = 0;
int choix = 0;
string espace = "";
do
{
    Console.WriteLine(@"
                1---Effectuer un tirage
                2---Voir la liste des personnes déjà tirées
                3---Voir la liste des personnes restantes
                0---Quitter");
    Console.Write("Faites votre choix : ");
    choix = int.Parse(Console.ReadLine());
  
    if (choix < 0 || choix > 3)
    { // !!ce que tu ne veux pas en condition 
        Console.WriteLine("vous devez saisir un chiffre entre 0 et 3");

    }
    switch (choix)
    {
        case 1:
            if (tiragecompteur < tab.Length)
            {
                Random random = new Random();
                int index;

                // Trouver un index valide qui n'a pas encore été tiré
                do
                {
                    index = random.Next(tab.Length);
                } while (Array.IndexOf(tab2, tab[index]) != -1);

                // Ajouter le nom tiré à tab2
                tab2[tiragecompteur] = tab[index];
                tiragecompteur++;
                Console.WriteLine($"L'heureux gagnant est : {tab[index]}");
            }
            else 
            {
                Console.WriteLine("Tous les noms ont déjà été tirés.");
                
            }
            break;
        case 2:
            Console.WriteLine("Liste des personnes déjà tirées :");
            if (tiragecompteur > 0)
            {
                for (int i = 0; i < tiragecompteur; i++)
                {
                    Console.WriteLine($"{tab2[i]}");
                    
                }
            }
            else
            {
                Console.WriteLine("Aucun nom n'a encore été tiré.");
            }
            break;
        case 0:
            Environment.Exit(0);
            break;
        case 3:
            Console.WriteLine("Liste des personnes restantes :");  /// vérifie que le prenom dans tab 1 n'est pas dans tab 2
            if (tiragecompteur < tab.Length)
            {
                for (int i = 0; i < tab.Length; i++)
                {
                    if (Array.IndexOf(tab2, tab[i]) == -1)
                    {
                        Console.WriteLine($"{espace}{tab[i]}");
                        espace += "\t ";
                    }
                }
            }
            else
            {
                Console.WriteLine("Il ne reste plus personne à tirer.");
            }
            break;
        default:
            Console.WriteLine($"erreur");
            break;
    }
}
while (true);