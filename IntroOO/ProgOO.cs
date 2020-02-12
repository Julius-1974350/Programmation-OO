using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroOO
{
    class Program
    {
        // Le paramètre "args" (un tableau de chaines de caractères) servira à recevoir des arguments au lancement du programme
        // Exemples à venir plus tard, on peut l'ignorer pour l'instant
        static void Main(string[] args)
        {
            TestRectangle();
            TestHorloge();

            Console.WriteLine("Appuyer pour continuer");
            Console.ReadKey(true);

        }

        static void TestHorloge()
        {
            // Définit une horloge à 12h, 0 minutes, 0 secondes
            Horloge h1 = new Horloge(12);
            h1.Afficher(); //12:00:00

            Horloge h2 = new Horloge(12, 34);
            h2.Afficher(); //12:34:00

            Horloge h3 = new Horloge(12, 34, 56);
            h3.Afficher(); // 12:34:56
            Console.WriteLine("Heures de h3: "+ h3.heures);
            Console.WriteLine("Minutes de h3: " + h3.minutes);
            Console.WriteLine("Secondes de h3: " + h3.secondes);

            // NE DOIt PAS COMPILER
            // h3.heures = 1;
            // h3.minutes = 2;
            // h3.secondes = 3;

            // L'horloge valide les paramètres: heures entre 0 et 23, minutes et secondes entre 0 et 59
            Horloge h4 = new Horloge(3, -5, 67);
            h4.Afficher(); //03:00:00

            Horloge h5 = new Horloge(12, 34, 0);
            h5.Afficher(); // 12:34:00

            if (h2.EstEgaleA(h5))
            {
                Console.WriteLine("h2 est égale à h5"); // résultat attendu
            }
            else
            {
                Console.WriteLine("h2 n'est pas égale à h5");
            }


            if (h2.EstEgaleA(h3))
            {
                Console.WriteLine("h2 est égale à h3"); 
            }
            else
            {
                Console.WriteLine("h2 n'est pas égale à h3"); // résultat attendu
            }

            HorlogeV2 h6 = new HorlogeV2();
            h6.Afficher();
        }

        static void TestRectangle()
            { 
            //Déclaration d'une variable de type Rectangle
            Rectangle rectangle1 = new Rectangle(18, 4);

            rectangle1.SetHauteur(4);
            rectangle1.Largeur = 6;
            rectangle1.Largeur = -3;
            //rectangle1.surface = 12; //Impossible car propriété en lecture seule
            Console.WriteLine(rectangle1.Nom + ": largeur = " + rectangle1.Largeur + ", Hauteur = " + rectangle1.Hauteur() + ", Surface = " + rectangle1.Surface);

            //AfficherRectangle(rectangle1);
            rectangle1.Afficher('*');

            //Autre objet rectangle();
            Rectangle rectangle2 = new Rectangle(18, 6);
            rectangle2.SetHauteur(5);
            rectangle2.Largeur = 7;
            Console.WriteLine(rectangle2.Nom + ": largeur = " + rectangle2.Largeur + ", Hauteur = " + rectangle2.Hauteur() + ", Surface = " + rectangle2.Surface);
            rectangle2.Afficher('*');

            //Initialise un rectangle avec une hauteur de 4 et une largeur de 8
            Rectangle rectangle3 = new Rectangle(4, 8);
            rectangle3.Afficher();

            Rectangle r4 = new Rectangle();
            // Même sans ref, on pase une référence à r4
            TestDeParametre(r4);
            r4.Afficher();

            // Déclaration d'une variable avec le mots clé "var", le compilateur va déterminer le type de la variable
            var r5 = new Rectangle();
            // Identique à: Rectangle r5 = new Rectangle();

            // Bien qu'il soit possible de le faire, la norme de programmation préfère ne pas utiliser "var" pour les types de base
            //var entier = 5; // int
            //var reel = 3.14; // double
            //var chaineDeCaractere = "test"; // string

            // Sans initialisation, il est impossible d'utiliser "var" car le compilateur ne peut pas déterminer le type
            //var x;
            //x = new Rectangle();
        }

        static void AfficherRectangle(Rectangle rectangle)
        {
            for (int ligne = 0; ligne < rectangle.Hauteur(); ++ligne)
			{
                for (int colonne = 0; colonne < rectangle.Largeur; ++colonne)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
			}
        }
        // Méthodes qui prend un rectangle en paramètre
        static void TestDeParametre(Rectangle rectangle)
        {
            // Une variable de type classe sera toujours considérée comme une référence lorsque passé en paramètre à une méthode
            rectangle.SetHauteur(3);
            rectangle.Largeur = 5;
            // Pour les types de classes, une variable n'est créée que lorsque l'instruction "new" est appelée
            // autreRectangle est une référence sur réctangle, car une nouvelle variable n'a pas été créée avec "new"
            Rectangle autreRectangle = rectangle;
            autreRectangle.SetHauteur(10);
            autreRectangle.Largeur = 22;
        }
    }
}
