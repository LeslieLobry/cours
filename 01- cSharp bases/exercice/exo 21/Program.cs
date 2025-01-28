Console.WriteLine("--- Accroissement de population ---");

double habitant = 96809;

double taux = 0.0089;
double final = 120000;
double annee = 0;
double depart = 2015;

while (habitant <= final)
{
    habitant = habitant * (1 + taux);
    annee = annee+1;
    depart = depart+1;

}
Console.WriteLine(@$"Il faudra {annee}, nous serons en {depart}
                       Il y aura {Math.Round(habitant,0)} habitants en {depart}");