////nom complet
//void nom(string prenom, string nom)
//{
//    Console.WriteLine("Bonjour  " + prenom + " " + nom);
//}

//nom("john", "doe");
//// extraction
//void soustaction(int A = 2, int B = 1)
//{
//    Console.WriteLine($"je soustrait  {A} - {B}");
//    var resultat = A - B;
//    Console.WriteLine($"le résultat est de : {resultat}");
//}
//soustaction();

////Quelle heure

//void quelle_heure(string heure = "12h00")
//{
//    Console.WriteLine("il est " + heure);
//}
//quelle_heure();
//quelle_heure("14h00");

//// compteur de lettre 

//void compter_lettre_a(string mot)
//{
//    int compteur = 0;


//    foreach (char lettre in mot) // char pour parcourir une chaine de caractère
//    {
//        if (lettre == 'a')
//        {
//            compteur++;
//        }
//    }
//    Console.WriteLine($"Le nombre de lettres 'a' dans la chaîne est : {compteur}");
//}
//compter_lettre_a("c'est le baba");
//compter_lettre_a("okie");

// utilisation de Count 

 void compteur(string mot)
    {
       
        // Étape 2 : Utiliser Count pour compter les occurrences de 'a'
        int compteur = mot.Count(c => c == 'a');
        // Explication :
        // - La méthode Count parcourt tous les caractères.
        // - Chaque caractère est comparé à 'a' (grâce à la fonction lambda c => c == 'a').
        // - À chaque fois que c == 'a' est vrai, 1 est ajouté au total.

        // Étape 3 : Afficher le résultat
        Console.WriteLine($"Le nombre de lettres 'a' dans la chaîne est : {compteur}");
    }

compteur("c'est le baba");
compteur("koko");
compteur("aaaaaaa");


// ADN 

void verification_adn(string adn)
{
    Console.WriteLine("saisir la chaine d'adn"); 
    void compteur(string mot) {
    
    Console.WriteLine($"Le nombre de lettres 'a' dans la chaîne est : {compteur}");
}
