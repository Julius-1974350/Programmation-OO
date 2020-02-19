using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    /// <summary>
    /// Contient l'information d'un étudiant 
    /// </summary>
    /// La classe Etudiant hérite de la classe Presonne
    /// Personne est une généralisation d'Etudiant, Etudiant est une spécialisation de Presonne
    /// Personne est la classe de base, Etudiant est la classe dérivée
    /// Personne est la classe parent (mère), Etudiant est la classe enfant (fille)
    /// L'héritage est une relation " EST UN(E)": un étudiant est une personne
    class Etudiant : Personne
    {
        public Etudiant()
        {
            Console.WriteLine("Constructeur par défaut d'Etudiant");
            // Il est impossible d'accéder à la partie privée de la classe de base
            //_valeurPrivee = 1;
            // dans une classe dérivée, le protected est similaire à public, il donne accès aux attributs/propriétés/méthodes
            _valeurProtegee = 1;
        }
        // À chaque fois qu'un constructeur d'une classe dérivée  est appelé, un constructeur de la classe de base est aussi toujours appelé
        // Si aucun constructeur de la classe de base n'est spécifié, le constructeur par défaut est implicitement choisi
        // Le constructeur de la classe de base est toujours appelé AVANT le constructeur de la classe dérivée
        public Etudiant(string prenom, string nom, int annee, int mois, int jour, int matricule)// : base () ---> implicite si aucun constructeur spécifié
        {
            Console.WriteLine("Constructeur d'Etudinat avec valeurs initiales");
            Prenom = prenom;
            Nom = nom;
            DateDeNaissance = new DateTime(annee, mois, jour);
            Matricule = matricule;
        }
        // Le paramètre bidon set uniquement à faire la différence avec le constructeur précédent
        // Pour exemple éducatif du mécanisme de construction uniquement
        public Etudiant(int bidon, string prenom, string nom, int annee, int mois, int jour, int matricule) :
            // Le mots clé base sert à appeller le constructeur de la classe de base, Personne dans le cas présent
            base(prenom, nom, annee, mois, jour)
        {
            Console.WriteLine("2e version du constructeur d'Etudinat avec valeurs initiales");
            Matricule = matricule;
        }
       public int Matricule { get; set; }
    }
}
