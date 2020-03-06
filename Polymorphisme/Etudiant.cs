using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisme
{
    class Personne
    {
        public Personne(string nom)
        {
            Console.WriteLine("Constructeur de Personne");
            Nom = nom;
            // On ne doit jamais appeller une méthode virtuelle dans un constructeur
            // L'objet dérivé n'est pas encore construit
            // Console.WriteLine("Appel de DireInformation à partir du constructeur de Personne");
            // DireInformation();
            // Console.WriteLine("++++++");
        }
        public string Nom { get; set; }
        public void DireNom()
        {
            Console.WriteLine("Mon nom est " + Nom);
            Console.WriteLine("Appel de DireInformation à partir de DireNom");
            DireInformation();
            Console.WriteLine("-------------------------------");
        }
        // Le mot clé virtual indique que la méthode va pouvoir être remplacée par une version définie
        // dans une classe dérivée
        public virtual void DireBonjour()
        {
            Console.WriteLine("Bonjour, je suis une personne");
        }
        public virtual void DireInformation()
        {
            Console.WriteLine("Bonjour, je suis une personne et je m'appelle " + Nom);
        }
    }
    class Etudiant : Personne
    {
        public Etudiant(string nom, int matricule) :
        base(nom)
        {
            Console.WriteLine("Constructeur d'Etudiant");
            Matricule = matricule;
        }
        public int Matricule { get; set; }
        // Le mot clé override indique que la méthode remplace la versin de la classe de base.
        // Ne peut s'utiliser que pour des méthodes virtuelles
        // Il n'est pas nécessaire de redéfinir une méthode virtuelle. Dans ce cas, elle se comporte comme 
        // une méthode ordinaire, et la version de base est appelée
        //public override void DireBonjour()
        //{
        //  Console.WriteLine("Bonjour, je suis un(e) étudiant(e)");
        //}
        public override void DireInformation()
        {
            base.DireInformation(); // Appelle la version de personne (la classe de base)
            Console.WriteLine("... en plus, je suis un étudiant et mon matricule est " + Matricule);
        }
    }
}
