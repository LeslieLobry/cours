Console.WriteLine("--- Quelle boisson souhaitez vous? ---");
Console.Write("Lite des boissons dispo:\n" +
    "1)Eau plate\n"  +
    "2)Eau gazeuze\n" +
    "3) coca-cola\n" +
    "4) Fanta\n" +
    "5) Sprite\n" +
    "6) Orangina\n" +
    "7) 7Up\n");
Console.Write("faites votre choix (1 à 7) :");
int boisson = int.Parse(Console.ReadLine());
string choix = "";
switch (boisson)
{

    case 1: 
        choix = "eau plate";
        break;
    case 2:
        choix = "eau gazeuze";
        break;
    case 3:
        choix = "coca-coca";
        break;
    case 4:
        choix = "Fanta";
        break;
    case 5:
        choix = "Sprite";
        break;
    case 6:
        choix = "Orangina";
        break;
    case 7:
        choix = "7Up";        
        break;
    default:
         Console.WriteLine("votre boisson n'est pas dispo");
        break;
}
if (choix != ""){
    Console.WriteLine($"votre choix de boisson est {choix}");
};

// mettre @ qui permet d'écrire directement ce que l'on veut 

Console.WriteLine(@"Lite des boissons dispo:
                    1) eau plate 
                    2) eau gazeuze");