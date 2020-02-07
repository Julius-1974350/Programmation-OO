using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroOO
{
    class Program
    {
        // Le paramètre "args" (tableau de chaines de caractères) va servir à recevoir des arguments lors du lancement du programme.
        // Exemples à venir plus tard.
        static void Main(string[] args)
        {
            
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Clear();
            Rectangle r1 = new Rectangle();
            r1.SetHauteur(4);
            r1.Largeur = 6;
            r1.Largeur = -3;
            r1.Nom = "Rectangle 1";
            //r1.Surface = 12; // Impossible car propriété en lecture seule
            Console.WriteLine(r1.Nom + ": Largeur = " + r1.Largeur + ", Hauteur = " + r1.Hauteur() + ", Surface = " + r1.Surface);
            //AfficherRectangle(r1);
            r1.Afficher('/');
            // Autre objet rectangle
            Rectangle r2 = new Rectangle();
            r2.SetHauteur(5);
            r2.Largeur = 7;
            r2.Nom = "Rectangle 2";
            r2.Afficher('▓');
            Console.WriteLine(r2.Nom + ": Largeur = " + r2.Largeur + ", Hauteur = " + r2.Hauteur() + ", Surface = " + r2.Surface);
            Console.Write("Appuyer sur une touche pour continuer...");
            Console.ReadKey(true);
        }
        static void AfficherRectangle(Rectangle rectangle)
        {
            for (int ligne = 0; ligne < rectangle.Hauteur(); ligne++)
            {
                for (int colonne = 0; colonne < rectangle.Largeur; colonne++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
