using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banque
{
    class CompteBancaire
    {
        string nom1;
        double montant1;
        public CompteBancaire(string nom, double montant)
        {
            nom1 = nom;
            montant1 = montant;

        }
        public bool Contains(string nomDifferent)
        {

            if (nom1 == nomDifferent)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void AfficherLeSolde()
        {
            Console.WriteLine("Solde du compte " + nom1 + " : " + montant1 + "$");
        }
        public double Addition(double montant)
        {
            return montant1 = montant1 + montant;
        }
        public void Dep(double montant)
        {
            Console.WriteLine("Dépôt de " + montant + "$ dans le compte " + nom1);
            Console.WriteLine("  Nouveau solde: " + montant1 + "$" );
        }
        public double Sustraction(double montant)
        {
            return montant1 = montant1 - montant;
        }
        public void Ret(double montant)
        {
            Console.WriteLine("Dépôt de " + montant + "$ dans le compte " + nom1);
            Console.WriteLine("  Nouveau solde: " + montant1 + "$");
        }
        public void Sauvegarde(StreamWriter fichierLecture)
        {
            fichierLecture.WriteLine(nom1);
            fichierLecture.WriteLine(montant1);
        }
    }
}
