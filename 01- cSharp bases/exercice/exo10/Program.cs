Console.WriteLine("--- la lettre est-elle une voyelle ? ---");
Console.Write("Entrez une lettre :");
string lettre = Console.ReadLine().ToUpper(); // toUpper pour majuscule 

if (lettre =="A"  ||
    lettre == "E" ||
    lettre == "I" ||
    lettre == "O" ||
    lettre == "U" || 
    lettre == "Y")
{
    Console.WriteLine("Cette lettre est une voyelle ! ");
}
else Console.WriteLine("cette lettre est une consonne");