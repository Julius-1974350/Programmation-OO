using System;
using System.IO;

namespace banque
{
    /// <summary>
    /// Une banque contient 5 comptes bancaires et permet d'effectuer des opérations sur les comptes
    /// </summary>
    class Banque
    {
        public Banque(string nomFichier)
        {
            using (StreamReader fichierLecture = new StreamReader(nomFichier))
            {
                int compteur = 0;
                string nom;
                double montant;
                // on lit une ligne du fichier
                string ligne = fichierLecture.ReadLine();
                // null est une valeur spéciale pour indiquer "rien", retournée lorsque la fin du fichier est atteinte
                // Différent d'une ligne vide ""
                while (ligne != null)
                {
                    nom = ligne;
                    ligne = fichierLecture.ReadLine();
                    montant = Convert.ToDouble(ligne);
                    _comptes[compteur] = new CompteBancaire(nom, montant);
                    compteur++;
                    ligne = fichierLecture.ReadLine();
                }
            }
        }
        public void AfficherSolde(string nom)
        {
            for (int i = 0; i < NbComptes; i++)
            {
                if (_comptes[i].Contains(nom))
                {
                    _comptes[i].AfficherLeSolde();
                }
            }
            
        }
        public void Deposer(string nom, double montant)
        {
            for (int i = 0; i < NbComptes; i++)
            {
                if (_comptes[i].Contains(nom))
                {
                    _comptes[i].Addition(montant);
                    _comptes[i].Dep(montant);
                }
            }

        }
        public void Retirer(string nom, double montant)
        {
            for (int i = 0; i < NbComptes; i++)
            {
                if (_comptes[i].Contains(nom))
                {
                    _comptes[i].Sustraction(montant);
                    _comptes[i].Ret(montant);
                }
            }

        }
        public void Sauvegarder()
        {
            using (StreamWriter fichierLecture = new StreamWriter("Banque.txt"))
            {
                int compteur = 0;
                while (compteur != 5)
                {
                    _comptes[compteur].Sauvegarde(fichierLecture);
                    compteur++;
                }
            }
        }
	
	
        private const int NbComptes = 5;
        // Un tableau de 5 comptes bancaires.
        // Notez que le tableau est vide et que les comptes ne sont pas initialisés.
        // Dans le constructeur, il sera nécessaire de créer chaque objet contenu dans le tableau:
        //   _comptes[0] = new CompteBancaire(...);
        //   ...
        //   _comptes[4] = new CompteBancaire(...);
        private CompteBancaire[] _comptes = new CompteBancaire[NbComptes];
    }
}
