using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tableau = { 12, 34, 56, 78, 90 };
            // Un bloc d'instruction qui débute par le mot try va permettre de gérer les erreurs possibles dans l'exécution de ce bloc
            try
            {
                Console.Write("Entrez un index: ");
                int index = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Index = " + index);
                Console.WriteLine("Valeur du tableau à l'index = " + tableau[index]);
                Console.WriteLine("Division: " + tableau[index] / index);

                Console.WriteLine("Fin du bloc try");
            }
            // Un bloc try doit suivi d'un bloc catch qui sera exécuté si une exception se produit durant l'exécution du bloc try
            // Le bloc catch ne sera pas exécuté s'il n'y a pas d'erreur durant l'exécution du bloc try
            // Il faut mettre les exceptions les plus spécialisées en premier, et les plus générales en drenier
            // Si le type correspond, les catch suivant ne seront pas exécuté
            //catch (Exception e)
            //{
            //
            //}
            // Si l'exception est du type spécifier, le bloc catch associé est exécuté
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("Exception de type IndexOutOfRange: " + e.Message);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Erreur: division par 0");
            }
            // Les données dans les parenthèses qui suivent l'instruction catch sont similaire à un paramètre de méthode
            // On spécifie le type et une variable de ce type qui contiendra l'exception attrapée
            // Exception est la classe de base de toues les exceptions. Si une exception spécifique n'est pas présente dans une clause catch, Exception va tout attraper
            catch(Exception exception) // Exception est un type (classe), exception est une variable de ce type
            {
                Console.WriteLine("Exception: " + exception.Message); // Message est une propriété de la classe Exception qui donne de l'information sur l'erreur
            }
            // Ne sera jamais exécuté puisique le catch précédent aura tout attrapé
            catch // Équivalent à: catch (Exception e), mais sans information sur l'erreur
            {
                Console.WriteLine("Une exception s'est produite");
            }
            try
            {
                Console.Write("Entrez un index: ");
                int index = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Index = " + index);
                Console.WriteLine("Valeur du tableau à l'index = " + tableau[index]);
                Console.WriteLine("Division: " + tableau[index] / index);

                Console.WriteLine("Fin du bloc try");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Exception de type IndexOutOfRange: " + e.Message);
            }
            // Uniquement les exceptions de type IndexOutOfRange sont attrapées, les autres vont faire planter le programme 
            Console.WriteLine("Appuyez sur une touche pour continuer");
            Console.ReadKey(true);
        }
    }
}
