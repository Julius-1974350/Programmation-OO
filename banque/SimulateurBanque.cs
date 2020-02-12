using System;

//
// IMPORTANT: Les classes Banque et CompteBancaires ne doivent contenir aucune propriété, aucun accesseur et aucun mutateur
//

namespace banque
{
    class SimulateurBanque
    {
        /// <summary>
        /// Exécute un petit programme qui simule des opérations bancaires
        /// </summary>
        public void Simuler()
        {
            // La banque est initialisée avec le nom du fichier contenant l'information des comptes
            Banque banque = new Banque("banque.txt");

            string nom;
            double montant;

            // On boucle tant que l'utilisateur n'indique pas la fin du programme
            while (true)
            {
                AfficherMenu();

                string operation = Console.ReadLine();
                switch (operation)
                {
                    case "s":
                    case "S":
                        nom = DemanderNom();
						// Demande à la banque d'afficher le solde du compte portant le nom donné.
						// Affichera un message d'erreur si le compte est introuvable.
                        banque.AfficherSolde(nom);
                        break;

                    case "d":
                    case "D":
                        nom = DemanderNom();
                        montant = DemanderMontant();
						// Demande à la banque d'effectuer un dépôt du montant donné dans le compte donné.
						// Affichera un message d'erreur si le compte est introuvable.
                        banque.Deposer(nom, montant);
                        break;

                    case "r":
                    case "R":
                        nom = DemanderNom();
                        montant = DemanderMontant();
						// Demande à la banque d'effectuer un retrait du montant donné du compte donné.
						// Affichera un message d'erreur si le compte est introuvable.
						// Affichera un message d'erreur si le solde est insuffisant.
                        banque.Retirer(nom, montant);
                        break;

                    case "q":
                    case "Q":
                        Console.WriteLine("Fermeture de la banque");
                        // Avant de quitter, on demande à la banque de sauvegarder l'infomation des comptes dans le fichier
                        banque.Sauvegarder();
                        return;

                    default:
                        Console.WriteLine("Opération invalide");
                        break;
                }

                Console.WriteLine("Appuyez sur une touche pour continuer");
                Console.ReadKey(true);
            }
        }


        // Affiche la liste des opérations possibles.
        private void AfficherMenu()
        {
            Console.Clear();
            Console.WriteLine("Opérations");
            Console.WriteLine("----------");
            Console.WriteLine("S: Afficher le solde");
            Console.WriteLine("D: Effectuer un dépôt");
            Console.WriteLine("R: Effectuer un retrait");
            Console.WriteLine("Q: Quitter\n");
            Console.Write("Choix: ");
        }

        /// Demande le nom d'un comte bancaire à l'utilisateur et retourne la valeur donnée.
        private string DemanderNom()
        {
            Console.Write("Indiquez le nom du compte: ");
            string nom = Console.ReadLine();
            return nom;
        }

        /// Demande un montant à l'utilisateur et retourne la valeur donnée.
        private double DemanderMontant()
        {
            Console.Write("Indiquez le montant: ");
            string texte = Console.ReadLine();
            return Convert.ToDouble(texte);
        }

    }
}
