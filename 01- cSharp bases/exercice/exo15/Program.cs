Console.WriteLine("--- Quelle sera le montant de l'indemnité de licenciement ? ---");
Console.Write("Merci de saisir le dernier salaire (en euros):");
decimal salaire = decimal.Parse(Console.ReadLine());
Console.Write("Entrez votre âge :");
int age = int.Parse(Console.ReadLine());
Console.Write("Merci de saisir le nombre d'année d'ancienneté :");
int annee = int.Parse(Console.ReadLine());

decimal calcul10 = 0;


if (annee >= 1 && annee <= 10)
{
    calcul10 = (salaire / 2) * annee;
    Console.WriteLine(calcul10);
}
else
{
    calcul10 += (salaire / 2) * 10;
    calcul10 += (annee - 10) * salaire;
}

if (age > 45 && age <= 49)
{
    calcul10 += 2*salaire;
}
else if(age >= 50)
{
    calcul10 += 5 * salaire;
}

Console.WriteLine(calcul10);