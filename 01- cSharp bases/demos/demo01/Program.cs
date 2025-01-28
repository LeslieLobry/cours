//See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");  // ctrl :  une ligne

/*
 pour commenter sur plusieurs ligne
ctrl + maj + :
 */

/*
 les conventions de nommages :
    screaming snake case : SCREAMING_SNAKE_CASE
    camelase : camelCase 
    snake case : snake_case   
    kebab case : Kebab-case
 */

// déclaration et initialisation des variables : 

int entier = 42; // si pas de valeur, valeur défaut 0
double reel = 3.14; // valeur défaut = 0
decimal precis = 3.333333M; 
char caractere = 'a'; // valut par défaut \0
string texte = "bonjour"; //valeur par defaut : ""
bool vraiOuFaux = true; // valeur par défaut false


// ? pour passe la valeur a nul

// const   : pour valeur constante la valeur ne changera jamais 
// exemple : 
const double pi = 3.14;

Console.WriteLine("Entier : " + entier);
Console.WriteLine($"reel: { reel}");
Console.Write("veuillez écrire votre prénom : ");
string prenom = Console.ReadLine();
Console.WriteLine(prenom);