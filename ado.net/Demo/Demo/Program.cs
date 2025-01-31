using Demo.classes;
using Microsoft.Data.SqlClient;
using System.Data;

//string connectionString = "Data Source=(localdb)\\ContactDB;Integrated Security=True";

//var connection = new SqlConnection(connectionString);

//connection.Open();

//if (connection.State == ConnectionState.Open)
//{
//    Console.WriteLine("La connexion est ouverte!");
//}
//else
//{
//    Console.WriteLine("Problème de connexion ...");
//}

//Console.WriteLine("votre nom?");
//string nom = Console.ReadLine()!;
//Console.WriteLine("votre prénom?");
//string prenom = Console.ReadLine()!;
//Console.WriteLine("votre n° de classe:");
//int classe = Convert.ToInt32( Console.ReadLine())!;
//Console.WriteLine("date du diplome:");
//DateTime datediplome = DateTime.Parse(Console.ReadLine()!);

//string query = "INSERT INTO Personne ( nom,prenom, classe, datediplome) VALUES ( @nom,@prenom, @classe, @datediplome)";

//var command = new SqlCommand(query, connection);


//command.Parameters.AddWithValue("@nom", nom);
//command.Parameters.AddWithValue("@prenom", prenom);
//command.Parameters.AddWithValue("@classe", classe);
//command.Parameters.AddWithValue("@datediplome", datediplome);
//command.ExecuteNonQuery();

//using (SqlConnection connt = new SqlConnection(connectionString))
//{
//    connt.Open();

//    string request = "SELECT id, prenom, nom, classe, datediplome FROM Personne;";

//    using (SqlCommand sqlCommand = new SqlCommand(request, connt))
//    {
//        SqlDataReader reader = sqlCommand.ExecuteReader();

//        while (reader.Read())
//        {
//            Console.WriteLine($"id: {reader.GetInt32(0)} prenom: {reader.GetString(1)} nom: {reader.GetString(2)}, classe: {reader.GetInt32(3)}, datediplome:{reader.GetDateTime(4)}");
//        }
//    }
//}

////une classe
//using (SqlConnection connt = new SqlConnection(connectionString))
//{
//    connt.Open();
//    Console.WriteLine("quelle classe voulez vous afficher?"); 
//    int classedemand = Convert.ToInt32(Console.ReadLine());
//    string request = "SELECT *  FROM Personne WHERE classe = @classedemand;";

//    using (SqlCommand sqlCommand = new SqlCommand(request, connt))
//    {
//        sqlCommand.Parameters.AddWithValue("@classedemand", classedemand);
//        SqlDataReader reader = sqlCommand.ExecuteReader();

//        while (reader.Read())
//        {
//            Console.WriteLine($"id: {reader.GetInt32(0)} prenom: {reader.GetString(1)} nom: {reader.GetString(2)}, classe: {reader.GetInt32(3)}, datediplome:{reader.GetDateTime(4)}");
//        }
//    }
//}

////supprimer

//using (SqlConnection connt = new SqlConnection(connectionString))
//{
//    connt.Open();
//    Console.WriteLine("quelle étudiante voulez-vous supprimer, mettez l'id?");
//    int suppression = Convert.ToInt32(Console.ReadLine());
//    string request = "DELETE Personne WHERE id = @suppression;";

//    using (SqlCommand sqlCommand = new SqlCommand(request, connt))
//    {
//        sqlCommand.Parameters.AddWithValue("@suppression", suppression);
//        int nbLignes = sqlCommand.ExecuteNonQuery();
//        Console.WriteLine(nbLignes == 1 ? "étudiant supprimé" : "un problème est survenu lors de la suppression"

//        //while (reader.Read())
//        //{
//        //    Console.WriteLine($"id: {reader.GetInt32(0)} prenom: {reader.GetString(1)} nom: {reader.GetString(2)}, classe: {reader.GetInt32(3)}, datediplome:{reader.GetDateTime(4)}");
//        //}
//    }
//}


////modifier
//Console.WriteLine("quelle étudiant voulez-vous modifier, mettez l'id?");
//int updateId = Convert.ToInt32(Console.ReadLine());
//// possible d'afficher l'utilisateur et mettre un message de confirmation (cf. Select par Id)

//Console.WriteLine("Saisir les nouvelles valeurs :");
//Console.WriteLine("votre nom?");
//nom = Console.ReadLine()!;
//Console.WriteLine("votre prénom?");
//prenom = Console.ReadLine()!;
//Console.WriteLine("votre n° de classe:");
//classe = int.Parse(Console.ReadLine())!;//penser au contrôle de saisie
//Console.WriteLine("date du diplome:");
//dateDiplome = DateTime.Parse(Console.ReadLine()!);//penser au contrôle de saisie

//request = "UPDATE student " +
//          "SET " +
//              "prenom = @prenom" +
//              "nom = @nom" +
//              "numero_classe = @numero_classe" +
//              "date_diplome = @date_diplome" +
//          "WHERE id = @updateId;";

//using (SqlCommand sqlCommand = new SqlCommand(request, conn))
//{
//    sqlCommand.Parameters.AddWithValue("@updateId", updateId);
//    sqlCommand.Parameters.AddWithValue("@nom", nom);
//    sqlCommand.Parameters.AddWithValue("@prenom", prenom);
//    sqlCommand.Parameters.AddWithValue("@numero_classe", classe);
//    sqlCommand.Parameters.AddWithValue("@date_diplome", dateDiplome);

//    int nbLignes = sqlCommand.ExecuteNonQuery();
//    Console.WriteLine(nbLignes == 1 ? "Etudiant.e mis.e à jour" : "Un problème est survenu lors de la mise à jour de l'étudiant.e ...");
//}
////UPDATE Chien
////SET id_maitre = (SELECT id FROM Personne WHERE first_name = 'Sherlock')
////where id_maitre is NULL

IHM.AfficherMenu();


//connection.Close();
