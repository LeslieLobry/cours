Console.Write("veuillez saisir votre nom: ");
string nom = Console.ReadLine();
Console.Write("veuillez saisir votre prénom: ");
string prenom = Console.ReadLine();
Console.Write("veuillez saisir votre âge : ");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"bonjour {prenom}  {nom}, vous avez : {age} ");
