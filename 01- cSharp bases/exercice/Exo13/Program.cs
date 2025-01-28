Console.WriteLine("--- Quelle est la nature du triangle ABC ? ---");

Console.Write("Entrez la longueur du segment AB : ");
double AB = double.Parse(Console.ReadLine());
Console.Write("Entrez la longueur du segment BC : ");
double BC = double.Parse(Console.ReadLine());
Console.Write("Entrez la longueur du segment CA : ");
double CA = double.Parse(Console.ReadLine());

if  (AB == BC){
    if (BC == CA)
    {
        Console.WriteLine("le triangle est équilatéral ");
    }
    else
    {
        Console.WriteLine("le triangle est isocèle en B ");
    }
} else if ( AB == CA)
{
    Console.WriteLine("le triangle est isocèle en A ");
}
else if ( BC == CA)
{
    Console.WriteLine("le triangle est isocèle en c ");
}
else
{
   Console.WriteLine("le triangle n'est pas isocèle, ni en A, ni en B, ni en C");
}

