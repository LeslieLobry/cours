using exo02;


using System.Runtime.InteropServices;


List<Salarie> salaries = new List<Salarie>
{
    new Salarie("001", "Chloé", "Comptabilité", "Cadre", 24000),
    new Salarie("002", "Emma", "Comptabilité", "Employée", 30000),
    new Salarie("003", "Georges", "Developpement", "Employé", 26000),
    new Salarie()

};


foreach (Salarie salarie in salaries)
{
    salarie.AfficherSalaire();

}
Salarie.NombreSalaries();
Salarie.TotalSalaires();
//Console.WriteLine("Salaire total : " + Salarie.TotalSalaires);

Console.WriteLine("On change le salaire de Chloé à 500000.");
salaries[0].Salaire = 500000;
foreach (Salarie salarie in salaries)
{
    salarie.AfficherSalaire();

}


