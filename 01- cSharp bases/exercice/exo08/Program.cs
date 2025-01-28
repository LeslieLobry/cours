Console.Write("Entrez le prix HT de l'objet (en euros ):");
double prix = double.Parse(Console.ReadLine());
Console.Write("Entrez le taux de T.V.A est de (en %) :");
double tva = double.Parse(Console.ReadLine());
double calcultva = (prix * tva) / 100;
Console.WriteLine($" le montant de la T.V.A est de : {calcultva}");
Console.WriteLine($" le prix TTC de l'objet est de  : {calcultva + prix}");
