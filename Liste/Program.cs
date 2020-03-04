using System;
using System.Collections.Generic; // Pour la classe liste 
using System.Text;

namespace Liste
{
    class Program
    {
        static void Main(string[] args)
        {
            TestListe();
            Console.WriteLine("appuyez sur une touche pour continuer...");
            Console.ReadKey(true);
        }
        static void TestListe()
        {
            List<string> liste = new List<string>();
            // La méthode add ajoute à la fin de la liste (push_back)
            liste.Add("Un");
            liste.Add("Trois");
            liste.Add("Quatre");
            liste.Add("Trois");
            liste.Add("Quatre");
            AfficherListe(liste);
            Console.WriteLine("Insertion de Deux à la position 1");
            liste.Insert(1, "Deux");// Comme le reste en programmation, la position de la liste commence à 0, 1 est la 2e position
            AfficherListe(liste);
            Console.WriteLine("Insertion de Zéro au début de la liste");
            liste.Insert(0, "Zéro"); // Insérer à la position 0 insère au début de la liste
            AfficherListe(liste);
            Console.WriteLine("Première position de Trois: " + liste.IndexOf("Trois"));
            Console.WriteLine("Prochain position de Trois après la position 4: " + liste.IndexOf("Trois", 4));
            Console.WriteLine("Drenière position de Trois: " + liste.LastIndexOf("Trois"));
            Console.WriteLine("Position de Cinq: " + liste.IndexOf("Cinq")); // Un élément non trouvé retourne la valeur -1
            if (liste.Contains("Trois"))
            {
                Console.WriteLine("La liste contient Trois");
            }
            else
            {
                Console.WriteLine("La liste ne contient PAS Trois");
            }
            if (liste.Contains("Cinq"))
            {
                Console.WriteLine("La liste contient Cinq");
            }
            else
            {
                Console.WriteLine("La liste ne contient PAS Cinq");
            }
            Console.WriteLine("Enlève la première ossurence de Quatre");
            liste.Remove("Quatre");
            AfficherListe(liste);
            Console.WriteLine("élément à la position 4: " + liste[4]);
            Console.WriteLine("Enlève l'élément à la position 4");
            liste.RemoveAt(4);
            AfficherListe(liste);
            Console.WriteLine("Met Cinq à la position 0");
            liste[0] = "Cinq";
            AfficherListe(liste);
            Console.WriteLine("Inverse la liste");
            liste.Reverse();
            AfficherListe(liste);
            Console.WriteLine("Tri de la liste");
            liste.Sort();
            AfficherListe(liste);
            Console.WriteLine("Vide la liste");
            liste.Clear();
            AfficherListe(liste);
        }
        static void AfficherListe(List<string> liste)
        {
            Console.WriteLine("-------------------------------------");
            // La propriété Count de la liste indique le nombre d'éléments contenus dans la liste
            Console.WriteLine("Taille de la liste: {0}, contenu: ", liste.Count);
            foreach (string s in liste)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("-------------------------------------");
        }
    }
}
