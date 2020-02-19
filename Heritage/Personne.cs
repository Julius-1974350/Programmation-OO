using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    /// <summary>
    /// Contient l'information d'une personne
    /// </summary>
    class Personne
    {
        public Personne()
        {
            Console.WriteLine("Constructeur par défaut de Personne");
        }
        public Personne(string prenom, string nom, int annee, int mois, int jour)
        {
            Console.WriteLine("Constructeur avec valeur initiales de Personne");
            Prenom = prenom;
            Nom = nom;
            DateDeNaissance = new DateTime(annee, mois, jour);
        }
        public string Prenom { get; set; }

        public string Nom { get; set; }
        //Le type DateTime permet de spécifier une date du calendrier et une heure de la journée
        public DateTime DateDeNaissance { get; set; }

        public void DireBonjour()
        {
            Console.WriteLine("Bonjour, je m'appelle {0} {1}",Prenom, Nom);
        }
        private int _valeurPrivee;
        // protected est un niveau d'accès entre public et private
        protected int _valeurProtegee;
    }
}
