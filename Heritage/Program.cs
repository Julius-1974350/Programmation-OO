using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne p1 = new Personne();
            p1.Prenom = "Albert";
            p1.Nom = "Einstein";
            p1.DateDeNaissance = new DateTime(1879, 3, 4);
            // Une personne n'a pas de matricule
            // p1.Matricule = 0;
            Console.WriteLine("Personne 1: {0} {1}, Né le {2}", p1.Prenom, p1.Nom, p1.DateDeNaissance);
            p1.DireBonjour();
            // tu peux pas mettre des valeur proteger
            //p1._valeurProtegee;
            Etudiant e1 = new Etudiant();
            e1.Prenom = "David";
            e1.Nom = "Moussette";
            e1.DateDeNaissance = new DateTime(2000, 11, 15);
            e1.Matricule = 1234567;
            Console.WriteLine("Étudiant 1: {0} {1}, Né le {2}, Matricule {3}", e1.Prenom, e1.Nom, e1.DateDeNaissance, e1.Matricule);
            // Les méthodes publiques de la classe de base sont aussi accessibles par un objet d'une classe dérivée
            e1.DireBonjour();
            Personne p2 = new Personne("Bill", "Gates", 1955, 10, 28);
            Console.WriteLine("Personne 2: {0} {1}, Né le {2}", p2.Prenom, p2.Nom, p2.DateDeNaissance);
            Etudiant e2 = new Etudiant("Julius", "Leblanc", 2001, 05, 08, 2011111);
            Console.WriteLine("Étudiant 2: {0} {1}, Né le {2}, Matricule {3}", e2.Prenom, e2.Nom, e2.DateDeNaissance, e2.Matricule);
            // La valeur 0 sert uniquement à spécifier d'utiliser le 2e constructeur
            Etudiant e3 = new Etudiant(0, "Kevin", "Furtado", 1984, 07, 23, 1111111);
            Console.WriteLine("Étudiant 3: {0} {1}, Né le {2}, Matricule {3}", e3.Prenom, e3.Nom, e3.DateDeNaissance, e3.Matricule);
            Console.WriteLine("Appuyer sur une toujours pour continuer");
            Console.ReadKey(true);
        }
    }
}
