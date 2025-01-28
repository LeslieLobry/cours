Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("--- Question à choix multiple --- ");

Console.WriteLine($@"Quelle est l'instruction qui permet de sortir d'une boucle en C#?
                a) quit
                b) continue
                c) break
                d) exit");

string lettre, nouvelEssai;

do
{
    Console.Write("Entrez votre réponse : ");
    lettre = Console.ReadLine().ToUpper();

    if (lettre == "A" || lettre == "B" || lettre == "D")
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"votre réponse {lettre} est incorrect");
        Console.ResetColor();
        Console.Write("un nouvel essai ? : ");
        string yesno = Console.ReadLine().ToUpper();
        if(yesno == "NON")
        {
            Console.WriteLine("dommage");
            Environment.Exit(0); // pour tout couper !!!!!!!!!!!!!!!!!!!!!!!!§
            
        }
        else
        {
            Console.Write("votre nouvel essai :");
            lettre = Console.ReadLine().ToUpper();
        }
    }
}
while (lettre != "C");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Bonne réponse ❤️");
Console.ResetColor();

