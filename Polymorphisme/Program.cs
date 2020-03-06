using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisme
{
    class Program
    {
        static void Main(string[] args)
        {
            TestEtudiant();
            Console.WriteLine("Appuyez sur une touche pour continuer...");
            Console.ReadKey();
        }
        static void TestEtudiant()
        {
            Personne p = new Personne("Rosaire");
            AfficherPersonne(p);
            Console.WriteLine("----------------------------------------");
            Etudiant e = new Etudiant("Pauline", 1234567);
            AfficherPersonne(e);
        }
        static void AfficherPersonne(Personne p)
        {
            // on peut recevoir en argument une variable de type personne, ou de tout type héritant de Personne
            // Si l'argument est d'un type dérivé, on n'a pas accès à rien d'autre que la partie Personne
            //Console.WriteLine(p.Matricule);// Impossible, une personne n'a pas de matricule
            Console.WriteLine("Le nom de la personne est: " + p.Nom);
            p.DireNom();
            p.DireBonjour();
            p.DireInformation();
        }
    }
}
