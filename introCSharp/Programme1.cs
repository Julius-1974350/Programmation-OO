//
/*
 * les commentaire multi-lignes existent aussi 
 */

// En C++, il faut inclure les fichiers externes nécessaires: #include <...>
// Il faut indiquer les namespaces utilisés: using namespace std;
// En C#, seule l'instruction using nécessaire
using System; // commme en C++, les instructions se terminent par un ;
using System.Text; // Pour avoir accès au stringBuilder
using System.IO; // Pour les fichiers
// on importe toutes les définitions du namespace Astronomie dans le namespace global
using Astronomie;
using Chimie; // Il est impossible d'importer des définitions qui sont en conflit, Mercure devient ambigue car une définition existe dans Astronomie
// Convention de nomenclature
// camelCase: lettre minuscule en premier = indentifiantDePlusieursMots
// - les variables (inclure les paramètres de méthodes)
// PascalCase: lettre majuscule en premier = IndentifiantDePlusieursMots
// - tout le reste

// En C#, une classe est nécessaire à tous les programmes
class Programme1
{
    // La fonction main du C++ devient la méthode Main d'une classe
    // Le mots clé static permet d'imiter une fonction avec une méthode 
    static void Main()
    {
        Console.BackgroundColor = ConsoleColor.DarkCyan;
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        // En C#, Console va remplacer cout et cin pour afficher à l'écran et lire du clavier
        // cout << "Bonjour tout le monde\n";
        Console.WriteLine("Bonjour tous le monde"); // Write inclut le changement de ligne
        // Pour remplacer le system("pause");
        // Lire une touche du clavier 
        Console.ReadKey(true); // Si l'argument donné est vrai, la touche lue n'est pas affichée dans la console
        // Au lieu de system("cls");
        Console.Clear();
        TestNamespaces();
        Grep();
        //TestString();
        //TestFichier();
        //partie 2
        // int valeur1;
        //int valeur2;
        // Il n'est pas nécessaire d'initialiser les variables avant l'appel lorsque qualifiées avec out
        //ObtenirValeurs(out valeur1, out valeur2);
        Console.Write("Appuyer sur une touche pour continuer...");
        Console.ReadKey(true);
    }
    static void TestDeBase()
    {
        Console.WriteLine("Bienvenue au cours de \nProgrammation Orientée Objet");
        // Les types de base sont indentiques au C++
        int entier = 12;
        // En C#, il est impossible d'utiliser une variable non initialisée
        Console.WriteLine(entier);
        double nombreReel = 34.56;
        char caractere = 'A';
        bool estValide = true; // false
        string prenom = "Joel";
        // cout << "L'entier est: " << entier << endl;
        // cw TAB TAB se transeforme en Console.WriteLine
        Console.WriteLine("L'entier est: " + entier + " " + nombreReel + " " + caractere + " " + estValide + " " + prenom);
        Console.WriteLine("L'entier est: {0}, le réel est: {1}, le prénom est {2}, l'entier est toujours {0}", /*position 0*/ entier, /*position 1*/ nombreReel, /*position 2*/ prenom);
        // Les constantes sont identiques au C++
        const double Pi = 3.1415;
        Console.WriteLine(Pi);
        string lecture;
        Console.Write("Entrez une chaine de caractères: ");
        // readline(cin, lecture)
        lecture = Console.ReadLine();
        Console.WriteLine("La chaine est: \"" + lecture + "\"");
        Calculer();
        // La syntaxe du for est identique au C++
        for (int i = 0; i < 10; ++i)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("");
        // La syntaxe du while est aussi identique au C++
        string line;
        Console.Write("Entrez 1: ");
        line = Console.ReadLine();
        while (line != "1")
        {
            Console.Write("Entrez 1: ");
            line = Console.ReadLine();
        }
        Console.WriteLine("Résultat de l'addition: " + Additionner(4, 7));
        int v1 = 12;
        double v2 = 34.56;
        ModifierValeurs(ref v1, ref v2);
        // étant donné que le paramètres de la méthode sont des références, il faut explicitement donner des références lors de l'appel
        Console.WriteLine("v1 = " + v1 + ", v2 = " + v2);

    }
    // En C++, pour passer des paramètre en référence, il faut utilisier &: int& valeur1
    // En C#, il faut utiliser le mots clé ref: ref int valeur1
    static void ModifierValeurs(ref int valeur1, ref double valeur2)
    {
        valeur1 += 5;
        valeur2 *= 2;
    }
    static int Additionner(int nombre1, int nombre2)
    {
        return nombre1 + nombre2;
    }
    static void Calculer()
    {
        Console.Write("Entrez un entier: ");
        string ligne = Console.ReadLine();
        // Équivalent à stoi
        int entier1 = Convert.ToInt32(ligne);

        Console.Write("entrz un opérateur (+, -, *, /, %): ");
        string operateur = Console.ReadLine();

        Console.Write("Entrez un entier: ");
        ligne = Console.ReadLine();
        // Équivalent à stoi
        int entier2 = Convert.ToInt32(ligne);
        // En C#, on peut utiliser un switch avec une chaine de caractères
        Console.Write("{0} {1} {2} = ", entier1, operateur, entier2);
        switch (operateur)
        {
            // On compare des strings, donc "+" et non pas un caractère '+'
            case "+":
                // Tous les opérateurs en C# sont identiques aux opérateurs du C++
                Console.WriteLine(entier1 + entier2);
                break;
            case "-":
                Console.WriteLine(entier1 - entier2);
                break;
            case "*":
                Console.WriteLine(entier1 * entier2);
                break;
            // Il est possible de combiner des cases s'il n'y a pas de code
            case "/":
            case "%":
                // la syntaxe du if est identique au C++
                if (entier2 == 0)
                {
                    Console.WriteLine("Division par 0 impossible");
                }
                else
                {
                    if (operateur == "/")
                    {
                        Console.WriteLine(entier1 / entier2);
                    }
                    else
                    {
                        Console.WriteLine(entier1 % entier2);
                    }
                }
                break;
            default:
                Console.WriteLine("Opérateur invalide");
                break;

        }

    }
    // Partie 2
    // on peut pas utiliser des constant quand on utilise out ou ref
    static void ObtenirValeurs(out int valeur1, out int valeur2)
    {
        // Les paramètres sont considérés non initialisés, et ne peuvent donc pas être utilisés tant qu'une valeur ne leur est pas assignée
        //Console.WriteLine(valeur1);
        // le qualificatif out oblige d'assigner des valeurs aux paramètres
        valeur1 = 456;
        valeur2 = 123;
    }
    static void TestString()
    {
        string maChaine = "Bonjour";
        // Length est une popriété de la string, qui se comporte comme une variable, donc pas de () à la fin  
        Console.WriteLine("Longueur de la chaine: " + maChaine.Length + ", le premier caractère est '" + maChaine[0] + "', le dernier caractère est '" + maChaine[maChaine.Length - 1] + "'");
        //Console.WriteLine(maChaine[100]); Un index à l'exétrieur de la chaine fait planter le programme 
        //maChaine[1] = 'a'; impossible de modifier le contenu d'une variable de typre string 
        // Il est possible d'assigner un nouvelle valeur à une variable de type string 
        maChaine = "Ceci est";
        maChaine += " un test"; // maChaine = maChaine + " un test";
        maChaine += '|'; // += fonctionne avec un seul caractère
        maChaine = "               Une chaine de caractères avec des espaces avant et après.                     "; // *utile pour un menu
        Console.WriteLine("La chaine originale: \"" + maChaine + "\"");
        maChaine.Trim(); // pour enlever seulement des espaces au début maChaine.TrimStart(), enleve a la fin pour maChaine.TrimEnd();
        Console.WriteLine("La chaine originale: \"" + maChaine + "\"");
        // Comme il est impossible de modifier le contenu du string, Trim retourne une copie modifiée
        maChaine = maChaine.Trim();
        Console.WriteLine("La chaine originale: \"" + maChaine + "\"");
        //suivent le même principe que trim, retournent une copie de la chaine modifiée  
        //maChaine = maChaine.Replace(...);
        //maChaine = maChaine.Remove(...);
        //maChaine = maChaine.Insert(...);
        if (maChaine.Contains("avec"))
        {
            Console.WriteLine("Le texte est contenu dans la chaine");
            // Vérifie si la chaine débute par le texte donné
            if (maChaine.StartsWith("Une")) // maChaine.EndWith() se termine par
            {
                Console.WriteLine("La chaine débute par le texte donné");
            }
            else
            {
                Console.WriteLine("La chaine ne débute pas par le texte donné");
            }
        }
        else
        {
            Console.WriteLine("Le texte n'est pas contenu dans la chaine");
        }
        int index = maChaine.IndexOf("de");
        Console.WriteLine("Index de \"de\": " + index);
        index = maChaine.IndexOf("de", index + 1); // on demande de rechercher à partir de la position (index + 1)
        Console.WriteLine("Index de \"de\": " + index);
        index = maChaine.LastIndexOf("de"); // commence la recherche à la fin de la chaine, va trouver le dernière occurence
        Console.WriteLine("Index de \"de\": " + index);
        index = maChaine.IndexOf("patate");
        Console.WriteLine("Index de \"patate\": " + index); // un texte introuvable va générer un index de -1

        // Extrait une sous-chaine, à partir de la position 4, d'une longeur de 6 caractères
        string sousChaine = maChaine.Substring(4, 6);
        Console.WriteLine(sousChaine);
        int NombreDeMots = 0;
        //for(int i = 0; i < maChaine.Length; ++i)
        // La boucle foreach parcours chaque élément de la chaine itération, la variable prend la valeur de l'élément courrant
        foreach (char caractere in maChaine)
        {
            //maChaine[i] ---> caractere
            if (char.IsWhiteSpace(caractere) || char.IsPunctuation(caractere))
            {
                ++NombreDeMots;
            }
            Console.WriteLine(caractere);

        }
        Console.WriteLine("Nombre de mots dans la phrase: " + NombreDeMots);

        maChaine = "bonjour le monde";

        // Pour tous les types autre que les types de base, pour déclarer une variable, il faut utiliser la syntaxe:
        // Type variable = new Type(...);

        // Le StringBuilder garde une copie de la chaine qui peut être modifiée
        // utile lorsque plusieurs modifications sont requises
        StringBuilder builder = new StringBuilder(maChaine);
        builder[0] = 'B';
        builder.Append("!");// Append accepte des valeurs ou des variables de (presque) tous le types
        builder.Append(12);
        // La syntaxe de Insert, Remove, Replace est indentique pour la classe string
        builder.Insert(8, "abcdefg "); // Insère "abcdefg" à la position 8, et pousse le texte déjà présent vers la fin
        builder.Remove(12, 3); // Enlever 3 caractères à partir de la position 12
        builder.Replace("abcd", "tout"); // Remplace les occurences de "abcd" par "tout" dans la chaine
        maChaine = builder.ToString(); // Récupère une variable de type string du contenu modifié
        Console.WriteLine(maChaine);
        // Avec l'argument de position suivi d'une vrigule, le nombre indique la largeur en caractères à utiliser pour afficher l'élément (setwidth)
        // -Un nombre négatif aligne à gauche 
        // -Un nombre positif aligne à droite
        // Un symbole : (deux points) permet de spécifier un format
        // -D: nombre Décimaux, l'espace est comblé par des 0 jusqu'au nombre donné (setwidth, setfill('0'))
        // -F: nombre Flottant (réel), le nombre donné indique la précision (nombre de chiffres après la virgule) (setprecision)
        Console.WriteLine("|{0,-10}|{0,10}|{1,8}|{2,4:D2}|{3,12:F2}|", "allo", 12, 3, 34.56789);

    }
    static void TestFichier()
    {
        string nomFichier = "test.txt";
        #region EcritureDansFichier
        // Au lieu du ofstream, on a un StreamWriter
        //Comme le ofstream, le StreamWriter va créer le fichier s'il n'existe pas, et va l'écraser s'il existe
        // StreamWriter(nomFichier, true) va ajouter à la fin si le fichier existe déjà
        using (StreamWriter fichierEcriture = new StreamWriter(nomFichier))
        {
            fichierEcriture.WriteLine("Du texte pour tester");
            fichierEcriture.WriteLine("l'écriture");
            fichierEcriture.WriteLine("dans un fichier \n\n\nqui pourra être lu par la suite.");

        }// L'instruction using va avoir pour effet de fermer le fichier à la sortie du bloc associé
         // Il sera impossible d'accéder au fichier ici
        #endregion
        // Équivalent au ifstream
        using (StreamReader fichierLecture = new StreamReader(nomFichier))
        {
            // on lit une ligne du fichier
            string ligne = fichierLecture.ReadLine();
            // null est une valeur spéciale pour indiquer "rien", retournée lorsque la fin du fichier est atteinte
            // Différent d'une ligne vide ""
            while (ligne != null)
            {
                Console.WriteLine(ligne);
                // Lire la ligne suivant
                ligne = fichierLecture.ReadLine();
            }
        }
    }
    // les commentaires débutant par 3 barres obliques /// indique un commentaire de type CodeDoc
    // la balise "summary" sert à décrire la méthode
    // Chauqe méthode aura son propre commentaire summary pour exipliquer sa fonctionnalité 
    /// <summary>
    /// Recherce dans un fichier le texte donné par l'utilisateur
    /// </summary>
    /// <remarks>
    /// le fichier utiliser peut juste être des fichiers ".txt"
    /// </remarks>
    static void Grep()
    {
        Console.Write("Veuillez entrer le nom du fichier ");
        string nomFichier = Console.ReadLine();
        nomFichier += ".txt";
        int nombre = Rechercher(ref nomFichier);
        Console.WriteLine("");
        Console.WriteLine("Total de ligne : " + nombre + "\n");
    }
    /// <summary>
    /// Recherche du texte dans un fichier
    /// </summary>
    /// <param name="nomFichier">Le nom du fichier dans lequel il va effectuer la recherche</param>
    /// <returns>Le nombre de lignes contenant le texte cherché</returns>
    static int Rechercher(ref string nomFichier)
    {
        Console.Write("Veuillez entrer les ou le mot(s) a chercher ");
        string mot = Console.ReadLine();
        Console.WriteLine("");
        using (StreamReader fichierLecture = new StreamReader(nomFichier))
        {
            int nombreDeLigne = 1;
            int totalDeLigne = 0;
            string ligne = fichierLecture.ReadLine();
            while (ligne != null)
            {  
                if (ligne.Contains(mot))
                {
                    Console.WriteLine(nombreDeLigne + " : " + ligne);
                    ++totalDeLigne;
                }
                ligne = fichierLecture.ReadLine();
                ++nombreDeLigne;
            }
            return totalDeLigne;
        }
        
    }
    // partie 3
    static void TestNamespaces()
    {
        // Il est possible de spéficier le namespace de la définition voulue lors de l'utilisation
        Console.WriteLine("Mercure en mythologie: " + Mythologie.Mercure.Description());
        // Si le namespace n'est pas spécifié, le compilateur recherce dans les namespaces utilisés (using)
        Console.WriteLine("Mercure par défaut: " + Mercure.Description());
    }
}