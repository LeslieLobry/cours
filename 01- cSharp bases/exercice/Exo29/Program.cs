// Créer une liste des codes ASCII pour les lettres majuscules (A-Z)
string espace = ""; // ppur gérer les espaces
                    // Créer un tableau pour stocker les codes ASCII des lettres A-Z
int[] asciiCodes = new int[26];

        // Remplir le tableau avec les codes ASCII des lettres majuscules
        for (int i = 0; i < 26; i++)
        {
            asciiCodes[i] = 65 + i; // 65 est le code ASCII de 'A'
        }

        // Afficher les codes ASCII
        Console.WriteLine("Codes ASCII des lettres majuscules A-Z :");
        for (int i = 0; i < asciiCodes.Length; i++)
        {
            Console.WriteLine($"{espace}{(char)asciiCodes[i]}");
            espace += " ";
}

